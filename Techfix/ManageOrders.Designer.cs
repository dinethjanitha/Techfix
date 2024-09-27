namespace Techfix
{
    partial class ManageOrders
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
            ordertable = new DataGridView();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            m_orderid_box = new TextBox();
            m_ordername_box = new TextBox();
            label4 = new Label();
            m_itemid_box = new TextBox();
            label5 = new Label();
            m_quantityi_box = new TextBox();
            label6 = new Label();
            m_dateTimePicker1 = new DateTimePicker();
            label7 = new Label();
            m_total_box = new TextBox();
            updateOrder_btn = new Button();
            deleteOrder_btn = new Button();
            clear_btn = new Button();
            label8 = new Label();
            m_itemprice_box = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)ordertable).BeginInit();
            SuspendLayout();
            // 
            // ordertable
            // 
            ordertable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ordertable.Location = new Point(330, 132);
            ordertable.Name = "ordertable";
            ordertable.RowHeadersWidth = 51;
            ordertable.Size = new Size(895, 522);
            ordertable.TabIndex = 0;
            ordertable.CellContentClick += dataGridView1_CellContentClick;
            ordertable.RowHeaderMouseClick += ordertable_RowHeaderMouseClick;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(431, 86);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(807, 27);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(343, 89);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 139);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 2;
            label2.Text = "Order Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 89);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 2;
            label3.Text = "Order ID";
            // 
            // m_orderid_box
            // 
            m_orderid_box.Location = new Point(139, 89);
            m_orderid_box.Name = "m_orderid_box";
            m_orderid_box.ReadOnly = true;
            m_orderid_box.Size = new Size(125, 27);
            m_orderid_box.TabIndex = 3;
            // 
            // m_ordername_box
            // 
            m_ordername_box.Location = new Point(139, 132);
            m_ordername_box.Name = "m_ordername_box";
            m_ordername_box.ReadOnly = true;
            m_ordername_box.Size = new Size(125, 27);
            m_ordername_box.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 187);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 2;
            label4.Text = "Item ID";
            // 
            // m_itemid_box
            // 
            m_itemid_box.Location = new Point(139, 180);
            m_itemid_box.Name = "m_itemid_box";
            m_itemid_box.ReadOnly = true;
            m_itemid_box.Size = new Size(125, 27);
            m_itemid_box.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 239);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 2;
            label5.Text = "Quantity";
            // 
            // m_quantityi_box
            // 
            m_quantityi_box.Location = new Point(139, 232);
            m_quantityi_box.Name = "m_quantityi_box";
            m_quantityi_box.Size = new Size(125, 27);
            m_quantityi_box.TabIndex = 3;
            m_quantityi_box.Text = "0";
            m_quantityi_box.TextChanged += m_quantityi_box_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 285);
            label6.Name = "label6";
            label6.Size = new Size(83, 20);
            label6.TabIndex = 2;
            label6.Text = "Order Date";
            // 
            // m_dateTimePicker1
            // 
            m_dateTimePicker1.Location = new Point(139, 280);
            m_dateTimePicker1.Name = "m_dateTimePicker1";
            m_dateTimePicker1.Size = new Size(170, 27);
            m_dateTimePicker1.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 330);
            label7.Name = "label7";
            label7.Size = new Size(42, 20);
            label7.TabIndex = 2;
            label7.Text = "Total";
            // 
            // m_total_box
            // 
            m_total_box.Location = new Point(139, 323);
            m_total_box.Name = "m_total_box";
            m_total_box.Size = new Size(125, 27);
            m_total_box.TabIndex = 3;
            m_total_box.Text = "0";
            // 
            // updateOrder_btn
            // 
            updateOrder_btn.Location = new Point(43, 397);
            updateOrder_btn.Name = "updateOrder_btn";
            updateOrder_btn.Size = new Size(94, 29);
            updateOrder_btn.TabIndex = 5;
            updateOrder_btn.Text = "Update";
            updateOrder_btn.UseVisualStyleBackColor = true;
            updateOrder_btn.Click += updateOrder_btn_Click;
            // 
            // deleteOrder_btn
            // 
            deleteOrder_btn.Location = new Point(170, 397);
            deleteOrder_btn.Name = "deleteOrder_btn";
            deleteOrder_btn.Size = new Size(94, 29);
            deleteOrder_btn.TabIndex = 5;
            deleteOrder_btn.Text = "Delete";
            deleteOrder_btn.UseVisualStyleBackColor = true;
            deleteOrder_btn.Click += deleteOrder_btn_Click;
            // 
            // clear_btn
            // 
            clear_btn.Location = new Point(43, 458);
            clear_btn.Name = "clear_btn";
            clear_btn.Size = new Size(94, 29);
            clear_btn.TabIndex = 5;
            clear_btn.Text = "Clear";
            clear_btn.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(12, 29);
            label8.Name = "label8";
            label8.Size = new Size(173, 31);
            label8.TabIndex = 2;
            label8.Text = "Manage Orders";
            // 
            // m_itemprice_box
            // 
            m_itemprice_box.Location = new Point(43, 605);
            m_itemprice_box.Name = "m_itemprice_box";
            m_itemprice_box.Size = new Size(125, 27);
            m_itemprice_box.TabIndex = 3;
            m_itemprice_box.Text = "0";
            m_itemprice_box.Visible = false;
            m_itemprice_box.TextChanged += m_quantityi_box_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(170, 458);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ManageOrders
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1250, 666);
            Controls.Add(button1);
            Controls.Add(clear_btn);
            Controls.Add(deleteOrder_btn);
            Controls.Add(updateOrder_btn);
            Controls.Add(m_dateTimePicker1);
            Controls.Add(m_total_box);
            Controls.Add(m_itemprice_box);
            Controls.Add(m_quantityi_box);
            Controls.Add(m_itemid_box);
            Controls.Add(m_ordername_box);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(m_orderid_box);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label8);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(ordertable);
            Name = "ManageOrders";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageOrders";
            ((System.ComponentModel.ISupportInitialize)ordertable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView ordertable;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox m_orderid_box;
        private TextBox m_ordername_box;
        private Label label4;
        private TextBox m_itemid_box;
        private Label label5;
        private TextBox m_quantityi_box;
        private Label label6;
        private DateTimePicker m_dateTimePicker1;
        private Label label7;
        private TextBox m_total_box;
        private Button updateOrder_btn;
        private Button deleteOrder_btn;
        private Button clear_btn;
        private Label label8;
        private TextBox m_itemprice_box;
        private Button button1;
    }
}