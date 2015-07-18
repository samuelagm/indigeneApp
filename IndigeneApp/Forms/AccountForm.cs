using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IndigeneApp.Controls;

namespace IndigeneApp.Forms
{
    public partial class AccountForm : Form, IConfigurationFormInteraction
    {
        NewUserControl newUserControl;
        ChangePasswordControl changePasswordControl;

        public AccountForm() {
            InitializeComponent();
            newUserControl = new NewUserControl(this);
            changePasswordControl = new ChangePasswordControl(this);
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e) {
            if (e.Node.Text == "New User") {
                loadControls(newUserControl);
            } else if (e.Node.Text == "Change Password") {
                loadControls(changePasswordControl);
            }
        }

        private void loadControls(UserControl control){
            OkButton.Enabled = false;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(control);
        }

        private void button1_Click(object sender, EventArgs e) {
           this.Close();
        }

        private void button2_Click(object sender, EventArgs e) {
            this.Close();
        }

        public void EnableFormOKButton() {
            OkButton.Enabled = true;
        }
    }
}
