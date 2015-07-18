namespace IndigeneApp.Controls
{
    partial class NewUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.newAccountButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.confirmationPassword = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.accountTypeListBox = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.newAccountButton);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.confirmationPassword);
            this.groupBox1.Controls.Add(this.password);
            this.groupBox1.Controls.Add(this.accountTypeListBox);
            this.groupBox1.Location = new System.Drawing.Point(14, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 236);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New User";
            // 
            // newAccountButton
            // 
            this.newAccountButton.Location = new System.Drawing.Point(156, 162);
            this.newAccountButton.Name = "newAccountButton";
            this.newAccountButton.Size = new System.Drawing.Size(101, 28);
            this.newAccountButton.TabIndex = 18;
            this.newAccountButton.Text = "Create";
            this.newAccountButton.UseVisualStyleBackColor = true;
            this.newAccountButton.Click += new System.EventHandler(this.newAccountButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Retype Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Account name";
            // 
            // confirmationPassword
            // 
            this.confirmationPassword.Location = new System.Drawing.Point(156, 122);
            this.confirmationPassword.Name = "confirmationPassword";
            this.confirmationPassword.Size = new System.Drawing.Size(236, 20);
            this.confirmationPassword.TabIndex = 14;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(156, 95);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(236, 20);
            this.password.TabIndex = 13;
            // 
            // accountTypeListBox
            // 
            this.accountTypeListBox.FormattingEnabled = true;
            this.accountTypeListBox.Items.AddRange(new object[] {
            "Administrator",
            "User"});
            this.accountTypeListBox.Location = new System.Drawing.Point(156, 46);
            this.accountTypeListBox.Name = "accountTypeListBox";
            this.accountTypeListBox.Size = new System.Drawing.Size(236, 21);
            this.accountTypeListBox.TabIndex = 12;
            // 
            // NewUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "NewUserControl";
            this.Size = new System.Drawing.Size(443, 254);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button newAccountButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox confirmationPassword;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.ComboBox accountTypeListBox;

    }
}
