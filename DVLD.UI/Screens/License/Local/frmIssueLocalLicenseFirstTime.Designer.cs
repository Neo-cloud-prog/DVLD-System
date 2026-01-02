namespace DVLD.UI.Screens.License.Local
{
    partial class frmIssueLocalLicenseFirstTime
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIssueLocalLicenseFirstTime));
            this.tbNotes = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ibtnSave = new DVLD.UI.UserControls.Shared.IconButton();
            this.ibtnClose = new DVLD.UI.UserControls.Shared.IconButton();
            this.ApplicationDetails = new DVLD.UI.UserControls.Application.ApplicationDetails();
            this.SuspendLayout();
            // 
            // tbNotes
            // 
            this.tbNotes.Location = new System.Drawing.Point(76, 335);
            this.tbNotes.Multiline = true;
            this.tbNotes.Name = "tbNotes";
            this.tbNotes.Size = new System.Drawing.Size(607, 71);
            this.tbNotes.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 335);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 15);
            this.label8.TabIndex = 20;
            this.label8.Text = "Notes :";
            // 
            // ibtnSave
            // 
            this.ibtnSave.BakColor = System.Drawing.Color.Snow;
            this.ibtnSave.Icon = ((System.Drawing.Image)(resources.GetObject("ibtnSave.Icon")));
            this.ibtnSave.IconSize = new System.Drawing.Size(24, 24);
            this.ibtnSave.Location = new System.Drawing.Point(575, 412);
            this.ibtnSave.Name = "ibtnSave";
            this.ibtnSave.Size = new System.Drawing.Size(108, 43);
            this.ibtnSave.TabIndex = 23;
            this.ibtnSave.TextColor = System.Drawing.Color.Black;
            this.ibtnSave.Value = "Save";
            this.ibtnSave.Click += new System.EventHandler(this.ibtnSave_Click);
            // 
            // ibtnClose
            // 
            this.ibtnClose.BakColor = System.Drawing.Color.Snow;
            this.ibtnClose.Icon = ((System.Drawing.Image)(resources.GetObject("ibtnClose.Icon")));
            this.ibtnClose.IconSize = new System.Drawing.Size(24, 24);
            this.ibtnClose.Location = new System.Drawing.Point(461, 412);
            this.ibtnClose.Name = "ibtnClose";
            this.ibtnClose.Size = new System.Drawing.Size(108, 43);
            this.ibtnClose.TabIndex = 22;
            this.ibtnClose.TextColor = System.Drawing.Color.Black;
            this.ibtnClose.Value = "Close";
            this.ibtnClose.Click += new System.EventHandler(this.ibtnClose_Click);
            // 
            // ApplicationDetails
            // 
            this.ApplicationDetails.BackColor = System.Drawing.Color.White;
            this.ApplicationDetails.Location = new System.Drawing.Point(12, 12);
            this.ApplicationDetails.Name = "ApplicationDetails";
            this.ApplicationDetails.Size = new System.Drawing.Size(678, 317);
            this.ApplicationDetails.TabIndex = 0;
            // 
            // frmIssueLocalLicenseFirstTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(695, 470);
            this.Controls.Add(this.ibtnSave);
            this.Controls.Add(this.ibtnClose);
            this.Controls.Add(this.tbNotes);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ApplicationDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmIssueLocalLicenseFirstTime";
            this.Text = "Issue Local License First Time";
            this.Load += new System.EventHandler(this.frmIssueLocalLicenseFirstTime_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Application.ApplicationDetails ApplicationDetails;
        private System.Windows.Forms.TextBox tbNotes;
        private System.Windows.Forms.Label label8;
        private UserControls.Shared.IconButton ibtnClose;
        private UserControls.Shared.IconButton ibtnSave;
    }
}