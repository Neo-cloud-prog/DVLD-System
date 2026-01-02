namespace DVLD.UI.Screens.License.Local
{
    partial class frmLocalDrivingLicenseInfo
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
            this.DrivingLicenseInfo = new DVLD.UI.UserControls.License.Local.DrivingLicenseInfo();
            this.screenHeader1 = new DVLD.UI.UserControls.Shared.ScreenHeader();
            this.SuspendLayout();
            // 
            // DrivingLicenseInfo
            // 
            this.DrivingLicenseInfo.Location = new System.Drawing.Point(18, 159);
            this.DrivingLicenseInfo.Name = "DrivingLicenseInfo";
            this.DrivingLicenseInfo.Size = new System.Drawing.Size(735, 277);
            this.DrivingLicenseInfo.TabIndex = 0;
            // 
            // screenHeader1
            // 
            this.screenHeader1.BackColor = System.Drawing.Color.White;
            this.screenHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.screenHeader1.Location = new System.Drawing.Point(0, 0);
            this.screenHeader1.Name = "screenHeader1";
            this.screenHeader1.Size = new System.Drawing.Size(765, 153);
            this.screenHeader1.TabIndex = 1;
            // 
            // frmLocalDrivingLicenseInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(765, 439);
            this.Controls.Add(this.screenHeader1);
            this.Controls.Add(this.DrivingLicenseInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmLocalDrivingLicenseInfo";
            this.Text = "Local Driving LicenseInfo";
            this.Load += new System.EventHandler(this.frmLocalDrivingLicenseInfo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.License.Local.DrivingLicenseInfo DrivingLicenseInfo;
        private UserControls.Shared.ScreenHeader screenHeader1;
    }
}