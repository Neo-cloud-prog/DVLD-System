namespace DVLD.UI.Screens.Person
{
    partial class frmPersonDetails
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
            this.PersonDetailsControl = new DVLD.UI.UserControls.Person.PersonDetails();
            this.SuspendLayout();
            // 
            // PersonDetailsControl
            // 
            this.PersonDetailsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PersonDetailsControl.Location = new System.Drawing.Point(0, 0);
            this.PersonDetailsControl.Name = "PersonDetailsControl";
            this.PersonDetailsControl.Size = new System.Drawing.Size(680, 248);
            this.PersonDetailsControl.TabIndex = 0;
            this.PersonDetailsControl.ParentChanged += new System.EventHandler(this.PersonDetailsControl_ParsonChanged);
            // 
            // frmPersonDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 248);
            this.Controls.Add(this.PersonDetailsControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmPersonDetails";
            this.Text = "frmPersonDetails";
            this.Load += new System.EventHandler(this.frmPersonDetails_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public UserControls.Person.PersonDetails PersonDetailsControl;
    }
}