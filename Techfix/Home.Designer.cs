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
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(140, 141);
            button1.Name = "button1";
            button1.Size = new Size(169, 62);
            button1.TabIndex = 0;
            button1.Text = "Quotation Request";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button4
            // 
            button4.Location = new Point(601, 141);
            button4.Name = "button4";
            button4.Size = new Size(169, 62);
            button4.TabIndex = 0;
            button4.Text = "Order History";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // AddProduct_btn
            // 
            AddProduct_btn.Location = new Point(362, 141);
            AddProduct_btn.Name = "AddProduct_btn";
            AddProduct_btn.Size = new Size(169, 62);
            AddProduct_btn.TabIndex = 0;
            AddProduct_btn.Text = "Add Product";
            AddProduct_btn.UseVisualStyleBackColor = true;
            AddProduct_btn.Click += AddProduct_btn_Click;
            // 
            // button2
            // 
            button2.Location = new Point(140, 234);
            button2.Name = "button2";
            button2.Size = new Size(169, 56);
            button2.TabIndex = 1;
            button2.Text = "Qutations";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1036, 597);
            Controls.Add(button2);
            Controls.Add(button4);
            Controls.Add(AddProduct_btn);
            Controls.Add(button1);
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button4;
        private Button AddProduct_btn;
        private Button button2;
    }
}