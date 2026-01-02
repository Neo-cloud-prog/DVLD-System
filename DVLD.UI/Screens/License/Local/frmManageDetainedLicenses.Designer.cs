namespace DVLD.UI.Screens.License.Local
{
    partial class frmManageDetainedLicenses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageDetainedLicenses));
            this.screenHeader1 = new DVLD.UI.UserControls.Shared.ScreenHeader();
            this.DataGridViewFilter = new DVLD.UI.UserControls.Shared.DataGridViewFilter();
            this.sbDetainedLicenses = new DVLD.UI.UserControls.Shared.ManagementScreenBody();
            this.cmsDetainedLicense = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showPersonDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLicenseDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPersonLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.releaseDetainLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ibtnRelease = new DVLD.UI.UserControls.Shared.IconButton();
            this.ibtnDetain = new DVLD.UI.UserControls.Shared.IconButton();
            this.cmsDetainedLicense.SuspendLayout();
            this.SuspendLayout();
            // 
            // screenHeader1
            // 
            this.screenHeader1.BackColor = System.Drawing.Color.White;
            this.screenHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.screenHeader1.Location = new System.Drawing.Point(0, 0);
            this.screenHeader1.Name = "screenHeader1";
            this.screenHeader1.Size = new System.Drawing.Size(800, 155);
            this.screenHeader1.TabIndex = 0;
            // 
            // DataGridViewFilter
            // 
            this.DataGridViewFilter.Location = new System.Drawing.Point(12, 187);
            this.DataGridViewFilter.Name = "DataGridViewFilter";
            this.DataGridViewFilter.Size = new System.Drawing.Size(345, 41);
            this.DataGridViewFilter.TabIndex = 1;
            // 
            // sbDetainedLicenses
            // 
            this.sbDetainedLicenses.DataGridViewContextMenu = this.cmsDetainedLicense;
            this.sbDetainedLicenses.HideCloseButton = true;
            this.sbDetainedLicenses.Location = new System.Drawing.Point(12, 250);
            this.sbDetainedLicenses.Name = "sbDetainedLicenses";
            this.sbDetainedLicenses.Size = new System.Drawing.Size(775, 188);
            this.sbDetainedLicenses.TabIndex = 2;
            // 
            // cmsDetainedLicense
            // 
            this.cmsDetainedLicense.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showPersonDetailsToolStripMenuItem,
            this.showLicenseDetailsToolStripMenuItem,
            this.showPersonLicenseHistoryToolStripMenuItem,
            this.releaseDetainLicenseToolStripMenuItem});
            this.cmsDetainedLicense.Name = "cmsDetainedLicense";
            this.cmsDetainedLicense.Size = new System.Drawing.Size(226, 92);
            this.cmsDetainedLicense.Opening += new System.ComponentModel.CancelEventHandler(this.cmsDetainedLicense_Opening);
            // 
            // showPersonDetailsToolStripMenuItem
            // 
            this.showPersonDetailsToolStripMenuItem.Name = "showPersonDetailsToolStripMenuItem";
            this.showPersonDetailsToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.showPersonDetailsToolStripMenuItem.Text = "Show Person Details";
            this.showPersonDetailsToolStripMenuItem.Click += new System.EventHandler(this.showPersonDetailsToolStripMenuItem_Click);
            // 
            // showLicenseDetailsToolStripMenuItem
            // 
            this.showLicenseDetailsToolStripMenuItem.Name = "showLicenseDetailsToolStripMenuItem";
            this.showLicenseDetailsToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.showLicenseDetailsToolStripMenuItem.Text = "Show License Details";
            this.showLicenseDetailsToolStripMenuItem.Click += new System.EventHandler(this.showLicenseDetailsToolStripMenuItem_Click);
            // 
            // showPersonLicenseHistoryToolStripMenuItem
            // 
            this.showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
            this.showPersonLicenseHistoryToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.showPersonLicenseHistoryToolStripMenuItem.Text = "Show Person License History";
            this.showPersonLicenseHistoryToolStripMenuItem.Click += new System.EventHandler(this.showPersonLicenseHistoryToolStripMenuItem_Click);
            // 
            // releaseDetainLicenseToolStripMenuItem
            // 
            this.releaseDetainLicenseToolStripMenuItem.Enabled = false;
            this.releaseDetainLicenseToolStripMenuItem.Name = "releaseDetainLicenseToolStripMenuItem";
            this.releaseDetainLicenseToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.releaseDetainLicenseToolStripMenuItem.Text = "Release Detain License";
            this.releaseDetainLicenseToolStripMenuItem.Click += new System.EventHandler(this.releaseDetainLicenseToolStripMenuItem_Click);
            // 
            // ibtnRelease
            // 
            this.ibtnRelease.BakColor = System.Drawing.Color.Snow;
            this.ibtnRelease.Icon = ((System.Drawing.Image)(resources.GetObject("ibtnRelease.Icon")));
            this.ibtnRelease.IconSize = new System.Drawing.Size(24, 24);
            this.ibtnRelease.Location = new System.Drawing.Point(679, 185);
            this.ibtnRelease.Name = "ibtnRelease";
            this.ibtnRelease.Size = new System.Drawing.Size(51, 43);
            this.ibtnRelease.TabIndex = 3;
            this.ibtnRelease.TextColor = System.Drawing.Color.Black;
            this.ibtnRelease.Value = "";
            this.ibtnRelease.Click += new System.EventHandler(this.ibtnRelease_Click);
            // 
            // ibtnDetain
            // 
            this.ibtnDetain.BakColor = System.Drawing.Color.Snow;
            this.ibtnDetain.Icon = ((System.Drawing.Image)(resources.GetObject("ibtnDetain.Icon")));
            this.ibtnDetain.IconSize = new System.Drawing.Size(24, 24);
            this.ibtnDetain.Location = new System.Drawing.Point(736, 185);
            this.ibtnDetain.Name = "ibtnDetain";
            this.ibtnDetain.Size = new System.Drawing.Size(51, 43);
            this.ibtnDetain.TabIndex = 4;
            this.ibtnDetain.TextColor = System.Drawing.Color.Black;
            this.ibtnDetain.Value = "";
            this.ibtnDetain.Click += new System.EventHandler(this.ibtnDetain_Click);
            // 
            // frmManageDetainedLicenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ibtnDetain);
            this.Controls.Add(this.ibtnRelease);
            this.Controls.Add(this.sbDetainedLicenses);
            this.Controls.Add(this.DataGridViewFilter);
            this.Controls.Add(this.screenHeader1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmManageDetainedLicenses";
            this.Text = "frmManageDetainedLicenses";
            this.Load += new System.EventHandler(this.frmManageDetainedLicenses_Load);
            this.cmsDetainedLicense.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.Shared.ScreenHeader screenHeader1;
        private UserControls.Shared.DataGridViewFilter DataGridViewFilter;
        private UserControls.Shared.ManagementScreenBody sbDetainedLicenses;
        private UserControls.Shared.IconButton ibtnRelease;
        private UserControls.Shared.IconButton ibtnDetain;
        private System.Windows.Forms.ContextMenuStrip cmsDetainedLicense;
        private System.Windows.Forms.ToolStripMenuItem showPersonDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLicenseDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem releaseDetainLicenseToolStripMenuItem;
    }
}