using Newtonsoft.Json;
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
using SendIt.models;

namespace SendIt
{
    public partial class PesananSaya : Form
    {
        private Users _loggedInUser;
        public PesananSaya(Users loggedInUser)
        {
            InitializeComponent();
            _loggedInUser = loggedInUser;
        }

        private void namaPenerimaLabel_Click(object sender, EventArgs e)
        {

        }

        private void alamatTujuanLabel_Click(object sender, EventArgs e)
        {

        }

        private void nomorTelefonLabel_Click(object sender, EventArgs e)
        {

        }

        private void PesananSaya_Load(object sender, EventArgs e)
        {

        }

        private void BeratLabel_Click(object sender, EventArgs e)
        {

        }

        private void JarakLabel_Click(object sender, EventArgs e)
        {

        }

        private void metodePembayaranLabel_Click(object sender, EventArgs e)
        {

        }

        private void HargaLabel_Click(object sender, EventArgs e)
        {

        }

        private void StatusLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DashboardPengirimGUI dashboardPeng = new DashboardPengirimGUI(_loggedInUser);
            dashboardPeng.Show();
            this.Hide();
        }
    }
}
