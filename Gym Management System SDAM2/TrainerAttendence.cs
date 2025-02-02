using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Gym_Management_System_SDAM2
{
    public partial class TrainerAttendence : Form
    {
        string connectionString = "Server=(local)\\SQLEXPRESS;Database=Gym_Management_System_SDAM2;Integrated Security=True;";
        public TrainerAttendence()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

    }
}
