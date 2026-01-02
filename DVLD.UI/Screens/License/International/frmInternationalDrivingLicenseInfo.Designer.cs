namespace DVLD.UI.Screens.License.International
{
    partial class frmInternationalDrivingLicenseInfo
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
            this.InternationalDrivingLicenseInfo = new DVLD.UI.UserControls.License.International.InternationalDrivingLicenseInfo();
            this.screenHeader1 = new DVLD.UI.UserControls.Shared.ScreenHeader();
            this.ibtnClose = new DVLD.UI.UserControls.Shared.IconButton();
            this.SuspendLayout();
            // 
            // InternationalDrivingLicenseInfo
            // 
            this.InternationalDrivingLicenseInfo.Location = new System.Drawing.Point(12, 161);
            this.InternationalDrivingLicenseInfo.Name = "InternationalDrivingLicenseInfo";
            this.InternationalDrivingLicenseInfo.Size = new System.Drawing.Size(676, 202);
            this.InternationalDrivingLicenseInfo.TabIndex = 1;
            // 
            // screenHeader1
            // 
            this.screenHeader1.BackColor = System.Drawing.Color.White;
            this.screenHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.screenHeader1.Location = new System.Drawing.Point(0, 0);
            this.screenHeader1.Name = "screenHeader1";
            this.screenHeader1.Size = new System.Drawing.Size(696, 155);
            this.screenHeader1.TabIndex = 2;
            // 
            // ibtnClose
            // 
            this.ibtnClose.BakColor = System.Drawing.Color.Tomato;
            this.ibtnClose.IconSize = new System.Drawing.Size(24, 24);
            this.ibtnClose.Location = new System.Drawing.Point(576, 369);
            this.ibtnClose.Name = "ibtnClose";
            this.ibtnClose.Size = new System.Drawing.Size(108, 43);
            this.ibtnClose.TabIndex = 3;
            this.ibtnClose.TextColor = System.Drawing.Color.Black;
            this.ibtnClose.Value = "Close";
            this.ibtnClose.Click += this.ibtnClose_OnClick;
            // 
            // frmInternationalDrivingLicenseInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(696, 419);
            this.Controls.Add(this.ibtnClose);
            this.Controls.Add(this.screenHeader1);
            this.Controls.Add(this.InternationalDrivingLicenseInfo);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmInternationalDrivingLicenseInfo";
            this.Text = "International Driving License Info";
            this.Load += new System.EventHandler(this.frmInternationalDrivingLicenseInfo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.License.International.InternationalDrivingLicenseInfo InternationalDrivingLicenseInfo;
        private UserControls.Shared.ScreenHeader screenHeader1;
        private UserControls.Shared.IconButton ibtnClose;
    }
}