namespace StudentRegistrationForm1
{
    partial class frmStudent
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.picPhoto = new System.Windows.Forms.PictureBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.DateofBirth = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdoUnmarried = new System.Windows.Forms.RadioButton();
            this.rdoMarried = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.chkDiploma = new System.Windows.Forms.CheckBox();
            this.chkUG = new System.Windows.Forms.CheckBox();
            this.chkPG = new System.Windows.Forms.CheckBox();
            this.Experience = new System.Windows.Forms.Label();
            this.cmbExperience = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rtbProject = new System.Windows.Forms.RichTextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Blue;
            this.lblTitle.Location = new System.Drawing.Point(139, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(475, 41);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "STUDENT REGISTRATION FORM\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // picPhoto
            // 
            this.picPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPhoto.Location = new System.Drawing.Point(368, 57);
            this.picPhoto.Name = "picPhoto";
            this.picPhoto.Size = new System.Drawing.Size(150, 150);
            this.picPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPhoto.TabIndex = 2;
            this.picPhoto.TabStop = false;
            this.picPhoto.Click += new System.EventHandler(this.picPhoto_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(443, 226);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(75, 23);
            this.btnUpload.TabIndex = 3;
            this.btnUpload.Text = "Upload Photo\r\n";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // DateofBirth
            // 
            this.DateofBirth.AutoSize = true;
            this.DateofBirth.Location = new System.Drawing.Point(19, 99);
            this.DateofBirth.Name = "DateofBirth";
            this.DateofBirth.Size = new System.Drawing.Size(79, 16);
            this.DateofBirth.TabIndex = 6;
            this.DateofBirth.Text = "Date of Birth";
            this.DateofBirth.Click += new System.EventHandler(this.DateofBirth_Click);
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(104, 99);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(200, 22);
            this.dtpDOB.TabIndex = 7;
            this.dtpDOB.ValueChanged += new System.EventHandler(this.dtpDOB_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoFemale);
            this.groupBox1.Controls.Add(this.rdoMale);
            this.groupBox1.Location = new System.Drawing.Point(22, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 71);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gender";
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Location = new System.Drawing.Point(6, 45);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(74, 20);
            this.rdoFemale.TabIndex = 9;
            this.rdoFemale.TabStop = true;
            this.rdoFemale.Text = "Female";
            this.rdoFemale.UseVisualStyleBackColor = true;
            this.rdoFemale.CheckedChanged += new System.EventHandler(this.rdoFemale_CheckedChanged);
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Location = new System.Drawing.Point(6, 21);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(58, 20);
            this.rdoMale.TabIndex = 9;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "Male";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdoUnmarried);
            this.groupBox2.Controls.Add(this.rdoMarried);
            this.groupBox2.Location = new System.Drawing.Point(22, 226);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(208, 99);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Marital Status";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // rdoUnmarried
            // 
            this.rdoUnmarried.AutoSize = true;
            this.rdoUnmarried.Location = new System.Drawing.Point(6, 47);
            this.rdoUnmarried.Name = "rdoUnmarried";
            this.rdoUnmarried.Size = new System.Drawing.Size(91, 20);
            this.rdoUnmarried.TabIndex = 10;
            this.rdoUnmarried.TabStop = true;
            this.rdoUnmarried.Text = "Unmarried";
            this.rdoUnmarried.UseVisualStyleBackColor = true;
            // 
            // rdoMarried
            // 
            this.rdoMarried.AutoSize = true;
            this.rdoMarried.Location = new System.Drawing.Point(6, 21);
            this.rdoMarried.Name = "rdoMarried";
            this.rdoMarried.Size = new System.Drawing.Size(74, 20);
            this.rdoMarried.TabIndex = 10;
            this.rdoMarried.TabStop = true;
            this.rdoMarried.Text = "Married";
            this.rdoMarried.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Qualification";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // chkDiploma
            // 
            this.chkDiploma.AutoSize = true;
            this.chkDiploma.Location = new System.Drawing.Point(29, 374);
            this.chkDiploma.Name = "chkDiploma";
            this.chkDiploma.Size = new System.Drawing.Size(80, 20);
            this.chkDiploma.TabIndex = 11;
            this.chkDiploma.Text = "Diploma";
            this.chkDiploma.UseVisualStyleBackColor = true;
            // 
            // chkUG
            // 
            this.chkUG.AutoSize = true;
            this.chkUG.Location = new System.Drawing.Point(29, 400);
            this.chkUG.Name = "chkUG";
            this.chkUG.Size = new System.Drawing.Size(49, 20);
            this.chkUG.TabIndex = 12;
            this.chkUG.Text = "UG";
            this.chkUG.UseVisualStyleBackColor = true;
            // 
            // chkPG
            // 
            this.chkPG.AutoSize = true;
            this.chkPG.Location = new System.Drawing.Point(30, 426);
            this.chkPG.Name = "chkPG";
            this.chkPG.Size = new System.Drawing.Size(48, 20);
            this.chkPG.TabIndex = 13;
            this.chkPG.Text = "PG";
            this.chkPG.UseVisualStyleBackColor = true;
            // 
            // Experience
            // 
            this.Experience.AutoSize = true;
            this.Experience.Location = new System.Drawing.Point(26, 459);
            this.Experience.Name = "Experience";
            this.Experience.Size = new System.Drawing.Size(75, 16);
            this.Experience.TabIndex = 14;
            this.Experience.Text = "Experience";
            this.Experience.Click += new System.EventHandler(this.Experience_Click);
            // 
            // cmbExperience
            // 
            this.cmbExperience.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbExperience.FormattingEnabled = true;
            this.cmbExperience.Items.AddRange(new object[] {
            "Fresher",
            "1-2 Years",
            "2-5 Years",
            "5+ Years"});
            this.cmbExperience.Location = new System.Drawing.Point(30, 488);
            this.cmbExperience.Name = "cmbExperience";
            this.cmbExperience.Size = new System.Drawing.Size(121, 24);
            this.cmbExperience.TabIndex = 15;
            this.cmbExperience.SelectedIndexChanged += new System.EventHandler(this.cmbExperience_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(365, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "About Project";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // rtbProject
            // 
            this.rtbProject.Location = new System.Drawing.Point(368, 342);
            this.rtbProject.Name = "rtbProject";
            this.rtbProject.Size = new System.Drawing.Size(385, 110);
            this.rtbProject.TabIndex = 17;
            this.rtbProject.Text = "";
            this.rtbProject.TextChanged += new System.EventHandler(this.rtbProject_TextChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(735, 533);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 18;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(104, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 19;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // frmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(882, 603);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.rtbProject);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbExperience);
            this.Controls.Add(this.Experience);
            this.Controls.Add(this.chkPG);
            this.Controls.Add(this.chkUG);
            this.Controls.Add(this.chkDiploma);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.DateofBirth);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.picPhoto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTitle);
            this.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.Name = "frmStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Registration Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picPhoto;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Label DateofBirth;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdoUnmarried;
        private System.Windows.Forms.RadioButton rdoMarried;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkDiploma;
        private System.Windows.Forms.CheckBox chkUG;
        private System.Windows.Forms.CheckBox chkPG;
        private System.Windows.Forms.Label Experience;
        private System.Windows.Forms.ComboBox cmbExperience;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtbProject;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox textBox1;
    }
}

