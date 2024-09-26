namespace Techfix
{
    partial class OrderItems
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            producttable = new DataGridView();
            label2 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label3 = new Label();
            itemid_box = new TextBox();
            label4 = new Label();
            itemname_box = new TextBox();
            label5 = new Label();
            itemquantity_box = new TextBox();
            dateTimePicker = new DateTimePicker();
            label6 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            button1 = new Button();
            label7 = new Label();
            search_box = new TextBox();
            label8 = new Label();
            totalprice_box = new Label();
            label9 = new Label();
            itemprice_box = new TextBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)producttable).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 48);
            label1.Name = "label1";
            label1.Size = new Size(165, 38);
            label1.TabIndex = 0;
            label1.Text = "Make Order";
            // 
            // producttable
            // 
            producttable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            producttable.Location = new Point(399, 170);
            producttable.Name = "producttable";
            producttable.RowHeadersWidth = 51;
            producttable.Size = new Size(736, 467);
            producttable.TabIndex = 1;
            producttable.CellContentClick += dataGridView1_CellContentClick;
            producttable.RowHeaderMouseClick += producttable_RowHeaderMouseClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(399, 89);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 2;
            label2.Text = "Select Shop";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(513, 91);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(76, 24);
            radioButton1.TabIndex = 3;
            radioButton1.TabStop = true;
            radioButton1.Text = "Shop 1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(606, 91);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(76, 24);
            radioButton2.TabIndex = 4;
            radioButton2.TabStop = true;
            radioButton2.Text = "Shop 2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 177);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 2;
            label3.Text = "Item ID";
            // 
            // itemid_box
            // 
            itemid_box.Location = new Point(141, 170);
            itemid_box.Name = "itemid_box";
            itemid_box.ReadOnly = true;
            itemid_box.Size = new Size(125, 27);
            itemid_box.TabIndex = 5;
            itemid_box.TextChanged += textBox1_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 222);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 2;
            label4.Text = "Item Name";
            // 
            // itemname_box
            // 
            itemname_box.Location = new Point(141, 215);
            itemname_box.Name = "itemname_box";
            itemname_box.ReadOnly = true;
            itemname_box.Size = new Size(125, 27);
            itemname_box.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 309);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 2;
            label5.Text = "Quantity";
            // 
            // itemquantity_box
            // 
            itemquantity_box.Location = new Point(141, 302);
            itemquantity_box.Name = "itemquantity_box";
            itemquantity_box.Size = new Size(125, 27);
            itemquantity_box.TabIndex = 5;
            itemquantity_box.TextChanged += itemquantity_box_TextChanged;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(141, 351);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(243, 27);
            dateTimePicker.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(29, 358);
            label6.Name = "label6";
            label6.Size = new Size(83, 20);
            label6.TabIndex = 2;
            label6.Text = "Order Date";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(141, 452);
            button1.Name = "button1";
            button1.Size = new Size(125, 39);
            button1.TabIndex = 8;
            button1.Text = "Place Order";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(399, 125);
            label7.Name = "label7";
            label7.Size = new Size(70, 28);
            label7.TabIndex = 2;
            label7.Text = "Search";
            // 
            // search_box
            // 
            search_box.Location = new Point(482, 121);
            search_box.Name = "search_box";
            search_box.Size = new Size(653, 27);
            search_box.TabIndex = 5;
            search_box.TextChanged += textBox4_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(30, 406);
            label8.Name = "label8";
            label8.Size = new Size(42, 20);
            label8.TabIndex = 2;
            label8.Text = "Total";
            // 
            // totalprice_box
            // 
            totalprice_box.AutoSize = true;
            totalprice_box.Location = new Point(141, 406);
            totalprice_box.Name = "totalprice_box";
            totalprice_box.Size = new Size(36, 20);
            totalprice_box.TabIndex = 2;
            totalprice_box.Text = "0.00";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(29, 266);
            label9.Name = "label9";
            label9.Size = new Size(75, 20);
            label9.TabIndex = 2;
            label9.Text = "Item Price";
            // 
            // itemprice_box
            // 
            itemprice_box.Location = new Point(141, 259);
            itemprice_box.Name = "itemprice_box";
            itemprice_box.ReadOnly = true;
            itemprice_box.Size = new Size(125, 27);
            itemprice_box.TabIndex = 5;
            itemprice_box.Text = "0";
            // 
            // button2
            // 
            button2.Location = new Point(149, 529);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 9;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // OrderItems
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1147, 649);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dateTimePicker);
            Controls.Add(itemquantity_box);
            Controls.Add(itemprice_box);
            Controls.Add(itemname_box);
            Controls.Add(search_box);
            Controls.Add(itemid_box);
            Controls.Add(totalprice_box);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label9);
            Controls.Add(radioButton2);
            Controls.Add(label4);
            Controls.Add(radioButton1);
            Controls.Add(label3);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(producttable);
            Controls.Add(label1);
            Name = "OrderItems";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OrderItems";
            Load += OrderItems_Load;
            ((System.ComponentModel.ISupportInitialize)producttable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView producttable;
        private Label label2;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label3;
        private TextBox itemid_box;
        private Label label4;
        private TextBox itemname_box;
        private Label label5;
        private TextBox itemquantity_box;
        private DateTimePicker dateTimePicker;
        private Label label6;
        private ContextMenuStrip contextMenuStrip1;
        private Button button1;
        private Label label7;
        private TextBox search_box;
        private Label label8;
        private Label totalprice_box;
        private Label label9;
        private TextBox itemprice_box;
        private Button button2;
    }
}