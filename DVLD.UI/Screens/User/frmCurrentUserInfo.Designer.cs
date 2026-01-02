namespace DVLD.UI.Screens.User
{
    partial class frmCurrentUserInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCurrentUserInfo));
            this.UserInformation = new DVLD.UI.UserControls.User.UserInformation();
            this.btnClose = new DVLD.UI.UserControls.Shared.IconButton();
            this.SuspendLayout();
            // 
            // UserInformation
            // 
            this.UserInformation.BackColor = System.Drawing.Color.White;
            this.UserInformation.Dock = System.Windows.Forms.DockStyle.Top;
            this.UserInformation.Location = new System.Drawing.Point(0, 0);
            this.UserInformation.Name = "UserInformation";
            this.UserInformation.Size = new System.Drawing.Size(703, 336);
            this.UserInformation.TabIndex = 3;
            // 
            // btnClose
            // 
            this.btnClose.BakColor = System.Drawing.Color.Tomato;
            this.btnClose.Icon = ((System.Drawing.Image)(resources.GetObject("btnClose.Icon")));
            this.btnClose.IconSize = new System.Drawing.Size(24, 24);
            this.btnClose.Location = new System.Drawing.Point(583, 342);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(108, 43);
            this.btnClose.TabIndex = 2;
            this.btnClose.TextColor = System.Drawing.Color.White;
            this.btnClose.Value = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmCurrentUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(703, 397);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.UserInformation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmCurrentUserInfo";
            this.Text = "Current User Info";
            this.Load += new System.EventHandler(this.frmCurrentUserInfo_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private UserControls.User.UserInformation UserInformation;
        private UserControls.Shared.IconButton btnClose;
    }
}