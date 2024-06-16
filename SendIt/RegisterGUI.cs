using SendIt.controllers;
using SendIt.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

        private async void registerButton_Click(object sender, EventArgs e)
        {
            string selectedRole = roleComboBox.SelectedItem.ToString();
            Role roleRegis = (Role)Enum.Parse(typeof(Role), selectedRole);
            bool regisCondition = await auth.RegisterUser(inputNamaLengkap.Text, inputUsername.Text, inputPassword.Text, inputUsia.Text, roleRegis);
            //string namaLengkap, string username, string password, string umur, Role role
            if (regisCondition == true)
            {
                LoginPage login = new LoginPage();
                login.Show();
                this.Hide();
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
    }
}
