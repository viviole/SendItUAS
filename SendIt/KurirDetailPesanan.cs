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
    public partial class KurirDetailPesanan : Form
    {
        public KurirDetailPesanan()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LoadOrders()
        {
            try
            {
                List<string> orders = _orderController.GetOrders();
                var listModel = new BindingList<string>();

                foreach (string order in orders)
                {
                    listModel.Add(order);
                }

                listBox1.DataSource = listModel;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private void UpdateOrderStatus(string newStatus)
        {
            string selectedOrder = listBox1.SelectedItem?.ToString();
            if (selectedOrder != null)
            {
                string orderId = selectedOrder.Split(',')[0].Trim().Replace("ID: ", ""); 
                Console.WriteLine("Selected Order ID: " + orderId); 
                Console.WriteLine("New Status: " + newStatus); 

                orderController.UpdateOrderStatus(orderId, newStatus);
                LoadOrders(); 
            }
            else
            {
                MessageBox.Show("Please select an order to update");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
