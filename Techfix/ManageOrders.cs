using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Techfix
{
    public partial class ManageOrders : Form
    {
        public readonly HttpClient client = new HttpClient();

        public ManageOrders()
        {
            InitializeComponent();
            loadorders();
        }

        public class Order
        {
            public int orderid { get; set; }
            public string ordername { get; set; }
            public int itemId { get; set; }
            public int quantity { get; set; }
            public string orderDate { get; set; }
            public double total { get; set; }
        }

        public async Task<List<Order>> GetAllOrders()
        {
            var response = await client.GetAsync("https://localhost:7138/api/Orders/all");

            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<Order>>(result);

            }
            else
            {
                return new List<Order>();
            }


        }

        public async void loadorders()
        {
            var orders = await GetAllOrders();
            if (orders != null && orders.Count > 0)
            {
                ordertable.AutoGenerateColumns = true; // Set once
                ordertable.DataSource = orders;
            }
            else
            {
                MessageBox.Show("No products found.");
            }

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ordertable_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int row = e.RowIndex;
            m_orderid_box.Text = ordertable.Rows[row].Cells[0].Value.ToString();
            m_ordername_box.Text = ordertable.Rows[row].Cells[1].Value.ToString();
            m_itemid_box.Text = ordertable.Rows[row].Cells[2].Value.ToString();
            m_quantityi_box.Text = ordertable.Rows[row].Cells[3].Value.ToString();

            try
            {
                m_dateTimePicker1.Text = ordertable.Rows[row].Cells[4].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Date set Error!");
            }
            m_total_box.Text = ordertable.Rows[row].Cells[5].Value.ToString();

            try
            {
                int quantity = Convert.ToInt32(m_quantityi_box.Text);

                double total = Convert.ToDouble(m_total_box.Text);

                double itemprice = total / quantity;

                m_itemprice_box.Text = itemprice.ToString();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);


            }
        }

        private async void updateOrder_btn_Click(object sender, EventArgs e)
        {
            int orderid = Convert.ToInt32(m_orderid_box.Text);
            string ordername = m_ordername_box.Text.ToString();
            int itemid = Convert.ToInt32(m_itemid_box.Text);
            int quantity = Convert.ToInt32(m_quantityi_box.Text);
            double totalprice = Convert.ToDouble(m_total_box.Text);
            string orderdate = m_dateTimePicker1.Text.ToString();

            var order = new Order { orderid = orderid, ordername = ordername, itemId = itemid, quantity = quantity, orderDate = orderdate, total = totalprice };

            var json = JsonConvert.SerializeObject(order);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            try
            {
                var response = await client.PutAsync($"https://localhost:7138/api/Orders/{orderid}", data);

                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    MessageBox.Show("Success " + result);
                    loadorders();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void m_quantityi_box_TextChanged(object sender, EventArgs e)
        {

            valueChange();


        }

        public void valueChange()
        {
            try
            {
                if (m_quantityi_box.Text != "")
                {
                    int quantity = Convert.ToInt32(m_quantityi_box.Text);

                    double itemprice = Convert.ToDouble(m_itemprice_box.Text);


                    double updateTotal = (itemprice * quantity);

                    m_total_box.Text = updateTotal.ToString();
                }
                else
                {
                    m_quantityi_box.Text = "0";
                    m_total_box.Text = "0";
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void deleteOrder_btn_Click(object sender, EventArgs e)
        {
            int orderid = 0;

            try
            {
                orderid = Convert.ToInt32(m_orderid_box.Text);
            }
            catch
            {
                MessageBox.Show("Pls Select Product to Delete!");
            }



            if (orderid != 0)
            {
                try
                {
                    var response = await client.DeleteAsync($"https://localhost:7138/api/Orders/{orderid}");

                    if (response.IsSuccessStatusCode)
                    {
                        var result = await response.Content.ReadAsStringAsync();
                        MessageBox.Show("Delete Success " + result);
                        loadorders();
                    }
                    else
                    {
                        MessageBox.Show("Delete faild" + response.ReasonPhrase.ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
