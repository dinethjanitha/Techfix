namespace Techfix
{
    partial class Home
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
            button1 = new Button();
            button4 = new Button();
            AddProduct_btn = new Button();
            button2 = new Button();
            label1 = new Label();
            panel1 = new Panel();
            button3 = new Button();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(58, 394);
            button1.Name = "button1";
            button1.Size = new Size(169, 62);
            button1.TabIndex = 0;
            button1.Text = "Make Order";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button4
            // 
            button4.Location = new Point(58, 202);
            button4.Name = "button4";
            button4.Size = new Size(169, 62);
            button4.TabIndex = 0;
            button4.Text = "Order History";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // AddProduct_btn
            // 
            AddProduct_btn.BackColor = Color.Transparent;
            AddProduct_btn.Location = new Point(283, 202);
            AddProduct_btn.Name = "AddProduct_btn";
            AddProduct_btn.Size = new Size(169, 62);
            AddProduct_btn.TabIndex = 0;
            AddProduct_btn.Text = "Add Product";
            AddProduct_btn.UseVisualStyleBackColor = false;
            AddProduct_btn.Click += AddProduct_btn_Click;
            // 
            // button2
            // 
            button2.Location = new Point(58, 304);
            button2.Name = "button2";
            button2.Size = new Size(169, 56);
            button2.TabIndex = 1;
            button2.Text = "Qutations Details";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(353, 112);
            label1.Name = "label1";
            label1.Size = new Size(347, 50);
            label1.TabIndex = 2;
            label1.Text = "Tech Fix Home Page";
            label1.Click += label1_Click_1;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.back1;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(AddProduct_btn);
            panel1.Controls.Add(button4);
            panel1.Location = new Point(2, -64);
            panel1.Name = "panel1";
            panel1.Size = new Size(1009, 677);
            panel1.TabIndex = 3;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.BackgroundImage = Properties.Resources.logout;
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Location = new Point(935, 91);
            button3.Name = "button3";
            button3.Size = new Size(45, 43);
            button3.TabIndex = 4;
            button3.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(812, 96);
            label2.Name = "label2";
            label2.Size = new Size(117, 31);
            label2.TabIndex = 3;
            label2.Text = "Username";
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 603);
            Controls.Add(panel1);
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            Load += Home_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button4;
        private Button AddProduct_btn;
        private Button button2;
        private Label label1;
        private Panel panel1;
        private Label label2;
        private Button button3;
    }
}