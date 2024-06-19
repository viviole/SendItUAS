using Newtonsoft.Json;
using SendIt.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SendIt
{
    public partial class DashboardKurirGUI : Form
    {
        
        public DashboardKurirGUI()
        {
            InitializeComponent();
            LoadOrders();
        }

        private async void LoadOrders()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync("https://localhost:7150/api/Pengiriman");

                    if (response.IsSuccessStatusCode)
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();
                        List<Pengiriman> orders = JsonConvert.DeserializeObject<List<Pengiriman>>(responseBody);

                        // Hitung jumlah pesanan
                        int jumlahPesanan = orders.Count;
                        jumlahPesananLabel.Text = $"Jumlah Pesanan : {jumlahPesanan}";
                    }
                    else
                    {
                        MessageBox.Show($"Error: Unable to load orders. Status Code: {response.StatusCode}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Exception: {ex.Message}");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void jumlahPesananLabel_Click(object sender, EventArgs e)
        {

        }

        public class Pengiriman
        {
            public int Id { get; set; }
            public string Nama { get; set; }
            public int Berat { get; set; }
            public string AlamatTujuan { get; set; }
            public string AlamatJemput { get; set; }
            public int Jarak { get; set; }
            public string NomorTelepon { get; set; }
            public string MetodePembayaran { get; set; }
            public int Harga { get; set; }
            public int IdKurir { get; set; }
            public int IdPengirim { get; set; }
            public string Status { get; set; }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Users loggedInUser = new Users();
            KurirDetailPesanan dashboardKur = new KurirDetailPesanan(loggedInUser);
            dashboardKur.Show();
            this.Hide();
        }
    }
}
