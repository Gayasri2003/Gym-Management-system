﻿namespace Gym_Management_System_SDAM2
{
    partial class TrainerProfile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.attendLink = new System.Windows.Forms.LinkLabel();
            this.classLink = new System.Windows.Forms.LinkLabel();
            this.homeLink = new System.Windows.Forms.LinkLabel();
            this.homeLogout = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.trnName = new System.Windows.Forms.Label();
            this.trnLname = new System.Windows.Forms.Label();
            this.trnGender = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.closelabel = new System.Windows.Forms.Label();
            this.trnDOB = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.attendLink);
            this.panel1.Controls.Add(this.classLink);
            this.panel1.Controls.Add(this.homeLink);
            this.panel1.Controls.Add(this.homeLogout);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(128, 491);
            this.panel1.TabIndex = 0;
            // 
            // attendLink
            // 
            this.attendLink.AutoSize = true;
            this.attendLink.BackColor = System.Drawing.Color.Transparent;
            this.attendLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.attendLink.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.attendLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.attendLink.LinkColor = System.Drawing.Color.White;
            this.attendLink.Location = new System.Drawing.Point(9, 293);
            this.attendLink.Name = "attendLink";
            this.attendLink.Size = new System.Drawing.Size(108, 18);
            this.attendLink.TabIndex = 23;
            this.attendLink.TabStop = true;
            this.attendLink.Text = "ATTENDENCE";
            this.attendLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.attendLink_LinkClicked);
            // 
            // classLink
            // 
            this.classLink.AutoSize = true;
            this.classLink.BackColor = System.Drawing.Color.Transparent;
            this.classLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.classLink.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.classLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.classLink.LinkColor = System.Drawing.Color.White;
            this.classLink.Location = new System.Drawing.Point(25, 251);
            this.classLink.Name = "classLink";
            this.classLink.Size = new System.Drawing.Size(76, 18);
            this.classLink.TabIndex = 22;
            this.classLink.TabStop = true;
            this.classLink.Text = "CLASSES";
            this.classLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.classLink_LinkClicked);
            // 
            // homeLink
            // 
            this.homeLink.AutoSize = true;
            this.homeLink.BackColor = System.Drawing.Color.Transparent;
            this.homeLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homeLink.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.homeLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.homeLink.LinkColor = System.Drawing.Color.White;
            this.homeLink.Location = new System.Drawing.Point(38, 207);
            this.homeLink.Name = "homeLink";
            this.homeLink.Size = new System.Drawing.Size(53, 18);
            this.homeLink.TabIndex = 21;
            this.homeLink.TabStop = true;
            this.homeLink.Text = "HOME";
            this.homeLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.homeLink_LinkClicked);
            // 
            // homeLogout
            // 
            this.homeLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.homeLogout.Location = new System.Drawing.Point(18, 440);
            this.homeLogout.Name = "homeLogout";
            this.homeLogout.Size = new System.Drawing.Size(89, 37);
            this.homeLogout.TabIndex = 19;
            this.homeLogout.Text = "LOG OUT";
            this.homeLogout.UseVisualStyleBackColor = true;
            this.homeLogout.Click += new System.EventHandler(this.homeLogout_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(25, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "TRAINER";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(13, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Logged in as: ";
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::Gym_Management_System_SDAM2.Properties.Resources.icons8_user_100;
            this.pictureBox.Location = new System.Drawing.Point(41, 9);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(40, 36);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 13;
            this.pictureBox.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(146, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Dashboard";
            // 
            // trnName
            // 
            this.trnName.AutoSize = true;
            this.trnName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trnName.ForeColor = System.Drawing.Color.Black;
            this.trnName.Location = new System.Drawing.Point(304, 56);
            this.trnName.Name = "trnName";
            this.trnName.Size = new System.Drawing.Size(85, 18);
            this.trnName.TabIndex = 6;
            this.trnName.Text = "First Name:";
            // 
            // trnLname
            // 
            this.trnLname.AutoSize = true;
            this.trnLname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trnLname.ForeColor = System.Drawing.Color.Black;
            this.trnLname.Location = new System.Drawing.Point(305, 85);
            this.trnLname.Name = "trnLname";
            this.trnLname.Size = new System.Drawing.Size(84, 18);
            this.trnLname.TabIndex = 7;
            this.trnLname.Text = "Last Name:";
            // 
            // trnGender
            // 
            this.trnGender.AutoSize = true;
            this.trnGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trnGender.ForeColor = System.Drawing.Color.Black;
            this.trnGender.Location = new System.Drawing.Point(305, 114);
            this.trnGender.Name = "trnGender";
            this.trnGender.Size = new System.Drawing.Size(57, 18);
            this.trnGender.TabIndex = 12;
            this.trnGender.Text = "Gender";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Gym_Management_System_SDAM2.Properties.Resources.icons8_user_100;
            this.pictureBox1.Location = new System.Drawing.Point(151, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 129);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // closelabel
            // 
            this.closelabel.AutoSize = true;
            this.closelabel.BackColor = System.Drawing.Color.Red;
            this.closelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closelabel.ForeColor = System.Drawing.Color.White;
            this.closelabel.Location = new System.Drawing.Point(650, 9);
            this.closelabel.Name = "closelabel";
            this.closelabel.Size = new System.Drawing.Size(20, 20);
            this.closelabel.TabIndex = 13;
            this.closelabel.Text = "X";
            // 
            // trnDOB
            // 
            this.trnDOB.AutoSize = true;
            this.trnDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.trnDOB.Location = new System.Drawing.Point(304, 143);
            this.trnDOB.Name = "trnDOB";
            this.trnDOB.Size = new System.Drawing.Size(94, 18);
            this.trnDOB.TabIndex = 14;
            this.trnDOB.Text = "Date of Birth:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(146, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 29);
            this.label4.TabIndex = 15;
            this.label4.Text = "Upcoming Events";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(151, 359);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(247, 118);
            this.dataGridView1.TabIndex = 16;
            // 
            // TrainerProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 490);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.trnDOB);
            this.Controls.Add(this.closelabel);
            this.Controls.Add(this.trnGender);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.trnLname);
            this.Controls.Add(this.trnName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TrainerProfile";
            this.Text = "TrainerProfile";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label trnName;
        private System.Windows.Forms.Label trnLname;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label trnGender;
        private System.Windows.Forms.Button homeLogout;
        private System.Windows.Forms.LinkLabel homeLink;
        private System.Windows.Forms.LinkLabel attendLink;
        private System.Windows.Forms.LinkLabel classLink;
        private System.Windows.Forms.Label closelabel;
        private System.Windows.Forms.Label trnDOB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}