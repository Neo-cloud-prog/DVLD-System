namespace DVLD.UI.Screens.Application
{
    partial class frmUpdateApplicationType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdateApplicationType));
            this.label1 = new System.Windows.Forms.Label();
            this.lbAppTypeID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.tbFees = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ibtnClose = new DVLD.UI.UserControls.Shared.IconButton();
            this.ibtnSave = new DVLD.UI.UserControls.Shared.IconButton();
            this.screenHeader1 = new DVLD.UI.UserControls.Shared.ScreenHeader();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID      :";
            // 
            // lbAppTypeID
            // 
            this.lbAppTypeID.AutoSize = true;
            this.lbAppTypeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAppTypeID.Location = new System.Drawing.Point(77, 81);
            this.lbAppTypeID.Name = "lbAppTypeID";
            this.lbAppTypeID.Size = new System.Drawing.Size(31, 16);
            this.lbAppTypeID.TabIndex = 3;
            this.lbAppTypeID.Text = "???";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tilte  :";
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(80, 120);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(229, 20);
            this.tbTitle.TabIndex = 5;
            // 
            // tbFees
            // 
            this.tbFees.Location = new System.Drawing.Point(80, 166);
            this.tbFees.Name = "tbFees";
            this.tbFees.Size = new System.Drawing.Size(229, 20);
            this.tbFees.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fees :";
            // 
            // ibtnClose
            // 
            this.ibtnClose.BakColor = System.Drawing.Color.Tomato;
            this.ibtnClose.IconSize = new System.Drawing.Size(24, 24);
            this.ibtnClose.Location = new System.Drawing.Point(117, 192);
            this.ibtnClose.Name = "ibtnClose";
            this.ibtnClose.Size = new System.Drawing.Size(93, 38);
            this.ibtnClose.TabIndex = 8;
            this.ibtnClose.TextColor = System.Drawing.Color.Black;
            this.ibtnClose.Value = "Close";
            this.ibtnClose.Click += new System.EventHandler(this.ibtnClose_OnClick);
            // 
            // ibtnSave
            // 
            this.ibtnSave.BakColor = System.Drawing.Color.White;
            this.ibtnSave.Icon = ((System.Drawing.Image)(resources.GetObject("ibtnSave.Icon")));
            this.ibtnSave.IconSize = new System.Drawing.Size(24, 24);
            this.ibtnSave.Location = new System.Drawing.Point(216, 192);
            this.ibtnSave.Name = "ibtnSave";
            this.ibtnSave.Size = new System.Drawing.Size(93, 38);
            this.ibtnSave.TabIndex = 9;
            this.ibtnSave.TextColor = System.Drawing.Color.Black;
            this.ibtnSave.Value = "Save";
            this.ibtnSave.Click += new System.EventHandler(this.ibtnSave_OnClick);
            // 
            // screenHeader1
            // 
            this.screenHeader1.BackColor = System.Drawing.Color.White;
            this.screenHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.screenHeader1.Location = new System.Drawing.Point(0, 0);
            this.screenHeader1.Name = "screenHeader1";
            this.screenHeader1.Size = new System.Drawing.Size(335, 57);
            this.screenHeader1.TabIndex = 10;
            // 
            // frmUpdateApplicationType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(335, 243);
            this.Controls.Add(this.screenHeader1);
            this.Controls.Add(this.ibtnSave);
            this.Controls.Add(this.ibtnClose);
            this.Controls.Add(this.tbFees);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbAppTypeID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmUpdateApplicationType";
            this.Text = "Update Application Type";
            this.Load += new System.EventHandler(this.frmUpdateApplicationType_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbAppTypeID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.TextBox tbFees;
        private System.Windows.Forms.Label label3;
        private UserControls.Shared.IconButton ibtnClose;
        private UserControls.Shared.IconButton ibtnSave;
        private UserControls.Shared.ScreenHeader screenHeader1;
    }
}