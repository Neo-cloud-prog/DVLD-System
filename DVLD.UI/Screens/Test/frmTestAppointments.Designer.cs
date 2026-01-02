using System.ComponentModel;
using System.Windows.Forms;

namespace DVLD.UI.Screens.Test
{
    partial class frmTestAppointments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTestAppointments));
            this.ScreenHeader = new DVLD.UI.UserControls.Shared.ScreenHeader();
            this.ApplicationDetails = new DVLD.UI.UserControls.Application.ApplicationDetails();
            this.sbAppointments = new DVLD.UI.UserControls.Shared.ManagementScreenBody();
            this.cmsTest = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.takeTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.ibtnAddAppointment = new DVLD.UI.UserControls.Shared.IconButton();
            this.cmsTest.SuspendLayout();
            this.SuspendLayout();
            // 
            // ScreenHeader
            // 
            this.ScreenHeader.BackColor = System.Drawing.Color.White;
            this.ScreenHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.ScreenHeader.Location = new System.Drawing.Point(0, 0);
            this.ScreenHeader.Name = "ScreenHeader";
            this.ScreenHeader.Size = new System.Drawing.Size(700, 155);
            this.ScreenHeader.TabIndex = 4;
            this.ScreenHeader.Title = "Test Appointments";
            // 
            // ApplicationDetails
            // 
            this.ApplicationDetails.BackColor = System.Drawing.Color.White;
            this.ApplicationDetails.Location = new System.Drawing.Point(12, 161);
            this.ApplicationDetails.Name = "ApplicationDetails";
            this.ApplicationDetails.Size = new System.Drawing.Size(686, 317);
            this.ApplicationDetails.TabIndex = 3;
            // 
            // sbAppointments
            // 
            this.sbAppointments.DataGridViewContextMenu = this.cmsTest;
            this.sbAppointments.HideCloseButton = true;
            this.sbAppointments.Location = new System.Drawing.Point(12, 549);
            this.sbAppointments.Name = "sbAppointments";
            this.sbAppointments.Size = new System.Drawing.Size(676, 188);
            this.sbAppointments.TabIndex = 5;
            // 
            // cmsTest
            // 
            this.cmsTest.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.takeTestToolStripMenuItem});
            this.cmsTest.Name = "cmsTest";
            this.cmsTest.Size = new System.Drawing.Size(121, 48);
            this.cmsTest.Opening += new System.ComponentModel.CancelEventHandler(this.cmsTest_Opening);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // takeTestToolStripMenuItem
            // 
            this.takeTestToolStripMenuItem.Name = "takeTestToolStripMenuItem";
            this.takeTestToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.takeTestToolStripMenuItem.Text = "Take Test";
            this.takeTestToolStripMenuItem.Click += new System.EventHandler(this.takeTestToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 506);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Appointments:";
            // 
            // ibtnAddAppointment
            // 
            this.ibtnAddAppointment.BakColor = System.Drawing.Color.Snow;
            this.ibtnAddAppointment.Icon = ((System.Drawing.Image)(resources.GetObject("ibtnAddAppointment.Icon")));
            this.ibtnAddAppointment.IconSize = new System.Drawing.Size(24, 24);
            this.ibtnAddAppointment.Location = new System.Drawing.Point(638, 484);
            this.ibtnAddAppointment.Name = "ibtnAddAppointment";
            this.ibtnAddAppointment.Size = new System.Drawing.Size(50, 43);
            this.ibtnAddAppointment.TabIndex = 7;
            this.ibtnAddAppointment.TextColor = System.Drawing.Color.Black;
            this.ibtnAddAppointment.Value = "";
            this.ibtnAddAppointment.Click += this.ibtnAddAppointment_OnClick;
            // 
            // frmTestAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(700, 749);
            this.Controls.Add(this.ibtnAddAppointment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sbAppointments);
            this.Controls.Add(this.ScreenHeader);
            this.Controls.Add(this.ApplicationDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmTestAppointments";
            this.Text = "Test Appointments";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmTestAppointments_FormClosed);
            this.Load += new System.EventHandler(this.frmTestAppointments_Load);
            this.cmsTest.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Application.ApplicationDetails ApplicationDetails;
        private UserControls.Shared.ScreenHeader ScreenHeader;
        private UserControls.Shared.ManagementScreenBody sbAppointments;
        private System.Windows.Forms.Label label1;
        private UserControls.Shared.IconButton ibtnAddAppointment;
        private ContextMenuStrip cmsTest;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem takeTestToolStripMenuItem;
    }
}