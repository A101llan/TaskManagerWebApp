using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace TaskManagerWebApp
{
    public partial class UserSignIn : Form
    {
        public UserSignIn()
        {
            InitializeComponent();
        }

        private void UserSignInCancelbtn_Click(object sender, EventArgs e)
        {
            this.Hide(); // Close the current form
            Index IndexForm = new Index();
            IndexForm.Closed += (s, args) => this.Close();
            IndexForm.Show();
        }

        private void UserSignInSubmitbtn_Click(object sender, EventArgs e)
        {
            string mySqlConn = "server=localhost; user=root; database=taskmanagerwebapp; password=";
            string role = "";
            MySqlConnection mySqlConnection = new MySqlConnection(mySqlConn);
            try
            {
                string email = UserSignInEmailtxt.Text;
                string password = UserSignInPasswordtxt.Text;
                mySqlConnection.Open();

                // Hashing password
                string hashedPassword = HashPassword(password);
                //Confirm all fields are field in
                if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("All fields are required");
                    return;
                }

                // Query to check if user with given email and password exists
                string query = "SELECT * FROM users WHERE useremail = @useremail AND userpassword = @userpassword";
                MySqlCommand command = new MySqlCommand(query, mySqlConnection);
                command.Parameters.AddWithValue("@useremail", email);
                command.Parameters.AddWithValue("@userpassword", HashPassword(password));

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        role = reader["userrole"].ToString();
                        MessageBox.Show("Successfully logged in!");
                        // Perform actions after successful login, such as navigating to another form
                    }
                    else
                    {
                        MessageBox.Show("Invalid credentials! Try again");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (role == "admin")
                {
                    this.Hide(); // Close the current form
                    AdminHome AdminHomeForm = new AdminHome();
                    AdminHomeForm.Closed += (s, args) => this.Close();
                    AdminHomeForm.Show();
                }
                else if (role == "user")
                {
                    this.Hide(); // Close the current form
                    Home HomeForm = new Home();
                    HomeForm.Closed += (s, args) => this.Close();
                    HomeForm.Show();
                }
                else
                {
                    MessageBox.Show("Error signing in.");
                }
                mySqlConnection.Close();
            }
        }
        private string HashPassword(string password)
        {
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }
    }
}
