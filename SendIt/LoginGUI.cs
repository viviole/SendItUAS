using SendIt.controllers;
using SendIt.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SendIt
{
    public partial class LoginPage : Form
    {
        
        public LoginPage()
        {
            InitializeComponent();
        }

        Authentication auth = new Authentication();
        Users loggedInUser;

        private async void loginButton_Click(object sender, EventArgs e)
        {
            string selectedRole = RoleComboBoxLogin.SelectedItem.ToString();
            Role roleLogin = (Role)Enum.Parse(typeof(Role), selectedRole);
            loggedInUser = await auth.AunthenticateUser(inputUsername.Text, inputPassword.Text, roleLogin);
            Console.WriteLine(loggedInUser);
            
            if (loggedInUser != null)
            {
                if(roleLogin == Role.Pengirim)
                {
                    DashboardPengirimGUI dashboardPeng = new DashboardPengirimGUI(loggedInUser);
                    dashboardPeng.Show();
                    this.Hide();
                }else
                {
                    DashboardKurirGUI dashboardKur = new DashboardKurirGUI();
                    dashboardKur.Show();
                    this.Hide();
                }
                
            }else
            {
                errorLabel.Text = "Invalid Username or Password";
            }
        }


        private void RegisterLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterGUI register = new RegisterGUI();
            register.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void inputUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
