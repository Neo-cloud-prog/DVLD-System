namespace DVLD.UI.Screens.Application
{
    partial class frmManageApplicationTypes
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
            this.sbApplicationTypes = new DVLD.UI.UserControls.Shared.ManagementScreenBody();
            this.screenHeader1 = new DVLD.UI.UserControls.Shared.ScreenHeader();
            this.cmsAppType = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editAppTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsAppType.SuspendLayout();
            this.SuspendLayout();
            // 
            // sbApplicationTypes
            // 
            this.sbApplicationTypes.DataGridViewContextMenu = this.cmsAppType;
            this.sbApplicationTypes.Location = new System.Drawing.Point(12, 172);
            this.sbApplicationTypes.Name = "sbApplicationTypes";
            this.sbApplicationTypes.Size = new System.Drawing.Size(362, 188);
            this.sbApplicationTypes.TabIndex = 1;
            // 
            // screenHeader1
            // 
            this.screenHeader1.BackColor = System.Drawing.Color.White;
            this.screenHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.screenHeader1.Location = new System.Drawing.Point(0, 0);
            this.screenHeader1.Name = "screenHeader1";
            this.screenHeader1.Size = new System.Drawing.Size(386, 155);
            this.screenHeader1.TabIndex = 7;
            // 
            // cmsAppType
            // 
            this.cmsAppType.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editAppTypeToolStripMenuItem});
            this.cmsAppType.Name = "cmsAppType";
            this.cmsAppType.Size = new System.Drawing.Size(181, 48);
            // 
            // editAppTypeToolStripMenuItem
            // 
            this.editAppTypeToolStripMenuItem.Name = "editAppTypeToolStripMenuItem";
            this.editAppTypeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editAppTypeToolStripMenuItem.Text = "Edit App Type";
            this.editAppTypeToolStripMenuItem.Click += new System.EventHandler(this.editAppTypeToolStripMenuItem_Click);
            // 
            // frmManageApplicationTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(386, 366);
            this.Controls.Add(this.screenHeader1);
            this.Controls.Add(this.sbApplicationTypes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmManageApplicationTypes";
            this.Text = "Manage Application Types";
            this.Load += new System.EventHandler(this.frmManageApplicationTypes_Load);
            this.cmsAppType.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.Shared.ManagementScreenBody sbApplicationTypes;
        private UserControls.Shared.ScreenHeader screenHeader1;
        private System.Windows.Forms.ContextMenuStrip cmsAppType;
        private System.Windows.Forms.ToolStripMenuItem editAppTypeToolStripMenuItem;
    }
}