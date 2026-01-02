namespace DVLD.UI.Screens.Test
{
    partial class frmManageTestTypes
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
            this.screenHeader1 = new DVLD.UI.UserControls.Shared.ScreenHeader();
            this.sbTestTypes = new DVLD.UI.UserControls.Shared.ManagementScreenBody();
            this.cmsTestType = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editTestTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsTestType.SuspendLayout();
            this.SuspendLayout();
            // 
            // screenHeader1
            // 
            this.screenHeader1.BackColor = System.Drawing.Color.White;
            this.screenHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.screenHeader1.Location = new System.Drawing.Point(0, 0);
            this.screenHeader1.Name = "screenHeader1";
            this.screenHeader1.Size = new System.Drawing.Size(463, 155);
            this.screenHeader1.TabIndex = 18;
            // 
            // sbTestTypes
            // 
            this.sbTestTypes.DataGridViewContextMenu = this.cmsTestType;
            this.sbTestTypes.Location = new System.Drawing.Point(9, 161);
            this.sbTestTypes.Name = "sbTestTypes";
            this.sbTestTypes.Size = new System.Drawing.Size(445, 158);
            this.sbTestTypes.TabIndex = 8;
            // 
            // cmsTestType
            // 
            this.cmsTestType.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editTestTypeToolStripMenuItem});
            this.cmsTestType.Name = "cmsTestType";
            this.cmsTestType.Size = new System.Drawing.Size(181, 48);
            // 
            // editTestTypeToolStripMenuItem
            // 
            this.editTestTypeToolStripMenuItem.Name = "editTestTypeToolStripMenuItem";
            this.editTestTypeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editTestTypeToolStripMenuItem.Text = "Edit Test Type";
            this.editTestTypeToolStripMenuItem.Click += new System.EventHandler(this.editTestTypeToolStripMenuItem_Click);
            // 
            // frmManageTestTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(463, 324);
            this.Controls.Add(this.screenHeader1);
            this.Controls.Add(this.sbTestTypes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmManageTestTypes";
            this.Text = "Manage Test Types";
            this.Load += new System.EventHandler(this.frmManageTestTypes_Load);
            this.cmsTestType.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.Shared.ManagementScreenBody sbTestTypes;
        private UserControls.Shared.ScreenHeader screenHeader1;
        private System.Windows.Forms.ContextMenuStrip cmsTestType;
        private System.Windows.Forms.ToolStripMenuItem editTestTypeToolStripMenuItem;
    }
}