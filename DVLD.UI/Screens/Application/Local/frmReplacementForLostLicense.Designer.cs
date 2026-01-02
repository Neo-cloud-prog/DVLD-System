namespace DVLD.UI.Screens.Application.Local
{
    partial class frmReplacementForLostLicense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReplacementForLostLicense));
            this.ibtnClose = new DVLD.UI.UserControls.Shared.IconButton();
            this.ibtnSave = new DVLD.UI.UserControls.Shared.IconButton();
            this.lnkShowLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.lnkShowLicenseHistory = new System.Windows.Forms.LinkLabel();
            this.screenHeader1 = new DVLD.UI.UserControls.Shared.ScreenHeader();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbLostLicense = new System.Windows.Forms.RadioButton();
            this.rbDamagedLicense = new System.Windows.Forms.RadioButton();
            this.ApplicationInfoForReplacement = new System.Windows.Forms.GroupBox();
            this.lbUsername = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbOldLicenseID = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbReplacedLicesneID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbAppFees = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbAppDate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbLRAppID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DrivingLicenseInfoWithFilter = new DVLD.UI.UserControls.License.Local.DrivingLicenseInfoWithFilter();
            this.groupBox1.SuspendLayout();
            this.ApplicationInfoForReplacement.SuspendLayout();
            this.SuspendLayout();
            // 
            // ibtnClose
            // 
            this.ibtnClose.BakColor = System.Drawing.Color.Salmon;
            this.ibtnClose.Icon = ((System.Drawing.Image)(resources.GetObject("ibtnClose.Icon")));
            this.ibtnClose.IconSize = new System.Drawing.Size(24, 24);
            this.ibtnClose.Location = new System.Drawing.Point(504, 561);
            this.ibtnClose.Name = "ibtnClose";
            this.ibtnClose.Size = new System.Drawing.Size(93, 38);
            this.ibtnClose.TabIndex = 8;
            this.ibtnClose.TextColor = System.Drawing.Color.Black;
            this.ibtnClose.Value = "Close";
            this.ibtnClose.Click += new System.EventHandler(this.ibtnClose_Click);
            // 
            // ibtnSave
            // 
            this.ibtnSave.BakColor = System.Drawing.Color.White;
            this.ibtnSave.Icon = ((System.Drawing.Image)(resources.GetObject("ibtnSave.Icon")));
            this.ibtnSave.IconSize = new System.Drawing.Size(24, 24);
            this.ibtnSave.Location = new System.Drawing.Point(603, 561);
            this.ibtnSave.Name = "ibtnSave";
            this.ibtnSave.Size = new System.Drawing.Size(87, 38);
            this.ibtnSave.TabIndex = 15;
            this.ibtnSave.TextColor = System.Drawing.Color.Black;
            this.ibtnSave.Value = "Save";
            this.ibtnSave.Click += new System.EventHandler(this.ibtnSave_OnClick);
            // 
            // lnkShowLicenseInfo
            // 
            this.lnkShowLicenseInfo.AutoSize = true;
            this.lnkShowLicenseInfo.Enabled = false;
            this.lnkShowLicenseInfo.Location = new System.Drawing.Point(148, 586);
            this.lnkShowLicenseInfo.Name = "lnkShowLicenseInfo";
            this.lnkShowLicenseInfo.Size = new System.Drawing.Size(95, 13);
            this.lnkShowLicenseInfo.TabIndex = 14;
            this.lnkShowLicenseInfo.TabStop = true;
            this.lnkShowLicenseInfo.Text = "Show License Info";
            this.lnkShowLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkShowLicenseInfo_LinkClicked);
            // 
            // lnkShowLicenseHistory
            // 
            this.lnkShowLicenseHistory.AutoSize = true;
            this.lnkShowLicenseHistory.Enabled = false;
            this.lnkShowLicenseHistory.Location = new System.Drawing.Point(13, 586);
            this.lnkShowLicenseHistory.Name = "lnkShowLicenseHistory";
            this.lnkShowLicenseHistory.Size = new System.Drawing.Size(109, 13);
            this.lnkShowLicenseHistory.TabIndex = 13;
            this.lnkShowLicenseHistory.TabStop = true;
            this.lnkShowLicenseHistory.Text = "Show License History";
            // 
            // screenHeader1
            // 
            this.screenHeader1.BackColor = System.Drawing.Color.White;
            this.screenHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.screenHeader1.Location = new System.Drawing.Point(0, 0);
            this.screenHeader1.Name = "screenHeader1";
            this.screenHeader1.Size = new System.Drawing.Size(704, 55);
            this.screenHeader1.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbLostLicense);
            this.groupBox1.Controls.Add(this.rbDamagedLicense);
            this.groupBox1.Location = new System.Drawing.Point(479, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 82);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Replace For";
            // 
            // rbLostLicense
            // 
            this.rbLostLicense.AutoSize = true;
            this.rbLostLicense.Location = new System.Drawing.Point(7, 52);
            this.rbLostLicense.Name = "rbLostLicense";
            this.rbLostLicense.Size = new System.Drawing.Size(85, 17);
            this.rbLostLicense.TabIndex = 1;
            this.rbLostLicense.Tag = "3";
            this.rbLostLicense.Text = "Lost License";
            this.rbLostLicense.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbLostLicense.UseVisualStyleBackColor = true;
            this.rbLostLicense.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // rbDamagedLicense
            // 
            this.rbDamagedLicense.AutoSize = true;
            this.rbDamagedLicense.Checked = true;
            this.rbDamagedLicense.Location = new System.Drawing.Point(7, 19);
            this.rbDamagedLicense.Name = "rbDamagedLicense";
            this.rbDamagedLicense.Size = new System.Drawing.Size(111, 17);
            this.rbDamagedLicense.TabIndex = 0;
            this.rbDamagedLicense.TabStop = true;
            this.rbDamagedLicense.Tag = "4";
            this.rbDamagedLicense.Text = "Damaged License";
            this.rbDamagedLicense.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbDamagedLicense.UseVisualStyleBackColor = true;
            this.rbDamagedLicense.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // ApplicationInfoForReplacement
            // 
            this.ApplicationInfoForReplacement.Controls.Add(this.lbUsername);
            this.ApplicationInfoForReplacement.Controls.Add(this.label6);
            this.ApplicationInfoForReplacement.Controls.Add(this.lbOldLicenseID);
            this.ApplicationInfoForReplacement.Controls.Add(this.label8);
            this.ApplicationInfoForReplacement.Controls.Add(this.lbReplacedLicesneID);
            this.ApplicationInfoForReplacement.Controls.Add(this.label5);
            this.ApplicationInfoForReplacement.Controls.Add(this.lbAppFees);
            this.ApplicationInfoForReplacement.Controls.Add(this.label4);
            this.ApplicationInfoForReplacement.Controls.Add(this.lbAppDate);
            this.ApplicationInfoForReplacement.Controls.Add(this.label3);
            this.ApplicationInfoForReplacement.Controls.Add(this.lbLRAppID);
            this.ApplicationInfoForReplacement.Controls.Add(this.label1);
            this.ApplicationInfoForReplacement.Location = new System.Drawing.Point(16, 450);
            this.ApplicationInfoForReplacement.Name = "ApplicationInfoForReplacement";
            this.ApplicationInfoForReplacement.Size = new System.Drawing.Size(676, 100);
            this.ApplicationInfoForReplacement.TabIndex = 17;
            this.ApplicationInfoForReplacement.TabStop = false;
            this.ApplicationInfoForReplacement.Text = "Application info for replacement";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Location = new System.Drawing.Point(443, 73);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(25, 13);
            this.lbUsername.TabIndex = 13;
            this.lbUsername.Text = "???";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(324, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Created By                 :";
            // 
            // lbOldLicenseID
            // 
            this.lbOldLicenseID.AutoSize = true;
            this.lbOldLicenseID.Location = new System.Drawing.Point(443, 51);
            this.lbOldLicenseID.Name = "lbOldLicenseID";
            this.lbOldLicenseID.Size = new System.Drawing.Size(25, 13);
            this.lbOldLicenseID.TabIndex = 11;
            this.lbOldLicenseID.Text = "???";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(324, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Old License ID           :";
            // 
            // lbReplacedLicesneID
            // 
            this.lbReplacedLicesneID.AutoSize = true;
            this.lbReplacedLicesneID.Location = new System.Drawing.Point(443, 26);
            this.lbReplacedLicesneID.Name = "lbReplacedLicesneID";
            this.lbReplacedLicesneID.Size = new System.Drawing.Size(25, 13);
            this.lbReplacedLicesneID.TabIndex = 7;
            this.lbReplacedLicesneID.Text = "???";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(324, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Replaced Licesne ID :";
            // 
            // lbAppFees
            // 
            this.lbAppFees.AutoSize = true;
            this.lbAppFees.Location = new System.Drawing.Point(74, 73);
            this.lbAppFees.Name = "lbAppFees";
            this.lbAppFees.Size = new System.Drawing.Size(25, 13);
            this.lbAppFees.TabIndex = 5;
            this.lbAppFees.Text = "???";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "App Fees    :";
            // 
            // lbAppDate
            // 
            this.lbAppDate.AutoSize = true;
            this.lbAppDate.Location = new System.Drawing.Point(75, 51);
            this.lbAppDate.Name = "lbAppDate";
            this.lbAppDate.Size = new System.Drawing.Size(25, 13);
            this.lbAppDate.TabIndex = 3;
            this.lbAppDate.Text = "???";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "App Date    :";
            // 
            // lbLRAppID
            // 
            this.lbLRAppID.AutoSize = true;
            this.lbLRAppID.Location = new System.Drawing.Point(75, 26);
            this.lbLRAppID.Name = "lbLRAppID";
            this.lbLRAppID.Size = new System.Drawing.Size(25, 13);
            this.lbLRAppID.TabIndex = 1;
            this.lbLRAppID.Text = "???";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "L.R App ID :";
            // 
            // DrivingLicenseInfoWithFilter
            // 
            this.DrivingLicenseInfoWithFilter.BackColor = System.Drawing.Color.White;
            this.DrivingLicenseInfoWithFilter.Location = new System.Drawing.Point(16, 104);
            this.DrivingLicenseInfoWithFilter.Name = "DrivingLicenseInfoWithFilter";
            this.DrivingLicenseInfoWithFilter.Size = new System.Drawing.Size(682, 340);
            this.DrivingLicenseInfoWithFilter.TabIndex = 19;
            // 
            // frmReplacementForLostLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(704, 606);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DrivingLicenseInfoWithFilter);
            this.Controls.Add(this.ApplicationInfoForReplacement);
            this.Controls.Add(this.ibtnClose);
            this.Controls.Add(this.ibtnSave);
            this.Controls.Add(this.lnkShowLicenseInfo);
            this.Controls.Add(this.lnkShowLicenseHistory);
            this.Controls.Add(this.screenHeader1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmReplacementForLostLicense";
            this.Text = "Replacement For LostLicnese";
            this.Load += new System.EventHandler(this.frmReplacementForLostLicense_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ApplicationInfoForReplacement.ResumeLayout(false);
            this.ApplicationInfoForReplacement.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Shared.IconButton ibtnClose;
        private UserControls.Shared.IconButton ibtnSave;
        private System.Windows.Forms.LinkLabel lnkShowLicenseInfo;
        private System.Windows.Forms.LinkLabel lnkShowLicenseHistory;
        private UserControls.Shared.ScreenHeader screenHeader1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbDamagedLicense;
        private System.Windows.Forms.RadioButton rbLostLicense;
        private System.Windows.Forms.GroupBox ApplicationInfoForReplacement;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbReplacedLicesneID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbAppFees;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbAppDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbLRAppID;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbOldLicenseID;
        private System.Windows.Forms.Label label8;
        private UserControls.License.Local.DrivingLicenseInfoWithFilter DrivingLicenseInfoWithFilter;
    }
}