﻿namespace Gym_Management_System_SDAM2
{
    partial class MemberPayments
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.MonthFeeLbl = new System.Windows.Forms.Label();
            this.PayPlanLbl = new System.Windows.Forms.Label();
            this.userNameLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.closeLabel = new System.Windows.Forms.Label();
            this.DashPanel = new System.Windows.Forms.Panel();
            this.logoBox = new System.Windows.Forms.PictureBox();
            this.DPanel2 = new System.Windows.Forms.Panel();
            this.payBox4 = new System.Windows.Forms.PictureBox();
            this.classBox2 = new System.Windows.Forms.PictureBox();
            this.attenBox3 = new System.Windows.Forms.PictureBox();
            this.profBox1 = new System.Windows.Forms.PictureBox();
            this.MpaymentsLbl = new System.Windows.Forms.Label();
            this.AttendLbl = new System.Windows.Forms.Label();
            this.MclassLbl = new System.Windows.Forms.Label();
            this.MprofileLbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.DashPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
            this.DPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.payBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attenBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.MonthFeeLbl);
            this.panel1.Controls.Add(this.PayPlanLbl);
            this.panel1.Controls.Add(this.userNameLbl);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.closeLabel);
            this.panel1.Controls.Add(this.DashPanel);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(682, 489);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(391, 223);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(226, 22);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(266, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Payment Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.RoyalBlue;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(240, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Payment History:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(244, 346);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(414, 131);
            this.dataGridView1.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MidnightBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(512, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 49);
            this.button1.TabIndex = 10;
            this.button1.Text = "Process Payment";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Payment Method";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(391, 179);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(226, 24);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(391, 97);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(226, 22);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(391, 137);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(226, 22);
            this.textBox2.TabIndex = 2;
            // 
            // MonthFeeLbl
            // 
            this.MonthFeeLbl.AutoSize = true;
            this.MonthFeeLbl.Location = new System.Drawing.Point(269, 229);
            this.MonthFeeLbl.Name = "MonthFeeLbl";
            this.MonthFeeLbl.Size = new System.Drawing.Size(0, 16);
            this.MonthFeeLbl.TabIndex = 7;
            // 
            // PayPlanLbl
            // 
            this.PayPlanLbl.AutoSize = true;
            this.PayPlanLbl.Location = new System.Drawing.Point(266, 143);
            this.PayPlanLbl.Name = "PayPlanLbl";
            this.PayPlanLbl.Size = new System.Drawing.Size(111, 16);
            this.PayPlanLbl.TabIndex = 6;
            this.PayPlanLbl.Text = "Payment Amount:";
            this.PayPlanLbl.Click += new System.EventHandler(this.PayPlanLbl_Click);
            // 
            // userNameLbl
            // 
            this.userNameLbl.AutoSize = true;
            this.userNameLbl.Location = new System.Drawing.Point(269, 103);
            this.userNameLbl.Name = "userNameLbl";
            this.userNameLbl.Size = new System.Drawing.Size(73, 16);
            this.userNameLbl.TabIndex = 5;
            this.userNameLbl.Text = "Username:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.RoyalBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(361, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Payment Details";
            // 
            // closeLabel
            // 
            this.closeLabel.AutoSize = true;
            this.closeLabel.BackColor = System.Drawing.Color.Red;
            this.closeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeLabel.ForeColor = System.Drawing.Color.White;
            this.closeLabel.Location = new System.Drawing.Point(650, 9);
            this.closeLabel.Name = "closeLabel";
            this.closeLabel.Size = new System.Drawing.Size(20, 20);
            this.closeLabel.TabIndex = 3;
            this.closeLabel.Text = "X";
            this.closeLabel.Click += new System.EventHandler(this.closeLabel_Click);
            // 
            // DashPanel
            // 
            this.DashPanel.BackColor = System.Drawing.Color.MidnightBlue;
            this.DashPanel.Controls.Add(this.logoBox);
            this.DashPanel.Controls.Add(this.DPanel2);
            this.DashPanel.Location = new System.Drawing.Point(0, 0);
            this.DashPanel.Name = "DashPanel";
            this.DashPanel.Size = new System.Drawing.Size(212, 489);
            this.DashPanel.TabIndex = 2;
            // 
            // logoBox
            // 
            this.logoBox.Image = global::Gym_Management_System_SDAM2.Properties.Resources.Screenshot_2025_01_23_182521;
            this.logoBox.Location = new System.Drawing.Point(56, 23);
            this.logoBox.Name = "logoBox";
            this.logoBox.Size = new System.Drawing.Size(93, 111);
            this.logoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoBox.TabIndex = 9;
            this.logoBox.TabStop = false;
            // 
            // DPanel2
            // 
            this.DPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DPanel2.Controls.Add(this.payBox4);
            this.DPanel2.Controls.Add(this.classBox2);
            this.DPanel2.Controls.Add(this.attenBox3);
            this.DPanel2.Controls.Add(this.profBox1);
            this.DPanel2.Controls.Add(this.MpaymentsLbl);
            this.DPanel2.Controls.Add(this.AttendLbl);
            this.DPanel2.Controls.Add(this.MclassLbl);
            this.DPanel2.Controls.Add(this.MprofileLbl);
            this.DPanel2.Location = new System.Drawing.Point(13, 151);
            this.DPanel2.Name = "DPanel2";
            this.DPanel2.Size = new System.Drawing.Size(181, 296);
            this.DPanel2.TabIndex = 0;
            // 
            // payBox4
            // 
            this.payBox4.Image = global::Gym_Management_System_SDAM2.Properties.Resources.input_onlinepngtools__8_;
            this.payBox4.Location = new System.Drawing.Point(14, 218);
            this.payBox4.Name = "payBox4";
            this.payBox4.Size = new System.Drawing.Size(37, 37);
            this.payBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.payBox4.TabIndex = 7;
            this.payBox4.TabStop = false;
            // 
            // classBox2
            // 
            this.classBox2.Image = global::Gym_Management_System_SDAM2.Properties.Resources.input_onlinepngtools__6_;
            this.classBox2.Location = new System.Drawing.Point(14, 87);
            this.classBox2.Name = "classBox2";
            this.classBox2.Size = new System.Drawing.Size(37, 37);
            this.classBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.classBox2.TabIndex = 6;
            this.classBox2.TabStop = false;
            // 
            // attenBox3
            // 
            this.attenBox3.Image = global::Gym_Management_System_SDAM2.Properties.Resources.input_onlinepngtools__9_;
            this.attenBox3.Location = new System.Drawing.Point(14, 150);
            this.attenBox3.Name = "attenBox3";
            this.attenBox3.Size = new System.Drawing.Size(37, 37);
            this.attenBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.attenBox3.TabIndex = 5;
            this.attenBox3.TabStop = false;
            // 
            // profBox1
            // 
            this.profBox1.Image = global::Gym_Management_System_SDAM2.Properties.Resources.input_onlinepngtools__7_;
            this.profBox1.Location = new System.Drawing.Point(14, 27);
            this.profBox1.Name = "profBox1";
            this.profBox1.Size = new System.Drawing.Size(37, 37);
            this.profBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profBox1.TabIndex = 4;
            this.profBox1.TabStop = false;
            // 
            // MpaymentsLbl
            // 
            this.MpaymentsLbl.AutoSize = true;
            this.MpaymentsLbl.BackColor = System.Drawing.Color.White;
            this.MpaymentsLbl.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MpaymentsLbl.Location = new System.Drawing.Point(68, 233);
            this.MpaymentsLbl.Name = "MpaymentsLbl";
            this.MpaymentsLbl.Size = new System.Drawing.Size(92, 22);
            this.MpaymentsLbl.TabIndex = 3;
            this.MpaymentsLbl.Text = "Payments ";
            this.MpaymentsLbl.Click += new System.EventHandler(this.MpaymentsLbl_Click);
            // 
            // AttendLbl
            // 
            this.AttendLbl.AutoSize = true;
            this.AttendLbl.BackColor = System.Drawing.Color.White;
            this.AttendLbl.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttendLbl.Location = new System.Drawing.Point(68, 165);
            this.AttendLbl.Name = "AttendLbl";
            this.AttendLbl.Size = new System.Drawing.Size(102, 22);
            this.AttendLbl.TabIndex = 2;
            this.AttendLbl.Text = "Attendance";
            this.AttendLbl.Click += new System.EventHandler(this.AttendLbl_Click);
            // 
            // MclassLbl
            // 
            this.MclassLbl.AutoSize = true;
            this.MclassLbl.BackColor = System.Drawing.Color.White;
            this.MclassLbl.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MclassLbl.Location = new System.Drawing.Point(68, 100);
            this.MclassLbl.Name = "MclassLbl";
            this.MclassLbl.Size = new System.Drawing.Size(80, 22);
            this.MclassLbl.TabIndex = 1;
            this.MclassLbl.Text = "Classes   ";
            this.MclassLbl.Click += new System.EventHandler(this.MclassLbl_Click);
            // 
            // MprofileLbl
            // 
            this.MprofileLbl.AutoSize = true;
            this.MprofileLbl.BackColor = System.Drawing.Color.White;
            this.MprofileLbl.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MprofileLbl.Location = new System.Drawing.Point(68, 42);
            this.MprofileLbl.Name = "MprofileLbl";
            this.MprofileLbl.Size = new System.Drawing.Size(78, 22);
            this.MprofileLbl.TabIndex = 0;
            this.MprofileLbl.Text = "Profile   ";
            this.MprofileLbl.Click += new System.EventHandler(this.MprofileLbl_Click);
            // 
            // MemberPayments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 489);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MemberPayments";
            this.Text = "MemberPayments";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.DashPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
            this.DPanel2.ResumeLayout(false);
            this.DPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.payBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attenBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel DashPanel;
        private System.Windows.Forms.Panel DPanel2;
        private System.Windows.Forms.PictureBox payBox4;
        private System.Windows.Forms.PictureBox classBox2;
        private System.Windows.Forms.PictureBox attenBox3;
        private System.Windows.Forms.PictureBox profBox1;
        private System.Windows.Forms.Label MpaymentsLbl;
        private System.Windows.Forms.Label AttendLbl;
        private System.Windows.Forms.Label MclassLbl;
        private System.Windows.Forms.Label MprofileLbl;
        private System.Windows.Forms.Label closeLabel;
        private System.Windows.Forms.PictureBox logoBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label MonthFeeLbl;
        private System.Windows.Forms.Label PayPlanLbl;
        private System.Windows.Forms.Label userNameLbl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
    }
}