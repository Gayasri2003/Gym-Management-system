﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_Management_System_SDAM2
{
    public partial class LoginForm : Form
    {
        private string connectionString = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=GymDatabase;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";
        public LoginForm()
        {
            InitializeComponent();
        }

        private void WcLabel_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void RegistertextBox_TextChanged(object sender, EventArgs e)
        {

        }
        //navigate to the register form
        private void RegisterTxt_Click(object sender, EventArgs e)
        {
            Register sForm = new Register();
            sForm.Show();
            this.Hide();
        }
        //close button
        private void closelabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // login button
        private void loginBtn_Click(object sender, EventArgs e)
        {
            string username = UsernameTxt.Text;
            string password = passwdTxt.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //get data from database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT UserId, Role FROM Users WHERE Username = @Username AND Password = @Password";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int userId = Convert.ToInt32(reader["UserID"]);
                            string role = reader["Role"].ToString();

                            //navigate according to the role
                            if (role == "Member")
                            {
                                MemberProfile memberProfileForm = new MemberProfile(username, password);
                                memberProfileForm.Show();
                                this.Hide();
                            }
                            else if (role == "Trainer")
                            {

                                TrainerProfile trainerProfile = new TrainerProfile();
                                trainerProfile.Show();
                                this.Hide();
                            }
                        }
                        //if user not found,cannot login message 
                        else
                        {
                            MessageBox.Show("Can't log in, please register first.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

            }
        }

            // display password 
            private void showPcheck_CheckedChanged(object sender, EventArgs e)
            {
                if (showPcheck.Checked)
                {
                    // Show password
                    passwdTxt.PasswordChar = '\0';
                }
                else
                {
                    // Hide password
                    passwdTxt.PasswordChar = '*';
                }
            }
        }
    } 

