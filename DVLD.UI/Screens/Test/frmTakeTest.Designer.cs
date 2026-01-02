namespace DVLD.UI.Screens.Test
{
    partial class frmTakeTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTakeTest));
            this.label7 = new System.Windows.Forms.Label();
            this.rbPass = new System.Windows.Forms.RadioButton();
            this.rbFail = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.tbNotes = new System.Windows.Forms.TextBox();
            this.ibtnClose = new DVLD.UI.UserControls.Shared.IconButton();
            this.ibtnSave = new DVLD.UI.UserControls.Shared.IconButton();
            this.ucScheduleTest = new DVLD.UI.UserControls.Test.ucScheduleTest();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTestID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(5, 419);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Result :";
            // 
            // rbPass
            // 
            this.rbPass.AutoSize = true;
            this.rbPass.Location = new System.Drawing.Point(67, 419);
            this.rbPass.Name = "rbPass";
            this.rbPass.Size = new System.Drawing.Size(48, 17);
            this.rbPass.TabIndex = 16;
            this.rbPass.Text = "Pass";
            this.rbPass.UseVisualStyleBackColor = true;
            // 
            // rbFail
            // 
            this.rbFail.AutoSize = true;
            this.rbFail.Checked = true;
            this.rbFail.Location = new System.Drawing.Point(121, 419);
            this.rbFail.Name = "rbFail";
            this.rbFail.Size = new System.Drawing.Size(41, 17);
            this.rbFail.TabIndex = 17;
            this.rbFail.TabStop = true;
            this.rbFail.Text = "Fail";
            this.rbFail.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 463);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "Notes :";
            // 
            // tbNotes
            // 
            this.tbNotes.Location = new System.Drawing.Point(67, 463);
            this.tbNotes.Multiline = true;
            this.tbNotes.Name = "tbNotes";
            this.tbNotes.Size = new System.Drawing.Size(328, 71);
            this.tbNotes.TabIndex = 19;
            // 
            // ibtnClose
            // 
            this.ibtnClose.BakColor = System.Drawing.Color.Snow;
            this.ibtnClose.Icon = ((System.Drawing.Image)(resources.GetObject("ibtnClose.Icon")));
            this.ibtnClose.IconSize = new System.Drawing.Size(24, 24);
            this.ibtnClose.Location = new System.Drawing.Point(171, 550);
            this.ibtnClose.Name = "ibtnClose";
            this.ibtnClose.Size = new System.Drawing.Size(108, 43);
            this.ibtnClose.TabIndex = 4;
            this.ibtnClose.TextColor = System.Drawing.Color.Black;
            this.ibtnClose.Value = "Close";
            this.ibtnClose.Click += new System.EventHandler(this.ibtnClose_Click);
            // 
            // ibtnSave
            // 
            this.ibtnSave.BakColor = System.Drawing.Color.Snow;
            this.ibtnSave.Icon = ((System.Drawing.Image)(resources.GetObject("ibtnSave.Icon")));
            this.ibtnSave.IconSize = new System.Drawing.Size(24, 24);
            this.ibtnSave.Location = new System.Drawing.Point(287, 550);
            this.ibtnSave.Name = "ibtnSave";
            this.ibtnSave.Size = new System.Drawing.Size(108, 43);
            this.ibtnSave.TabIndex = 8;
            this.ibtnSave.TextColor = System.Drawing.Color.Black;
            this.ibtnSave.Value = "Save";
            this.ibtnSave.Click += new System.EventHandler(this.ibtnSave_OnClick);
            // 
            // ucScheduleTest
            // 
            this.ucScheduleTest.BackColor = System.Drawing.Color.White;
            this.ucScheduleTest.GroupBoxHeight = 390;
            this.ucScheduleTest.Location = new System.Drawing.Point(9, 12);
            this.ucScheduleTest.Name = "ucScheduleTest";
            this.ucScheduleTest.Padding = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.ucScheduleTest.Size = new System.Drawing.Size(386, 404);
            this.ucScheduleTest.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 366);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 23;
            this.label1.Text = "Test.ID       :";
            // 
            // lbTestID
            // 
            this.lbTestID.AutoSize = true;
            this.lbTestID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTestID.Location = new System.Drawing.Point(110, 366);
            this.lbTestID.Name = "lbTestID";
            this.lbTestID.Size = new System.Drawing.Size(96, 15);
            this.lbTestID.TabIndex = 24;
            this.lbTestID.Text = "Not Taken Yet";
            // 
            // frmTakeTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(407, 604);
            this.Controls.Add(this.lbTestID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ucScheduleTest);
            this.Controls.Add(this.tbNotes);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.rbFail);
            this.Controls.Add(this.rbPass);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ibtnClose);
            this.Controls.Add(this.ibtnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmTakeTest";
            this.Text = "Take Test";
            this.Load += new System.EventHandler(this.frmTakeTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private UserControls.Shared.IconButton ibtnSave;
        private UserControls.Shared.IconButton ibtnClose;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rbPass;
        private System.Windows.Forms.RadioButton rbFail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbNotes;
        private UserControls.Test.ucScheduleTest ucScheduleTest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTestID;
    }
}