namespace Gym_Management_System_SDAM2
{
    partial class TrainerClasses
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
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.attendLink = new System.Windows.Forms.LinkLabel();
            this.classLink = new System.Windows.Forms.LinkLabel();
            this.homeLink = new System.Windows.Forms.LinkLabel();
            this.homeLogout = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.closelabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(151, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Class Overview";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(156, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(507, 219);
            this.dataGridView1.TabIndex = 3;
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
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(129, 494);
            this.panel1.TabIndex = 4;
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
            // closelabel
            // 
            this.closelabel.AutoSize = true;
            this.closelabel.BackColor = System.Drawing.Color.Red;
            this.closelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closelabel.ForeColor = System.Drawing.Color.White;
            this.closelabel.Location = new System.Drawing.Point(650, 8);
            this.closelabel.Name = "closelabel";
            this.closelabel.Size = new System.Drawing.Size(20, 20);
            this.closelabel.TabIndex = 12;
            this.closelabel.Text = "X";
            // 
            // TrainerClasses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(682, 490);
            this.Controls.Add(this.closelabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TrainerClasses";
            this.Text = "TrainerClasses";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel attendLink;
        private System.Windows.Forms.LinkLabel classLink;
        private System.Windows.Forms.LinkLabel homeLink;
        private System.Windows.Forms.Button homeLogout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label closelabel;
    }
}