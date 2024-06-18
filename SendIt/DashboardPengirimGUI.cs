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
    public partial class DashboardPengirimGUI : Form
    {
        Users _loggedInUser;
        public DashboardPengirimGUI(Users user)
        {
            InitializeComponent();
            _loggedInUser = user;
        }

        private void kirimButton_Click(object sender, EventArgs e)
        {
            Informasi_Pengiriman infoKirim = new Informasi_Pengiriman(_loggedInUser);
            infoKirim.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
