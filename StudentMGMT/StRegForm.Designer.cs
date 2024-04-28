namespace StudentMGMT
{
    partial class StRegForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.liblLogout = new System.Windows.Forms.LinkLabel();
            this.cbId = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtPNumber = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtNIC = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtParentName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtHomeNum = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMobileNum = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pbExit = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.liblLogout);
            this.groupBox1.Controls.Add(this.cbId);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnRegister);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(52, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(540, 759);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Registration";
            // 
            // liblLogout
            // 
            this.liblLogout.AutoSize = true;
            this.liblLogout.Location = new System.Drawing.Point(488, 738);
            this.liblLogout.Name = "liblLogout";
            this.liblLogout.Size = new System.Drawing.Size(45, 13);
            this.liblLogout.TabIndex = 18;
            this.liblLogout.TabStop = true;
            this.liblLogout.Text = "Log Out";
            this.liblLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.liblLogout_LinkClicked);
            // 
            // cbId
            // 
            this.cbId.FormattingEnabled = true;
            this.cbId.Location = new System.Drawing.Point(95, 42);
            this.cbId.Name = "cbId";
            this.cbId.Size = new System.Drawing.Size(153, 21);
            this.cbId.TabIndex = 10;
            this.cbId.SelectionChangeCommitted += new System.EventHandler(this.cbId_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Reg Num";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(384, 709);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(277, 709);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(173, 709);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnRegister.ForeColor = System.Drawing.Color.Black;
            this.btnRegister.Location = new System.Drawing.Point(66, 709);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 5;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtPNumber);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.txtNIC);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.txtParentName);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Location = new System.Drawing.Point(39, 514);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(447, 189);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Parent Details";
            // 
            // txtPNumber
            // 
            this.txtPNumber.Location = new System.Drawing.Point(114, 128);
            this.txtPNumber.Name = "txtPNumber";
            this.txtPNumber.Size = new System.Drawing.Size(306, 20);
            this.txtPNumber.TabIndex = 21;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(33, 131);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 13);
            this.label14.TabIndex = 20;
            this.label14.Text = "Number";
            // 
            // txtNIC
            // 
            this.txtNIC.Location = new System.Drawing.Point(114, 79);
            this.txtNIC.Name = "txtNIC";
            this.txtNIC.Size = new System.Drawing.Size(306, 20);
            this.txtNIC.TabIndex = 19;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(33, 82);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(25, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "NIC";
            // 
            // txtParentName
            // 
            this.txtParentName.Location = new System.Drawing.Point(114, 33);
            this.txtParentName.Name = "txtParentName";
            this.txtParentName.Size = new System.Drawing.Size(306, 20);
            this.txtParentName.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(33, 36);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "Parent Name";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtHomeNum);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtMobileNum);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtEmail);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtAddress);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(39, 296);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(447, 212);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Contact Details";
            // 
            // txtHomeNum
            // 
            this.txtHomeNum.Location = new System.Drawing.Point(325, 161);
            this.txtHomeNum.Name = "txtHomeNum";
            this.txtHomeNum.Size = new System.Drawing.Size(95, 20);
            this.txtHomeNum.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(244, 164);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Home Phone";
            // 
            // txtMobileNum
            // 
            this.txtMobileNum.Location = new System.Drawing.Point(114, 158);
            this.txtMobileNum.Name = "txtMobileNum";
            this.txtMobileNum.Size = new System.Drawing.Size(95, 20);
            this.txtMobileNum.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(33, 161);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Mobile Phone";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(114, 99);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(306, 20);
            this.txtEmail.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Email";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(114, 33);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(306, 20);
            this.txtAddress.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Address";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbGender);
            this.groupBox2.Controls.Add(this.dtpDOB);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtLName);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtFName);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(39, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(447, 204);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Basic Details";
            // 
            // cbGender
            // 
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbGender.Location = new System.Drawing.Point(113, 155);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(200, 21);
            this.cbGender.TabIndex = 7;
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(113, 113);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(200, 20);
            this.dtpDOB.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Gender";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Date of Birth";
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(114, 72);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(240, 20);
            this.txtLName.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Last Name";
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(114, 29);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(240, 20);
            this.txtFName.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(218, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 37);
            this.label1.TabIndex = 16;
            this.label1.Text = "Skill International ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(193, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(256, 28);
            this.label3.TabIndex = 17;
            this.label3.Text = "Student Management System ";
            // 
            // pbExit
            // 
            this.pbExit.Image = global::StudentMGMT.Properties.Resources.cross;
            this.pbExit.Location = new System.Drawing.Point(609, 6);
            this.pbExit.Name = "pbExit";
            this.pbExit.Size = new System.Drawing.Size(27, 27);
            this.pbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbExit.TabIndex = 18;
            this.pbExit.TabStop = false;
            this.pbExit.Click += new System.EventHandler(this.pbExit_Click_1);
            // 
            // StRegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumOrchid;
            this.ClientSize = new System.Drawing.Size(643, 891);
            this.Controls.Add(this.pbExit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StRegForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtPNumber;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtNIC;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtParentName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtHomeNum;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtMobileNum;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel liblLogout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbExit;
    }
}

