using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IndigeneApp.Models;
using NHibernate;

namespace IndigeneApp.Controls
{
    public partial class NewUserControl : UserControl
    {
        IConfigurationFormInteraction parentForm;
        public NewUserControl(IConfigurationFormInteraction parentForm) {
            this.parentForm = parentForm;
            InitializeComponent();
        }

        private void saveAccount() {

            if (password.Text != confirmationPassword.Text) {
                MessageBox.Show("Password Mismatch, please ensure the two passwords provided match.");
                return;
            }

            String accountName = "";
            try {
                accountName = accountTypeListBox.SelectedItem.ToString();
            }catch(Exception e){
                MessageBox.Show("Please select an account name from the Account Name dropdown.");
                return;
            }
           
            Account account = new Account {
                AccountName = accountName,
                Password = password.Text
            };

            ValidationHelper helper = new ValidationHelper(account);

            if (!helper.IsValid) {
                MessageBox.Show(helper.Message());
                return;
            }

            ISessionFactory sessionFactory = DataBaseConnection.CreateSessionFactory();
            using (ISession session = sessionFactory.OpenSession()) {
                using (ITransaction transaction = session.BeginTransaction()) {
                    session.Save(account);
                    transaction.Commit();
                    parentForm.EnableFormOKButton();
                    MessageBox.Show("Account Created");
                }
            }
            
        }

        private void newAccountButton_Click(object sender, EventArgs e) {
            saveAccount();
        }
    }
}
