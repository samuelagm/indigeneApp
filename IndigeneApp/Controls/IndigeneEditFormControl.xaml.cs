using System;
using System.Collections.Generic;
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
using IndigeneApp.Models;
using NHibernate;
namespace IndigeneApp
{
    /// <summary>
    /// Interaction logic for IndigeneEditFormControl.xaml
    /// </summary>
    public partial class IndigeneEditFormControl : UserControl, IBackNavigationListener
    {
        private static String controlTitle = "Update Indigene";
        private int Id;
        IParentFormInteraction parentWindow;
        UserControl parentControl;

        public int IndigeneId {
            get { return Id; }
            set { Id = value; }
        }

        private Indigene indigene;
        IList<String> villageList = new List<String>() { 
            "Umu Esiakam", 
            "Umu Akamudo", 
            "Umu Nenyeli", 
            "Umu Ezeogiga" 
        };
        IList<String> sexList = new List<String>() { 
            "Male", 
            "Female" 
        };
        IList<String> maritalStatusList = new List<String>() { 
            "Divorced", 
            "Married", 
            "Widowed", 
            "Single"
        };

        public IList<String> SexList {
            get { return sexList; }
        }

        public IList<String> MaritalStatusList {
            get { return maritalStatusList; }
        }

        public IList<String> VillageList {
            get { return villageList; }
        }

        public Indigene CommunityIndigene {
            get { return indigene; }
        }

        public IndigeneEditFormControl(IParentFormInteraction parentWindow,
            UserControl parentControl) {
            this.parentWindow = parentWindow;
            this.parentControl = parentControl;
            parentWindow.SetBackButtonPressedListener(this);
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e) {
            parentWindow.setHeaderTitle(controlTitle);
            loadData();
        }

        private void loadData() {

            var sessionFactory = DataBaseConnection.CreateSessionFactory();
            using (var session = sessionFactory.OpenSession()) {
                indigene = session.CreateCriteria(typeof(Indigene))
                    .Add(NHibernate.Criterion.Expression.Eq("Id", Id)).UniqueResult<Indigene>();

                DataContext = this;
            }

        }

        private void updateIndigene() {
            ISessionFactory sessionFactory = DataBaseConnection.CreateSessionFactory();
            using (ISession session = sessionFactory.OpenSession()) {
                using (ITransaction transaction = session.BeginTransaction()) {
                    try {
                        indigene.FirstName = name.Text.Substring(0, name.Text.IndexOf(" ")).Trim();
                        indigene.OtherNames = name.Text.Substring(name.Text.IndexOf(" ")).Trim();
                        indigene.Village = village.SelectedItem.ToString().Trim();
                        indigene.MaritalStatus = maritalstatus.SelectedItem.ToString().Trim();
                        indigene.Sex = sexComboBox.SelectedItem.ToString().Trim();
                        indigene.DateOfBirth = (DateTime)dateofbirthDatePicker.SelectedDate;
                        indigene.NameOfParents = nameofParents.Text.Trim();
                        indigene.Occupation = occupation.Text.Trim();
                        indigene.PhoneNumber = phoneNumber.Text.Trim();
                        indigene.PlaceOfResidence = placeofResidence.Text.Trim();
                        indigene.Comments = comments.Text.Trim();
                    }
                    catch (Exception ex) {
                        parentWindow.ShowDialog("Some fields are empty, please fill them and then re-submit", true);
                        return;
                    }

                    ValidationHelper validationHelper = new ValidationHelper(indigene);
                    if (!validationHelper.IsValid) {
                        parentWindow.ShowDialog(validationHelper.Message(), true);
                    } else {
                        foreach (var child in indigene.Children) {
                            indigene.AddChild(child);
                            //session.SaveOrUpdate(child);
                        }

                        session.Update(indigene);
                        transaction.Commit();
                        parentWindow.ShowDialog("Indigene information Updated", true);
                        parentWindow.IndigeneUpdate();
                    }

                }
            }

        }

        public void SetParentWindow(MainWindow mainWindow) {
            parentWindow = mainWindow;
        }

        private void Button_Click(object sender, RoutedEventArgs e) {

        }

        public void OnBackButtonPressed() {
            parentWindow.LoadControl(parentControl);
            parentWindow.HideBackButton();
        }

        private void updateButton_Click(object sender, RoutedEventArgs e) {

            updateIndigene();
        }

        private void UserControl_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e) {
            if (((bool)(e.NewValue)) == true) {
                parentWindow.setHeaderTitle(controlTitle);
            }
        }
    }
}
