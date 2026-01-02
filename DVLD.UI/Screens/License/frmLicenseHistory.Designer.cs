namespace DVLD.UI.Screens.License
{
    partial class frmLicenseHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLicenseHistory));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.sbLocalLicense = new DVLD.UI.UserControls.Shared.ManagementScreenBody();
            this.cmsLicense = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showLicenseInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.sbInternationalLicenses = new DVLD.UI.UserControls.Shared.ManagementScreenBody();
            this.ibtnClose = new DVLD.UI.UserControls.Shared.IconButton();
            this.PersonDetailsWithFilter = new DVLD.UI.UserControls.Person.PersonDetailsWithFilter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.cmsLicense.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(21, 370);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(690, 220);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.sbLocalLicense);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(682, 194);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Local";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // sbLocalLicense
            // 
            this.sbLocalLicense.ContextMenuStrip = this.cmsLicense;
            this.sbLocalLicense.HideCloseButton = false;
            this.sbLocalLicense.Location = new System.Drawing.Point(6, 6);
            this.sbLocalLicense.Name = "sbLocalLicense";
            this.sbLocalLicense.Size = new System.Drawing.Size(670, 188);
            this.sbLocalLicense.TabIndex = 0;
            // 
            // cmsLicense
            // 
            this.cmsLicense.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showLicenseInfoToolStripMenuItem});
            this.cmsLicense.Name = "cmsLicense";
            this.cmsLicense.Size = new System.Drawing.Size(170, 26);
            // 
            // showLicenseInfoToolStripMenuItem
            // 
            this.showLicenseInfoToolStripMenuItem.Name = "showLicenseInfoToolStripMenuItem";
            this.showLicenseInfoToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.showLicenseInfoToolStripMenuItem.Text = "Show License Info";
            this.showLicenseInfoToolStripMenuItem.Click += new System.EventHandler(this.showLicenseInfoToolStripMenuItem_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.sbInternationalLicenses);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(682, 194);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "International";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // sbInternationalLicenses
            // 
            this.sbInternationalLicenses.ContextMenuStrip = this.cmsLicense;
            this.sbInternationalLicenses.HideCloseButton = false;
            this.sbInternationalLicenses.Location = new System.Drawing.Point(6, 3);
            this.sbInternationalLicenses.Name = "sbInternationalLicenses";
            this.sbInternationalLicenses.Size = new System.Drawing.Size(670, 188);
            this.sbInternationalLicenses.TabIndex = 1;
            // 
            // ibtnClose
            // 
            this.ibtnClose.BakColor = System.Drawing.Color.Tomato;
            this.ibtnClose.Icon = ((System.Drawing.Image)(resources.GetObject("ibtnClose.Icon")));
            this.ibtnClose.IconSize = new System.Drawing.Size(24, 24);
            this.ibtnClose.Location = new System.Drawing.Point(599, 596);
            this.ibtnClose.Name = "ibtnClose";
            this.ibtnClose.Size = new System.Drawing.Size(108, 43);
            this.ibtnClose.TabIndex = 2;
            this.ibtnClose.TextColor = System.Drawing.Color.Black;
            this.ibtnClose.Value = "Close";
            this.ibtnClose.Click += new System.EventHandler(this.ibtnClose_Click);
            // 
            // PersonDetailsWithFilter
            // 
            this.PersonDetailsWithFilter.BackColor = System.Drawing.Color.White;
            this.PersonDetailsWithFilter.Location = new System.Drawing.Point(12, 12);
            this.PersonDetailsWithFilter.Name = "PersonDetailsWithFilter";
            this.PersonDetailsWithFilter.Size = new System.Drawing.Size(698, 327);
            this.PersonDetailsWithFilter.TabIndex = 3;
            // 
            // frmLicenseHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(723, 643);
            this.Controls.Add(this.PersonDetailsWithFilter);
            this.Controls.Add(this.ibtnClose);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmLicenseHistory";
            this.Text = "License History";
            this.Load += new System.EventHandler(this.frmLicenseHistory_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.cmsLicense.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private UserControls.Shared.ManagementScreenBody sbLocalLicense;
        private UserControls.Shared.IconButton ibtnClose;
        private UserControls.Shared.ManagementScreenBody sbInternationalLicenses;
        private System.Windows.Forms.ContextMenuStrip cmsLicense;
        private System.Windows.Forms.ToolStripMenuItem showLicenseInfoToolStripMenuItem;
        private UserControls.Person.PersonDetailsWithFilter PersonDetailsWithFilter;
    }
}