namespace DVLD.UI.UserControls.User
{
    partial class UserInformation
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
            this.gbUserInformation = new System.Windows.Forms.GroupBox();
            this.lbIsAvtive = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbUserID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PersonDetails = new DVLD.UI.UserControls.Person.PersonDetails();
            this.gbUserInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbUserInformation
            // 
            this.gbUserInformation.BackColor = System.Drawing.Color.White;
            this.gbUserInformation.Controls.Add(this.lbIsAvtive);
            this.gbUserInformation.Controls.Add(this.label5);
            this.gbUserInformation.Controls.Add(this.lbUsername);
            this.gbUserInformation.Controls.Add(this.label3);
            this.gbUserInformation.Controls.Add(this.lbUserID);
            this.gbUserInformation.Controls.Add(this.label1);
            this.gbUserInformation.Location = new System.Drawing.Point(3, 253);
            this.gbUserInformation.Name = "gbUserInformation";
            this.gbUserInformation.Size = new System.Drawing.Size(692, 58);
            this.gbUserInformation.TabIndex = 0;
            this.gbUserInformation.TabStop = false;
            this.gbUserInformation.Text = "User Information";
            // 
            // lbIsAvtive
            // 
            this.lbIsAvtive.AutoSize = true;
            this.lbIsAvtive.Location = new System.Drawing.Point(601, 26);
            this.lbIsAvtive.Name = "lbIsAvtive";
            this.lbIsAvtive.Size = new System.Drawing.Size(13, 13);
            this.lbIsAvtive.TabIndex = 5;
            this.lbIsAvtive.Text = "?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(549, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Is Active:";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Location = new System.Drawing.Point(388, 26);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(13, 13);
            this.lbUsername.TabIndex = 3;
            this.lbUsername.Text = "?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(324, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Username:";
            // 
            // lbUserID
            // 
            this.lbUserID.AutoSize = true;
            this.lbUserID.Location = new System.Drawing.Point(144, 26);
            this.lbUserID.Name = "lbUserID";
            this.lbUserID.Size = new System.Drawing.Size(13, 13);
            this.lbUserID.TabIndex = 1;
            this.lbUserID.Text = "?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "User ID:";
            // 
            // PersonDetails
            // 
            this.PersonDetails.Location = new System.Drawing.Point(3, 3);
            this.PersonDetails.Name = "PersonDetails";
            this.PersonDetails.Size = new System.Drawing.Size(689, 244);
            this.PersonDetails.TabIndex = 1;
            // 
            // UserInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.PersonDetails);
            this.Controls.Add(this.gbUserInformation);
            this.Name = "UserInformation";
            this.Size = new System.Drawing.Size(695, 317);
            this.gbUserInformation.ResumeLayout(false);
            this.gbUserInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbUserInformation;
        private System.Windows.Forms.Label lbIsAvtive;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbUserID;
        private System.Windows.Forms.Label label1;
        private Person.PersonDetails PersonDetails;
    }
}
