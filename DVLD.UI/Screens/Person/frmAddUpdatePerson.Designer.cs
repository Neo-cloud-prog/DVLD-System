namespace DVLD.UI.Screens.Person
{
    partial class frmAddUpdatePerson
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddUpdatePerson));
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.tbNationalNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbThird = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSecond = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbFirst = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbPersonID = new System.Windows.Forms.Label();
            this.tbLast = new System.Windows.Forms.TextBox();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbPerson = new System.Windows.Forms.GroupBox();
            this.lnkRemoveImage = new System.Windows.Forms.LinkLabel();
            this.lnkSetImage = new System.Windows.Forms.LinkLabel();
            this.pbPerson = new System.Windows.Forms.PictureBox();
            this.btnClose = new DVLD.UI.UserControls.Shared.IconButton();
            this.btnSave = new DVLD.UI.UserControls.Shared.IconButton();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbCountries = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.OpenFileDialogImage = new System.Windows.Forms.OpenFileDialog();
            this.lbTitle = new System.Windows.Forms.Label();
            this.AddUpdatePersonErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.CenterControlContainer = new DVLD.UI.UserControls.Shared.CenterControlContainer();
            this.AddUpdatePersonValidator = new DVLD.UI.Components.Validation.Validator(this.components);
            this.panel1.SuspendLayout();
            this.gbPerson.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerson)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddUpdatePersonErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Person ID :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "Gender :";
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateOfBirth.Location = new System.Drawing.Point(407, 94);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(100, 20);
            this.dtpDateOfBirth.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(271, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Date Of Birth :";
            // 
            // tbNationalNo
            // 
            this.tbNationalNo.Location = new System.Drawing.Point(123, 90);
            this.tbNationalNo.Name = "tbNationalNo";
            this.tbNationalNo.Size = new System.Drawing.Size(100, 20);
            this.tbNationalNo.TabIndex = 13;
            this.tbNationalNo.Leave += new System.EventHandler(this.tbNationalNo_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "National No :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(435, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Third";
            // 
            // tbThird
            // 
            this.tbThird.Location = new System.Drawing.Point(407, 49);
            this.tbThird.Name = "tbThird";
            this.tbThird.Size = new System.Drawing.Size(100, 20);
            this.tbThird.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(578, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Last";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(289, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Second";
            // 
            // tbSecond
            // 
            this.tbSecond.Location = new System.Drawing.Point(268, 48);
            this.tbSecond.Name = "tbSecond";
            this.tbSecond.Size = new System.Drawing.Size(100, 20);
            this.tbSecond.TabIndex = 6;
            this.tbSecond.Leave += new System.EventHandler(this.CheckIfFieldFull_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(153, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "First";
            // 
            // tbFirst
            // 
            this.tbFirst.Location = new System.Drawing.Point(123, 48);
            this.tbFirst.Name = "tbFirst";
            this.tbFirst.Size = new System.Drawing.Size(100, 20);
            this.tbFirst.TabIndex = 4;
            this.tbFirst.Leave += new System.EventHandler(this.CheckIfFieldFull_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name :";
            // 
            // lbPersonID
            // 
            this.lbPersonID.AutoSize = true;
            this.lbPersonID.Location = new System.Drawing.Point(101, 88);
            this.lbPersonID.Name = "lbPersonID";
            this.lbPersonID.Size = new System.Drawing.Size(27, 13);
            this.lbPersonID.TabIndex = 3;
            this.lbPersonID.Text = "N/A";
            // 
            // tbLast
            // 
            this.tbLast.Location = new System.Drawing.Point(548, 48);
            this.tbLast.Name = "tbLast";
            this.tbLast.Size = new System.Drawing.Size(100, 20);
            this.tbLast.TabIndex = 8;
            this.tbLast.Leave += new System.EventHandler(this.CheckIfFieldFull_Leave);
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(57, 3);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(59, 17);
            this.rbFemale.TabIndex = 1;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            this.rbFemale.Click += new System.EventHandler(this.RedioButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.gbPerson);
            this.panel1.Controls.Add(this.lbPersonID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 1;
            // 
            // gbPerson
            // 
            this.gbPerson.Controls.Add(this.lnkRemoveImage);
            this.gbPerson.Controls.Add(this.lnkSetImage);
            this.gbPerson.Controls.Add(this.pbPerson);
            this.gbPerson.Controls.Add(this.btnClose);
            this.gbPerson.Controls.Add(this.btnSave);
            this.gbPerson.Controls.Add(this.tbAddress);
            this.gbPerson.Controls.Add(this.label13);
            this.gbPerson.Controls.Add(this.cmbCountries);
            this.gbPerson.Controls.Add(this.label12);
            this.gbPerson.Controls.Add(this.tbEmail);
            this.gbPerson.Controls.Add(this.label11);
            this.gbPerson.Controls.Add(this.tbPhone);
            this.gbPerson.Controls.Add(this.label10);
            this.gbPerson.Controls.Add(this.panel2);
            this.gbPerson.Controls.Add(this.label9);
            this.gbPerson.Controls.Add(this.dtpDateOfBirth);
            this.gbPerson.Controls.Add(this.label8);
            this.gbPerson.Controls.Add(this.tbNationalNo);
            this.gbPerson.Controls.Add(this.label7);
            this.gbPerson.Controls.Add(this.label6);
            this.gbPerson.Controls.Add(this.tbThird);
            this.gbPerson.Controls.Add(this.label5);
            this.gbPerson.Controls.Add(this.tbLast);
            this.gbPerson.Controls.Add(this.label4);
            this.gbPerson.Controls.Add(this.tbSecond);
            this.gbPerson.Controls.Add(this.label3);
            this.gbPerson.Controls.Add(this.tbFirst);
            this.gbPerson.Controls.Add(this.label2);
            this.gbPerson.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gbPerson.Location = new System.Drawing.Point(12, 118);
            this.gbPerson.Name = "gbPerson";
            this.gbPerson.Size = new System.Drawing.Size(776, 329);
            this.gbPerson.TabIndex = 4;
            this.gbPerson.TabStop = false;
            // 
            // lnkRemoveImage
            // 
            this.lnkRemoveImage.AutoSize = true;
            this.lnkRemoveImage.Location = new System.Drawing.Point(625, 282);
            this.lnkRemoveImage.Name = "lnkRemoveImage";
            this.lnkRemoveImage.Size = new System.Drawing.Size(47, 13);
            this.lnkRemoveImage.TabIndex = 30;
            this.lnkRemoveImage.TabStop = true;
            this.lnkRemoveImage.Text = "Remove";
            this.lnkRemoveImage.Visible = false;
            this.lnkRemoveImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkRemoveImage_LinkClicked);
            // 
            // lnkSetImage
            // 
            this.lnkSetImage.AutoSize = true;
            this.lnkSetImage.Location = new System.Drawing.Point(620, 247);
            this.lnkSetImage.Name = "lnkSetImage";
            this.lnkSetImage.Size = new System.Drawing.Size(52, 13);
            this.lnkSetImage.TabIndex = 29;
            this.lnkSetImage.TabStop = true;
            this.lnkSetImage.Text = "SetImage";
            this.lnkSetImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSetImage_LinkClicked);
            // 
            // pbPerson
            // 
            this.pbPerson.Image = global::DVLD.UI.Properties.Resources.unknown;
            this.pbPerson.Location = new System.Drawing.Point(548, 94);
            this.pbPerson.Name = "pbPerson";
            this.pbPerson.Size = new System.Drawing.Size(189, 141);
            this.pbPerson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPerson.TabIndex = 28;
            this.pbPerson.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BakColor = System.Drawing.Color.Snow;
            this.btnClose.Icon = ((System.Drawing.Image)(resources.GetObject("btnClose.Icon")));
            this.btnClose.IconSize = new System.Drawing.Size(24, 24);
            this.btnClose.Location = new System.Drawing.Point(335, 282);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(83, 36);
            this.btnClose.TabIndex = 27;
            this.btnClose.TextColor = System.Drawing.Color.Black;
            this.btnClose.Value = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.BakColor = System.Drawing.Color.Snow;
            this.btnSave.Icon = ((System.Drawing.Image)(resources.GetObject("btnSave.Icon")));
            this.btnSave.IconSize = new System.Drawing.Size(24, 24);
            this.btnSave.Location = new System.Drawing.Point(424, 282);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 36);
            this.btnSave.TabIndex = 26;
            this.btnSave.TextColor = System.Drawing.Color.Black;
            this.btnSave.Value = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(123, 219);
            this.tbAddress.Multiline = true;
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(384, 57);
            this.tbAddress.TabIndex = 25;
            this.tbAddress.Leave += new System.EventHandler(this.CheckIfFieldFull_Leave);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(6, 219);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 16);
            this.label13.TabIndex = 24;
            this.label13.Text = "Address :";
            // 
            // cmbCountries
            // 
            this.cmbCountries.FormattingEnabled = true;
            this.cmbCountries.Location = new System.Drawing.Point(407, 176);
            this.cmbCountries.Name = "cmbCountries";
            this.cmbCountries.Size = new System.Drawing.Size(100, 21);
            this.cmbCountries.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(301, 179);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 16);
            this.label12.TabIndex = 22;
            this.label12.Text = "Country :";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(123, 178);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(100, 20);
            this.tbEmail.TabIndex = 21;
            this.tbEmail.Leave += new System.EventHandler(this.tbEmail_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 178);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 16);
            this.label11.TabIndex = 20;
            this.label11.Text = "Email :";
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(407, 140);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(100, 20);
            this.tbPhone.TabIndex = 19;
            this.tbPhone.Leave += new System.EventHandler(this.CheckIfFieldFull_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(309, 140);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 16);
            this.label10.TabIndex = 18;
            this.label10.Text = "Phone :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbFemale);
            this.panel2.Controls.Add(this.rbMale);
            this.panel2.Location = new System.Drawing.Point(123, 137);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(118, 24);
            this.panel2.TabIndex = 5;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Checked = true;
            this.rbMale.Location = new System.Drawing.Point(3, 3);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(48, 17);
            this.rbMale.TabIndex = 0;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            this.rbMale.Click += new System.EventHandler(this.RedioButton_Click);
            // 
            // OpenFileDialogImage
            // 
            this.OpenFileDialogImage.FileName = "openFileDialog1";
            this.OpenFileDialogImage.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.BackColor = System.Drawing.Color.White;
            this.lbTitle.Font = new System.Drawing.Font("Magneto", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.Crimson;
            this.lbTitle.Location = new System.Drawing.Point(351, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(114, 45);
            this.lbTitle.TabIndex = 5;
            this.lbTitle.Text = "Titel";
            // 
            // AddUpdatePersonErrorProvider
            // 
            this.AddUpdatePersonErrorProvider.ContainerControl = this;
            // 
            // CenterControlContainer
            // 
            this.CenterControlContainer.AutoScroll = true;
            this.CenterControlContainer.BackColor = System.Drawing.Color.White;
            this.CenterControlContainer.Location = new System.Drawing.Point(0, 0);
            this.CenterControlContainer.Name = "CenterControlContainer";
            this.CenterControlContainer.Size = new System.Drawing.Size(816, 50);
            this.CenterControlContainer.TabIndex = 2;
            // 
            // frmAddUpdatePerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CenterControlContainer);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddUpdatePerson";
            this.Text = "Add / Edit Person info";
            this.Load += new System.EventHandler(this.frmAddUpdatePerson_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbPerson.ResumeLayout(false);
            this.gbPerson.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerson)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddUpdatePersonErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbNationalNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbThird;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSecond;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbFirst;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbPersonID;
        private System.Windows.Forms.TextBox tbLast;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbPerson;
        private System.Windows.Forms.LinkLabel lnkRemoveImage;
        private System.Windows.Forms.LinkLabel lnkSetImage;
        private System.Windows.Forms.PictureBox pbPerson;
        private UserControls.Shared.IconButton btnClose;
        private UserControls.Shared.IconButton btnSave;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbCountries;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.OpenFileDialog OpenFileDialogImage;
        private UserControls.Shared.CenterControlContainer CenterControlContainer;
        private System.Windows.Forms.Label lbTitle;
        private Components.Validation.Validator AddUpdatePersonValidator;
        private System.Windows.Forms.ErrorProvider AddUpdatePersonErrorProvider;
    }
}