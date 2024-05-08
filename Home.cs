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
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Bcpg.OpenPgp;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TaskManagerWebApp
{
    public partial class Home : Form
    {
        public Home()
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
                string insertQuery = "select * from tasks";
                MySqlCommand command = new MySqlCommand(insertQuery, mySqlConnection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    TasksDataGrid.Rows.Add(TasksDataGrid.Rows.Count + 1, reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString());
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
        private void UserSignOutbtn_Click(object sender, EventArgs e)
        {
            this.Hide(); // Close the current form (Index.cs)
            Index IndexForm = new Index();
            IndexForm.Closed += (s, args) => this.Close();
            IndexForm.Show(); // Show the UserSignInForm
        }

        private void TasksAddbtn_Click(object sender, EventArgs e)
        {
            string mySqlConn = "server=localhost; user=root; database=taskmanagerwebapp; password=";
            MySqlConnection mySqlConnection = new MySqlConnection(mySqlConn);
            try
            {
                string name = TaskNametxt.Text;
                string description = TaskDescriptiontxt.Text;
                string priority = TaskPriorityCom.Text;
                string status = TaskStatusCom.Text;
                string duedate = TaskDueDatePicker.Value.ToString("yyyy-MM-dd");
                string user = "4";

                mySqlConnection.Open();
                
                //Add data to database
                string insertQuery = "INSERT INTO tasks (TaskName, TaskDescription, TaskPriority, TaskStatus, UserID, TaskDueDate) VALUES (@taskname, @taskdescription, @taskpriority, @taskstatus, @userid, @taskduedate)";
                MySqlCommand command = new MySqlCommand(insertQuery, mySqlConnection);
                command.Parameters.AddWithValue("@taskname", name);
                command.Parameters.AddWithValue("@taskdescription", description);
                command.Parameters.AddWithValue("@taskpriority", priority);
                command.Parameters.AddWithValue("@taskstatus", status);
                command.Parameters.AddWithValue("@userid", user);
                command.Parameters.AddWithValue("@taskduedate", duedate);

                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Task added successfully");
                }
                else
                {
                    MessageBox.Show("Failed to add task");
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

        private void TasksUpdatebtn_Click(object sender, EventArgs e)
        {
            string mySqlConn = "server=localhost; user=root; database=taskmanagerwebapp; password=";
            MySqlConnection mySqlConnection = new MySqlConnection(mySqlConn);
            try
            {
                string taskid = TaskIDtxt.Text;
                string name = TaskNametxt.Text;
                string description = TaskDescriptiontxt.Text;
                string priority = TaskPriorityCom.Text;
                string status = TaskStatusCom.Text;
                string duedate = TaskDueDatePicker.Value.ToString("yyyy-MM-dd");
                string user = "4";

                mySqlConnection.Open();

                //Add data to database
                //string insertQuery = "UPDATE tasks SET TaskID=@taskid, UserID=@taskname, TaskName=@taskid, TaskDescription=@TaskDescription, TaskPriority=@TaskPriority, TaskStatus=@tasktatus, TaskDueDate=@taskduedate";
                string insertQuery = "UPDATE tasks SET UserID = @userid, TaskName = @taskname, TaskDescription = @taskdescription, TaskPriority = @taskpriority, TaskStatus = @taskstatus, TaskDueDate = @taskduedate WHERE TaskID = @taskid";
                MySqlCommand command = new MySqlCommand(insertQuery, mySqlConnection);
                command.Parameters.AddWithValue("@taskname", name);
                command.Parameters.AddWithValue("@taskid", taskid);
                command.Parameters.AddWithValue("@userid", user);
                command.Parameters.AddWithValue("@taskdescription", description);
                command.Parameters.AddWithValue("@taskpriority", priority);
                command.Parameters.AddWithValue("@taskstatus", status);
                command.Parameters.AddWithValue("@taskduedate", duedate);

                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Task updated successfully");
                }
                else
                {
                    MessageBox.Show("Failed to update task");
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

        private void TasksDeletebtn_Click(object sender, EventArgs e)
        {
            string mySqlConn = "server=localhost; user=root; database=taskmanagerwebapp; password=";
            MySqlConnection mySqlConnection = new MySqlConnection(mySqlConn);
            try
            {
                string name = TaskNametxt.Text;
                string description = TaskDescriptiontxt.Text;
                string priority = TaskPriorityCom.Text;
                string status = TaskStatusCom.Text;
                string duedate = TaskDueDatePicker.Value.ToString("yyyy-MM-dd");
                string user = "4";
                string id = TaskIDtxt.Text;

                mySqlConnection.Open();
                
                //Add data to database
                string insertQuery = "DELETE FROM `tasks` WHERE TaskID = @taskid";
                MySqlCommand command = new MySqlCommand(insertQuery, mySqlConnection);
                command.Parameters.AddWithValue("@taskid", id);

                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Task deleted successfully");
                }
                else
                {
                    MessageBox.Show("Failed to delete task");
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

        private void TasksDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TaskIDtxt.Text = TasksDataGrid.CurrentRow.Cells[1].Value.ToString();
            TaskNametxt.Text = TasksDataGrid.CurrentRow.Cells[3].Value.ToString();
            TaskDescriptiontxt.Text = TasksDataGrid.CurrentRow.Cells[4].Value.ToString();
            TaskPriorityCom.Text = TasksDataGrid.CurrentRow.Cells[5].Value.ToString();
            TaskStatusCom.Text = TasksDataGrid.CurrentRow.Cells[6].Value.ToString();
            TaskDueDatePicker.Text = TasksDataGrid.CurrentRow.Cells[7].Value.ToString();
        }
    }
}
