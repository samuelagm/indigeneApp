using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHibernate;
using IndigeneApp.Models;

namespace IndigeneApp.Controls
{
    public partial class ChangePasswordControl : UserControl
    {
        IConfigurationFormInteraction parentForm;
        public ChangePasswordControl(IConfigurationFormInteraction parentForm) {
            this.parentForm = parentForm;
            InitializeComponent();
        }

        private void changePassword() {
            String accountText = "";
            String oldPasswordText = oldPassword.Text;
            String newPasswordText = newPassword.Text;

            try {
                accountText = accountNameListBox.SelectedItem.ToString();
            }
            catch (Exception e) {
                MessageBox.Show("Please select an account name from the Account Name dropdown.");
                return;
            }

            ISessionFactory sessionfactory = DataBaseConnection.CreateSessionFactory();
            using (var session = sessionfactory.OpenSession()) {
                Account account = session.CreateCriteria<Account>().Add(NHibernate.Criterion.Expression
                        .And(NHibernate.Criterion.Expression.Eq("AccountName", accountText),
                             NHibernate.Criterion.Expression.Eq("Password", oldPasswordText)))
                    .UniqueResult<Account>();
                if (account != null) {
                    using (var transaction = session.BeginTransaction()) {
                        account.Password = newPasswordText;
                        session.Update(account);
                        transaction.Commit();
                        MessageBox.Show("Password successfully changed.");
                        parentForm.EnableFormOKButton();
                    }
                } else {
                    MessageBox.Show("An account with the current details does not exist.");
                }
            }
        }

        private void changeButton_Click(object sender, EventArgs e) {
            changePassword();
        }
    }
}
