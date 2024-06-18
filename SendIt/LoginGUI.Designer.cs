﻿namespace SendIt
{
    partial class LoginPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.inputUsername = new System.Windows.Forms.TextBox();
            this.inputPassword = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.RegisterLabel = new System.Windows.Forms.LinkLabel();
            this.registerLabelComp = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.RoleComboBoxLogin = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(278, 97);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(55, 13);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "Username";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(280, 151);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(53, 13);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "Password";
            // 
            // inputUsername
            // 
            this.inputUsername.Location = new System.Drawing.Point(278, 112);
            this.inputUsername.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inputUsername.Name = "inputUsername";
            this.inputUsername.Size = new System.Drawing.Size(174, 20);
            this.inputUsername.TabIndex = 2;
            // 
            // inputPassword
            // 
            this.inputPassword.Location = new System.Drawing.Point(280, 167);
            this.inputPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inputPassword.Name = "inputPassword";
            this.inputPassword.Size = new System.Drawing.Size(174, 20);
            this.inputPassword.TabIndex = 3;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(271, 39);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(146, 44);
            this.titleLabel.TabIndex = 8;
            this.titleLabel.Text = "SendIt!";
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(280, 252);
            this.loginButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(172, 27);
            this.loginButton.TabIndex = 9;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // RegisterLabel
            // 
            this.RegisterLabel.AutoSize = true;
            this.RegisterLabel.Location = new System.Drawing.Point(399, 291);
            this.RegisterLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RegisterLabel.Name = "RegisterLabel";
            this.RegisterLabel.Size = new System.Drawing.Size(46, 13);
            this.RegisterLabel.TabIndex = 11;
            this.RegisterLabel.TabStop = true;
            this.RegisterLabel.Text = "Register";
            this.RegisterLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RegisterLabel_LinkClicked);
            // 
            // registerLabelComp
            // 
            this.registerLabelComp.AutoSize = true;
            this.registerLabelComp.Location = new System.Drawing.Point(292, 291);
            this.registerLabelComp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.registerLabelComp.Name = "registerLabelComp";
            this.registerLabelComp.Size = new System.Drawing.Size(108, 13);
            this.registerLabelComp.TabIndex = 12;
            this.registerLabelComp.Text = "Belum memiliki akun?";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(292, 304);
            this.errorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 13);
            this.errorLabel.TabIndex = 14;
            this.errorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RoleComboBoxLogin
            // 
            this.RoleComboBoxLogin.FormattingEnabled = true;
            this.RoleComboBoxLogin.Items.AddRange(new object[] {
            "Pengirim",
            "Kurir"});
            this.RoleComboBoxLogin.Location = new System.Drawing.Point(359, 209);
            this.RoleComboBoxLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RoleComboBoxLogin.Name = "RoleComboBoxLogin";
            this.RoleComboBoxLogin.Size = new System.Drawing.Size(92, 21);
            this.RoleComboBoxLogin.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(62, 111);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 178);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.RoleComboBoxLogin);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.registerLabelComp);
            this.Controls.Add(this.RegisterLabel);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.inputPassword);
            this.Controls.Add(this.inputUsername);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "LoginPage";
            this.Text = "Login Page";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox inputUsername;
        private System.Windows.Forms.TextBox inputPassword;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.LinkLabel RegisterLabel;
        private System.Windows.Forms.Label registerLabelComp;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.ComboBox RoleComboBoxLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

