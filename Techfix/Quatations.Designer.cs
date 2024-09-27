namespace Techfix
{
    partial class Quatations
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
            shop1q = new RadioButton();
            shoptwor = new RadioButton();
            qutview = new DataGridView();
            qtSearch_Box = new TextBox();
            label3 = new Label();
            radioButton1 = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)qutview).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(56, 25);
            label1.Name = "label1";
            label1.Size = new Size(187, 46);
            label1.TabIndex = 0;
            label1.Text = "Quotations";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F);
            label2.Location = new Point(68, 82);
            label2.Name = "label2";
            label2.Size = new Size(105, 25);
            label2.TabIndex = 1;
            label2.Text = "Select Shop";
            label2.Click += label2_Click;
            // 
            // shop1q
            // 
            shop1q.AutoSize = true;
            shop1q.Font = new Font("Segoe UI", 10.8F);
            shop1q.Location = new Point(153, 123);
            shop1q.Name = "shop1q";
            shop1q.Size = new Size(90, 29);
            shop1q.TabIndex = 2;
            shop1q.TabStop = true;
            shop1q.Text = "Shop 1";
            shop1q.UseVisualStyleBackColor = true;
            shop1q.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // shoptwor
            // 
            shoptwor.AutoSize = true;
            shoptwor.Font = new Font("Segoe UI", 10.8F);
            shoptwor.Location = new Point(273, 123);
            shoptwor.Name = "shoptwor";
            shoptwor.Size = new Size(90, 29);
            shoptwor.TabIndex = 3;
            shoptwor.TabStop = true;
            shoptwor.Text = "Shop 2";
            shoptwor.UseVisualStyleBackColor = true;
            shoptwor.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // qutview
            // 
            qutview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            qutview.Location = new Point(68, 228);
            qutview.Name = "qutview";
            qutview.RowHeadersWidth = 51;
            qutview.Size = new Size(1004, 407);
            qutview.TabIndex = 4;
            // 
            // qtSearch_Box
            // 
            qtSearch_Box.Location = new Point(222, 186);
            qtSearch_Box.Name = "qtSearch_Box";
            qtSearch_Box.Size = new Size(850, 27);
            qtSearch_Box.TabIndex = 5;
            qtSearch_Box.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F);
            label3.Location = new Point(68, 185);
            label3.Name = "label3";
            label3.Size = new Size(148, 25);
            label3.TabIndex = 1;
            label3.Text = "Search Quatation";
            label3.Click += label2_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI", 10.8F);
            radioButton1.Location = new Point(68, 123);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(53, 29);
            radioButton1.TabIndex = 2;
            radioButton1.TabStop = true;
            radioButton1.Text = "All";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // Quatations
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1114, 666);
            Controls.Add(qtSearch_Box);
            Controls.Add(qutview);
            Controls.Add(shoptwor);
            Controls.Add(radioButton1);
            Controls.Add(shop1q);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Quatations";
            Text = "Quatations";
            ((System.ComponentModel.ISupportInitialize)qutview).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private RadioButton shop1q;
        private RadioButton shoptwor;
        private DataGridView qutview;
        private TextBox qtSearch_Box;
        private Label label3;
        private RadioButton radioButton1;
    }
}