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
    public partial class Informasi_Pengiriman : Form
    {
        private readonly HttpClient _httpClient;
        private int _harga;
        private Users _loggedInUser;
        public Informasi_Pengiriman(Users loggedInUser)
        {
            InitializeComponent();
            _httpClient = new HttpClient { BaseAddress = new Uri("https://localhost:7150/api/Pengiriman") };
            _loggedInUser = loggedInUser;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            

        }

        private void pengirimanLabel_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private async void submitButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Memeriksa apakah harga sudah dihitung sebelumnya
                if (_harga == 0)
                {
                    MessageBox.Show("Mohon hitung harga terlebih dahulu.");
                    return;
                }

                // Memeriksa apakah data yang dimasukkan sudah valid
                if (string.IsNullOrEmpty(receiverNameInput.Text) ||
                    string.IsNullOrEmpty(itemWeightInput.Text) ||
                    string.IsNullOrEmpty(receiverAddressInput.Text) ||
                    string.IsNullOrEmpty(itemDistanceInput.Text) ||
                    string.IsNullOrEmpty(receiverPhoneInput.Text) ||
                    comboBox1.SelectedItem == null ||
                    !int.TryParse(itemWeightInput.Text, out int berat) ||
                    !int.TryParse(itemDistanceInput.Text, out int jarak))
                {
                    MessageBox.Show("Mohon isi semua kolom dengan benar.");
                    return;
                }

                var pengiriman = new DataPengiriman
                {
                    Nama = receiverNameInput.Text,
                    Berat = berat,
                    AlamatTujuan = receiverAddressInput.Text,
                    Jarak = jarak,
                    NomorTelepon = receiverPhoneInput.Text,
                    MetodePembayaran = comboBox1.SelectedItem.ToString(),
                    Harga = _harga // Menggunakan nilai harga yang telah dihitung sebelumnya
                };

                var content = new StringContent(JsonConvert.SerializeObject(pengiriman), Encoding.UTF8, "application/json");
                var response = await _httpClient.PostAsync("pengiriman", content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Data pengiriman berhasil disimpan!");
                    DashboardPengirimGUI dPengirim = new DashboardPengirimGUI(_loggedInUser);
                    dPengirim.Show();
                    this.Hide();
                }
                else
                {
                    string message = $"Gagal menyimpan data pengiriman. Kode status: {response.StatusCode}";
                    MessageBox.Show(message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}");
            }
        }
        public class DataPengiriman
        {
            public int Id { get; set; }
            public string Nama { get; set; }
            public int Berat { get; set; }
            public string AlamatTujuan { get; set; }
            public int Jarak { get; set; }
            public string NomorTelepon { get; set; }
            public string MetodePembayaran { get; set; }
            public int Harga { get; set; }
        }

        private void receiverNameInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void itemWeightInput_TextChanged(object sender, EventArgs e)
        {
            // Validasi input
            if (!int.TryParse(itemWeightInput.Text, out int berat))
            {
                MessageBox.Show("Berat harus angka.");
                return;
            }

            // Menghitung harga
            int hargaDasar = 10000;
            int biayaPerKilometer = 1000;
            int biayaPerKilogram = 500;
            int jarak = 0; // Atau dapat diambil dari input jarak
            _harga = hargaDasar + (jarak * biayaPerKilometer) + (berat * biayaPerKilogram);
            // Menampilkan harga
            hargaField.Text = _harga.ToString();
        }


        private void receiverAddressInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void itemDistanceInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void receiverPhoneInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Informasi_Pengiriman_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click_1(object sender, EventArgs e)
        {

        }

        private void hargaField_TextChanged(object sender, EventArgs e)
        {   

        }

        private void Back_Click(object sender, EventArgs e)
        {
            DashboardPengirimGUI dashboardPeng = new DashboardPengirimGUI(_loggedInUser);
            dashboardPeng.Show();
            this.Hide();
        }
    }
}
