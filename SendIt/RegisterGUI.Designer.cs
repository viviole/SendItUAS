namespace SendIt
{
    partial class RegisterGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterGUI));
            this.titleLabelReg = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.inputPassword = new System.Windows.Forms.TextBox();
            this.inputUsername = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.registerButton = new System.Windows.Forms.Button();
            this.loginLabelComp = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.LinkLabel();
            this.inputNamaLengkap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.inputUsia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.roleComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabelReg
            // 
            this.titleLabelReg.AutoSize = true;
            this.titleLabelReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabelReg.Location = new System.Drawing.Point(317, 40);
            this.titleLabelReg.Name = "titleLabelReg";
            this.titleLabelReg.Size = new System.Drawing.Size(178, 54);
            this.titleLabelReg.TabIndex = 9;
            this.titleLabelReg.Text = "SendIt!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(82, 137);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 178);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // inputPassword
            // 
            this.inputPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputPassword.Location = new System.Drawing.Point(292, 187);
            this.inputPassword.Name = "inputPassword";
            this.inputPassword.Size = new System.Drawing.Size(230, 22);
            this.inputPassword.TabIndex = 17;
            // 
            // inputUsername
            // 
            this.inputUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputUsername.Location = new System.Drawing.Point(292, 137);
            this.inputUsername.Name = "inputUsername";
            this.inputUsername.Size = new System.Drawing.Size(230, 22);
            this.inputUsername.TabIndex = 16;
            // 
            // passwordLabel
            // 
            this.passwordLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(292, 167);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(67, 16);
            this.passwordLabel.TabIndex = 15;
            this.passwordLabel.Text = "Password";
            // 
            // usernameLabel
            // 
            this.usernameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(292, 118);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(70, 16);
            this.usernameLabel.TabIndex = 14;
            this.usernameLabel.Text = "Username";
            // 
            // registerButton
            // 
            this.registerButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.registerButton.Location = new System.Drawing.Point(424, 282);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(230, 33);
            this.registerButton.TabIndex = 19;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // loginLabelComp
            // 
            this.loginLabelComp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginLabelComp.AutoSize = true;
            this.loginLabelComp.Location = new System.Drawing.Point(441, 330);
            this.loginLabelComp.Name = "loginLabelComp";
            this.loginLabelComp.Size = new System.Drawing.Size(137, 16);
            this.loginLabelComp.TabIndex = 20;
            this.loginLabelComp.Text = "Sudah memiliki akun?";
            // 
            // loginLabel
            // 
            this.loginLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(584, 330);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(40, 16);
            this.loginLabel.TabIndex = 21;
            this.loginLabel.TabStop = true;
            this.loginLabel.Text = "Login";
            this.loginLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.loginLabel_LinkClicked);
            // 
            // inputNamaLengkap
            // 
            this.inputNamaLengkap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputNamaLengkap.Location = new System.Drawing.Point(554, 137);
            this.inputNamaLengkap.Name = "inputNamaLengkap";
            this.inputNamaLengkap.Size = new System.Drawing.Size(230, 22);
            this.inputNamaLengkap.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(554, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "Nama Lengkap";
            // 
            // inputUsia
            // 
            this.inputUsia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputUsia.Location = new System.Drawing.Point(554, 186);
            this.inputUsia.Name = "inputUsia";
            this.inputUsia.Size = new System.Drawing.Size(230, 22);
            this.inputUsia.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(554, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "Usia";
            // 
            // roleComboBox
            // 
            this.roleComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.roleComboBox.FormattingEnabled = true;
            this.roleComboBox.Items.AddRange(new object[] {
            "Pengirim",
            "Kurir"});
            this.roleComboBox.Location = new System.Drawing.Point(482, 236);
            this.roleComboBox.Name = "roleComboBox";
            this.roleComboBox.Size = new System.Drawing.Size(121, 24);
            this.roleComboBox.TabIndex = 26;
            // 
            // RegisterGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.roleComboBox);
            this.Controls.Add(this.inputUsia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputNamaLengkap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.loginLabelComp);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.inputPassword);
            this.Controls.Add(this.inputUsername);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.titleLabelReg);
            this.Name = "RegisterGUI";
            this.Text = "RegisterGUI";
            this.Load += new System.EventHandler(this.RegisterGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabelReg;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox inputPassword;
        private System.Windows.Forms.TextBox inputUsername;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Label loginLabelComp;
        private System.Windows.Forms.LinkLabel loginLabel;
        private System.Windows.Forms.TextBox inputNamaLengkap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputUsia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox roleComboBox;
    }
}