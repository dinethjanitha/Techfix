namespace Techfix
{
    partial class AddProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            productName_Box = new TextBox();
            Catagory_Box = new ComboBox();
            ProductPrice_Box = new TextBox();
            ProductDes_Box = new TextBox();
            button1 = new Button();
            label6 = new Label();
            quntity_Box = new TextBox();
            loadproductData = new DataGridView();
            dataLoad = new Button();
            label8 = new Label();
            productId_Box = new TextBox();
            update_btn = new Button();
            delete_btn = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)loadproductData).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(101, 23);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(185, 41);
            label1.TabIndex = 0;
            label1.Text = "Add Product";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(101, 130);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(138, 28);
            label2.TabIndex = 1;
            label2.Text = "Product Name";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(101, 181);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(166, 28);
            label3.TabIndex = 1;
            label3.Text = "Product Catagory";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(101, 235);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(128, 28);
            label4.TabIndex = 1;
            label4.Text = "Product Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(101, 336);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(112, 28);
            label5.TabIndex = 1;
            label5.Text = "Description";
            // 
            // productName_Box
            // 
            productName_Box.Font = new Font("Segoe UI", 12F);
            productName_Box.Location = new Point(294, 124);
            productName_Box.Margin = new Padding(4);
            productName_Box.Name = "productName_Box";
            productName_Box.Size = new Size(206, 34);
            productName_Box.TabIndex = 2;
            productName_Box.TextChanged += productName_Box_TextChanged;
            // 
            // Catagory_Box
            // 
            Catagory_Box.Font = new Font("Segoe UI", 12F);
            Catagory_Box.FormattingEnabled = true;
            Catagory_Box.Items.AddRange(new object[] { "RAM", "Hard", "SSD" });
            Catagory_Box.Location = new Point(294, 173);
            Catagory_Box.Margin = new Padding(4);
            Catagory_Box.Name = "Catagory_Box";
            Catagory_Box.Size = new Size(206, 36);
            Catagory_Box.TabIndex = 3;
            // 
            // ProductPrice_Box
            // 
            ProductPrice_Box.Font = new Font("Segoe UI", 12F);
            ProductPrice_Box.Location = new Point(294, 229);
            ProductPrice_Box.Margin = new Padding(4);
            ProductPrice_Box.Name = "ProductPrice_Box";
            ProductPrice_Box.Size = new Size(206, 34);
            ProductPrice_Box.TabIndex = 2;
            ProductPrice_Box.TextChanged += productName_Box_TextChanged;
            // 
            // ProductDes_Box
            // 
            ProductDes_Box.Font = new Font("Segoe UI", 12F);
            ProductDes_Box.Location = new Point(294, 330);
            ProductDes_Box.Margin = new Padding(4);
            ProductDes_Box.Name = "ProductDes_Box";
            ProductDes_Box.Size = new Size(206, 34);
            ProductDes_Box.TabIndex = 2;
            ProductDes_Box.TextChanged += productName_Box_TextChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(294, 383);
            button1.Name = "button1";
            button1.Size = new Size(118, 42);
            button1.TabIndex = 4;
            button1.Text = "Add Prodcut";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(101, 285);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(78, 28);
            label6.TabIndex = 1;
            label6.Text = "Quntity";
            // 
            // quntity_Box
            // 
            quntity_Box.Font = new Font("Segoe UI", 12F);
            quntity_Box.Location = new Point(294, 279);
            quntity_Box.Margin = new Padding(4);
            quntity_Box.Name = "quntity_Box";
            quntity_Box.Size = new Size(206, 34);
            quntity_Box.TabIndex = 2;
            quntity_Box.TextChanged += productName_Box_TextChanged;
            // 
            // loadproductData
            // 
            loadproductData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            loadproductData.Location = new Point(530, 101);
            loadproductData.Name = "loadproductData";
            loadproductData.RowHeadersWidth = 51;
            loadproductData.Size = new Size(851, 431);
            loadproductData.TabIndex = 5;
            loadproductData.CellContentClick += loadproductData_CellContentClick;
            loadproductData.RowHeaderMouseClick += loadproductData_RowHeaderMouseClick;
            // 
            // dataLoad
            // 
            dataLoad.Location = new Point(294, 500);
            dataLoad.Name = "dataLoad";
            dataLoad.Size = new Size(118, 41);
            dataLoad.TabIndex = 6;
            dataLoad.Text = "Load";
            dataLoad.UseVisualStyleBackColor = true;
            dataLoad.Click += dataLoad_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(101, 85);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(103, 28);
            label8.TabIndex = 1;
            label8.Text = "Product Id";
            label8.Click += label2_Click;
            // 
            // productId_Box
            // 
            productId_Box.Cursor = Cursors.No;
            productId_Box.Font = new Font("Segoe UI", 12F);
            productId_Box.Location = new Point(294, 79);
            productId_Box.Margin = new Padding(4);
            productId_Box.Name = "productId_Box";
            productId_Box.ReadOnly = true;
            productId_Box.Size = new Size(206, 34);
            productId_Box.TabIndex = 2;
            productId_Box.TextChanged += productName_Box_TextChanged;
            // 
            // update_btn
            // 
            update_btn.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            update_btn.Location = new Point(294, 440);
            update_btn.Name = "update_btn";
            update_btn.Size = new Size(118, 44);
            update_btn.TabIndex = 7;
            update_btn.Text = "Update";
            update_btn.UseVisualStyleBackColor = true;
            update_btn.Click += update_btn_Click;
            // 
            // delete_btn
            // 
            delete_btn.Location = new Point(294, 562);
            delete_btn.Name = "delete_btn";
            delete_btn.Size = new Size(118, 46);
            delete_btn.TabIndex = 8;
            delete_btn.Text = "Delete";
            delete_btn.UseVisualStyleBackColor = true;
            delete_btn.Click += delete_btn_Click;
            // 
            // button2
            // 
            button2.Location = new Point(68, 579);
            button2.Name = "button2";
            button2.Size = new Size(94, 42);
            button2.TabIndex = 9;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // AddProduct
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1412, 858);
            Controls.Add(button2);
            Controls.Add(delete_btn);
            Controls.Add(update_btn);
            Controls.Add(dataLoad);
            Controls.Add(loadproductData);
            Controls.Add(button1);
            Controls.Add(Catagory_Box);
            Controls.Add(ProductDes_Box);
            Controls.Add(quntity_Box);
            Controls.Add(ProductPrice_Box);
            Controls.Add(productId_Box);
            Controls.Add(productName_Box);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label8);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "AddProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddProduct";
            ((System.ComponentModel.ISupportInitialize)loadproductData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox productName_Box;
        private ComboBox Catagory_Box;
        private TextBox ProductPrice_Box;
        private TextBox ProductDes_Box;
        private Button button1;
        private Label label6;
        private TextBox quntity_Box;
        private DataGridView loadproductData;
        private Button dataLoad;
        private Label label8;
        private TextBox productId_Box;
        private Button update_btn;
        private Button delete_btn;
        private Button button2;
    }
}