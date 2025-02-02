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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Gym_Management_System_SDAM2
{
    public partial class MemberAttendence : Form
    {

        private string username;
        private string password;
        public MemberAttendence(string username, string password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
            radioPresent.Checked = true;
            uNameTxt.Text = username;
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

        private void MpaymentsLbl_Click(object sender, EventArgs e)
        {
            MemberPayments memberPaymentsForm = new MemberPayments(username, password);
            memberPaymentsForm.Show();
            this.Hide();
        }

        private void closeLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // mark attendance
        private void MarkABtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(username))
            {
                bool isPresent = radioPresent.Checked; // True if "Present" 

                if (DB_Helper.AttendanceExists(username))
                {
                    MessageBox.Show("Attendance already marked for today!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            

                int result = DB_Helper.MarkAttendance(username, isPresent);
                if (result > 0)
                    MessageBox.Show("Attendance marked successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Error marking attendance.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Please enter a valid username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // view attendance
        private void ViewABtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(username))
            {
                DataTable attendanceTable = DB_Helper.GetAttendanceHistory(username);
                dataGridView1.DataSource = attendanceTable;
            }
            else
            {
                MessageBox.Show("Please enter a valid Username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
