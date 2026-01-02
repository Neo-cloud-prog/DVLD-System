namespace DVLD.UI.Screens.Driver
{
    partial class frmManageDrivers
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
            this.cmsDriver = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showPersonInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issueInternationalLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPersonLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DataGridViewFilter = new DVLD.UI.UserControls.Shared.DataGridViewFilter();
            this.sbDrivers = new DVLD.UI.UserControls.Shared.ManagementScreenBody();
            this.screenHeader1 = new DVLD.UI.UserControls.Shared.ScreenHeader();
            this.cmsDriver.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmsDriver
            // 
            this.cmsDriver.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showPersonInfoToolStripMenuItem,
            this.issueInternationalLicenseToolStripMenuItem,
            this.showPersonLicenseHistoryToolStripMenuItem});
            this.cmsDriver.Name = "cmsDriver";
            this.cmsDriver.Size = new System.Drawing.Size(226, 70);
            // 
            // showPersonInfoToolStripMenuItem
            // 
            this.showPersonInfoToolStripMenuItem.Name = "showPersonInfoToolStripMenuItem";
            this.showPersonInfoToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.showPersonInfoToolStripMenuItem.Text = "Show Person Info";
            this.showPersonInfoToolStripMenuItem.Click += new System.EventHandler(this.showPersonInfoToolStripMenuItem_Click);
            // 
            // issueInternationalLicenseToolStripMenuItem
            // 
            this.issueInternationalLicenseToolStripMenuItem.Name = "issueInternationalLicenseToolStripMenuItem";
            this.issueInternationalLicenseToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.issueInternationalLicenseToolStripMenuItem.Text = "Issue International License";
            this.issueInternationalLicenseToolStripMenuItem.Click += new System.EventHandler(this.issueInternationalLicenseToolStripMenuItem_Click);
            // 
            // showPersonLicenseHistoryToolStripMenuItem
            // 
            this.showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
            this.showPersonLicenseHistoryToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.showPersonLicenseHistoryToolStripMenuItem.Text = "Show Person License History";
            this.showPersonLicenseHistoryToolStripMenuItem.Click += new System.EventHandler(this.sToolStripMenuItem_Click);
            // 
            // DataGridViewFilter
            // 
            this.DataGridViewFilter.Location = new System.Drawing.Point(12, 201);
            this.DataGridViewFilter.Name = "DataGridViewFilter";
            this.DataGridViewFilter.Size = new System.Drawing.Size(345, 41);
            this.DataGridViewFilter.TabIndex = 16;
            // 
            // sbDrivers
            // 
            this.sbDrivers.DataGridViewContextMenu = this.cmsDriver;
            this.sbDrivers.HideCloseButton = true;
            this.sbDrivers.Location = new System.Drawing.Point(12, 250);
            this.sbDrivers.Name = "sbDrivers";
            this.sbDrivers.Size = new System.Drawing.Size(776, 188);
            this.sbDrivers.TabIndex = 2;
            // 
            // screenHeader1
            // 
            this.screenHeader1.BackColor = System.Drawing.Color.White;
            this.screenHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.screenHeader1.Location = new System.Drawing.Point(0, 0);
            this.screenHeader1.Name = "screenHeader1";
            this.screenHeader1.ScreenImage = global::DVLD.UI.Properties.Resources.driver;
            this.screenHeader1.Size = new System.Drawing.Size(800, 186);
            this.screenHeader1.TabIndex = 15;
            // 
            // frmManageDrivers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DataGridViewFilter);
            this.Controls.Add(this.sbDrivers);
            this.Controls.Add(this.screenHeader1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmManageDrivers";
            this.Text = "frmManageDrivers";
            this.Load += new System.EventHandler(this.frmManageDrivers_Load);
            this.cmsDriver.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private UserControls.Shared.ScreenHeader screenHeader1;
        private UserControls.Shared.ManagementScreenBody sbDrivers;
        private UserControls.Shared.DataGridViewFilter DataGridViewFilter;
        private System.Windows.Forms.ContextMenuStrip cmsDriver;
        private System.Windows.Forms.ToolStripMenuItem showPersonInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issueInternationalLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
    }
}