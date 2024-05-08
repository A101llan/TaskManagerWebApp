using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Bcpg.OpenPgp;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace TaskManagerWebApp
{
    public partial class UserSignUp : Form
    {
        public UserSignUp()
        {
            InitializeComponent();
        }

        private void UserSignUpCancelbtn_Click(object sender, EventArgs e)
        {
            this.Hide(); // Close the current form
            Index IndexForm = new Index();
            IndexForm.Closed += (s, args) => this.Close();
            IndexForm.Show();
        }

        private void UserSignUpSubmitbtn_Click(object sender, EventArgs e)
        {
            string mySqlConn = "server=localhost; user=root; database=taskmanagerwebapp; password=";
            MySqlConnection mySqlConnection = new MySqlConnection(mySqlConn);
            try
            {
                string name = UserSignUpNametxt.Text;
                string email = UserSignUpEmailtxt.Text;
                string password = UserSignUpPasswrdtxt.Text;
                string confirmPassword = UserSignUpConPasswordtxt.Text;
                string gender = "";
                if (UserSignUpMalerdb.Checked)
                {
                    gender = "Male";
                }
                else if (UserSignUpFemalerdb.Checked)
                {
                    gender = "Female";
                }
                string role = "user";
                mySqlConnection.Open();

                //Confirm all fields are field in
                if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword) || string.IsNullOrEmpty(gender) || string.IsNullOrEmpty(role))
                {
                    MessageBox.Show("All fields are required");
                    return;
                }

                // Checking if passwords match
                if (password != confirmPassword)
                {
                    MessageBox.Show("Passwords do not match");
                    return;
                }

                // Hashing password
                string hashedPassword = HashPassword(password);

                //Add data to database
                string insertQuery = "INSERT INTO users (username, useremail, userpassword, usergender, userrole) VALUES (@username, @useremail, @userpassword, @usergender, @userrole)";
                MySqlCommand command = new MySqlCommand(insertQuery, mySqlConnection);
                command.Parameters.AddWithValue("@username", name);
                command.Parameters.AddWithValue("@useremail", email);
                command.Parameters.AddWithValue("@userpassword", hashedPassword);
                command.Parameters.AddWithValue("@usergender", gender);
                command.Parameters.AddWithValue("@userrole", role);

                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("User signed up successfully");
                }
                else
                {
                    MessageBox.Show("Failed to sign up user");
                    this.Hide(); // Close the current form
                    Index IndexForm = new Index();
                    IndexForm.Closed += (s, args) => this.Close();
                    IndexForm.Show();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                mySqlConnection.Close();
                this.Hide(); // Close the current form
                Home HomeForm = new Home();
                HomeForm.Closed += (s, args) => this.Close();
                HomeForm.Show();
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

        private void UserSignUpMalerdb_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
