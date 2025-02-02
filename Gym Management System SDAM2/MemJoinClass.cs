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
    public partial class MemJoinClass : Form
    {
        private string username;
        private string password;
        private int _memberID;

        private ComboBox combClass;
        private Button btnJoinClass;

        private DB_Helper _dbHelper;

        //member join
        public MemJoinClass(int memberID, string username, string password, string connectionString)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
            _memberID = memberID;

            _dbHelper = new DB_Helper(connectionString);

            combClass = new ComboBox();
            btnJoinClass = new Button();

            LoadClasses();
        }

        private void LoadClasses()
        {
            try
            {

                List<GymClass> availableClasses = _dbHelper.GetAvailableClassesForComboBox();

                // Clear any previous entries
                combClass.Items.Clear();

                // ComboBox with available classes

                combClass.DataSource = availableClasses;
                combClass.DisplayMember = "ClassName";
                combClass.ValueMember = "ClassID";


                // Set default selection
                if (combClass.Items.Count > 0)
                {
                    combClass.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading classes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e) { }

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

        private void conJoinBtn_Click(object sender, EventArgs e)
        {
            int selectedClassID = (int)combClass.SelectedValue;

            // Save the member's class selection
            try
            {
                _dbHelper.SaveMemberClassSelection(_memberID, selectedClassID); 
                MessageBox.Show("You have successfully joined the class.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error joining the class: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            MemberClasses memberClassesForm = new MemberClasses(username, password);
            memberClassesForm.Show();
            this.Hide();

        }

        private void closeLable_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
