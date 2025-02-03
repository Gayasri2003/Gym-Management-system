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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Gym_Management_System_SDAM2
{
    public partial class EditMemProfile : Form
    {
        private string username;
        private string password;
        private DB_Helper dbHelper;
        private Members currentMember;
        public EditMemProfile(string username, string password, DB_Helper dbHelper, Members memberProfile)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
            this.currentMember = memberProfile;
            this.dbHelper = dbHelper;
            LoadMemberData();

        }

        public EditMemProfile(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        private void LoadMemberData()
        {
            
  
            txtFname.Text = currentMember.FirstName;
            txtLname.Text = currentMember.LastName;
            dateTimePicker1.Value = currentMember.DateOfBirth;
            txtContact.Text = currentMember.ContactNumber;
            txtCity.Text = currentMember.City;
            txtMail.Text = currentMember.Email;
            if (currentMember.Gender == "Male")
            {
                MaleBtn.Checked = true;
            }
            else if (currentMember.Gender == "Female")
            {
                FemaleBtn.Checked = true;
            }
            txtUname.Text = currentMember.Username;
            txtPwd.Text = currentMember.Password;
            txtMemTyp.Text = currentMember.MembershipType;
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

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

        private void EditBtn_Click(object sender, EventArgs e)
        {
            currentMember.FirstName = txtFname.Text;
            currentMember.LastName = txtLname.Text;
            currentMember.DateOfBirth = dateTimePicker1.Value;
            currentMember.ContactNumber = txtContact.Text;
            currentMember.City = txtCity.Text;
            currentMember.Email = txtMail.Text;
            if (MaleBtn.Checked)
            {
                currentMember.Gender = "Male";
            }
            else if (FemaleBtn.Checked)
            {
                currentMember.Gender = "Female";
            }
            currentMember.Username = txtUname.Text;
            currentMember.SetPassword(txtPwd.Text);
            currentMember.MembershipType = txtMemTyp.Text;

        
            bool success = dbHelper.UpdateMemberProfile(currentMember);

            if (success)
            {
                MessageBox.Show("Profile updated successfully!");

                MemberProfile memberProfileForm = new MemberProfile(username,password);
                memberProfileForm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to update profile.");
            }
        }
    }
}

