namespace Techfix
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            login_btn = new Button();
            password_Box = new TextBox();
            email_Box = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(login_btn);
            panel1.Controls.Add(password_Box);
            panel1.Controls.Add(email_Box);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Font = new Font("Segoe UI", 16.2F);
            panel1.Location = new Point(1, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(838, 560);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // login_btn
            // 
            login_btn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_btn.Location = new Point(492, 361);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(136, 51);
            login_btn.TabIndex = 3;
            login_btn.Text = "Login";
            login_btn.UseVisualStyleBackColor = true;
            login_btn.Click += button1_Click;
            // 
            // password_Box
            // 
            password_Box.Font = new Font("Segoe UI", 16.2F);
            password_Box.Location = new Point(367, 281);
            password_Box.Name = "password_Box";
            password_Box.Size = new Size(261, 43);
            password_Box.TabIndex = 2;
       
            // 
            // email_Box
            // 
            email_Box.Font = new Font("Segoe UI", 16.2F);
            email_Box.Location = new Point(367, 209);
            email_Box.Name = "email_Box";
            email_Box.Size = new Size(261, 43);
            email_Box.TabIndex = 2;
            email_Box.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F);
            label3.Location = new Point(187, 286);
            label3.Name = "label3";
            label3.Size = new Size(132, 38);
            label3.TabIndex = 1;
            label3.Text = "Password";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F);
            label2.Location = new Point(187, 214);
            label2.Name = "label2";
            label2.Size = new Size(83, 38);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(367, 110);
            label1.Name = "label1";
            label1.Size = new Size(122, 54);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(839, 562);
            Controls.Add(panel1);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox password_Box;
        private TextBox email_Box;
        private Button login_btn;
    }
}
