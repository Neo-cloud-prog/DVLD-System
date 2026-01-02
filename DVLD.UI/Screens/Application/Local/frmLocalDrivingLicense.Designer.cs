using DVLD.UI.Events.Person;

namespace DVLD.UI.Screens.Application.Local
{
    partial class frmLocalDrivingLicense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLocalDrivingLicense));
            this.screenHeader1 = new DVLD.UI.UserControls.Shared.ScreenHeader();
            this.tabLocalLicenseApp = new System.Windows.Forms.TabControl();
            this.tabPerosnInfo = new System.Windows.Forms.TabPage();
            this.PersonDetailsWithFilter = new DVLD.UI.UserControls.Person.PersonDetailsWithFilter();
            this.btnNext = new DVLD.UI.UserControls.Shared.IconButton();
            this.tabApplicationInfo = new System.Windows.Forms.TabPage();
            this.lbUserName = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbAppFees = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbLicenseClasses = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbAppDate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbAppID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ibtnSave = new DVLD.UI.UserControls.Shared.IconButton();
            this.ibnClose = new DVLD.UI.UserControls.Shared.IconButton();
            this.tabLocalLicenseApp.SuspendLayout();
            this.tabPerosnInfo.SuspendLayout();
            this.tabApplicationInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // screenHeader1
            // 
            this.screenHeader1.BackColor = System.Drawing.Color.White;
            this.screenHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.screenHeader1.Location = new System.Drawing.Point(0, 0);
            this.screenHeader1.Name = "screenHeader1";
            this.screenHeader1.Size = new System.Drawing.Size(743, 55);
            this.screenHeader1.TabIndex = 0;
            // 
            // tabLocalLicenseApp
            // 
            this.tabLocalLicenseApp.Controls.Add(this.tabPerosnInfo);
            this.tabLocalLicenseApp.Controls.Add(this.tabApplicationInfo);
            this.tabLocalLicenseApp.Location = new System.Drawing.Point(12, 61);
            this.tabLocalLicenseApp.Name = "tabLocalLicenseApp";
            this.tabLocalLicenseApp.SelectedIndex = 0;
            this.tabLocalLicenseApp.Size = new System.Drawing.Size(724, 438);
            this.tabLocalLicenseApp.TabIndex = 1;
            this.tabLocalLicenseApp.SelectedIndexChanged += new System.EventHandler(this.tabLocalLicenseApp_SelectedIndexChanged);
            // 
            // tabPerosnInfo
            // 
            this.tabPerosnInfo.Controls.Add(this.PersonDetailsWithFilter);
            this.tabPerosnInfo.Controls.Add(this.btnNext);
            this.tabPerosnInfo.Location = new System.Drawing.Point(4, 22);
            this.tabPerosnInfo.Name = "tabPerosnInfo";
            this.tabPerosnInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPerosnInfo.Size = new System.Drawing.Size(716, 412);
            this.tabPerosnInfo.TabIndex = 0;
            this.tabPerosnInfo.Text = "Peson Info";
            this.tabPerosnInfo.UseVisualStyleBackColor = true;
            // 
            // PersonDetailsWithFilter
            // 
            this.PersonDetailsWithFilter.BackColor = System.Drawing.Color.White;
            this.PersonDetailsWithFilter.Location = new System.Drawing.Point(7, 30);
            this.PersonDetailsWithFilter.Name = "PersonDetailsWithFilter";
            this.PersonDetailsWithFilter.Size = new System.Drawing.Size(703, 327);
            this.PersonDetailsWithFilter.TabIndex = 6;
            // 
            // btnNext
            // 
            this.btnNext.BakColor = System.Drawing.Color.Snow;
            this.btnNext.Icon = ((System.Drawing.Image)(resources.GetObject("btnNext.Icon")));
            this.btnNext.IconSize = new System.Drawing.Size(24, 24);
            this.btnNext.Location = new System.Drawing.Point(589, 363);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(108, 43);
            this.btnNext.TabIndex = 4;
            this.btnNext.TextColor = System.Drawing.Color.Black;
            this.btnNext.Value = "Next";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // tabApplicationInfo
            // 
            this.tabApplicationInfo.Controls.Add(this.lbUserName);
            this.tabApplicationInfo.Controls.Add(this.label8);
            this.tabApplicationInfo.Controls.Add(this.lbAppFees);
            this.tabApplicationInfo.Controls.Add(this.label6);
            this.tabApplicationInfo.Controls.Add(this.cmbLicenseClasses);
            this.tabApplicationInfo.Controls.Add(this.label5);
            this.tabApplicationInfo.Controls.Add(this.lbAppDate);
            this.tabApplicationInfo.Controls.Add(this.label3);
            this.tabApplicationInfo.Controls.Add(this.lbAppID);
            this.tabApplicationInfo.Controls.Add(this.label1);
            this.tabApplicationInfo.Location = new System.Drawing.Point(4, 22);
            this.tabApplicationInfo.Name = "tabApplicationInfo";
            this.tabApplicationInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabApplicationInfo.Size = new System.Drawing.Size(716, 386);
            this.tabApplicationInfo.TabIndex = 1;
            this.tabApplicationInfo.Text = "Application Info:";
            this.tabApplicationInfo.UseVisualStyleBackColor = true;
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserName.Location = new System.Drawing.Point(389, 203);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(31, 15);
            this.lbUserName.TabIndex = 9;
            this.lbUserName.Text = "???";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(251, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "Created By             :";
            // 
            // lbAppFees
            // 
            this.lbAppFees.AutoSize = true;
            this.lbAppFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAppFees.Location = new System.Drawing.Point(389, 177);
            this.lbAppFees.Name = "lbAppFees";
            this.lbAppFees.Size = new System.Drawing.Size(31, 15);
            this.lbAppFees.TabIndex = 7;
            this.lbAppFees.Text = "???";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(251, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Application Fees   :";
            // 
            // cmbLicenseClasses
            // 
            this.cmbLicenseClasses.FormattingEnabled = true;
            this.cmbLicenseClasses.Location = new System.Drawing.Point(392, 152);
            this.cmbLicenseClasses.Name = "cmbLicenseClasses";
            this.cmbLicenseClasses.Size = new System.Drawing.Size(193, 21);
            this.cmbLicenseClasses.TabIndex = 5;
            this.cmbLicenseClasses.SelectedIndexChanged += new System.EventHandler(this.cmbLicenseClasses_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(251, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "License Class       :";
            // 
            // lbAppDate
            // 
            this.lbAppDate.AutoSize = true;
            this.lbAppDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAppDate.Location = new System.Drawing.Point(389, 125);
            this.lbAppDate.Name = "lbAppDate";
            this.lbAppDate.Size = new System.Drawing.Size(31, 15);
            this.lbAppDate.TabIndex = 3;
            this.lbAppDate.Text = "???";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(251, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Application Date   :";
            // 
            // lbAppID
            // 
            this.lbAppID.AutoSize = true;
            this.lbAppID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAppID.Location = new System.Drawing.Point(389, 95);
            this.lbAppID.Name = "lbAppID";
            this.lbAppID.Size = new System.Drawing.Size(31, 15);
            this.lbAppID.TabIndex = 1;
            this.lbAppID.Text = "???";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(251, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "L.D ApplicationID :";
            // 
            // ibtnSave
            // 
            this.ibtnSave.BakColor = System.Drawing.Color.Snow;
            this.ibtnSave.Icon = ((System.Drawing.Image)(resources.GetObject("ibtnSave.Icon")));
            this.ibtnSave.IconSize = new System.Drawing.Size(24, 24);
            this.ibtnSave.Location = new System.Drawing.Point(605, 505);
            this.ibtnSave.Name = "ibtnSave";
            this.ibtnSave.Size = new System.Drawing.Size(108, 43);
            this.ibtnSave.TabIndex = 6;
            this.ibtnSave.TextColor = System.Drawing.Color.Black;
            this.ibtnSave.Value = "Save";
            // 
            // ibnClose
            // 
            this.ibnClose.BakColor = System.Drawing.Color.Snow;
            this.ibnClose.Icon = ((System.Drawing.Image)(resources.GetObject("ibnClose.Icon")));
            this.ibnClose.IconSize = new System.Drawing.Size(24, 24);
            this.ibnClose.Location = new System.Drawing.Point(491, 505);
            this.ibnClose.Name = "ibnClose";
            this.ibnClose.Size = new System.Drawing.Size(108, 43);
            this.ibnClose.TabIndex = 5;
            this.ibnClose.TextColor = System.Drawing.Color.Black;
            this.ibnClose.Value = "Close";
            // 
            // frmLocalDrivingLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(743, 552);
            this.Controls.Add(this.ibtnSave);
            this.Controls.Add(this.ibnClose);
            this.Controls.Add(this.tabLocalLicenseApp);
            this.Controls.Add(this.screenHeader1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmLocalDrivingLicense";
            this.Text = "Local Driving License";
            this.Load += new System.EventHandler(this.frmLocalDrivingLicense_Load);
            this.tabLocalLicenseApp.ResumeLayout(false);
            this.tabPerosnInfo.ResumeLayout(false);
            this.tabApplicationInfo.ResumeLayout(false);
            this.tabApplicationInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.Shared.ScreenHeader screenHeader1;
        private System.Windows.Forms.TabControl tabLocalLicenseApp;
        private System.Windows.Forms.TabPage tabPerosnInfo;
        private System.Windows.Forms.TabPage tabApplicationInfo;
        private UserControls.Shared.IconButton btnNext;
        private UserControls.Shared.IconButton ibnClose;
        private UserControls.Shared.IconButton ibtnSave;
        private System.Windows.Forms.Label lbAppFees;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbLicenseClasses;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbAppDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbAppID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Label label8;
        private UserControls.Person.PersonDetailsWithFilter PersonDetailsWithFilter;
    }
}