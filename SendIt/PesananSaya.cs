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
using static SendIt.Informasi_Pengiriman;

namespace SendIt
{
    public partial class PesananSaya : Form
    {
        private Users _loggedInUser;
        private readonly HttpClient _httpClient;

        public PesananSaya(Users loggedInUser)
        {
            InitializeComponent();
            _loggedInUser = loggedInUser;
            _httpClient = new HttpClient { BaseAddress = new Uri("https://localhost:7150/api/") };
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
            LoadPengirimanData();
        }
        private async Task LoadPengirimanData()
        {
            try
            {
                int idPengirim = _loggedInUser.Id;
                HttpResponseMessage response = await _httpClient.GetAsync($"pengiriman?idPengirim={idPengirim}");

                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    var pengirimanList = JsonConvert.DeserializeObject<List<Pengiriman>>(jsonString);

                    if (pengirimanList != null && pengirimanList.Count > 0)
                    {
                        // Di sini, Anda harus menemukan pengiriman yang sesuai dengan _loggedInUser.Id
                        // Misalnya, Anda bisa mencari pengiriman dengan ID pengirim yang sesuai
                        var pengiriman = pengirimanList.FirstOrDefault(p => p.IdPengirim == idPengirim);

                        if (pengiriman != null)
                        {
                            // Menampilkan data di label-label
                            OrderIdLabel.Text = pengiriman.Id.ToString();
                            namaPenerimaLabel.Text = pengiriman.Nama;
                            alamatTujuanLabel.Text = pengiriman.AlamatTujuan;
                            alamatJemputLabel.Text = pengiriman.AlamatJemput;
                            nomorTelefonLabel.Text = pengiriman.NomorTelepon;
                            BeratLabel.Text = pengiriman.Berat.ToString();
                            JarakLabel.Text = pengiriman.Jarak.ToString();
                            metodePembayaranLabel.Text = pengiriman.MetodePembayaran;
                            statusBarangLabel.Text = pengiriman.Status;
                            HargaLabel.Text = pengiriman.Harga.ToString();
                            idKurirLabel.Text = pengiriman.IdKurir.ToString();
                        }
                        else
                        {
                            MessageBox.Show($"Tidak ada data pengiriman untuk pengirim dengan ID: {idPengirim}");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Tidak ada data pengiriman ditemukan.");
                    }
                }
                else
                {
                    MessageBox.Show($"Gagal mengambil data pengiriman. Kode status: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}");
            }
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

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
