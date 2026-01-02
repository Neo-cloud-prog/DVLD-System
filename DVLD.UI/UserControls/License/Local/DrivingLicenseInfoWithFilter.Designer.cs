namespace DVLD.UI.UserControls.License.Local
{
    partial class DrivingLicenseInfoWithFilter
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DrivingLicenseInfoWithFilter));
            this.DrivingLicenseInfo = new DVLD.UI.UserControls.License.Local.DrivingLicenseInfo();
            this.ibtnSearch = new DVLD.UI.UserControls.Shared.IconButton();
            this.tbSearchText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DrivingLicenseInfo
            // 
            this.DrivingLicenseInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DrivingLicenseInfo.Location = new System.Drawing.Point(0, 47);
            this.DrivingLicenseInfo.Name = "DrivingLicenseInfo";
            this.DrivingLicenseInfo.Size = new System.Drawing.Size(682, 293);
            this.DrivingLicenseInfo.TabIndex = 30;
            // 
            // ibtnSearch
            // 
            this.ibtnSearch.BakColor = System.Drawing.Color.Snow;
            this.ibtnSearch.Icon = ((System.Drawing.Image)(resources.GetObject("ibtnSearch.Icon")));
            this.ibtnSearch.IconSize = new System.Drawing.Size(15, 15);
            this.ibtnSearch.Location = new System.Drawing.Point(243, 12);
            this.ibtnSearch.Name = "ibtnSearch";
            this.ibtnSearch.Size = new System.Drawing.Size(35, 20);
            this.ibtnSearch.TabIndex = 33;
            this.ibtnSearch.TextColor = System.Drawing.Color.Black;
            this.ibtnSearch.Value = "";
            this.ibtnSearch.Click += new System.EventHandler(this.ibtnSearch_Click);
            // 
            // tbSearchText
            // 
            this.tbSearchText.Location = new System.Drawing.Point(97, 12);
            this.tbSearchText.Name = "tbSearchText";
            this.tbSearchText.Size = new System.Drawing.Size(140, 20);
            this.tbSearchText.TabIndex = 32;
            this.tbSearchText.TextChanged += new System.EventHandler(this.tbSearchText_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 31;
            this.label1.Text = "Licernse ID:";
            // 
            // DrivingLicenseInfoWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ibtnSearch);
            this.Controls.Add(this.tbSearchText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DrivingLicenseInfo);
            this.Name = "DrivingLicenseInfoWithFilter";
            this.Size = new System.Drawing.Size(682, 340);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DrivingLicenseInfo DrivingLicenseInfo;
        private Shared.IconButton ibtnSearch;
        private System.Windows.Forms.TextBox tbSearchText;
        private System.Windows.Forms.Label label1;
    }
}
