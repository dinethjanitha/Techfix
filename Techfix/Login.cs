using Newtonsoft.Json;
using System.Text;
using System.Text.Json.Serialization;
using Techfix.Models;
using Techfix.Operations;

namespace Techfix
{
    public partial class Login : Form
    {
        UserOp uop = new UserOp();

        private readonly HttpClient client = new HttpClient();
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

       
        private async void button1_Click(object sender, EventArgs e)
        {
            //uop.email = email_Box.Text;
            //uop.password = password_Box.Text;
            //
            //RegisterForm registerForm = new RegisterForm();
            //
            //bool login = uop.Login();
            //if (login) {
            //    MessageBox.Show("Login Success!!!");
            //    this.Hide();
            //    registerForm.ShowDialog();
            //
            //}
            //else
            //{
            //    MessageBox.Show("Login Fail!!!");
            //}

            var email = email_Box.Text;
            var password = password_Box.Text;   

            var user = new { Email = email, Password = password };

            var json = JsonConvert.SerializeObject(user);
            var data = new StringContent(json, Encoding.UTF8 , "application/json");

           

            try
            {
                var responce = await client.PostAsync("https://localhost:7138/api/login", data);

                if (responce.IsSuccessStatusCode) { 
                    var result = await responce.Content.ReadAsStringAsync();

                    var loginresponse = JsonConvert.DeserializeObject<User>(result);

                    SaveUser.userid = Convert.ToInt32(loginresponse.user_id);
                    SaveUser.shopname = loginresponse.user_name.ToString();

                    MessageBox.Show("Login Sucessfull " + loginresponse.user_name);
                    Home home = new Home();
                    
                    this.Hide();
                    home.ShowDialog();


                }
                else
                {
                    MessageBox.Show("Login Faild " + responce.ReasonPhrase);
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
