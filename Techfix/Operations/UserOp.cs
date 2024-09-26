using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Techfix.Operations
{
    public class UserOp
    {
        public int UserId { get; set; }
        public string email { get; set; }
        public string password { get; set;}

        string connString = "Data Source=localhost; Initial catalog=techfixDB;Integrated Security=True";

        public bool Login()
        { 
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(connString);

            try
            {
                string sql = "SELECT * FROM users WHERE email = @Email AND password = @Password";

                SqlCommand cmd = new SqlCommand(sql,conn);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Password" , password);

                conn.Open();

                int row = Convert.ToInt32(cmd.ExecuteScalar());

                if (row > 0) { 
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }


            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }


            return isSuccess;

        }
    }
}
