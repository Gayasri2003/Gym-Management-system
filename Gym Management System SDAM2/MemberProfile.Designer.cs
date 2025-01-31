namespace Gym_Management_System_SDAM2
{
    partial class MemberProfile
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
            this.closeLabel = new System.Windows.Forms.Label();
            this.MemPanel1 = new System.Windows.Forms.Panel();
            this.EditBtn = new System.Windows.Forms.Button();
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MemPanel1.SuspendLayout();
            this.DashPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
            this.DPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.payBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attenBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // closeLabel
            // 
            this.closeLabel.AutoSize = true;
            this.closeLabel.BackColor = System.Drawing.Color.Red;
            this.closeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeLabel.ForeColor = System.Drawing.Color.White;
            this.closeLabel.Location = new System.Drawing.Point(652, 9);
            this.closeLabel.Name = "closeLabel";
            this.closeLabel.Size = new System.Drawing.Size(20, 20);
            this.closeLabel.TabIndex = 0;
            this.closeLabel.Text = "X";
            this.closeLabel.Click += new System.EventHandler(this.closeLabel_Click);
            // 
            // MemPanel1
            // 
            this.MemPanel1.BackColor = System.Drawing.SystemColors.Window;
            this.MemPanel1.Controls.Add(this.dataGridView1);
            this.MemPanel1.Controls.Add(this.EditBtn);
            this.MemPanel1.Controls.Add(this.DashPanel);
            this.MemPanel1.Controls.Add(this.closeLabel);
            this.MemPanel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MemPanel1.Location = new System.Drawing.Point(-1, 0);
            this.MemPanel1.Name = "MemPanel1";
            this.MemPanel1.Size = new System.Drawing.Size(682, 489);
            this.MemPanel1.TabIndex = 1;
            // 
            // EditBtn
            // 
            this.EditBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.EditBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditBtn.ForeColor = System.Drawing.Color.White;
            this.EditBtn.Location = new System.Drawing.Point(502, 396);
            this.EditBtn.Margin = new System.Windows.Forms.Padding(0);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(108, 51);
            this.EditBtn.TabIndex = 2;
            this.EditBtn.Text = "Edit Profile";
            this.EditBtn.UseVisualStyleBackColor = false;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // DashPanel
            // 
            this.DashPanel.BackColor = System.Drawing.Color.MidnightBlue;
            this.DashPanel.Controls.Add(this.logoBox);
            this.DashPanel.Controls.Add(this.DPanel2);
            this.DashPanel.Location = new System.Drawing.Point(0, 0);
            this.DashPanel.Name = "DashPanel";
            this.DashPanel.Size = new System.Drawing.Size(212, 489);
            this.DashPanel.TabIndex = 1;
            // 
            // logoBox
            // 
            this.logoBox.Image = global::Gym_Management_System_SDAM2.Properties.Resources.Screenshot_2025_01_23_182521;
            this.logoBox.Location = new System.Drawing.Point(55, 21);
            this.logoBox.Name = "logoBox";
            this.logoBox.Size = new System.Drawing.Size(93, 111);
            this.logoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoBox.TabIndex = 8;
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
            this.MclassLbl.Click += new System.EventHandler(this.label2_Click);
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(229, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(432, 284);
            this.dataGridView1.TabIndex = 3;
            // 
            // MemberProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 488);
            this.Controls.Add(this.MemPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MemberProfile";
            this.Text = "MemberProfile";
            this.MemPanel1.ResumeLayout(false);
            this.MemPanel1.PerformLayout();
            this.DashPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
            this.DPanel2.ResumeLayout(false);
            this.DPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.payBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attenBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label closeLabel;
        private System.Windows.Forms.Panel MemPanel1;
        private System.Windows.Forms.Panel DashPanel;
        private System.Windows.Forms.Panel DPanel2;
        private System.Windows.Forms.Label MpaymentsLbl;
        private System.Windows.Forms.Label AttendLbl;
        private System.Windows.Forms.Label MclassLbl;
        private System.Windows.Forms.Label MprofileLbl;
        private System.Windows.Forms.PictureBox profBox1;
        private System.Windows.Forms.PictureBox logoBox;
        private System.Windows.Forms.PictureBox classBox2;
        private System.Windows.Forms.PictureBox attenBox3;
        private System.Windows.Forms.PictureBox payBox4;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}