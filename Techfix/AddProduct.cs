using Microsoft.VisualBasic.ApplicationServices;
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
using Techfix.Operations;
using static Techfix.AddProduct;

namespace Techfix
{
    public partial class AddProduct : Form
    {
        private readonly HttpClient client = new HttpClient();

        public AddProduct()
        {
            InitializeComponent();
            loadDataAll();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void productName_Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var productName = productName_Box.Text;
            var productCatagory = Catagory_Box.Text;
            var quantity = Convert.ToInt32(quntity_Box.Text);
            var productPrice = ProductPrice_Box.Text;
            var shopName = SaveUser.shopname;
            var productDes = ProductDes_Box.Text;

            var product = new { productName = productName, productDescription = productDes, productCategory = productCatagory, quantity = quantity, productprice = productPrice, shopName = shopName, };

            var json = JsonConvert.SerializeObject(product);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            try
            {
                var responce = await client.PostAsync("https://localhost:7138/api/product/addproduct", data);

                if (responce.IsSuccessStatusCode)
                {
                    var result = await responce.Content.ReadAsStringAsync();
                    MessageBox.Show("Product Add Success! " + result);
                }
                else
                {
                    MessageBox.Show("Product Add Unsuccess! " + responce.ReasonPhrase);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public class Product
        {
            public string productId { get; set; }
            public string productName { get; set; }
            public string productDescription { get; set; }
            public string productCategory { get; set; }
            public string quantity { get; set; }
            public string productprice { get; set; }
            public string shopName { get; set; }
        }

        private async Task<List<Product>> GetAllproducts()
        {

            var responce = await client.GetAsync("https://localhost:7138/api/product/all");
            if (responce.IsSuccessStatusCode)
            {
                var json = await responce.Content.ReadAsStringAsync();
                MessageBox.Show("Sucesss");
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
                    loadproductData.AutoGenerateColumns = true; // Set once
                    loadproductData.DataSource = products;
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

        private async void loadproductData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var products = await GetAllproducts();
            loadproductData.DataSource = products;
            loadproductData.AutoGenerateColumns = true;
        }

        private void dataLoad_Click(object sender, EventArgs e)
        {
            loadDataAll();
        }

        private void loadproductData_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = e.RowIndex;
            productId_Box.Text = loadproductData.Rows[id].Cells[0].Value.ToString();
            productName_Box.Text = loadproductData.Rows[id].Cells[1].Value.ToString();
            ProductDes_Box.Text = loadproductData.Rows[id].Cells[2].Value.ToString();
            Catagory_Box.Text = loadproductData.Rows[id].Cells[3].Value.ToString();
            quntity_Box.Text = loadproductData.Rows[id].Cells[4].Value.ToString();
            ProductPrice_Box.Text = loadproductData.Rows[id].Cells[5].Value.ToString();
            //shopName_Box.Text = loadproductData.Rows[id].Cells[5].Value.ToString() ;
            // ProductPrice_Box.Text = loadproductData.Rows[id].Cells[3]

        }

        private async void update_btn_Click(object sender, EventArgs e)
        {
            int productid = Convert.ToInt32(productId_Box.Text);
            string productname = productName_Box.Text;
            string productdes = ProductDes_Box.Text;
            string productCatagory = Catagory_Box.Text;
            string productprice = ProductPrice_Box.Text;
            string shopname = SaveUser.shopname;
            int quantity = Convert.ToInt32(quntity_Box.Text);

            var updatedProduct = new { productId = productid, productName = productname, productDescription = productdes, productCategory = productCatagory, quantity = quantity, productprice = productprice, shopName = shopname };

            var json = JsonConvert.SerializeObject(updatedProduct);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            try
            {
                var response = await client.PutAsync($"https://localhost:7138/api/product/{productid}/update", data);

                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    MessageBox.Show("Prodcut Updated " + result);
                    loadDataAll();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private async void delete_btn_Click(object sender, EventArgs e)
        {
            int productid = Int32.Parse(productId_Box.Text);

            try
            {
                var responce = await client.DeleteAsync($"https://localhost:7138/api/product/{productid}/delete");
                if (responce.IsSuccessStatusCode)
                {
                    var result = await responce.Content.ReadAsStringAsync();
                    MessageBox.Show(result);
                    loadDataAll();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.ShowDialog();
        }
    }
}
