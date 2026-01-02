namespace DVLD.UI.Screens.Application.Local
{
    partial class frmLocalDrivingLicenseApplocations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLocalDrivingLicenseApplocations));
            this.cmsLocalLicenseApplication = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showApplicationDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.cancelApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schedulTestsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schedulVisionTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleWriteenTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issueDrivingLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.showPersonLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DataGridViewFilter = new DVLD.UI.UserControls.Shared.DataGridViewFilter();
            this.screenHeader1 = new DVLD.UI.UserControls.Shared.ScreenHeader();
            this.sbLocalLicenseApplications = new DVLD.UI.UserControls.Shared.ManagementScreenBody();
            this.btnAddLoacalLicenseApplication = new DVLD.UI.UserControls.Shared.IconButton();
            this.cmsLocalLicenseApplication.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmsLocalLicenseApplication
            // 
            this.cmsLocalLicenseApplication.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showApplicationDetailsToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteApplicationToolStripMenuItem,
            this.toolStripMenuItem1,
            this.cancelApplicationToolStripMenuItem,
            this.schedulTestsToolStripMenuItem,
            this.issueDrivingLicenseToolStripMenuItem,
            this.showLicenseToolStripMenuItem,
            this.showToolStripMenuItem,
            this.showPersonLicenseHistoryToolStripMenuItem});
            this.cmsLocalLicenseApplication.Name = "cmsLocalLicenseApplication";
            this.cmsLocalLicenseApplication.Size = new System.Drawing.Size(246, 192);
            this.cmsLocalLicenseApplication.Opening += new System.ComponentModel.CancelEventHandler(this.cmsLocalLicenseApplication_Opening);
            // 
            // showApplicationDetailsToolStripMenuItem
            // 
            this.showApplicationDetailsToolStripMenuItem.Name = "showApplicationDetailsToolStripMenuItem";
            this.showApplicationDetailsToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.showApplicationDetailsToolStripMenuItem.Text = "Show Application Details";
            this.showApplicationDetailsToolStripMenuItem.Click += new System.EventHandler(this.showApplicationDetailsToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.editToolStripMenuItem.Text = "Edit Application";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteApplicationToolStripMenuItem
            // 
            this.deleteApplicationToolStripMenuItem.Name = "deleteApplicationToolStripMenuItem";
            this.deleteApplicationToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.deleteApplicationToolStripMenuItem.Text = "Delete Application";
            this.deleteApplicationToolStripMenuItem.Click += new System.EventHandler(this.deleteApplicationToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(242, 6);
            // 
            // cancelApplicationToolStripMenuItem
            // 
            this.cancelApplicationToolStripMenuItem.Name = "cancelApplicationToolStripMenuItem";
            this.cancelApplicationToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.cancelApplicationToolStripMenuItem.Text = "Cancel Application";
            this.cancelApplicationToolStripMenuItem.Click += new System.EventHandler(this.cancelApplicationToolStripMenuItem_Click);
            // 
            // schedulTestsToolStripMenuItem
            // 
            this.schedulTestsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.schedulVisionTestToolStripMenuItem,
            this.scheduleWriteenTestToolStripMenuItem,
            this.scheduleToolStripMenuItem});
            this.schedulTestsToolStripMenuItem.Name = "schedulTestsToolStripMenuItem";
            this.schedulTestsToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.schedulTestsToolStripMenuItem.Text = "ScheduleTests";
            // 
            // schedulVisionTestToolStripMenuItem
            // 
            this.schedulVisionTestToolStripMenuItem.Enabled = false;
            this.schedulVisionTestToolStripMenuItem.Name = "schedulVisionTestToolStripMenuItem";
            this.schedulVisionTestToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.schedulVisionTestToolStripMenuItem.Text = "Schedule Vision Test";
            this.schedulVisionTestToolStripMenuItem.Click += new System.EventHandler(this.schedulTestToolStripMenuItem_Click);
            // 
            // scheduleWriteenTestToolStripMenuItem
            // 
            this.scheduleWriteenTestToolStripMenuItem.Enabled = false;
            this.scheduleWriteenTestToolStripMenuItem.Name = "scheduleWriteenTestToolStripMenuItem";
            this.scheduleWriteenTestToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.scheduleWriteenTestToolStripMenuItem.Text = "Schedule Writeen Test";
            this.scheduleWriteenTestToolStripMenuItem.Click += new System.EventHandler(this.schedulTestToolStripMenuItem_Click);
            // 
            // scheduleToolStripMenuItem
            // 
            this.scheduleToolStripMenuItem.Enabled = false;
            this.scheduleToolStripMenuItem.Name = "scheduleToolStripMenuItem";
            this.scheduleToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.scheduleToolStripMenuItem.Text = "Schedule Street Test";
            this.scheduleToolStripMenuItem.Click += new System.EventHandler(this.schedulTestToolStripMenuItem_Click);
            // 
            // issueDrivingLicenseToolStripMenuItem
            // 
            this.issueDrivingLicenseToolStripMenuItem.Enabled = false;
            this.issueDrivingLicenseToolStripMenuItem.Name = "issueDrivingLicenseToolStripMenuItem";
            this.issueDrivingLicenseToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.issueDrivingLicenseToolStripMenuItem.Text = "Issue Driving License (First Time)";
            this.issueDrivingLicenseToolStripMenuItem.Click += new System.EventHandler(this.issueDrivingLicenseToolStripMenuItem_Click);
            // 
            // showLicenseToolStripMenuItem
            // 
            this.showLicenseToolStripMenuItem.Enabled = false;
            this.showLicenseToolStripMenuItem.Name = "showLicenseToolStripMenuItem";
            this.showLicenseToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.showLicenseToolStripMenuItem.Text = "Show License";
            this.showLicenseToolStripMenuItem.Click += new System.EventHandler(this.showLicenseToolStripMenuItem_Click);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(242, 6);
            // 
            // showPersonLicenseHistoryToolStripMenuItem
            // 
            this.showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
            this.showPersonLicenseHistoryToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.showPersonLicenseHistoryToolStripMenuItem.Text = "Show Person License History";
            this.showPersonLicenseHistoryToolStripMenuItem.Click += new System.EventHandler(this.showPersonLicenseHistoryToolStripMenuItem_Click);
            // 
            // DataGridViewFilter
            // 
            this.DataGridViewFilter.Location = new System.Drawing.Point(13, 200);
            this.DataGridViewFilter.Name = "DataGridViewFilter";
            this.DataGridViewFilter.Size = new System.Drawing.Size(345, 41);
            this.DataGridViewFilter.TabIndex = 8;
            // 
            // screenHeader1
            // 
            this.screenHeader1.BackColor = System.Drawing.Color.White;
            this.screenHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.screenHeader1.Location = new System.Drawing.Point(0, 0);
            this.screenHeader1.Name = "screenHeader1";
            this.screenHeader1.Size = new System.Drawing.Size(800, 186);
            this.screenHeader1.TabIndex = 7;
            // 
            // sbLocalLicenseApplications
            // 
            this.sbLocalLicenseApplications.DataGridViewContextMenu = this.cmsLocalLicenseApplication;
            this.sbLocalLicenseApplications.HideCloseButton = true;
            this.sbLocalLicenseApplications.Location = new System.Drawing.Point(13, 256);
            this.sbLocalLicenseApplications.Name = "sbLocalLicenseApplications";
            this.sbLocalLicenseApplications.Size = new System.Drawing.Size(775, 188);
            this.sbLocalLicenseApplications.TabIndex = 6;
            // 
            // btnAddLoacalLicenseApplication
            // 
            this.btnAddLoacalLicenseApplication.BakColor = System.Drawing.Color.Snow;
            this.btnAddLoacalLicenseApplication.Icon = ((System.Drawing.Image)(resources.GetObject("btnAddLoacalLicenseApplication.Icon")));
            this.btnAddLoacalLicenseApplication.IconSize = new System.Drawing.Size(24, 24);
            this.btnAddLoacalLicenseApplication.Location = new System.Drawing.Point(739, 198);
            this.btnAddLoacalLicenseApplication.Name = "btnAddLoacalLicenseApplication";
            this.btnAddLoacalLicenseApplication.Size = new System.Drawing.Size(49, 43);
            this.btnAddLoacalLicenseApplication.TabIndex = 5;
            this.btnAddLoacalLicenseApplication.TextColor = System.Drawing.Color.Black;
            this.btnAddLoacalLicenseApplication.Value = "";
            this.btnAddLoacalLicenseApplication.Click += new System.EventHandler(this.btnAddLoacalLicenseApplication_OnClick);
            // 
            // frmLocalDrivingLicenseApplocations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DataGridViewFilter);
            this.Controls.Add(this.sbLocalLicenseApplications);
            this.Controls.Add(this.screenHeader1);
            this.Controls.Add(this.btnAddLoacalLicenseApplication);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmLocalDrivingLicenseApplocations";
            this.Text = "Local Driving License Applocations";
            this.Load += new System.EventHandler(this.frmLocalDrivingLicenseApplocations_Load);
            this.cmsLocalLicenseApplication.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.Shared.DataGridViewFilter DataGridViewFilter;
        private UserControls.Shared.ScreenHeader screenHeader1;
        private UserControls.Shared.IconButton btnAddLoacalLicenseApplication;
        private System.Windows.Forms.ContextMenuStrip cmsLocalLicenseApplication;
        private System.Windows.Forms.ToolStripMenuItem showApplicationDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cancelApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schedulTestsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issueDrivingLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schedulVisionTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleWriteenTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleToolStripMenuItem;
        private DVLD.UI.UserControls.Shared.ManagementScreenBody sbLocalLicenseApplications;
    }
}