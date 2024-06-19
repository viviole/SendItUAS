using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SendIt
{
    public partial class KurirDetailPesanan : Form
    {
        public KurirDetailPesanan()
        {
            InitializeComponent();
            LoadOrders();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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

                        var listModel = new BindingList<string>();

                        foreach (Pengiriman order in orders)
                        {
                            listModel.Add($"Order ID: {order.Id}, Nama: {order.Nama}, Berat: {order.Berat}, Alamat: {order.AlamatTujuan}, Status: {order.Status}");
                        }

                        listBox1.DataSource = listModel;
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

        private async Task UpdateOrderStatusAsync(string orderId, string newStatus)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    // Get the selected order from listbox
                    string selectedOrder = listBox1.SelectedItem?.ToString();
                    if (selectedOrder != null)
                    {
                        // Assuming the format is "Order ID: {order.Id}, Nama: {order.Nama}, Berat: {order.Berat}, Alamat: {order.AlamatTujuan}"
                        string selectedOrderId = selectedOrder.Split(',')[0].Trim().Replace("Order ID: ", "");

                        // Get the existing order details from the API
                        HttpResponseMessage getOrderResponse = await client.GetAsync($"https://localhost:7150/api/Pengiriman/{selectedOrderId}");

                        if (getOrderResponse.IsSuccessStatusCode)
                        {
                            string getOrderResponseBody = await getOrderResponse.Content.ReadAsStringAsync();
                            Pengiriman order = JsonConvert.DeserializeObject<Pengiriman>(getOrderResponseBody);

                            // Update the status
                            order.Status = newStatus;

                            // Send the updated order back to the server
                            var content = new StringContent(JsonConvert.SerializeObject(order), Encoding.UTF8, "application/json");
                            HttpResponseMessage updateResponse = await client.PutAsync($"https://localhost:7150/api/Pengiriman/{selectedOrderId}", content);

                            if (updateResponse.IsSuccessStatusCode)
                            {
                                // Reload orders after successful update
                                LoadOrders();
                                MessageBox.Show("Status berhasil diperbarui!");
                            }
                            else
                            {
                                string errorMessage = await updateResponse.Content.ReadAsStringAsync();
                                MessageBox.Show($"Error: Unable to update order status. Status Code: {updateResponse.StatusCode}. {errorMessage}");
                            }
                        }
                        else
                        {
                            MessageBox.Show($"Error: Unable to fetch order details. Status Code: {getOrderResponse.StatusCode}");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please select an order to update");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Exception: {ex.Message}");
            }
        }

        private async void UpdateOrderStatus(string newStatus)
        {
            string selectedOrder = listBox1.SelectedItem?.ToString();
            if (selectedOrder != null)
            {
                // Assuming the format is "Order ID: {order.Id}, Nama: {order.Nama}, Berat: {order.Berat}, Alamat: {order.AlamatTujuan}"
                string orderId = selectedOrder.Split(',')[0].Trim().Replace("Order ID: ", "");

                Console.WriteLine("Selected Order ID: " + orderId);
                Console.WriteLine("New Status: " + newStatus);

                await UpdateOrderStatusAsync(orderId, newStatus);
                LoadOrders();
            }
            else
            {
                MessageBox.Show("Please select an order to update");
            }
        }

        private void sedangDipickupButton_Click(object sender, EventArgs e)
        {
            UpdateOrderStatus("sedang dipickup");
        }

        private void sedangDikirimButton_Click(object sender, EventArgs e)
        {
            UpdateOrderStatus("sedang dikirim");
        }

        private void sudahDiterimaButton_Click(object sender, EventArgs e)
        {
            UpdateOrderStatus("sudah diterima");
        }

        public class Pengiriman
        {
            public int Id { get; set; }
            public string Nama { get; set; }
            public int Berat { get; set; }
            public string AlamatTujuan { get; set; }
            public int Jarak { get; set; }
            public string NomorTelepon { get; set; }
            public string MetodePembayaran { get; set; }
            public int Harga { get; set; }
            public int IdKurir { get; set; }
            public string Status { get; set; }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            // Hide the current form
            this.Hide();

            // Show the login form
            LoginPage loginForm = new LoginPage();
            loginForm.Show();
            MessageBox.Show("Anda berhasil keluar!");
            // Close the current form
            this.Close();
        }
    }
}
