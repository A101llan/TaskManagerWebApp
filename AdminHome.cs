using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TaskManagerWebApp
{
    public partial class AdminHome : Form
    {
        public AdminHome()
        {
            InitializeComponent();
            LoadRecords();
        }

        public void LoadRecords()
        {
            string mySqlConn = "server=localhost; user=root; database=taskmanagerwebapp; password=";
            MySqlConnection mySqlConnection = new MySqlConnection(mySqlConn);
            try
            {
                mySqlConnection.Open();
                string insertQuery = "select * from users";
                MySqlCommand command = new MySqlCommand(insertQuery, mySqlConnection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    UsersDataGrid.Rows.Add(UsersDataGrid.Rows.Count + 1, reader["userid"].ToString(), reader["username"].ToString(), reader["useremail"].ToString(), reader["usergender"].ToString(), reader["userrole"].ToString());
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                mySqlConnection.Close();
            }
        }

        private void AdminSignUpbtn_Click(object sender, EventArgs e)
        {
            this.Hide(); // Close the current form (Index.cs)
            AdminSignUp AdminSignUpForm = new AdminSignUp();
            AdminSignUpForm.Closed += (s, args) => this.Close();
            AdminSignUpForm.Show(); // Show the UserSignInForm
        }

        private void AdminSignOutbtn_Click(object sender, EventArgs e)
        {
            this.Hide(); // Close the current form (Index.cs)
            Index IndexForm = new Index();
            IndexForm.Closed += (s, args) => this.Close();
            IndexForm.Show(); // Show the UserSignInForm
        }

        private void UserDeleteDVGbtn_Click(object sender, EventArgs e)
        {

            string mySqlConn = "server=localhost; user=root; database=taskmanagerwebapp; password=";
            MySqlConnection mySqlConnection = new MySqlConnection(mySqlConn);
            try
            {

                string id = UserIDDVGtxt.Text;

                mySqlConnection.Open();

                //Add data to database
                string insertQuery = "DELETE FROM `users` WHERE userid = @userid";
                MySqlCommand command = new MySqlCommand(insertQuery, mySqlConnection);
                command.Parameters.AddWithValue("@userid", id);

                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("User deleted successfully");
                }
                else
                {
                    MessageBox.Show("Failed to delete user");
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

        private void UsersDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            UserIDDVGtxt.Text = UsersDataGrid.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
