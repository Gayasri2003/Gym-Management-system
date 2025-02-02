using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Gym_Management_System_SDAM2
{
    public partial class MemberClasses : Form
    {
        private string username;
        private string password;

        private DB_Helper dbHelper;
        private int memberID;
     
        private string connectionString = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=GymDatabase;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        public MemberClasses(string username, string password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;

            dbHelper = new DB_Helper();
            this.Load += AvailableClassesForm_Load;
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

        private void AvailableClassesForm_Load(object sender, EventArgs e)
        {
            LoadAvailableClasses();
        }

        private void LoadAvailableClasses()
        {
            List<GymClass> availableClasses = dbHelper.GetAvailableClasses();

           
            // list of gym classes into a DataTable
            DataTable dt = new DataTable();
            dt.Columns.Add("Class Name");
            dt.Columns.Add("Instructor");
            dt.Columns.Add("Schedule");


            foreach (var gymClass in availableClasses)
            {
                dt.Rows.Add(gymClass.ClassName, gymClass.Instructor, gymClass.Schedule);
            }

            dataGridView1.DataSource = dt;
        }


        private void closeLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void JoinClassBtn_Click(object sender, EventArgs e)
        {
            MemJoinClass memJoinClassForm = new MemJoinClass(memberID, username, password, connectionString);

            // Show the form and hide the current one
            memJoinClassForm.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex >= 0)
            {
                string className = dataGridView1.Rows[rowIndex].Cells["Class Name"].Value.ToString();
                string instructor = dataGridView1.Rows[rowIndex].Cells["Instructor"].Value.ToString();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

    }
}
