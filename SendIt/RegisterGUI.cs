using SendIt.controllers;
using SendIt.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SendIt
{
    public partial class RegisterGUI : Form
    {
        public RegisterGUI()
        {
            InitializeComponent();
        }

        Authentication auth = new Authentication();
        Users registerUser;

        public bool ValidatePassword(string password)
        {
            var lengthRule = new Regex(@".{8,}");  // At least 8 characters
            var upperCaseRule = new Regex(@"[A-Z]");  // At least one uppercase letter
            var lowerCaseRule = new Regex(@"[a-z]");  // At least one lowercase letter
            var digitRule = new Regex(@"\d");  // At least one digit
            var specialCharRule = new Regex(@"\W|_");  // At least one special character

            // Check if password meets all rules
            if (!lengthRule.IsMatch(password))
            {
                errorLabel.Text = "Password must be at least 8 characters long.";
                return false;
            }

            if (!upperCaseRule.IsMatch(password))
            {
                errorLabel.Text = "Password must contain at least one uppercase letter.";
                return false;
            }

            if (!lowerCaseRule.IsMatch(password))
            {
                errorLabel.Text = "Password must contain at least one lowercase letter.";
                return false;
            }

            if (!digitRule.IsMatch(password))
            {
                errorLabel.Text = "Password must contain at least one digit.";
                return false;
            }

            if (!specialCharRule.IsMatch(password))
            {
                errorLabel.Text = "Password must contain at least one special character.";
                return false;
            }
            return true;
        }
        private async void registerButton_Click(object sender, EventArgs e)
        {
            if (!ValidatePassword(inputPassword.Text))
            {

            }
            else
            {
                string selectedRole = roleComboBox.SelectedItem.ToString();
                Role roleRegis = (Role)Enum.Parse(typeof(Role), selectedRole);
                bool regisCondition = await auth.RegisterUser(inputNamaLengkap.Text, inputUsername.Text, inputPassword.Text, inputUsia.Text, roleRegis);
                //string namaLengkap, string username, string password, string umur, Role role
                if (regisCondition == true)
                {
                    MessageBox.Show("Akun anda berhasil register!");
                    LoginPage login = new LoginPage();
                    login.Show();
                    this.Hide();
                }
                else
                {
                    errorLabel.Text = "Username already exists";
                }
            }
        }

        private void loginLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginPage login = new LoginPage();
            login.Show();
            this.Hide();
        }

        private void RegisterGUI_Load(object sender, EventArgs e)
        {

        }

        private void inputPassword_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void inputPassword_TextChanged_1(object sender, EventArgs e)
        {
            inputPassword.UseSystemPasswordChar = true;
        }
    }
}