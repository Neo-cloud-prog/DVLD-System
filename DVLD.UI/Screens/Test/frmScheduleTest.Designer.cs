using System;

namespace DVLD.UI.Screens.Test
{
    partial class frmScheduleTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmScheduleTest));
            this.ibtnClose = new DVLD.UI.UserControls.Shared.IconButton();
            this.ucScheduleTest = new DVLD.UI.UserControls.Test.ucScheduleTest();
            this.SuspendLayout();
            // 
            // ibtnClose
            // 
            this.ibtnClose.BakColor = System.Drawing.Color.Snow;
            this.ibtnClose.Icon = ((System.Drawing.Image)(resources.GetObject("ibtnClose.Icon")));
            this.ibtnClose.IconSize = new System.Drawing.Size(24, 24);
            this.ibtnClose.Location = new System.Drawing.Point(134, 563);
            this.ibtnClose.Name = "ibtnClose";
            this.ibtnClose.Size = new System.Drawing.Size(108, 40);
            this.ibtnClose.TabIndex = 2;
            this.ibtnClose.TextColor = System.Drawing.Color.Black;
            this.ibtnClose.Value = "Close";
            this.ibtnClose.Click += new System.EventHandler(this.ibtnClose_Click);
            // 
            // ucScheduleTest
            // 
            this.ucScheduleTest.BackColor = System.Drawing.Color.White;
            this.ucScheduleTest.GroupBoxHeight = 537;
            this.ucScheduleTest.Location = new System.Drawing.Point(1, 12);
            this.ucScheduleTest.Name = "ucScheduleTest";
            this.ucScheduleTest.Padding = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.ucScheduleTest.Size = new System.Drawing.Size(387, 545);
            this.ucScheduleTest.TabIndex = 3;
            // 
            // frmScheduleTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(388, 611);
            this.Controls.Add(this.ucScheduleTest);
            this.Controls.Add(this.ibtnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmScheduleTest";
            this.Text = "Schedule Test";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmScheduleTest_FormClosed);
            this.Load += new System.EventHandler(this.frmScheduleTest_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private UserControls.Shared.IconButton ibtnClose;
        private UserControls.Test.ucScheduleTest ucScheduleTest;
    }
}