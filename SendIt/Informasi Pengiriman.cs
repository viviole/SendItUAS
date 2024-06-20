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
using SendIt.helper;

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

        private async Task<List<Kurir>> GetKurirData()
        {
            try
            {
                Console.WriteLine("Mengambil data kurir...");

                HttpResponseMessage response = await _httpClient.GetAsync("kurir");

                Console.WriteLine($"Response status code: {response.StatusCode}");

                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    Console.WriteLine("Data kurir JSON: " + jsonString);

                    var kurirList = JsonConvert.DeserializeObject<List<Kurir>>(jsonString);
                    Console.WriteLine($"Jumlah kurir yang diambil: {kurirList.Count}");

                    foreach (var kurir in kurirList)
                    {
                        Console.WriteLine($"Kurir ID: {kurir.Id}, Nama: {kurir.NamaLengkap}");
                    }

                    return kurirList ?? new List<Kurir>();
                }
                else
                {
                    MessageBox.Show($"Gagal mengambil data kurir. Kode status: {response.StatusCode}");
                    return new List<Kurir>();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan saat mengambil data kurir: {ex.Message}");
                Console.WriteLine("Error: " + ex.Message);
                return new List<Kurir>();
            }
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
                    string.IsNullOrEmpty(alamatJemputField.Text) ||
                    string.IsNullOrEmpty(itemDistanceInput.Text) ||
                    string.IsNullOrEmpty(receiverPhoneInput.Text) ||
                    comboBox1.SelectedItem == null ||
                    !int.TryParse(itemWeightInput.Text, out int berat) ||
                    !int.TryParse(itemDistanceInput.Text, out int jarak))
                {
                    MessageBox.Show("Mohon isi semua kolom dengan benar.");
                    return;
                }
                Console.WriteLine("Mengambil data kurir...");

                // Mengambil data kurir dari API
                var kurirList = await GetKurirData();
                if (kurirList.Count == 0)
                {
                    MessageBox.Show("Tidak ada data kurir yang tersedia.");
                    return;
                }

                Console.WriteLine($"Jumlah kurir yang diambil: {kurirList.Count}");

                // Menentukan IdKurir secara acak dari data kurir yang didapat
                Random random = new Random();
                int randomIndex = random.Next(0, kurirList.Count);
                int idKurir = kurirList[randomIndex].Id;

                Console.WriteLine($"ID Kurir yang dipilih: {idKurir}");

                var pengiriman = new Pengiriman
                {
                    Nama = receiverNameInput.Text,
                    Berat = berat,
                    AlamatTujuan = receiverAddressInput.Text,
                    AlamatJemput = alamatJemputField.Text,
                    Jarak = jarak,
                    NomorTelepon = receiverPhoneInput.Text,
                    MetodePembayaran = comboBox1.SelectedItem.ToString(),
                    Harga = _harga, // Menggunakan nilai harga yang telah dihitung sebelumnya
                    IdKurir = idKurir,
                    IdPengirim = _loggedInUser.Id,
                    Status = "On Progress" // Nilai default
                };

                var content = new StringContent(JsonConvert.SerializeObject(pengiriman), Encoding.UTF8, "application/json");
                var response = await _httpClient.PostAsync("", content);

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

        private void receiverNameInput_TextChanged(object sender, EventArgs e)
        {

        }
        private void ValidateJarak()
        {

        }

        private bool isWeightValid = true;
        private bool isDistanceValid = true;

        private void CalculatePrice()
        {
            // Reset the flags before validation
            bool previousWeightValid = isWeightValid;
            bool previousDistanceValid = isDistanceValid;

            isWeightValid = true;
            isDistanceValid = true;

            // Pastikan input tidak kosong sebelum mencoba validasi
            if (string.IsNullOrWhiteSpace(itemWeightInput.Text) || string.IsNullOrWhiteSpace(itemDistanceInput.Text))
            {
                hargaField.Text = string.Empty;
                return;
            }

            // Validasi input berat
            if (!int.TryParse(itemWeightInput.Text, out int berat))
            {
                isWeightValid = false;
            }
            else if (!PriceCalculator.IsWeightValid(berat))
            {
                isWeightValid = false;
                MessageBox.Show("Berat tidak boleh lebih dari 20.");
            }

            // Validasi input jarak
            if (!int.TryParse(itemDistanceInput.Text, out int jarak))
            {
                isDistanceValid = false;
            }
            else if (!PriceCalculator.IsDistanceValid(jarak))
            {
                isDistanceValid = false;
                MessageBox.Show("Jarak tidak boleh lebih dari 7.");
            }

            // Tampilkan pesan kesalahan jika ada input yang tidak valid
            if (!isWeightValid && previousWeightValid)
            {
                MessageBox.Show("Berat harus angka.");
            }

            if (!isDistanceValid && previousDistanceValid)
            {
                MessageBox.Show("Jarak harus angka.");
            }

            if (!isWeightValid || !isDistanceValid)
            {
                hargaField.Text = string.Empty;
                return;
            }

            // Menghitung harga menggunakan kelas helper
            _harga = PriceCalculator.CalculatePrice(berat, jarak);

            // Menampilkan harga
            hargaField.Text = _harga.ToString();
        }

        private void itemWeightInput_TextChanged(object sender, EventArgs e)
        {
            CalculatePrice();
        }


        private void receiverAddressInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void itemDistanceInput_TextChanged(object sender, EventArgs e)
        {
            CalculatePrice() ;
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void alamatJemputField_TextChanged(object sender, EventArgs e)
        {

        }
    }
}