namespace gym_management_system_1
{
    partial class Form1
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
            this.classIDtext = new System.Windows.Forms.Label();
            this.dateTxt = new System.Windows.Forms.Label();
            this.timeTxt = new System.Windows.Forms.Label();
            this.locationTxt = new System.Windows.Forms.Label();
            this.typeTxt = new System.Windows.Forms.Label();
            this.classIDtextbox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.addclassBtn = new System.Windows.Forms.Button();
            this.classupdateBtn = new System.Windows.Forms.Button();
            this.classdeleteBtn = new System.Windows.Forms.Button();
            this.closelabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(60, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Class For Trainers";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(65, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(532, 228);
            this.dataGridView1.TabIndex = 7;
            // 
            // classIDtext
            // 
            this.classIDtext.AutoSize = true;
            this.classIDtext.Location = new System.Drawing.Point(65, 288);
            this.classIDtext.Name = "classIDtext";
            this.classIDtext.Size = new System.Drawing.Size(57, 16);
            this.classIDtext.TabIndex = 26;
            this.classIDtext.Text = "Class ID";
            this.classIDtext.Click += new System.EventHandler(this.classIDtext_Click);
            // 
            // dateTxt
            // 
            this.dateTxt.AutoSize = true;
            this.dateTxt.Location = new System.Drawing.Point(68, 320);
            this.dateTxt.Name = "dateTxt";
            this.dateTxt.Size = new System.Drawing.Size(36, 16);
            this.dateTxt.TabIndex = 27;
            this.dateTxt.Text = "Date";
            // 
            // timeTxt
            // 
            this.timeTxt.AutoSize = true;
            this.timeTxt.Location = new System.Drawing.Point(68, 352);
            this.timeTxt.Name = "timeTxt";
            this.timeTxt.Size = new System.Drawing.Size(38, 16);
            this.timeTxt.TabIndex = 28;
            this.timeTxt.Text = "Time";
            this.timeTxt.Click += new System.EventHandler(this.timeTxt_Click);
            // 
            // locationTxt
            // 
            this.locationTxt.AutoSize = true;
            this.locationTxt.Location = new System.Drawing.Point(65, 383);
            this.locationTxt.Name = "locationTxt";
            this.locationTxt.Size = new System.Drawing.Size(58, 16);
            this.locationTxt.TabIndex = 29;
            this.locationTxt.Text = "Location";
            this.locationTxt.Click += new System.EventHandler(this.locationTxt_Click);
            // 
            // typeTxt
            // 
            this.typeTxt.AutoSize = true;
            this.typeTxt.Location = new System.Drawing.Point(65, 414);
            this.typeTxt.Name = "typeTxt";
            this.typeTxt.Size = new System.Drawing.Size(39, 16);
            this.typeTxt.TabIndex = 30;
            this.typeTxt.Text = "Type";
            // 
            // classIDtextbox
            // 
            this.classIDtextbox.Location = new System.Drawing.Point(147, 282);
            this.classIDtextbox.Name = "classIDtextbox";
            this.classIDtextbox.Size = new System.Drawing.Size(174, 22);
            this.classIDtextbox.TabIndex = 31;
            this.classIDtextbox.TextChanged += new System.EventHandler(this.classIDtextbox_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(147, 314);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(174, 22);
            this.textBox1.TabIndex = 32;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(147, 346);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(174, 22);
            this.textBox2.TabIndex = 33;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(147, 380);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(174, 22);
            this.textBox3.TabIndex = 34;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(147, 411);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(174, 22);
            this.textBox4.TabIndex = 35;
            // 
            // addclassBtn
            // 
            this.addclassBtn.Font = new System.Drawing.Font("Tahoma", 8F);
            this.addclassBtn.Location = new System.Drawing.Point(193, 468);
            this.addclassBtn.Name = "addclassBtn";
            this.addclassBtn.Size = new System.Drawing.Size(128, 29);
            this.addclassBtn.TabIndex = 36;
            this.addclassBtn.Text = "Add New Class";
            this.addclassBtn.UseVisualStyleBackColor = true;
            // 
            // classupdateBtn
            // 
            this.classupdateBtn.Font = new System.Drawing.Font("Tahoma", 8F);
            this.classupdateBtn.Location = new System.Drawing.Point(381, 468);
            this.classupdateBtn.Name = "classupdateBtn";
            this.classupdateBtn.Size = new System.Drawing.Size(132, 29);
            this.classupdateBtn.TabIndex = 37;
            this.classupdateBtn.Text = "Update Class";
            this.classupdateBtn.UseVisualStyleBackColor = true;
            // 
            // classdeleteBtn
            // 
            this.classdeleteBtn.Font = new System.Drawing.Font("Tahoma", 8F);
            this.classdeleteBtn.Location = new System.Drawing.Point(611, 468);
            this.classdeleteBtn.Name = "classdeleteBtn";
            this.classdeleteBtn.Size = new System.Drawing.Size(114, 29);
            this.classdeleteBtn.TabIndex = 38;
            this.classdeleteBtn.Text = "Delete Class";
            this.classdeleteBtn.UseVisualStyleBackColor = true;
            // 
            // closelabel
            // 
            this.closelabel.AutoSize = true;
            this.closelabel.BackColor = System.Drawing.Color.Red;
            this.closelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closelabel.ForeColor = System.Drawing.Color.White;
            this.closelabel.Location = new System.Drawing.Point(768, 0);
            this.closelabel.Name = "closelabel";
            this.closelabel.Size = new System.Drawing.Size(20, 20);
            this.closelabel.TabIndex = 39;
            this.closelabel.Text = "X";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 509);
            this.Controls.Add(this.closelabel);
            this.Controls.Add(this.classdeleteBtn);
            this.Controls.Add(this.classupdateBtn);
            this.Controls.Add(this.addclassBtn);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.classIDtextbox);
            this.Controls.Add(this.typeTxt);
            this.Controls.Add(this.locationTxt);
            this.Controls.Add(this.timeTxt);
            this.Controls.Add(this.dateTxt);
            this.Controls.Add(this.classIDtext);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label classIDtext;
        private System.Windows.Forms.Label dateTxt;
        private System.Windows.Forms.Label timeTxt;
        private System.Windows.Forms.Label locationTxt;
        private System.Windows.Forms.Label typeTxt;
        private System.Windows.Forms.TextBox classIDtextbox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button addclassBtn;
        private System.Windows.Forms.Button classupdateBtn;
        private System.Windows.Forms.Button classdeleteBtn;
        private System.Windows.Forms.Label closelabel;
    }
}

