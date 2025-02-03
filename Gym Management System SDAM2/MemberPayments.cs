using System;
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
    public partial class MemberPayments : Form
    {
        private string username;
        private string password;
        

        public MemberPayments(string username, string password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
           LoadPaymentHistory();
        }
        private void LoadPaymentHistory()
        {
            DataTable dt = DB_Helper.GetPaymentHistory(username);
            dataGridView1.DataSource = dt;
        }

        private void MpaymentsLbl_Click(object sender, EventArgs e)
        {
            MemberPayments memberPaymentsForm = new MemberPayments(username, password);
            memberPaymentsForm.Show();
            this.Hide();
        }

       
        private void MprofileLbl_Click(object sender, EventArgs e)
        {
            MemberProfile memberProfileForm = new MemberProfile(username, password);
            memberProfileForm.Show();
            this.Hide();
        }

        private void MclassLbl_Click(object sender, EventArgs e)
        {
            MemberClasses memberClassesForm = new MemberClasses(username, password);
            memberClassesForm.Show();
            this.Hide();
        }

        private void AttendLbl_Click(object sender, EventArgs e)
        {
            MemberAttendence memberAttendenceForm = new MemberAttendence(username, password);
            memberAttendenceForm.Show();
            this.Hide();
        }

        private void closeLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PayPlanLbl_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || comboBox1.SelectedItem == null)
                {
                    MessageBox.Show("Please fill in all payment details.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string username = textBox1.Text.Trim();
                if (!decimal.TryParse(textBox2.Text, out decimal amount) || amount <= 0)
                {
                    MessageBox.Show("Invalid amount. Please enter a positive number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string method = comboBox1.SelectedItem.ToString();
                DateTime paymentDate = dateTimePicker1.Value;

                // Add Payment
                int result = DB_Helper.AddPayment(username, amount, paymentDate, method);
                if (result > 0)
                {
                    MessageBox.Show("Payment processed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadPaymentHistory(); 
                }
                else
                {
                    MessageBox.Show("Payment failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Payment Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Cash");
            comboBox1.Items.Add("Card");
            comboBox1.SelectedIndex = 0;
        }
    }
}
