namespace PersonalInfo
{
    partial class Personal_Information
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
            this.txtFname = new System.Windows.Forms.TextBox();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.lblFname = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblLname = new System.Windows.Forms.Label();
            this.dtpBday = new System.Windows.Forms.DateTimePicker();
            this.lblBday = new System.Windows.Forms.Label();
            this.cbMarital = new System.Windows.Forms.ComboBox();
            this.chkbHobby1 = new System.Windows.Forms.CheckBox();
            this.chkbHobby3 = new System.Windows.Forms.CheckBox();
            this.chkbHobby4 = new System.Windows.Forms.CheckBox();
            this.chkbHobby2 = new System.Windows.Forms.CheckBox();
            this.chkbHobby6 = new System.Windows.Forms.CheckBox();
            this.chkbHobby5 = new System.Windows.Forms.CheckBox();
            this.rbtnMale = new System.Windows.Forms.RadioButton();
            this.rbtnFemale = new System.Windows.Forms.RadioButton();
            this.lblMaritalStat = new System.Windows.Forms.Label();
            this.lblHobby = new System.Windows.Forms.Label();
            this.gbGender = new System.Windows.Forms.GroupBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.picboxImage = new System.Windows.Forms.PictureBox();
            this.btnBrowser = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.pbDisplay = new System.Windows.Forms.PictureBox();
            this.gbGender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFname
            // 
            this.txtFname.Location = new System.Drawing.Point(148, 188);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(153, 20);
            this.txtFname.TabIndex = 0;
            // 
            // txtLname
            // 
            this.txtLname.Location = new System.Drawing.Point(148, 214);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(153, 20);
            this.txtLname.TabIndex = 1;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(148, 240);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(153, 20);
            this.txtAddress.TabIndex = 2;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.SystemColors.Control;
            this.btnSubmit.Location = new System.Drawing.Point(142, 451);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btneventSubmit);
            // 
            // btnDisplay
            // 
            this.btnDisplay.BackColor = System.Drawing.SystemColors.Control;
            this.btnDisplay.Location = new System.Drawing.Point(247, 451);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(75, 23);
            this.btnDisplay.TabIndex = 4;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = false;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // lblFname
            // 
            this.lblFname.AutoSize = true;
            this.lblFname.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFname.Location = new System.Drawing.Point(44, 189);
            this.lblFname.Name = "lblFname";
            this.lblFname.Size = new System.Drawing.Size(68, 15);
            this.lblFname.TabIndex = 6;
            this.lblFname.Text = "First Name";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(44, 241);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(52, 15);
            this.lblAddress.TabIndex = 7;
            this.lblAddress.Text = "Address";
            // 
            // lblLname
            // 
            this.lblLname.AutoSize = true;
            this.lblLname.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLname.Location = new System.Drawing.Point(44, 215);
            this.lblLname.Name = "lblLname";
            this.lblLname.Size = new System.Drawing.Size(65, 15);
            this.lblLname.TabIndex = 8;
            this.lblLname.Text = "Last Name";
            // 
            // dtpBday
            // 
            this.dtpBday.Location = new System.Drawing.Point(148, 266);
            this.dtpBday.Name = "dtpBday";
            this.dtpBday.Size = new System.Drawing.Size(196, 20);
            this.dtpBday.TabIndex = 9;
            this.dtpBday.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lblBday
            // 
            this.lblBday.AutoSize = true;
            this.lblBday.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBday.Location = new System.Drawing.Point(44, 271);
            this.lblBday.Name = "lblBday";
            this.lblBday.Size = new System.Drawing.Size(55, 15);
            this.lblBday.TabIndex = 10;
            this.lblBday.Text = "Birthday";
            // 
            // cbMarital
            // 
            this.cbMarital.FormattingEnabled = true;
            this.cbMarital.Items.AddRange(new object[] {
            "Single",
            "Married",
            "Widow"});
            this.cbMarital.Location = new System.Drawing.Point(148, 292);
            this.cbMarital.Name = "cbMarital";
            this.cbMarital.Size = new System.Drawing.Size(121, 21);
            this.cbMarital.TabIndex = 11;
            this.cbMarital.Text = "-Select-";
            this.cbMarital.SelectedIndexChanged += new System.EventHandler(this.cbMarital_SelectedIndexChanged_1);
            // 
            // chkbHobby1
            // 
            this.chkbHobby1.AutoSize = true;
            this.chkbHobby1.Location = new System.Drawing.Point(148, 319);
            this.chkbHobby1.Name = "chkbHobby1";
            this.chkbHobby1.Size = new System.Drawing.Size(75, 17);
            this.chkbHobby1.TabIndex = 12;
            this.chkbHobby1.Text = "Basketball";
            this.chkbHobby1.UseVisualStyleBackColor = true;
            this.chkbHobby1.CheckedChanged += new System.EventHandler(this.chkbHobby1_CheckedChanged);
            // 
            // chkbHobby3
            // 
            this.chkbHobby3.AutoSize = true;
            this.chkbHobby3.Location = new System.Drawing.Point(148, 365);
            this.chkbHobby3.Name = "chkbHobby3";
            this.chkbHobby3.Size = new System.Drawing.Size(56, 17);
            this.chkbHobby3.TabIndex = 13;
            this.chkbHobby3.Text = "Hiking";
            this.chkbHobby3.UseVisualStyleBackColor = true;
            this.chkbHobby3.CheckedChanged += new System.EventHandler(this.chkbHobby3_CheckedChanged);
            // 
            // chkbHobby4
            // 
            this.chkbHobby4.AutoSize = true;
            this.chkbHobby4.Location = new System.Drawing.Point(234, 319);
            this.chkbHobby4.Name = "chkbHobby4";
            this.chkbHobby4.Size = new System.Drawing.Size(66, 17);
            this.chkbHobby4.TabIndex = 14;
            this.chkbHobby4.Text = "Running";
            this.chkbHobby4.UseVisualStyleBackColor = true;
            // 
            // chkbHobby2
            // 
            this.chkbHobby2.AutoSize = true;
            this.chkbHobby2.Location = new System.Drawing.Point(148, 342);
            this.chkbHobby2.Name = "chkbHobby2";
            this.chkbHobby2.Size = new System.Drawing.Size(73, 17);
            this.chkbHobby2.TabIndex = 15;
            this.chkbHobby2.Text = "Swimming";
            this.chkbHobby2.UseVisualStyleBackColor = true;
            this.chkbHobby2.CheckedChanged += new System.EventHandler(this.chkbHobby2_CheckedChanged);
            // 
            // chkbHobby6
            // 
            this.chkbHobby6.AutoSize = true;
            this.chkbHobby6.Location = new System.Drawing.Point(234, 365);
            this.chkbHobby6.Name = "chkbHobby6";
            this.chkbHobby6.Size = new System.Drawing.Size(62, 17);
            this.chkbHobby6.TabIndex = 16;
            this.chkbHobby6.Text = "Gaming";
            this.chkbHobby6.UseVisualStyleBackColor = true;
            this.chkbHobby6.CheckedChanged += new System.EventHandler(this.chkbHobby6_CheckedChanged);
            // 
            // chkbHobby5
            // 
            this.chkbHobby5.AutoSize = true;
            this.chkbHobby5.Location = new System.Drawing.Point(234, 342);
            this.chkbHobby5.Name = "chkbHobby5";
            this.chkbHobby5.Size = new System.Drawing.Size(66, 17);
            this.chkbHobby5.TabIndex = 17;
            this.chkbHobby5.Text = "Reading";
            this.chkbHobby5.UseVisualStyleBackColor = true;
            this.chkbHobby5.CheckedChanged += new System.EventHandler(this.chkbHobby5_CheckedChanged);
            // 
            // rbtnMale
            // 
            this.rbtnMale.AutoSize = true;
            this.rbtnMale.Location = new System.Drawing.Point(6, 19);
            this.rbtnMale.Name = "rbtnMale";
            this.rbtnMale.Size = new System.Drawing.Size(48, 17);
            this.rbtnMale.TabIndex = 18;
            this.rbtnMale.TabStop = true;
            this.rbtnMale.Text = "Male";
            this.rbtnMale.UseVisualStyleBackColor = true;
            // 
            // rbtnFemale
            // 
            this.rbtnFemale.AutoSize = true;
            this.rbtnFemale.Location = new System.Drawing.Point(97, 19);
            this.rbtnFemale.Name = "rbtnFemale";
            this.rbtnFemale.Size = new System.Drawing.Size(59, 17);
            this.rbtnFemale.TabIndex = 19;
            this.rbtnFemale.TabStop = true;
            this.rbtnFemale.Text = "Female";
            this.rbtnFemale.UseVisualStyleBackColor = true;
            // 
            // lblMaritalStat
            // 
            this.lblMaritalStat.AutoSize = true;
            this.lblMaritalStat.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaritalStat.Location = new System.Drawing.Point(44, 298);
            this.lblMaritalStat.Name = "lblMaritalStat";
            this.lblMaritalStat.Size = new System.Drawing.Size(86, 15);
            this.lblMaritalStat.TabIndex = 20;
            this.lblMaritalStat.Text = "Marital Status";
            // 
            // lblHobby
            // 
            this.lblHobby.AutoSize = true;
            this.lblHobby.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHobby.Location = new System.Drawing.Point(44, 321);
            this.lblHobby.Name = "lblHobby";
            this.lblHobby.Size = new System.Drawing.Size(50, 15);
            this.lblHobby.TabIndex = 21;
            this.lblHobby.Text = "Hobbies";
            // 
            // gbGender
            // 
            this.gbGender.Controls.Add(this.rbtnFemale);
            this.gbGender.Controls.Add(this.rbtnMale);
            this.gbGender.Location = new System.Drawing.Point(148, 388);
            this.gbGender.Name = "gbGender";
            this.gbGender.Size = new System.Drawing.Size(191, 54);
            this.gbGender.TabIndex = 22;
            this.gbGender.TabStop = false;
            this.gbGender.Enter += new System.EventHandler(this.gbGender_Enter);
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(44, 396);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(47, 15);
            this.lblGender.TabIndex = 23;
            this.lblGender.Text = "Gender";
            // 
            // picboxImage
            // 
            this.picboxImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picboxImage.Location = new System.Drawing.Point(148, 47);
            this.picboxImage.Name = "picboxImage";
            this.picboxImage.Size = new System.Drawing.Size(93, 91);
            this.picboxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxImage.TabIndex = 24;
            this.picboxImage.TabStop = false;
            this.picboxImage.Click += new System.EventHandler(this.pbImage);
            // 
            // btnBrowser
            // 
            this.btnBrowser.Location = new System.Drawing.Point(247, 115);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(92, 23);
            this.btnBrowser.TabIndex = 25;
            this.btnBrowser.Text = "Browser Image";
            this.btnBrowser.UseVisualStyleBackColor = true;
            this.btnBrowser.Click += new System.EventHandler(this.btneventBrowser);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // txtDisplay
            // 
            this.txtDisplay.Location = new System.Drawing.Point(447, 47);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.ReadOnly = true;
            this.txtDisplay.Size = new System.Drawing.Size(292, 427);
            this.txtDisplay.TabIndex = 26;
            this.txtDisplay.TextChanged += new System.EventHandler(this.txtDisplay_TextChanged);
            // 
            // pbDisplay
            // 
            this.pbDisplay.BackColor = System.Drawing.Color.LightYellow;
            this.pbDisplay.Location = new System.Drawing.Point(537, 74);
            this.pbDisplay.Name = "pbDisplay";
            this.pbDisplay.Size = new System.Drawing.Size(111, 98);
            this.pbDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDisplay.TabIndex = 27;
            this.pbDisplay.TabStop = false;
            this.pbDisplay.Click += new System.EventHandler(this.pbDisplay_Click);
            // 
            // Personal_Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(794, 589);
            this.Controls.Add(this.pbDisplay);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.btnBrowser);
            this.Controls.Add(this.picboxImage);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.gbGender);
            this.Controls.Add(this.lblHobby);
            this.Controls.Add(this.lblMaritalStat);
            this.Controls.Add(this.chkbHobby5);
            this.Controls.Add(this.chkbHobby6);
            this.Controls.Add(this.chkbHobby2);
            this.Controls.Add(this.chkbHobby4);
            this.Controls.Add(this.chkbHobby3);
            this.Controls.Add(this.chkbHobby1);
            this.Controls.Add(this.cbMarital);
            this.Controls.Add(this.lblBday);
            this.Controls.Add(this.dtpBday);
            this.Controls.Add(this.lblLname);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblFname);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtLname);
            this.Controls.Add(this.txtFname);
            this.MaximizeBox = false;
            this.Name = "Personal_Information";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personal Information";
            this.Load += new System.EventHandler(this.Personal_Information_Load);
            this.TextChanged += new System.EventHandler(this.txtFname_Textchange);
            this.gbGender.ResumeLayout(false);
            this.gbGender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Label lblFname;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblLname;
        private System.Windows.Forms.DateTimePicker dtpBday;
        private System.Windows.Forms.Label lblBday;
        private System.Windows.Forms.ComboBox cbMarital;
        private System.Windows.Forms.CheckBox chkbHobby1;
        private System.Windows.Forms.CheckBox chkbHobby3;
        private System.Windows.Forms.CheckBox chkbHobby4;
        private System.Windows.Forms.CheckBox chkbHobby2;
        private System.Windows.Forms.CheckBox chkbHobby6;
        private System.Windows.Forms.CheckBox chkbHobby5;
        private System.Windows.Forms.RadioButton rbtnMale;
        private System.Windows.Forms.RadioButton rbtnFemale;
        private System.Windows.Forms.Label lblMaritalStat;
        private System.Windows.Forms.Label lblHobby;
        private System.Windows.Forms.GroupBox gbGender;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.PictureBox picboxImage;
        private System.Windows.Forms.Button btnBrowser;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.PictureBox pbDisplay;
    }
}

