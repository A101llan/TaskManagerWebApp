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
    public partial class AdminSignUp : Form
    {
        public AdminSignUp()
        {
            InitializeComponent();
        }

        private void AdminSignUpCancelbtn_Click(object sender, EventArgs e)
        {
            this.Hide(); // Close the current form
            AdminHome AdminHomeForm = new AdminHome();
            AdminHomeForm.Closed += (s, args) => this.Close();
            AdminHomeForm.Show();
        }

        private void AdminSignUpSubmitbtn_Click(object sender, EventArgs e)
        {
            string mySqlConn = "server=localhost; user=root; database=taskmanagerwebapp; password=";
            MySqlConnection mySqlConnection = new MySqlConnection(mySqlConn);
            try
            {
                string name = AdminSignUpNametxt.Text;
                string email = AdminSignUpEmailtxt.Text;
                string password = AdminSignUpPasswrdtxt.Text;
                string confirmPassword = AdminSignUpConPasswordtxt.Text;
                string gender="";
                if (AdminSignUpMalerdb.Checked)
                {
                   gender = "Male";
                }
                else if (AdminSignUpFemalerdb.Checked)
                {
                   gender = "Female";
                }
                string role = "admin";
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
                 string insertQuery = "INSERT INTO users (username, useremail, userpassword, usergender, userrole) VALUES (@Adminname, @Adminemail, @Adminpassword, @Admingender, @Adminrole)";
                MySqlCommand command = new MySqlCommand(insertQuery, mySqlConnection);
                command.Parameters.AddWithValue("@Adminname", name);
                command.Parameters.AddWithValue("@Adminemail", email);
                command.Parameters.AddWithValue("@Adminpassword", hashedPassword);
                command.Parameters.AddWithValue("@Admingender", gender);
                command.Parameters.AddWithValue("@Adminrole", role);

                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Admin signed up successfully");                    
                }
                else
                {
                    MessageBox.Show("Failed to sign up admin");
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
                AdminHome AdminHomeForm = new AdminHome();
                AdminHomeForm.Closed += (s, args) => this.Close();
                AdminHomeForm.Show();
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
