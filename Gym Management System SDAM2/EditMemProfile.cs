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
    public partial class EditMemProfile : Form
    {
        public EditMemProfile()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void MprofileLbl_Click(object sender, EventArgs e)
        {
            MemberProfile memberProfileForm = new MemberProfile();
            memberProfileForm.Show();
            this.Hide();
        }

        private void MclassLbl_Click(object sender, EventArgs e)
        {
            MemberClasses memberClassesForm = new MemberClasses();
            memberClassesForm.Show();
            this.Hide();
        }

        private void AttendLbl_Click(object sender, EventArgs e)
        {

            MemberAttendence memberAttendenceForm = new MemberAttendence();
            memberAttendenceForm.Show();
            this.Hide();
        }

        private void MpaymentsLbl_Click(object sender, EventArgs e)
        {
            MemberPayments memberPaymentsForm = new MemberPayments();
            memberPaymentsForm.Show();
            this.Hide();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
