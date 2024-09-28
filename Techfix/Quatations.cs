using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Techfix.Models;

namespace Techfix
{
    public partial class Quatations : Form
    {
        public readonly HttpClient client = new HttpClient();
        public Quatations()
        {
            InitializeComponent();
            loadDataAll();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
       


        private async Task<List<Product>> GetAllproducts()
        {

            var responce = await client.GetAsync("https://localhost:7138/api/product");
            if (responce.IsSuccessStatusCode)
            {
                var json = await responce.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<Product>>(json);
            }
            else
            {
                MessageBox.Show("Error" + responce.ReasonPhrase);
                return new List<Product>();

            }



        }

        public async void loadDataAll()
        {
            try
            {
                var products = await GetAllproducts();
                if (products != null && products.Count > 0)
                {
                    qutview.AutoGenerateColumns = true; // Set once
                    qutview.DataSource = products;
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


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            loaddatatotable();
        }

        public async Task<List<Product>> searchData()
        {
            var searchTxt = qtSearch_Box.Text;

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
                    qutview.AutoGenerateColumns = true; // Set once
                    qutview.DataSource = products;
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home hm = new Home();
            hm.ShowDialog();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            var products = await GetAllproducts();
            qutview.DataSource = products;
            qutview.AutoGenerateColumns = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (shop1q.Checked)
            {
                shoponeproduct();
            }

            if (radioButton1.Checked)
            {
                loadDataAll();
            }
        }


        public async Task<List<Product>> shopone()
        {


            List<Product> products = new List<Product>();
            var responce = await client.GetAsync($"https://localhost:7138/api/product/shop1");

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


        public async void shoponeproduct()
        {
            try
            {
                var products = await shopone();
                if (products != null && products.Count > 0)
                {
                    qutview.AutoGenerateColumns = true; // Set once
                    qutview.DataSource = products;
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

        public async Task<List<Product>> shopTwo()
        {


            List<Product> products = new List<Product>();
            var responce = await client.GetAsync($"https://localhost:7138/api/product/shop2");

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


        public async void shopTwoproduct()
        {
            try
            {
                var products = await shopTwo();
                if (products != null && products.Count > 0)
                {
                    qutview.AutoGenerateColumns = true; // Set once
                    qutview.DataSource = products;
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

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (shoptwor.Checked) {
                shopTwoproduct();
            }
        }
    }




}
