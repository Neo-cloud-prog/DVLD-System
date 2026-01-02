namespace DVLD.UI.Screens.User
{
    partial class frmAddUpdateUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddUpdateUser));
            this.lbTitle = new System.Windows.Forms.Label();
            this.AddNewUserTab = new System.Windows.Forms.TabControl();
            this.PersonInfoTab = new System.Windows.Forms.TabPage();
            this.PersonDetailsWithFilter = new DVLD.UI.UserControls.Person.PersonDetailsWithFilter();
            this.btnNext = new DVLD.UI.UserControls.Shared.IconButton();
            this.LoginInfoTab = new System.Windows.Forms.TabPage();
            this.tbConfirmPassword = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.chkIsActive = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbUserID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose = new DVLD.UI.UserControls.Shared.IconButton();
            this.btnSave = new DVLD.UI.UserControls.Shared.IconButton();
            this.CenterControlContainer = new DVLD.UI.UserControls.Shared.CenterControlContainer();
            this.AddNewUserValidator = new DVLD.UI.Components.Validation.Validator(this.components);
            this.AddNewUserErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.AddNewUserTab.SuspendLayout();
            this.PersonInfoTab.SuspendLayout();
            this.LoginInfoTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddNewUserErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.BackColor = System.Drawing.Color.White;
            this.lbTitle.Font = new System.Drawing.Font("Magneto", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.Crimson;
            this.lbTitle.Location = new System.Drawing.Point(239, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(322, 45);
            this.lbTitle.TabIndex = 4;
            this.lbTitle.Text = "Add New User";
            // 
            // AddNewUserTab
            // 
            this.AddNewUserTab.Controls.Add(this.PersonInfoTab);
            this.AddNewUserTab.Controls.Add(this.LoginInfoTab);
            this.AddNewUserTab.Location = new System.Drawing.Point(13, 107);
            this.AddNewUserTab.Name = "AddNewUserTab";
            this.AddNewUserTab.SelectedIndex = 0;
            this.AddNewUserTab.Size = new System.Drawing.Size(715, 417);
            this.AddNewUserTab.TabIndex = 5;
            // 
            // PersonInfoTab
            // 
            this.PersonInfoTab.Controls.Add(this.PersonDetailsWithFilter);
            this.PersonInfoTab.Controls.Add(this.btnNext);
            this.PersonInfoTab.Location = new System.Drawing.Point(4, 22);
            this.PersonInfoTab.Name = "PersonInfoTab";
            this.PersonInfoTab.Padding = new System.Windows.Forms.Padding(3);
            this.PersonInfoTab.Size = new System.Drawing.Size(707, 391);
            this.PersonInfoTab.TabIndex = 0;
            this.PersonInfoTab.Text = "Person Info";
            this.PersonInfoTab.UseVisualStyleBackColor = true;
            // 
            // PersonDetailsWithFilter
            // 
            this.PersonDetailsWithFilter.BackColor = System.Drawing.Color.White;
            this.PersonDetailsWithFilter.Location = new System.Drawing.Point(6, 6);
            this.PersonDetailsWithFilter.Name = "PersonDetailsWithFilter";
            this.PersonDetailsWithFilter.Size = new System.Drawing.Size(695, 324);
            this.PersonDetailsWithFilter.TabIndex = 4;
            // 
            // btnNext
            // 
            this.btnNext.BakColor = System.Drawing.Color.Snow;
            this.btnNext.Icon = ((System.Drawing.Image)(resources.GetObject("btnNext.Icon")));
            this.btnNext.IconSize = new System.Drawing.Size(24, 24);
            this.btnNext.Location = new System.Drawing.Point(593, 336);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(108, 43);
            this.btnNext.TabIndex = 3;
            this.btnNext.TextColor = System.Drawing.Color.Black;
            this.btnNext.Value = "Next";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // LoginInfoTab
            // 
            this.LoginInfoTab.Controls.Add(this.tbConfirmPassword);
            this.LoginInfoTab.Controls.Add(this.tbPassword);
            this.LoginInfoTab.Controls.Add(this.tbUserName);
            this.LoginInfoTab.Controls.Add(this.chkIsActive);
            this.LoginInfoTab.Controls.Add(this.label7);
            this.LoginInfoTab.Controls.Add(this.label5);
            this.LoginInfoTab.Controls.Add(this.label3);
            this.LoginInfoTab.Controls.Add(this.lbUserID);
            this.LoginInfoTab.Controls.Add(this.label2);
            this.LoginInfoTab.Location = new System.Drawing.Point(4, 22);
            this.LoginInfoTab.Name = "LoginInfoTab";
            this.LoginInfoTab.Padding = new System.Windows.Forms.Padding(3);
            this.LoginInfoTab.Size = new System.Drawing.Size(707, 391);
            this.LoginInfoTab.TabIndex = 1;
            this.LoginInfoTab.Text = "Login Info";
            this.LoginInfoTab.UseVisualStyleBackColor = true;
            // 
            // tbConfirmPassword
            // 
            this.tbConfirmPassword.Location = new System.Drawing.Point(160, 207);
            this.tbConfirmPassword.Name = "tbConfirmPassword";
            this.tbConfirmPassword.Size = new System.Drawing.Size(135, 20);
            this.tbConfirmPassword.TabIndex = 15;
            this.tbConfirmPassword.UseSystemPasswordChar = true;
            this.tbConfirmPassword.Leave += new System.EventHandler(this.tbConfirmPassword_Leave);
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(160, 157);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(135, 20);
            this.tbPassword.TabIndex = 14;
            this.tbPassword.UseSystemPasswordChar = true;
            this.tbPassword.Leave += new System.EventHandler(this.tbPassword_Leave);
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(160, 104);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(135, 20);
            this.tbUserName.TabIndex = 13;
            this.tbUserName.Leave += new System.EventHandler(this.tbUserName_Leave);
            // 
            // chkIsActive
            // 
            this.chkIsActive.AutoSize = true;
            this.chkIsActive.Checked = true;
            this.chkIsActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIsActive.Location = new System.Drawing.Point(163, 249);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(67, 17);
            this.chkIsActive.TabIndex = 12;
            this.chkIsActive.Text = "Is Avtive";
            this.chkIsActive.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Confirm Password :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(65, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "UserName :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(71, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password :";
            // 
            // lbUserID
            // 
            this.lbUserID.AutoSize = true;
            this.lbUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserID.Location = new System.Drawing.Point(160, 48);
            this.lbUserID.Name = "lbUserID";
            this.lbUserID.Size = new System.Drawing.Size(31, 16);
            this.lbUserID.TabIndex = 5;
            this.lbUserID.Text = "???";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(91, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "UserID :";
            // 
            // btnClose
            // 
            this.btnClose.BakColor = System.Drawing.Color.Snow;
            this.btnClose.Icon = ((System.Drawing.Image)(resources.GetObject("btnClose.Icon")));
            this.btnClose.IconSize = new System.Drawing.Size(24, 24);
            this.btnClose.Location = new System.Drawing.Point(496, 530);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(108, 43);
            this.btnClose.TabIndex = 4;
            this.btnClose.TextColor = System.Drawing.Color.Black;
            this.btnClose.Value = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.BakColor = System.Drawing.Color.Snow;
            this.btnSave.Enabled = false;
            this.btnSave.Icon = ((System.Drawing.Image)(resources.GetObject("btnSave.Icon")));
            this.btnSave.IconSize = new System.Drawing.Size(24, 24);
            this.btnSave.Location = new System.Drawing.Point(610, 530);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(108, 43);
            this.btnSave.TabIndex = 6;
            this.btnSave.TextColor = System.Drawing.Color.Black;
            this.btnSave.Value = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // CenterControlContainer
            // 
            this.CenterControlContainer.AutoScroll = true;
            this.CenterControlContainer.BackColor = System.Drawing.Color.White;
            this.CenterControlContainer.Location = new System.Drawing.Point(0, -2);
            this.CenterControlContainer.Name = "CenterControlContainer";
            this.CenterControlContainer.Size = new System.Drawing.Size(800, 68);
            this.CenterControlContainer.TabIndex = 0;
            // 
            // AddNewUserErrorProvider
            // 
            this.AddNewUserErrorProvider.ContainerControl = this;
            // 
            // frmAddUpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(735, 584);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.AddNewUserTab);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.CenterControlContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmAddUpdateUser";
            this.Text = "Add New User";
            this.Load += new System.EventHandler(this.frmAddUpdateUser_Load);
            this.AddNewUserTab.ResumeLayout(false);
            this.PersonInfoTab.ResumeLayout(false);
            this.LoginInfoTab.ResumeLayout(false);
            this.LoginInfoTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddNewUserErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.TabControl AddNewUserTab;
        private System.Windows.Forms.TabPage PersonInfoTab;
        private System.Windows.Forms.TabPage LoginInfoTab;
        private UserControls.Shared.IconButton btnNext;
        private UserControls.Shared.IconButton btnClose;
        private UserControls.Shared.IconButton btnSave;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbUserID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbConfirmPassword;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.CheckBox chkIsActive;
        private UserControls.Person.PersonDetailsWithFilter PersonDetailsWithFilter;
        private UserControls.Shared.CenterControlContainer CenterControlContainer;
        private Components.Validation.Validator AddNewUserValidator;
        private System.Windows.Forms.ErrorProvider AddNewUserErrorProvider;
    }
}