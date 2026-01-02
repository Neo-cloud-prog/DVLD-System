namespace DVLD.UI.Screens.License.Local
{
    partial class frmDetainLicense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetainLicense));
            this.screenHeader1 = new DVLD.UI.UserControls.Shared.ScreenHeader();
            this.ibtnClose = new DVLD.UI.UserControls.Shared.IconButton();
            this.ibtnDetain = new DVLD.UI.UserControls.Shared.IconButton();
            this.lnkShowLicenseHistory = new System.Windows.Forms.LinkLabel();
            this.lnkShowLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.gbDetainInfo = new System.Windows.Forms.GroupBox();
            this.tbFineFees = new System.Windows.Forms.TextBox();
            this.lbCreatedByUserID = new System.Windows.Forms.Label();
            this.lbLicenseID = new System.Windows.Forms.Label();
            this.lbDetainDate = new System.Windows.Forms.Label();
            this.lbDetainID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DetainErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.DrivingLicenseInfoWithFilter = new DVLD.UI.UserControls.License.Local.DrivingLicenseInfoWithFilter();
            this.gbDetainInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetainErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // screenHeader1
            // 
            this.screenHeader1.BackColor = System.Drawing.Color.White;
            this.screenHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.screenHeader1.Location = new System.Drawing.Point(0, 0);
            this.screenHeader1.Name = "screenHeader1";
            this.screenHeader1.Size = new System.Drawing.Size(702, 52);
            this.screenHeader1.TabIndex = 1;
            // 
            // ibtnClose
            // 
            this.ibtnClose.BakColor = System.Drawing.Color.Tomato;
            this.ibtnClose.Icon = ((System.Drawing.Image)(resources.GetObject("ibtnClose.Icon")));
            this.ibtnClose.IconSize = new System.Drawing.Size(24, 24);
            this.ibtnClose.Location = new System.Drawing.Point(472, 522);
            this.ibtnClose.Name = "ibtnClose";
            this.ibtnClose.Size = new System.Drawing.Size(108, 43);
            this.ibtnClose.TabIndex = 4;
            this.ibtnClose.TextColor = System.Drawing.Color.Black;
            this.ibtnClose.Value = "Close";
            this.ibtnClose.Click += new System.EventHandler(this.ibtnClose_Click);
            // 
            // ibtnDetain
            // 
            this.ibtnDetain.BakColor = System.Drawing.Color.Snow;
            this.ibtnDetain.Icon = ((System.Drawing.Image)(resources.GetObject("ibtnDetain.Icon")));
            this.ibtnDetain.IconSize = new System.Drawing.Size(24, 24);
            this.ibtnDetain.Location = new System.Drawing.Point(586, 522);
            this.ibtnDetain.Name = "ibtnDetain";
            this.ibtnDetain.Size = new System.Drawing.Size(108, 43);
            this.ibtnDetain.TabIndex = 5;
            this.ibtnDetain.TextColor = System.Drawing.Color.Black;
            this.ibtnDetain.Value = "Detain";
            this.ibtnDetain.Click += new System.EventHandler(this.ibtnDetain_Click);
            // 
            // lnkShowLicenseHistory
            // 
            this.lnkShowLicenseHistory.AutoSize = true;
            this.lnkShowLicenseHistory.Enabled = false;
            this.lnkShowLicenseHistory.Location = new System.Drawing.Point(12, 542);
            this.lnkShowLicenseHistory.Name = "lnkShowLicenseHistory";
            this.lnkShowLicenseHistory.Size = new System.Drawing.Size(109, 13);
            this.lnkShowLicenseHistory.TabIndex = 42;
            this.lnkShowLicenseHistory.TabStop = true;
            this.lnkShowLicenseHistory.Text = "Show License History";
            this.lnkShowLicenseHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkShowLicenseHistory_LinkClicked);
            // 
            // lnkShowLicenseInfo
            // 
            this.lnkShowLicenseInfo.AutoSize = true;
            this.lnkShowLicenseInfo.Enabled = false;
            this.lnkShowLicenseInfo.Location = new System.Drawing.Point(147, 542);
            this.lnkShowLicenseInfo.Name = "lnkShowLicenseInfo";
            this.lnkShowLicenseInfo.Size = new System.Drawing.Size(95, 13);
            this.lnkShowLicenseInfo.TabIndex = 43;
            this.lnkShowLicenseInfo.TabStop = true;
            this.lnkShowLicenseInfo.Text = "Show License Info";
            this.lnkShowLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkShowLicenseInfo_LinkClicked);
            // 
            // gbDetainInfo
            // 
            this.gbDetainInfo.Controls.Add(this.tbFineFees);
            this.gbDetainInfo.Controls.Add(this.lbCreatedByUserID);
            this.gbDetainInfo.Controls.Add(this.lbLicenseID);
            this.gbDetainInfo.Controls.Add(this.lbDetainDate);
            this.gbDetainInfo.Controls.Add(this.lbDetainID);
            this.gbDetainInfo.Controls.Add(this.label5);
            this.gbDetainInfo.Controls.Add(this.label4);
            this.gbDetainInfo.Controls.Add(this.label3);
            this.gbDetainInfo.Controls.Add(this.label2);
            this.gbDetainInfo.Controls.Add(this.label1);
            this.gbDetainInfo.Location = new System.Drawing.Point(15, 404);
            this.gbDetainInfo.Name = "gbDetainInfo";
            this.gbDetainInfo.Size = new System.Drawing.Size(679, 105);
            this.gbDetainInfo.TabIndex = 44;
            this.gbDetainInfo.TabStop = false;
            this.gbDetainInfo.Text = "Detain Info";
            // 
            // tbFineFees
            // 
            this.tbFineFees.Location = new System.Drawing.Point(103, 79);
            this.tbFineFees.Name = "tbFineFees";
            this.tbFineFees.Size = new System.Drawing.Size(73, 20);
            this.tbFineFees.TabIndex = 0;
            this.tbFineFees.TextChanged += new System.EventHandler(this.ValidateFees);
            this.tbFineFees.Leave += new System.EventHandler(this.ValidateFees);
            // 
            // lbCreatedByUserID
            // 
            this.lbCreatedByUserID.AutoSize = true;
            this.lbCreatedByUserID.Location = new System.Drawing.Point(373, 56);
            this.lbCreatedByUserID.Name = "lbCreatedByUserID";
            this.lbCreatedByUserID.Size = new System.Drawing.Size(25, 13);
            this.lbCreatedByUserID.TabIndex = 8;
            this.lbCreatedByUserID.Text = "???";
            // 
            // lbLicenseID
            // 
            this.lbLicenseID.AutoSize = true;
            this.lbLicenseID.Location = new System.Drawing.Point(372, 34);
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
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Created By :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(302, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "License ID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fine Fees     :";
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
            // DetainErrorProvider
            // 
            this.DetainErrorProvider.ContainerControl = this;
            // 
            // DrivingLicenseInfoWithFilter
            // 
            this.DrivingLicenseInfoWithFilter.BackColor = System.Drawing.Color.White;
            this.DrivingLicenseInfoWithFilter.Location = new System.Drawing.Point(6, 58);
            this.DrivingLicenseInfoWithFilter.Name = "DrivingLicenseInfoWithFilter";
            this.DrivingLicenseInfoWithFilter.Size = new System.Drawing.Size(682, 340);
            this.DrivingLicenseInfoWithFilter.TabIndex = 45;
            this.DrivingLicenseInfoWithFilter.OnDataChanged += new System.EventHandler<DVLD.UI.Events.License.clsLicenseEventArgs>(DrivingLicenseInfoWithFilter_OnLicenseFound);
            // 
            // frmDetainLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(702, 577);
            this.Controls.Add(this.DrivingLicenseInfoWithFilter);
            this.Controls.Add(this.gbDetainInfo);
            this.Controls.Add(this.lnkShowLicenseHistory);
            this.Controls.Add(this.lnkShowLicenseInfo);
            this.Controls.Add(this.ibtnDetain);
            this.Controls.Add(this.ibtnClose);
            this.Controls.Add(this.screenHeader1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmDetainLicense";
            this.Text = "frmDetainLicense";
            this.Load += new System.EventHandler(this.frmDetainLicense_Load);
            this.gbDetainInfo.ResumeLayout(false);
            this.gbDetainInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetainErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private UserControls.Shared.ScreenHeader screenHeader1;
        private UserControls.Shared.IconButton ibtnClose;
        private UserControls.Shared.IconButton ibtnDetain;
        private System.Windows.Forms.LinkLabel lnkShowLicenseHistory;
        private System.Windows.Forms.LinkLabel lnkShowLicenseInfo;
        private System.Windows.Forms.GroupBox gbDetainInfo;
        private System.Windows.Forms.TextBox tbFineFees;
        private System.Windows.Forms.Label lbCreatedByUserID;
        private System.Windows.Forms.Label lbLicenseID;
        private System.Windows.Forms.Label lbDetainDate;
        private System.Windows.Forms.Label lbDetainID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider DetainErrorProvider;
        private UserControls.License.Local.DrivingLicenseInfoWithFilter DrivingLicenseInfoWithFilter;
    }
}