﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Techfix.Operations;

namespace Techfix
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
          
        }

        private void AddProduct_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddProduct addProduct = new AddProduct();
            addProduct.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderItems or = new OrderItems();
            or.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageOrders manageOrders = new ManageOrders();
            manageOrders.ShowDialog();
        }
    }
}