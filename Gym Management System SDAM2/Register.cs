using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Gym_Management_System_SDAM2
{
    public partial class Register : Form
    {
        //SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-28I7HML\SQLEXPRESS;Initial Catalog=GymManagementSystem;Integrated Security=True;Trust Server Certificate=True");
        public Register()
        {
            InitializeComponent();
        }

        private void PersonalLabel_Click(object sender, EventArgs e)
        {

        }

        private void contactLbl_Click(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void closeLable_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void regBtn_Click(object sender, EventArgs e)
        {
            //if(connect.State != ConnectionState.Open)
            //{
            //    try
            //    {
            //        connect.Open();
            //        string checkUsername = "SELECT * FROM Users ";
            //        MessageBox.Show("Connection successful!");
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("Connection failed: " + ex.Message);
            //    }
            //    finally
            //    {
            //        connect.Close();
            //    }
            }

        private void regPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void genBtn2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
    }

