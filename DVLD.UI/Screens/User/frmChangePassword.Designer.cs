namespace DVLD.UI.Screens.User
{
    partial class frmChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChangePassword));
            this.UserInformation = new DVLD.UI.UserControls.User.UserInformation();
            this.tbCurrentPassword = new System.Windows.Forms.TextBox();
            this.tbConfirmPassword = new System.Windows.Forms.TextBox();
            this.tbNewPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClose = new DVLD.UI.UserControls.Shared.IconButton();
            this.btnSave = new DVLD.UI.UserControls.Shared.IconButton();
            this.PasswordValidator = new DVLD.UI.Components.Validation.Validator(this.components);
            this.PasswordErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PasswordErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // UserInformation
            // 
            this.UserInformation.BackColor = System.Drawing.Color.White;
            this.UserInformation.Dock = System.Windows.Forms.DockStyle.Top;
            this.UserInformation.Location = new System.Drawing.Point(0, 0);
            this.UserInformation.Name = "UserInformation";
            this.UserInformation.Size = new System.Drawing.Size(704, 353);
            this.UserInformation.TabIndex = 7;
            // 
            // tbCurrentPassword
            // 
            this.tbCurrentPassword.Location = new System.Drawing.Point(111, 337);
            this.tbCurrentPassword.Name = "tbCurrentPassword";
            this.tbCurrentPassword.Size = new System.Drawing.Size(129, 20);
            this.tbCurrentPassword.TabIndex = 1;
            this.tbCurrentPassword.UseSystemPasswordChar = true;
            this.tbCurrentPassword.TextChanged += new System.EventHandler(this.ValidateCurrentPassword);
            this.tbCurrentPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBoxForm_KeyDown);
            this.tbCurrentPassword.Leave += new System.EventHandler(this.ValidateCurrentPassword);
            // 
            // tbConfirmPassword
            // 
            this.tbConfirmPassword.Location = new System.Drawing.Point(111, 395);
            this.tbConfirmPassword.Name = "tbConfirmPassword";
            this.tbConfirmPassword.Size = new System.Drawing.Size(129, 20);
            this.tbConfirmPassword.TabIndex = 3;
            this.tbConfirmPassword.UseSystemPasswordChar = true;
            this.tbConfirmPassword.TextChanged += new System.EventHandler(this.ValidateConfirmPassword);
            this.tbConfirmPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBoxForm_KeyDown);
            this.tbConfirmPassword.Leave += new System.EventHandler(this.ValidateConfirmPassword);
            // 
            // tbNewPassword
            // 
            this.tbNewPassword.Location = new System.Drawing.Point(111, 369);
            this.tbNewPassword.Name = "tbNewPassword";
            this.tbNewPassword.Size = new System.Drawing.Size(129, 20);
            this.tbNewPassword.TabIndex = 2;
            this.tbNewPassword.UseSystemPasswordChar = true;
            this.tbNewPassword.TextChanged += new System.EventHandler(this.ValidateNewPassword);
            this.tbNewPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBoxForm_KeyDown);
            this.tbNewPassword.Leave += new System.EventHandler(this.ValidateNewPassword);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 340);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Current Password :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 398);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Confirm Password :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 372);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "New Password     :";
            // 
            // btnClose
            // 
            this.btnClose.BakColor = System.Drawing.Color.Tomato;
            this.btnClose.IconSize = new System.Drawing.Size(24, 24);
            this.btnClose.Location = new System.Drawing.Point(472, 372);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(108, 43);
            this.btnClose.TabIndex = 5;
            this.btnClose.TextColor = System.Drawing.Color.White;
            this.btnClose.Value = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.BakColor = System.Drawing.Color.White;
            this.btnSave.Icon = ((System.Drawing.Image)(resources.GetObject("btnSave.Icon")));
            this.btnSave.IconSize = new System.Drawing.Size(24, 24);
            this.btnSave.Location = new System.Drawing.Point(586, 372);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(108, 43);
            this.btnSave.TabIndex = 4;
            this.btnSave.TextColor = System.Drawing.Color.DimGray;
            this.btnSave.Value = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // PasswordErrorProvider
            // 
            this.PasswordErrorProvider.ContainerControl = this;
            // 
            // frmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(704, 430);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNewPassword);
            this.Controls.Add(this.tbConfirmPassword);
            this.Controls.Add(this.tbCurrentPassword);
            this.Controls.Add(this.UserInformation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmChangePassword";
            this.Text = "frmChangePassword";
            this.Load += new System.EventHandler(this.frmChangePassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PasswordErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.User.UserInformation UserInformation;
        private System.Windows.Forms.TextBox tbCurrentPassword;
        private System.Windows.Forms.TextBox tbConfirmPassword;
        private System.Windows.Forms.TextBox tbNewPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private UserControls.Shared.IconButton btnClose;
        private UserControls.Shared.IconButton btnSave;
        private Components.Validation.Validator PasswordValidator;
        private System.Windows.Forms.ErrorProvider PasswordErrorProvider;
    }
}