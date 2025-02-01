namespace Gym_Management_System_SDAM2
{
    partial class LoginForm
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
            this.loginPanel1 = new System.Windows.Forms.Panel();
            this.RegisterTxt = new System.Windows.Forms.Label();
            this.closelabel = new System.Windows.Forms.Label();
            this.loginPanel2 = new System.Windows.Forms.Panel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.Logolabel = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.showPcheck = new System.Windows.Forms.CheckBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.passwdTxt = new System.Windows.Forms.TextBox();
            this.UsernameTxt = new System.Windows.Forms.TextBox();
            this.passwdLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.WcLabel = new System.Windows.Forms.Label();
            this.loginPanel1.SuspendLayout();
            this.loginPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // loginPanel1
            // 
            this.loginPanel1.BackColor = System.Drawing.Color.White;
            this.loginPanel1.Controls.Add(this.RegisterTxt);
            this.loginPanel1.Controls.Add(this.closelabel);
            this.loginPanel1.Controls.Add(this.loginPanel2);
            this.loginPanel1.Controls.Add(this.textBox);
            this.loginPanel1.Controls.Add(this.showPcheck);
            this.loginPanel1.Controls.Add(this.loginBtn);
            this.loginPanel1.Controls.Add(this.passwdTxt);
            this.loginPanel1.Controls.Add(this.UsernameTxt);
            this.loginPanel1.Controls.Add(this.passwdLabel);
            this.loginPanel1.Controls.Add(this.UsernameLabel);
            this.loginPanel1.Controls.Add(this.WcLabel);
            this.loginPanel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginPanel1.Location = new System.Drawing.Point(-1, 0);
            this.loginPanel1.Name = "loginPanel1";
            this.loginPanel1.Size = new System.Drawing.Size(683, 488);
            this.loginPanel1.TabIndex = 0;
            // 
            // RegisterTxt
            // 
            this.RegisterTxt.AutoSize = true;
            this.RegisterTxt.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterTxt.Location = new System.Drawing.Point(489, 419);
            this.RegisterTxt.Name = "RegisterTxt";
            this.RegisterTxt.Size = new System.Drawing.Size(90, 16);
            this.RegisterTxt.TabIndex = 12;
            this.RegisterTxt.Text = "Register Here";
            this.RegisterTxt.Click += new System.EventHandler(this.RegisterTxt_Click);
            // 
            // closelabel
            // 
            this.closelabel.AutoSize = true;
            this.closelabel.BackColor = System.Drawing.Color.Red;
            this.closelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closelabel.ForeColor = System.Drawing.Color.White;
            this.closelabel.Location = new System.Drawing.Point(652, 9);
            this.closelabel.Name = "closelabel";
            this.closelabel.Size = new System.Drawing.Size(20, 20);
            this.closelabel.TabIndex = 11;
            this.closelabel.Text = "X";
            this.closelabel.Click += new System.EventHandler(this.closelabel_Click);
            // 
            // loginPanel2
            // 
            this.loginPanel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.loginPanel2.Controls.Add(this.pictureBox);
            this.loginPanel2.Controls.Add(this.Logolabel);
            this.loginPanel2.Location = new System.Drawing.Point(0, 0);
            this.loginPanel2.Name = "loginPanel2";
            this.loginPanel2.Size = new System.Drawing.Size(297, 488);
            this.loginPanel2.TabIndex = 10;
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::Gym_Management_System_SDAM2.Properties.Resources.icons8_user_100;
            this.pictureBox.Location = new System.Drawing.Point(85, 149);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(100, 100);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 12;
            this.pictureBox.TabStop = false;
            // 
            // Logolabel
            // 
            this.Logolabel.AutoSize = true;
            this.Logolabel.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logolabel.ForeColor = System.Drawing.Color.White;
            this.Logolabel.Location = new System.Drawing.Point(57, 262);
            this.Logolabel.Name = "Logolabel";
            this.Logolabel.Size = new System.Drawing.Size(162, 34);
            this.Logolabel.TabIndex = 12;
            this.Logolabel.Text = "Pulse Gym";
            // 
            // textBox
            // 
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox.Location = new System.Drawing.Point(337, 420);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(160, 15);
            this.textBox.TabIndex = 8;
            this.textBox.Text = "Don\'t have an account?";
            this.textBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // showPcheck
            // 
            this.showPcheck.AutoSize = true;
            this.showPcheck.Location = new System.Drawing.Point(513, 275);
            this.showPcheck.Name = "showPcheck";
            this.showPcheck.Size = new System.Drawing.Size(125, 20);
            this.showPcheck.TabIndex = 7;
            this.showPcheck.Text = "Show Password";
            this.showPcheck.UseVisualStyleBackColor = true;
            this.showPcheck.CheckedChanged += new System.EventHandler(this.showPcheck_CheckedChanged);
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.DarkBlue;
            this.loginBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.Location = new System.Drawing.Point(337, 316);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(0);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(91, 44);
            this.loginBtn.TabIndex = 6;
            this.loginBtn.Text = "LOGIN";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // passwdTxt
            // 
            this.passwdTxt.BackColor = System.Drawing.SystemColors.Control;
            this.passwdTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwdTxt.Location = new System.Drawing.Point(337, 240);
            this.passwdTxt.Multiline = true;
            this.passwdTxt.Name = "passwdTxt";
            this.passwdTxt.PasswordChar = '*';
            this.passwdTxt.Size = new System.Drawing.Size(302, 29);
            this.passwdTxt.TabIndex = 5;
            // 
            // UsernameTxt
            // 
            this.UsernameTxt.BackColor = System.Drawing.SystemColors.Control;
            this.UsernameTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UsernameTxt.Location = new System.Drawing.Point(337, 170);
            this.UsernameTxt.Multiline = true;
            this.UsernameTxt.Name = "UsernameTxt";
            this.UsernameTxt.Size = new System.Drawing.Size(302, 29);
            this.UsernameTxt.TabIndex = 4;
            // 
            // passwdLabel
            // 
            this.passwdLabel.AutoSize = true;
            this.passwdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwdLabel.Location = new System.Drawing.Point(336, 219);
            this.passwdLabel.Name = "passwdLabel";
            this.passwdLabel.Size = new System.Drawing.Size(79, 18);
            this.passwdLabel.TabIndex = 3;
            this.passwdLabel.Text = "Password:";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.Location = new System.Drawing.Point(336, 149);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(81, 18);
            this.UsernameLabel.TabIndex = 2;
            this.UsernameLabel.Text = "Username:";
            // 
            // WcLabel
            // 
            this.WcLabel.AutoSize = true;
            this.WcLabel.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WcLabel.Location = new System.Drawing.Point(382, 88);
            this.WcLabel.Name = "WcLabel";
            this.WcLabel.Size = new System.Drawing.Size(221, 34);
            this.WcLabel.TabIndex = 1;
            this.WcLabel.Text = "Welcome Back!";
            this.WcLabel.Click += new System.EventHandler(this.WcLabel_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 487);
            this.Controls.Add(this.loginPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.loginPanel1.ResumeLayout(false);
            this.loginPanel1.PerformLayout();
            this.loginPanel2.ResumeLayout(false);
            this.loginPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel loginPanel1;
        private System.Windows.Forms.Label WcLabel;
        private System.Windows.Forms.Label passwdLabel;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.TextBox passwdTxt;
        private System.Windows.Forms.TextBox UsernameTxt;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.CheckBox showPcheck;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Panel loginPanel2;
        private System.Windows.Forms.Label closelabel;
        private System.Windows.Forms.Label Logolabel;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label RegisterTxt;
    }
}

