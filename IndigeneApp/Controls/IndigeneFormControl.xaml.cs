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
    /// Interaction logic for IndigeneFormControl.xaml
    /// </summary>
    public partial class IndigeneFormControl : UserControl
    {
        //Made Public for Databinding
        private static String controlTitle = "Add Indigene";
        ObservableCollection<Child> childList = new ObservableCollection<Child>();
        IList<String> villageList = new List<String>() { "Umu Esiakam", "Umu Akamudo", "Umu Nenyeli", "Umu Ezeogiga" };
        IList<String> sexList = new List<String>() { "Male", "Female" };
        IList<String> maritalStatusList = new List<String>() { "Divorced", "Married", "Widowed", "Single" };
        IParentFormInteraction parentWindow;

        public ObservableCollection<Child> ChildList {
            get { return childList; }
        }

        public IList<String> SexList {
            get { return sexList; }
        }

        public IList<String> MaritalStatusList {
            get { return maritalStatusList; }
        }

        public IList<String> VillageList {
            get { return villageList; }
        }

        public IndigeneFormControl(IParentFormInteraction parentWindow) {
            DataContext = this;
            this.parentWindow = parentWindow;
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e) {
            parentWindow.setHeaderTitle(controlTitle);
        }

        private void saveButton_Click(object sender, RoutedEventArgs e) {
            createIndigene();
        }

        private void createIndigene() {
            ISessionFactory sessionFactory = DataBaseConnection.CreateSessionFactory();
            using (ISession session = sessionFactory.OpenSession()) {
                using (ITransaction transaction = session.BeginTransaction()) {
                    
                    Indigene indigene = null;
                    try {
                        indigene = new Indigene {
                            FirstName = name.Text.Substring(0, name.Text.IndexOf(" ")).Trim(),
                            OtherNames = name.Text.Substring(name.Text.IndexOf(" ")).Trim(),
                            Village = village.SelectedItem.ToString().Trim(),
                            MaritalStatus = maritalstatus.SelectedItem.ToString().Trim(),
                            Sex = sexComboBox.SelectedItem.ToString().Trim(),
                            DateOfBirth = (DateTime)dateofbirthDatePicker.SelectedDate,
                            NameOfParents = nameofParents.Text.Trim(),
                            Occupation = occupation.Text.Trim(),
                            PhoneNumber = phoneNumber.Text.Trim(),
                            PlaceOfResidence = placeofResidence.Text.Trim(),
                            Comments = comments.Text.Trim()
                        };
                    }catch (Exception e) {
                        parentWindow.ShowDialog("Some fields are empty, please fill them and then re-submit", true);
                        return;
                    }

                    ValidationHelper validationHelper = new ValidationHelper(indigene);
                    if (!validationHelper.IsValid) {
                        parentWindow.ShowDialog(validationHelper.Message(), true);
                    } else { 
                        foreach (var child in childList) {
                            indigene.AddChild(child);
                            session.Save(child);
                        }

                        session.Save(indigene);
                        transaction.Commit();
                        parentWindow.ShowDialog("new Indigene created", true);
                        parentWindow.IndigeneUpdate();                    
                    }
                }
            }

        }

        private void addChildButton_Click(object sender, RoutedEventArgs e) {

            String name = childName.Text;
            int age = 0;
            try {
                age = Convert.ToInt32(childAge.Text);
            }
            catch (Exception ex) {
                childAge.Clear();
            }

            if (name.Length > 5 && age != 0) {
                Child child = new Child { Name = name, Age = age, Parent = null };
                childList.Add(child);
                childName.Clear();
                childAge.Clear();
            }
        }

        private void deleteMenuButton_Click(object sender, RoutedEventArgs e) {
            if (childList.Count > 0)
                childList.RemoveAt(childListBox.SelectedIndex);
        }

        private void UserControl_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e) {
            if (((bool)(e.NewValue)) == true) {
                parentWindow.setHeaderTitle(controlTitle);
            }
        }
    }
}
