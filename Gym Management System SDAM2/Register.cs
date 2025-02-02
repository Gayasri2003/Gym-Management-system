using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Gym_Management_System_SDAM2
{
    public partial class Register : Form
    {
        private string connectionString = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=GymDatabase;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        public Register()
        {
            InitializeComponent();
        }

        private void PersonalLabel_Click(object sender, EventArgs e)
        {

        }

        private void contactLbl_Click(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void closeLable_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void contactTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits (0-9) 
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true; 
            }
        }
        private void regBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Get values 
                string firstName = FnameTxt.Text;
                string lastName = LnameTxt.Text;
                DateTime dateOfBirth = dateTimePicker1.Value;
                string contactNumber = contactTxt.Text;
                string city = cityTxt.Text;
                string email = EmailTxt.Text;
                string username = UserNtxt.Text;
                string password = PassWtxt.Text;
                string gender = string.Empty;
                if (genBtn1.Checked)
                {
                    gender = "Male";
                }
                else if (genBtn2.Checked)
                {
                    gender = "Female";
                }
                else
                {
                    MessageBox.Show("Please select a gender.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string role = string.Empty;
                if (roleBtn1.Checked)
                {
                    role = "Trainer";
                }
                else if (roleBtn2.Checked)
                {
                    role = "Member";
                }
                else
                {
                    MessageBox.Show("Please select a role.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; 
                }



                // Validate input
                if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(contactNumber) ||
                    string.IsNullOrEmpty(email) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }




                // add to database

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO Users (FirstName, LastName, DateOfBirth, ContactNumber, City, Email, Username, Password, Gender, Role) " +
                                     " VALUES (@FirstName, @LastName, @DateOfBirth, @ContactNumber, @City, @Email, @Username, @Password, @Gender, @Role);" +
                                      "SELECT SCOPE_IDENTITY(); ";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@FirstName", firstName);
                        command.Parameters.AddWithValue("@LastName", lastName);
                        command.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
                        command.Parameters.AddWithValue("@ContactNumber", contactNumber);
                        command.Parameters.AddWithValue("@City", city);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);
                        command.Parameters.AddWithValue("@Gender", gender);
                        command.Parameters.AddWithValue("@Role", role);

                        int userId = Convert.ToInt32(command.ExecuteScalar());




                        // if user is a member
                        if (role == "Member" && userId > 0)
                        {
                            string memberQuery = "INSERT INTO Members (UserID, MembershipStartDate, MembershipType) " +
                                                 "VALUES (@UserID, @StartDate, @Type)";

                            using (SqlCommand memberCommand = new SqlCommand(memberQuery, connection))
                            {
                                memberCommand.Parameters.AddWithValue("@UserID", userId);
                                memberCommand.Parameters.AddWithValue("@StartDate", DateTime.Now);
                                memberCommand.Parameters.AddWithValue("@Type", "Standard");

                                memberCommand.ExecuteNonQuery();
                            }
                        }
                    }
                }
                // Navigate based on role
                if (role == "Member")
                {
                    MessageBox.Show("Registration Successful! Please log in.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    LoginForm loginForm = new LoginForm();
                    loginForm.ShowDialog();
                    this.Close();
                }
                else if (role == "Trainer")
                {
                    MessageBox.Show("Registration Successful! Waiting for admin approval.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    WaitingForm waitingForm = new WaitingForm();
                    waitingForm.ShowDialog();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}


