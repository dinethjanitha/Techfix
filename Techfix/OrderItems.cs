using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Techfix.Models;

namespace Techfix
{
    public partial class OrderItems : Form
    {

        private readonly HttpClient client = new HttpClient();
        public OrderItems()
        {
            InitializeComponent();
            dataloadtotable();
            itemquantity_box.Text = "0";

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var access = false;
            if (itemquantity_box.Text == "0" || itemquantity_box.Text == "")
            {
                MessageBox.Show("Pls Add quntity");
            }
            else if (totalprice_box.Text == "0" || totalprice_box.Text == "")
            {
                MessageBox.Show("Something wrong");
            }
            else
            {
                access = true;
            }

            if (access)
            {
                string ordername = itemname_box.Text;
                int itemid = Int32.Parse(itemid_box.Text);
                int quantity = Int32.Parse(itemquantity_box.Text);
                double total = double.Parse(totalprice_box.Text);
                string orderdate = dateTimePicker.Text;

                var order = new { ordername = ordername, itemId = itemid, quantity = quantity, orderDate = orderdate, total = total };

                var json = JsonConvert.SerializeObject(order);
                var data = new StringContent(json, Encoding.UTF8, "application/json");

                try
                {
                    var responce = await client.PostAsync("https://localhost:7138/api/Orders", data);

                    if (responce.IsSuccessStatusCode)
                    {
                        var result = await responce.Content.ReadAsStringAsync();
                        MessageBox.Show("Order Add Sucesss! " + result);
                    }
                    else
                    {
                        MessageBox.Show("Bad req");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }





        }

        


        public async Task<List<Product>> loadItems()
        {
            var responce = await client.GetAsync("https://localhost:7138/api/product");

            if (responce.IsSuccessStatusCode)
            {
                var json = await responce.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<Product>>(json);
            }
            else
            {
                return new List<Product>();
            }

        }

        public async void dataloadtotable()
        {
            try
            {
                var products = await loadItems();
                if (products != null && products.Count > 0)
                {
                    producttable.AutoGenerateColumns = true; // Set once
                    producttable.DataSource = products;
                }
                else
                {
                    MessageBox.Show("No products found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void producttable_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int row = e.RowIndex;
            itemid_box.Text = producttable.Rows[row].Cells[0].Value.ToString();
            itemname_box.Text = producttable.Rows[row].Cells[1].Value.ToString();
            itemprice_box.Text = producttable.Rows[row].Cells[5].Value.ToString();

        }

        private void itemquantity_box_TextChanged(object sender, EventArgs e)
        {

            try
            {
                if (itemquantity_box.Text != "")
                {
                    int quntity = Convert.ToInt32(itemquantity_box.Text);

                    double itemprice = Convert.ToDouble(itemprice_box.Text);

                    double total = quntity * itemprice;

                    totalprice_box.Text = total.ToString();


                }
                else
                {

                    //   itemquantity_box.Text = "0";
                    totalprice_box.Text = "0";
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private async void textBox4_TextChanged(object sender, EventArgs e)
        {
            loaddatatotable();

        }

        public async Task<List<Product>> searchData()
        {
            var searchTxt = search_box.Text;

            List<Product> products = new List<Product>();
            var responce = await client.GetAsync($"https://localhost:7138/api/Orders/{searchTxt}");

            if (responce.IsSuccessStatusCode)
            {
                var json = await responce.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<Product>>(json);
            }
            else
            {
                return new List<Product>();
            }
        }

        public async void loaddatatotable()
        {
            try
            {
                var products = await searchData();
                if (products != null && products.Count > 0)
                {
                    producttable.AutoGenerateColumns = true;
                    producttable.DataSource = products;
                }
                else
                {
                    MessageBox.Show("No products found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.ShowDialog();
        }

        private void OrderItems_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
