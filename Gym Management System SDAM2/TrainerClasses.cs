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
    public partial class TrainerClasses : Form
    {
        string connectionString = "Server=RAVINDUS-HP-VIC\\SQLEXPRESS;Database=TrainerClass;Integrated Security=True;";
        public TrainerClasses()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))

                {
                    conn.Open();
                    string query = "SELECT * FROM TrainerClass";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;

                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void  AddToGrid()
        {
            string ClassID = classIDtextbox.Text;
            string ClassDate = dateTextbox.Text;
            string ClassTime = timeTextbox.Text;
            string ClassLocation = locationTextbox.Text;
            string ClassType = typeTextbox.Text;

            DataRow newRow = ((DataTable)dataGridView1.DataSource).NewRow();
            newRow["ClassID"] = ClassID;
            newRow["ClassDate"] = ClassDate;
            newRow["ClassTime"] = ClassTime;
            newRow["ClassLocation"] = ClassLocation;
            newRow["ClassType"] = ClassType;

            ((DataTable)dataGridView1.DataSource).Rows.Add(newRow);

            MessageBox.Show("Successfully added new class!");

            ClearTextBoxes();


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void homeLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Open the Home form
            TrainerProfile homeForm = new TrainerProfile();
            homeForm.Show();

            // Close or hide the current form
            this.Hide();
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

        private void closelabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // This method inserts data into the database
        private void InsertDataIntoDatabase(string ClassID, string ClassDate, string ClassTime, string ClassLocation, string ClassType)
        {
            string query = "INSERT INTO YourTable (ClassID, ClassDate, ClassTime, ClassLocation, ClassType) VALUES (@ClassID, @ClassDate, @ClassTime, @ClassLocation, @ClassType)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ClassID", ClassID);
                    command.Parameters.AddWithValue("@ClassDate", ClassDate);
                    command.Parameters.AddWithValue("@ClassTime", ClassTime);
                    command.Parameters.AddWithValue("@ClassLocation", ClassLocation);
                    command.Parameters.AddWithValue("@ClassType", ClassType);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void ClearTextBoxes()
        {
            classIDtextbox.Clear();
            dateTextbox.Clear();
            timeTextbox.Clear();
            locationTextbox.Clear();
            typeTextbox.Clear();
        }

        private void addclassBtn_Click(object sender, EventArgs e)
        {
            AddToGrid();
        }

        private void classdeleteBtn_Click(object sender, EventArgs e)
        {
            string classIDToDelete = classIDtextbox.Text;

            if (string.IsNullOrEmpty(classIDToDelete))
            {
                MessageBox.Show("Please enter a ClassID to delete.");
                return;
            }
            DataTable dataTable = (DataTable)dataGridView1.DataSource;
            DataRow rowToDelete = dataTable.AsEnumerable()
                                           .FirstOrDefault(row => row.Field<string>("ClassID") == classIDToDelete);

            if (rowToDelete != null)
            {
                // Remove the row from DataTable
                dataTable.Rows.Remove(rowToDelete);

                

                MessageBox.Show("Class successfully deleted!");
            }
            else
            {
                MessageBox.Show("ClassID not found in the grid.");
            }
        }
    }
}
