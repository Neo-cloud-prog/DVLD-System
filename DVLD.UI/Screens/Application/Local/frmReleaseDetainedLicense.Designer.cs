namespace DVLD.UI.Screens.Application.Local
{
    partial class frmReleaseDetainedLicense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReleaseDetainedLicense));
            this.screenHeader1 = new DVLD.UI.UserControls.Shared.ScreenHeader();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbRDLAppID = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbFineFees = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbTotalFees = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbAppFees = new System.Windows.Forms.Label();
            this.lbUserName = new System.Windows.Forms.Label();
            this.lbLicenseID = new System.Windows.Forms.Label();
            this.lbDetainDate = new System.Windows.Forms.Label();
            this.lbDetainID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ibtnRelease = new DVLD.UI.UserControls.Shared.IconButton();
            this.ibtnClose = new DVLD.UI.UserControls.Shared.IconButton();
            this.lnkShowLicenseHistory = new System.Windows.Forms.LinkLabel();
            this.lnkShowLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.DrivingLicenseInfoWithFilter = new DVLD.UI.UserControls.License.Local.DrivingLicenseInfoWithFilter();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // screenHeader1
            // 
            this.screenHeader1.BackColor = System.Drawing.Color.White;
            this.screenHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.screenHeader1.Location = new System.Drawing.Point(0, 0);
            this.screenHeader1.Name = "screenHeader1";
            this.screenHeader1.Size = new System.Drawing.Size(705, 58);
            this.screenHeader1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbRDLAppID);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lbFineFees);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lbTotalFees);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lbAppFees);
            this.groupBox1.Controls.Add(this.lbUserName);
            this.groupBox1.Controls.Add(this.lbLicenseID);
            this.groupBox1.Controls.Add(this.lbDetainDate);
            this.groupBox1.Controls.Add(this.lbDetainID);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 410);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(681, 140);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detain Info";
            // 
            // lbRDLAppID
            // 
            this.lbRDLAppID.AutoSize = true;
            this.lbRDLAppID.Location = new System.Drawing.Point(388, 102);
            this.lbRDLAppID.Name = "lbRDLAppID";
            this.lbRDLAppID.Size = new System.Drawing.Size(25, 13);
            this.lbRDLAppID.TabIndex = 15;
            this.lbRDLAppID.Text = "???";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(302, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "R.D.L AppID   :";
            // 
            // lbFineFees
            // 
            this.lbFineFees.AutoSize = true;
            this.lbFineFees.Location = new System.Drawing.Point(388, 79);
            this.lbFineFees.Name = "lbFineFees";
            this.lbFineFees.Size = new System.Drawing.Size(25, 13);
            this.lbFineFees.TabIndex = 13;
            this.lbFineFees.Text = "???";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(302, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Fine Fees        :";
            // 
            // lbTotalFees
            // 
            this.lbTotalFees.AutoSize = true;
            this.lbTotalFees.Location = new System.Drawing.Point(100, 102);
            this.lbTotalFees.Name = "lbTotalFees";
            this.lbTotalFees.Size = new System.Drawing.Size(25, 13);
            this.lbTotalFees.TabIndex = 11;
            this.lbTotalFees.Text = "???";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Total Fees    :";
            // 
            // lbAppFees
            // 
            this.lbAppFees.AutoSize = true;
            this.lbAppFees.Location = new System.Drawing.Point(100, 79);
            this.lbAppFees.Name = "lbAppFees";
            this.lbAppFees.Size = new System.Drawing.Size(25, 13);
            this.lbAppFees.TabIndex = 9;
            this.lbAppFees.Text = "???";
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Location = new System.Drawing.Point(388, 56);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(25, 13);
            this.lbUserName.TabIndex = 8;
            this.lbUserName.Text = "???";
            // 
            // lbLicenseID
            // 
            this.lbLicenseID.AutoSize = true;
            this.lbLicenseID.Location = new System.Drawing.Point(388, 34);
            this.lbLicenseID.Name = "lbLicenseID";
            this.lbLicenseID.Size = new System.Drawing.Size(25, 13);
            this.lbLicenseID.TabIndex = 7;
            this.lbLicenseID.Text = "???";
            // 
            // lbDetainDate
            // 
            this.lbDetainDate.AutoSize = true;
            this.lbDetainDate.Location = new System.Drawing.Point(100, 56);
            this.lbDetainDate.Name = "lbDetainDate";
            this.lbDetainDate.Size = new System.Drawing.Size(53, 13);
            this.lbDetainDate.TabIndex = 6;
            this.lbDetainDate.Text = "0/0/0000";
            // 
            // lbDetainID
            // 
            this.lbDetainID.AutoSize = true;
            this.lbDetainID.Location = new System.Drawing.Point(100, 34);
            this.lbDetainID.Name = "lbDetainID";
            this.lbDetainID.Size = new System.Drawing.Size(25, 13);
            this.lbDetainID.TabIndex = 5;
            this.lbDetainID.Text = "???";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(302, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Created By      :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(302, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "License ID      :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "App Fees     :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Datain Date :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datain ID     :";
            // 
            // ibtnRelease
            // 
            this.ibtnRelease.BakColor = System.Drawing.Color.Snow;
            this.ibtnRelease.Icon = ((System.Drawing.Image)(resources.GetObject("ibtnRelease.Icon")));
            this.ibtnRelease.IconSize = new System.Drawing.Size(24, 24);
            this.ibtnRelease.Location = new System.Drawing.Point(585, 561);
            this.ibtnRelease.Name = "ibtnRelease";
            this.ibtnRelease.Size = new System.Drawing.Size(108, 43);
            this.ibtnRelease.TabIndex = 7;
            this.ibtnRelease.TextColor = System.Drawing.Color.Black;
            this.ibtnRelease.Value = "Release";
            this.ibtnRelease.Click += new System.EventHandler(this.ibtnRelease_Click);
            // 
            // ibtnClose
            // 
            this.ibtnClose.BakColor = System.Drawing.Color.Tomato;
            this.ibtnClose.Icon = ((System.Drawing.Image)(resources.GetObject("ibtnClose.Icon")));
            this.ibtnClose.IconSize = new System.Drawing.Size(24, 24);
            this.ibtnClose.Location = new System.Drawing.Point(471, 561);
            this.ibtnClose.Name = "ibtnClose";
            this.ibtnClose.Size = new System.Drawing.Size(108, 43);
            this.ibtnClose.TabIndex = 6;
            this.ibtnClose.TextColor = System.Drawing.Color.Black;
            this.ibtnClose.Value = "Close";
            this.ibtnClose.Click += new System.EventHandler(this.ibtnClose_Click);
            // 
            // lnkShowLicenseHistory
            // 
            this.lnkShowLicenseHistory.AutoSize = true;
            this.lnkShowLicenseHistory.Enabled = false;
            this.lnkShowLicenseHistory.Location = new System.Drawing.Point(12, 582);
            this.lnkShowLicenseHistory.Name = "lnkShowLicenseHistory";
            this.lnkShowLicenseHistory.Size = new System.Drawing.Size(109, 13);
            this.lnkShowLicenseHistory.TabIndex = 44;
            this.lnkShowLicenseHistory.TabStop = true;
            this.lnkShowLicenseHistory.Text = "Show License History";
            this.lnkShowLicenseHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkShowLicenseHistory_LinkClicked);
            // 
            // lnkShowLicenseInfo
            // 
            this.lnkShowLicenseInfo.AutoSize = true;
            this.lnkShowLicenseInfo.Enabled = false;
            this.lnkShowLicenseInfo.Location = new System.Drawing.Point(147, 582);
            this.lnkShowLicenseInfo.Name = "lnkShowLicenseInfo";
            this.lnkShowLicenseInfo.Size = new System.Drawing.Size(95, 13);
            this.lnkShowLicenseInfo.TabIndex = 45;
            this.lnkShowLicenseInfo.TabStop = true;
            this.lnkShowLicenseInfo.Text = "Show License Info";
            this.lnkShowLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkShowLicenseInfo_LinkClicked);
            // 
            // DrivingLicenseInfoWithFilter
            // 
            this.DrivingLicenseInfoWithFilter.BackColor = System.Drawing.Color.White;
            this.DrivingLicenseInfoWithFilter.Location = new System.Drawing.Point(11, 64);
            this.DrivingLicenseInfoWithFilter.Name = "DrivingLicenseInfoWithFilter";
            this.DrivingLicenseInfoWithFilter.Size = new System.Drawing.Size(682, 340);
            this.DrivingLicenseInfoWithFilter.TabIndex = 46;
            this.DrivingLicenseInfoWithFilter.OnDataChanged += new System.EventHandler<DVLD.UI.Events.License.clsLicenseEventArgs>(DrivingLicenseInfoWithFilter_OnLicenseFound);
            // 
            // frmReleaseDetainedLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(705, 616);
            this.Controls.Add(this.DrivingLicenseInfoWithFilter);
            this.Controls.Add(this.lnkShowLicenseHistory);
            this.Controls.Add(this.lnkShowLicenseInfo);
            this.Controls.Add(this.ibtnRelease);
            this.Controls.Add(this.ibtnClose);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.screenHeader1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmReleaseDetainedLicense";
            this.Text = "frmReleaseDetainedLicense";
            this.Load += new System.EventHandler(this.frmReleaseDetainedLicense_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Shared.ScreenHeader screenHeader1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbAppFees;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Label lbLicenseID;
        private System.Windows.Forms.Label lbDetainDate;
        private System.Windows.Forms.Label lbDetainID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbRDLAppID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbFineFees;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbTotalFees;
        private System.Windows.Forms.Label label7;
        private UserControls.Shared.IconButton ibtnRelease;
        private UserControls.Shared.IconButton ibtnClose;
        private System.Windows.Forms.LinkLabel lnkShowLicenseHistory;
        private System.Windows.Forms.LinkLabel lnkShowLicenseInfo;
        private UserControls.License.Local.DrivingLicenseInfoWithFilter DrivingLicenseInfoWithFilter;
    }
}