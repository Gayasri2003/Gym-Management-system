using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_Management_System_SDAM2
{
    public partial class MemberProfile : Form
    {
        private string username;
        private string password;
        private Members memberProfile;

        private DB_Helper dbHelper = new DB_Helper();
        public MemberProfile(string username, string password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
            LoadMemberProfile();
        }
        private void LoadMemberProfile()
        {
            memberProfile = dbHelper.GetMemberProfile(username, password);
            
            if (memberProfile != null)
            {
                displayMemberProfile();
            }
            else
            {
                MessageBox.Show("Member profile not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
       
         private void displayMemberProfile() { 
        // Bind the member data 
        lblFirstName.Text = memberProfile.FirstName;
        lblLastName.Text = memberProfile.LastName;
        lblDateOfBirth.Text = memberProfile.DateOfBirth.ToShortDateString();
        lblContactNumber.Text = memberProfile.ContactNumber;
        lblCity.Text = memberProfile.City;
        lblEmail.Text = memberProfile.Email;
        lblGender.Text = memberProfile.Gender;
        lblUsername.Text = memberProfile.Username;
        lblMembershipStartDate.Text = memberProfile.MembershipStartDate?.ToShortDateString();
        lblMembershipType.Text = memberProfile.MembershipType;
        }
        
       
        private void closeLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // navigate for the class form
        private void label2_Click(object sender, EventArgs e)
        {
            MemberClasses memberClassesForm = new MemberClasses(username, password);
            memberClassesForm.Show();
            this.Hide();
        }

        // navigate for the attendance form
        private void AttendLbl_Click(object sender, EventArgs e)
        {
            MemberAttendence memberAttendenceForm = new MemberAttendence(username, password);
            memberAttendenceForm.Show();
            this.Hide();
        }

       
        private void MprofileLbl_Click(object sender, EventArgs e)
        {

            MemberProfile memberProfileForm = new MemberProfile(username, password);
            memberProfileForm.Show();
            this.Hide();
        }

        // navigate for the payments form
        private void MpaymentsLbl_Click(object sender, EventArgs e)
        {
            MemberPayments memberPaymentsForm = new MemberPayments(username, password);
            memberPaymentsForm.Show();
            this.Hide();
        }

        // navigate for the edit profile form
        private void EditBtn_Click(object sender, EventArgs e)
        {
            EditMemProfile editMemProfileForm = new EditMemProfile(username, password);
            editMemProfileForm.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }
    }
}
