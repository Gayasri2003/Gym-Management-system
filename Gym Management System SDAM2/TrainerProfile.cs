using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Gym_Management_System_SDAM2
{
    public partial class TrainerProfile : Form
    {
        string connectionString = "Server=(local)\\SQLEXPRESS;Database=GymDatabase;Integrated Security=True;";
        private string username; 
        public TrainerProfile(string username)
        {
            InitializeComponent();
            this.username = username; 
            LoadTrainerProfile();
        }
        private void LoadTrainerProfile()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT FirstName, LastName, ContactNumber, Gender, City " +
                                   "FROM Users WHERE Username = @Username";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Display the data in labels (ensure you have labels like lblFirstName, lblLastName, etc.)
                                fName.Text = "First Name: " + reader["FirstName"].ToString();
                                lName.Text = "Last Name: " + reader["LastName"].ToString();
                                cOntact.Text = "Contact Number: " + reader["ContactNumber"].ToString();
                                gEnder.Text = "Gender: " + reader["Gender"].ToString();
                                cIty.Text = "City: " + reader["City"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading profile: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void homeLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            

        }

        private void homeLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void classLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Open the Classes form
            TrainerClasses classesForm = new TrainerClasses();
            classesForm.Show();

            // Close or hide the current form
            this.Hide();
        }

        private void attendLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Open the Attendance form
            TrainerAttendence attendanceForm = new TrainerAttendence();
            attendanceForm.Show();

            // Close or hide the current form
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
