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
    public partial class LoginForm : Form
    {
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

        private void RegisterTxt_Click(object sender, EventArgs e)
        {
            Register sForm = new Register();
            sForm.Show();
            this.Hide();
        }

        private void closelabel_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }
    }
}
