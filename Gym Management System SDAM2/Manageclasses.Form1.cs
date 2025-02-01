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
using System.Configuration ;

namespace gym_management_system_1
{
    public partial class Form1 : Form
    {
        private string connectionString = "";

        public Form1 ()
        {
            InitializeComponent();
            LoadClasses();
        }

        private void locationTxt_Click(object sender, EventArgs e)
        {

        }

        private void timeTxt_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void classIDtext_Click(object sender, EventArgs e)
        {

        }

        private void classIDtextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void homeLogout_Click(object sender, EventArgs e)
        {

        }


        // Load classes from the database into the DataGridView
        private void LoadClasses()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Manageclasses", con); 
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt; 
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("An error occurred while loading classes: " + ex.Message);
                }
            }
        }



        // Add a new class
        private void btnAddClass_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Manageclasses (Date, Time, Location, Type) VALUES (@Date, @Time, @Location, @Type)", con);
                    cmd.Parameters.AddWithValue("@Date", dateTxt.Text);
                    cmd.Parameters.AddWithValue("@Time", timeTxt.Text);
                    cmd.Parameters.AddWithValue("@Location", locationTxt.Text);
                    cmd.Parameters.AddWithValue("@Type", typeTxt.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Class Added Successfully");
                    LoadClasses();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("An error occurred while adding the class: " + ex.Message);
                }
            }
        }

        // Update an existing class
        private void btnUpdateClass_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(classIDtext.Text))
            {
                MessageBox.Show("Select a class to update");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Manageclasses SET Date=@Date, Time=@Time, Location=@Location, Type=@Type WHERE ClassID=@ClassID", con);
                    cmd.Parameters.AddWithValue("@ClassID", classIDtext.Text);
                    cmd.Parameters.AddWithValue("@Date", dateTxt.Text);
                    cmd.Parameters.AddWithValue("@Time", timeTxt.Text);
                    cmd.Parameters.AddWithValue("@Location", locationTxt.Text);
                    cmd.Parameters.AddWithValue("@Type", typeTxt.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Class Updated Successfully");
                    LoadClasses();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("An error occurred while updating the class: " + ex.Message);
                }
            }
        }

        // Delete a class
        private void btnDeleteClass_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(classIDtext.Text))
            {
                MessageBox.Show("Select a class to delete");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                   
                    using (SqlCommand cmd = new SqlCommand("DELETE FROM Manageclasses WHERE ClassID=@ClassID", con))
                    { 
                        cmd.Parameters.AddWithValue("@ClassID", classIDtext.Text);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Class Deleted Successfully");
                    LoadClasses();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("An error occurred while deleting the class: " + ex.Message);
                }
            }
        }

        // Load data from DataGridView to text fields when clicked
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                classIDtext.Text = row.Cells["ClassID"].Value.ToString();
                dateTxt.Text = row.Cells["Date"].Value.ToString();
                timeTxt.Text = row.Cells["Time"].Value.ToString();
                locationTxt.Text = row.Cells["Location"].Value.ToString();
                typeTxt.Text = row.Cells["Type"].Value.ToString();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
