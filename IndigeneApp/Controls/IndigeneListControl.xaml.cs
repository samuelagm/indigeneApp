using IndigeneApp.Models;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace IndigeneApp
{
    /// <summary>
    /// Interaction logic for IndigeneListControl.xaml
    /// </summary>
    public partial class IndigeneListControl : UserControl, IIndigeneUpdate
    {
        private static String controlTitle = "Indigene Record";
        IndigeneEditFormControl indigeneEditForm;
        List<Indigene> indigeneListCache = null;
        Boolean showingSearchItems = false;
        IParentFormInteraction parentWindow;
       

        ObservableCollection<Indigene> indigeneList = new ObservableCollection<Indigene>();
        private bool dataLoaded = false;

        public ObservableCollection<Indigene> IndigeneList {
            get { return indigeneList; }
        }

        public IndigeneListControl(IParentFormInteraction parentWindow) {
            this.parentWindow = parentWindow;
            this.parentWindow.SetIndigeneChangeListener(this);
            InitializeComponent();

        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e) {
   
            indigeneListCache = new List<Indigene>();

            if (!dataLoaded) {
                TaskFactory tf = new TaskFactory();
                tf.StartNew(() => {
                    this.Dispatcher.Invoke((Action)(() => {
                        loadData();
                        parentWindow.HideDialog();
                    }));

                });
                parentWindow.setHeaderTitle(controlTitle);
                parentWindow.ShowDialog("Loading data...", false);
            }
            
            indigeneEditForm = new IndigeneEditFormControl(parentWindow, this);
            
        }

        private void loadData() {
            var sessionFactory = DataBaseConnection.CreateSessionFactory();
            using (var session = sessionFactory.OpenSession()) {
                var list = session.CreateCriteria(typeof(Indigene)).List<Indigene>();
                foreach (var indigene in list) {
                    indigeneList.Add(indigene);
                }
                DataContext = this;
                dataLoaded = true;
            }
        }

        private void searchIndigene(string term) {
            if (searchTerm.Text == "")
                return;

            var sessionFactory = DataBaseConnection.CreateSessionFactory();
            using (var session = sessionFactory.OpenSession()) {
                var list = session.CreateCriteria(typeof(Indigene))
                    .Add(NHibernate.Criterion.Expression.
                    Or(NHibernate.Criterion.Expression.InsensitiveLike("FirstName", term),
                        NHibernate.Criterion.Expression.InsensitiveLike("OtherNames", term)))
                    .List<Indigene>();
                indigeneListCache = indigeneList.ToList<Indigene>();

                if (list.Count > 0) {
                    indigeneList.Clear();
                    searchButtonImage.Source = new BitmapImage(new Uri(@"/Media/appbar.clear.png", UriKind.Relative));
                    showingSearchItems = true;
                    foreach (var indigene in list)
                        indigeneList.Add(indigene);
                } else {
                    showingSearchItems = false;
                    parentWindow.ShowDialog("No record for " + term + " was found", true);
                }

            }
        }

        public void openEditForm() {

            if (parentWindow.HasPermission()) {
                parentWindow.ShowBackButton();
                indigeneEditForm.IndigeneId = getSelectedIndigeneId();
                parentWindow.LoadControl(indigeneEditForm);
            } else {
                parentWindow.ShowDialog("This action is reserved for administrators.", true);
            }

        }

        private void editButton_Click(object sender, RoutedEventArgs e) {
            if (indigeneList.Count == 0) return;
            openEditForm();
        }

        private void deleteIndigene() {
            try {
                String message = "You're about to delete an indigene, do you wish to continue";
                MessageBoxResult result = MessageBox.Show(message, "Deletion", MessageBoxButton.YesNo);
                int id = getSelectedIndigeneId();
                if (listbox.SelectedIndex == -1)
                    return;
                if (result == MessageBoxResult.Yes) {
                    indigeneList.RemoveAt(listbox.SelectedIndex);
                    ISessionFactory sessionFactory = DataBaseConnection.CreateSessionFactory();
                    using (ISession session = sessionFactory.OpenSession()) {
                        using (ITransaction transaction = session.BeginTransaction()) {
                            session.Delete(session.Load<Indigene>(id));
                            transaction.Commit();
                        }
                    }
                }
            }
            catch(Exception e) {
                parentWindow.ShowDialog("Something went wrong, probably try again later", true);
            }

        }

        private int getSelectedIndigeneId() {
            CollectionViewSource viewSource = (CollectionViewSource)this.FindResource("indigeneListViewSource");
            CollectionView view = (CollectionView)viewSource.View;
            Indigene indigene = (Indigene)view.CurrentItem;
            return indigene.Id;

        }

        private void deleteButton_Click(object sender, RoutedEventArgs e) {
            if (indigeneList.Count == 0) return;
            if (parentWindow.HasPermission()) {
                deleteIndigene();
            } else {
                parentWindow.ShowDialog("This action is reserved for administrators.", true);
            }
        }

        private void searchButton_Click(object sender, RoutedEventArgs e) {
            if (showingSearchItems) {
                indigeneList.Clear();
                searchButtonImage.Source = new BitmapImage(new Uri(@"/Media/appbar.magnify.png", UriKind.Relative));
                searchTerm.Clear();
                foreach (var indigene in indigeneListCache) {
                    indigeneList.Add(indigene);
                }
                showingSearchItems = false;
            } else {
                searchIndigene(searchTerm.Text);
            }

        }

        public void OnBackButtonPressed() {
            MessageBox.Show("Back button pressed","");
        }

        public void reload() {
            TaskFactory tf = new TaskFactory();
            tf.StartNew(() => {
                this.Dispatcher.Invoke(() => {
                    indigeneList.Clear();
                    loadData();
                });
            });
        }

        private void UserControl_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e) {
            if ( ((bool)(e.NewValue)) == true) {
                parentWindow.setHeaderTitle(controlTitle);
            }
        }
    }
}