namespace DVLD.UI.Screens.Application.International
{
    partial class frmInternationalDrivingLicenseApplicaitons
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInternationalDrivingLicenseApplicaitons));
            this.DataGridViewFilter = new DVLD.UI.UserControls.Shared.DataGridViewFilter();
            this.btnAddLoacalLicenseApplication = new DVLD.UI.UserControls.Shared.IconButton();
            this.showPersonLicenseHistoryApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLicenseDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPersonDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsInternationalLicenseApplication = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sbInternationalLicenseApplications = new DVLD.UI.UserControls.Shared.ManagementScreenBody();
            this.screenHeader1 = new DVLD.UI.UserControls.Shared.ScreenHeader();
            this.cmsInternationalLicenseApplication.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGridViewFilter
            // 
            this.DataGridViewFilter.Location = new System.Drawing.Point(13, 203);
            this.DataGridViewFilter.Name = "DataGridViewFilter";
            this.DataGridViewFilter.Size = new System.Drawing.Size(345, 41);
            this.DataGridViewFilter.TabIndex = 12;
            // 
            // btnAddLoacalLicenseApplication
            // 
            this.btnAddLoacalLicenseApplication.BakColor = System.Drawing.Color.Snow;
            this.btnAddLoacalLicenseApplication.Icon = ((System.Drawing.Image)(resources.GetObject("btnAddLoacalLicenseApplication.Icon")));
            this.btnAddLoacalLicenseApplication.IconSize = new System.Drawing.Size(24, 24);
            this.btnAddLoacalLicenseApplication.Location = new System.Drawing.Point(739, 201);
            this.btnAddLoacalLicenseApplication.Name = "btnAddLoacalLicenseApplication";
            this.btnAddLoacalLicenseApplication.Size = new System.Drawing.Size(49, 43);
            this.btnAddLoacalLicenseApplication.TabIndex = 9;
            this.btnAddLoacalLicenseApplication.TextColor = System.Drawing.Color.Black;
            this.btnAddLoacalLicenseApplication.Value = "";
            this.btnAddLoacalLicenseApplication.Click += new System.EventHandler(this.btnAddLoacalLicenseApplication_Click);
            // 
            // showPersonLicenseHistoryApplicationToolStripMenuItem
            // 
            this.showPersonLicenseHistoryApplicationToolStripMenuItem.Name = "showPersonLicenseHistoryApplicationToolStripMenuItem";
            this.showPersonLicenseHistoryApplicationToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.showPersonLicenseHistoryApplicationToolStripMenuItem.Text = "Show Person License History";
            this.showPersonLicenseHistoryApplicationToolStripMenuItem.Click += new System.EventHandler(this.showPersonLicenseHistoryApplicationToolStripMenuItem_Click);
            // 
            // showLicenseDetailsToolStripMenuItem
            // 
            this.showLicenseDetailsToolStripMenuItem.Name = "showLicenseDetailsToolStripMenuItem";
            this.showLicenseDetailsToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.showLicenseDetailsToolStripMenuItem.Text = "Show License Details";
            this.showLicenseDetailsToolStripMenuItem.Click += new System.EventHandler(this.showLicenseDetailsToolStripMenuItem_Click);
            // 
            // showPersonDetailsToolStripMenuItem
            // 
            this.showPersonDetailsToolStripMenuItem.Name = "showPersonDetailsToolStripMenuItem";
            this.showPersonDetailsToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.showPersonDetailsToolStripMenuItem.Text = "Show Person Details";
            this.showPersonDetailsToolStripMenuItem.Click += new System.EventHandler(this.showPersonDetailsToolStripMenuItem_Click);
            // 
            // cmsInternationalLicenseApplication
            // 
            this.cmsInternationalLicenseApplication.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showPersonDetailsToolStripMenuItem,
            this.showLicenseDetailsToolStripMenuItem,
            this.showPersonLicenseHistoryApplicationToolStripMenuItem});
            this.cmsInternationalLicenseApplication.Name = "cmsLocalLicenseApplication";
            this.cmsInternationalLicenseApplication.Size = new System.Drawing.Size(226, 70);
            this.cmsInternationalLicenseApplication.Opening += new System.ComponentModel.CancelEventHandler(this.cmsInternationalLicenseApplication_Opening);
            // 
            // sbInternationalLicenseApplications
            // 
            this.sbInternationalLicenseApplications.DataGridViewContextMenu = this.cmsInternationalLicenseApplication;
            this.sbInternationalLicenseApplications.HideCloseButton = true;
            this.sbInternationalLicenseApplications.Location = new System.Drawing.Point(13, 259);
            this.sbInternationalLicenseApplications.Name = "sbInternationalLicenseApplications";
            this.sbInternationalLicenseApplications.Size = new System.Drawing.Size(775, 188);
            this.sbInternationalLicenseApplications.TabIndex = 10;
            // 
            // screenHeader1
            // 
            this.screenHeader1.BackColor = System.Drawing.Color.White;
            this.screenHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.screenHeader1.Location = new System.Drawing.Point(0, 0);
            this.screenHeader1.Name = "screenHeader1";
            this.screenHeader1.Size = new System.Drawing.Size(800, 186);
            this.screenHeader1.TabIndex = 11;
            // 
            // frmInternationalDrivingLicenseApplicaitons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DataGridViewFilter);
            this.Controls.Add(this.btnAddLoacalLicenseApplication);
            this.Controls.Add(this.sbInternationalLicenseApplications);
            this.Controls.Add(this.screenHeader1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmInternationalDrivingLicenseApplicaitons";
            this.Text = "frmInternationalDrivingLicenseApplicaitons";
            this.Load += new System.EventHandler(this.frmInternationalDrivingLicenseApplicaitons_Load);
            this.cmsInternationalLicenseApplication.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.Shared.DataGridViewFilter DataGridViewFilter;
        private UserControls.Shared.IconButton btnAddLoacalLicenseApplication;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicenseHistoryApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLicenseDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPersonDetailsToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsInternationalLicenseApplication;
        private UserControls.Shared.ManagementScreenBody sbInternationalLicenseApplications;
        private UserControls.Shared.ScreenHeader screenHeader1;
    }
}