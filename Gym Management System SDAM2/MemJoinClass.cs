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

        private ComboBox combClass;
        private Button btnJoinClass;
        public MemJoinClass()
        {
            InitializeComponent();
            this.username = username;
            this.password = password;

            combClass= new ComboBox();
            btnJoinClass = new Button();
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
    }
}
