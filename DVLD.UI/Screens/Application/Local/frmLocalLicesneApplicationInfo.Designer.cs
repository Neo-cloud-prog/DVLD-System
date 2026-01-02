namespace DVLD.UI.Screens.Application.Local
{
    partial class frmLocalLicesneApplicationInfo
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
            this.ApplicationDetails = new DVLD.UI.UserControls.Application.ApplicationDetails();
            this.ibtnClose = new DVLD.UI.UserControls.Shared.IconButton();
            this.SuspendLayout();
            // 
            // ApplicationDetails
            // 
            this.ApplicationDetails.BackColor = System.Drawing.Color.White;
            this.ApplicationDetails.Location = new System.Drawing.Point(12, 12);
            this.ApplicationDetails.Name = "ApplicationDetails";
            this.ApplicationDetails.Size = new System.Drawing.Size(682, 317);
            this.ApplicationDetails.TabIndex = 0;
            // 
            // ibtnClose
            // 
            this.ibtnClose.BakColor = System.Drawing.Color.Snow;
            this.ibtnClose.IconSize = new System.Drawing.Size(24, 24);
            this.ibtnClose.Location = new System.Drawing.Point(586, 335);
            this.ibtnClose.Name = "ibtnClose";
            this.ibtnClose.Size = new System.Drawing.Size(108, 43);
            this.ibtnClose.TabIndex = 1;
            this.ibtnClose.TextColor = System.Drawing.Color.Black;
            this.ibtnClose.Value = "Close";
            this.ibtnClose.Click += new System.EventHandler(this.ibtnClose_OnClick);
            // 
            // frmLocalLicesneApplicationInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(706, 385);
            this.Controls.Add(this.ibtnClose);
            this.Controls.Add(this.ApplicationDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmLocalLicesneApplicationInfo";
            this.Text = "Local Licesne Application Info";
            this.Load += new System.EventHandler(this.frmLocalLicesneApplicationInfo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.Application.ApplicationDetails ApplicationDetails;
        private UserControls.Shared.IconButton ibtnClose;
    }
}