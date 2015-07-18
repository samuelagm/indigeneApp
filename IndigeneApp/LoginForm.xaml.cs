using IndigeneApp.Models;
using NHibernate;
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
using System.Windows.Shapes;

namespace IndigeneApp
{
    /// <summary>
    /// Interaction logic for LoginForm.xaml
    /// </summary>
    public partial class LoginForm : Window
    {
        public LoginForm() {
            InitializeComponent();
        }

        private Boolean doLogin() {
            String accountText = "";
            String passwordText = password.Password;

            try {
                accountText = ((ComboBoxItem)accountNameComboBox.SelectedItem).Content.ToString();
            }
            catch (Exception e) {
                MessageBox.Show("Please select an account name from the Account Name dropdown.");
                return false;
            }

            
            ISessionFactory sessionfactory = DataBaseConnection.CreateSessionFactory();
            using (var session = sessionfactory.OpenSession()) {

                if (DataBaseConnection.overwriteSchema()) {

                    Account newAccount = new Account {
                        AccountName = "Administrator",
                        Password = "admin"
                    };
                    using(var transaction = session.BeginTransaction()){
                        session.Save(newAccount);
                        transaction.Commit();
                    }
                    DataBaseConnection.saveCurrentSchema();
                }

                Account account = session.CreateCriteria<Account>().Add(NHibernate.Criterion.Expression
                        .And(NHibernate.Criterion.Expression.Eq("AccountName", accountText),
                             NHibernate.Criterion.Expression.Eq("Password", passwordText)))
                    .UniqueResult<Account>();
                if (account != null) {
                    MainWindow mainWindow = new MainWindow();
                    mainWindow.SetAccountType(accountText);
                    mainWindow.Show();
                    this.Close();
                } else {
                    MessageBox.Show("An account with the current details does not exist.");
                    password.Clear();
                    loginButton.Content = "Login";
                }
            }

            return false;
        }

        private void loginButton_Click(object sender, RoutedEventArgs e) {
            loginButton.Content = "Login In...";
            TaskFactory tf = new TaskFactory();
            tf.StartNew(() => {
                this.Dispatcher.Invoke(() => {
                    doLogin();
                });
            });
        }

        private void closeButton_Click(object sender, RoutedEventArgs e) {
            this.Close();
        }
    }
}
