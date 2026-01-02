namespace DVLD.UI.Screens.Person
{
    partial class frmManagePeople
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManagePeople));
            this.cmsPerson = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.sendEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phoneCallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sbPeople = new DVLD.UI.UserControls.Shared.ManagementScreenBody();
            this.screenHeader1 = new DVLD.UI.UserControls.Shared.ScreenHeader();
            this.btnAddPerson = new DVLD.UI.UserControls.Shared.IconButton();
            this.DataGridViewFilter = new DVLD.UI.UserControls.Shared.DataGridViewFilter();
            this.cmsPerson.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmsPerson
            // 
            this.cmsPerson.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsToolStripMenuItem,
            this.addNewToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripMenuItem2,
            this.sendEmailToolStripMenuItem,
            this.phoneCallToolStripMenuItem});
            this.cmsPerson.Name = "contextMenuStrip1";
            this.cmsPerson.Size = new System.Drawing.Size(163, 142);
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.showDetailsToolStripMenuItem.Text = "Show Details";
            this.showDetailsToolStripMenuItem.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click);
            // 
            // addNewToolStripMenuItem
            // 
            this.addNewToolStripMenuItem.Name = "addNewToolStripMenuItem";
            this.addNewToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.addNewToolStripMenuItem.Text = "Add New Person";
            this.addNewToolStripMenuItem.Click += new System.EventHandler(this.addNewToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(159, 6);
            // 
            // sendEmailToolStripMenuItem
            // 
            this.sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            this.sendEmailToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.sendEmailToolStripMenuItem.Text = "Send Email";
            this.sendEmailToolStripMenuItem.Click += new System.EventHandler(this.sendEmailToolStripMenuItem_Click);
            // 
            // phoneCallToolStripMenuItem
            // 
            this.phoneCallToolStripMenuItem.Name = "phoneCallToolStripMenuItem";
            this.phoneCallToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.phoneCallToolStripMenuItem.Text = "Phone Call";
            this.phoneCallToolStripMenuItem.Click += new System.EventHandler(this.phoneCallToolStripMenuItem_Click);
            // 
            // sbPeople
            // 
            this.sbPeople.DataGridViewContextMenu = this.cmsPerson;
            this.sbPeople.HideCloseButton = true;
            this.sbPeople.Location = new System.Drawing.Point(13, 250);
            this.sbPeople.Name = "sbPeople";
            this.sbPeople.Size = new System.Drawing.Size(775, 188);
            this.sbPeople.TabIndex = 1;
            // 
            // screenHeader1
            // 
            this.screenHeader1.BackColor = System.Drawing.Color.White;
            this.screenHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.screenHeader1.Location = new System.Drawing.Point(0, 0);
            this.screenHeader1.Name = "screenHeader1";
            this.screenHeader1.Size = new System.Drawing.Size(800, 186);
            this.screenHeader1.TabIndex = 3;
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.BakColor = System.Drawing.Color.Snow;
            this.btnAddPerson.Icon = ((System.Drawing.Image)(resources.GetObject("btnAddPerson.Icon")));
            this.btnAddPerson.IconSize = new System.Drawing.Size(24, 24);
            this.btnAddPerson.Location = new System.Drawing.Point(739, 192);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(49, 43);
            this.btnAddPerson.TabIndex = 0;
            this.btnAddPerson.TextColor = System.Drawing.Color.Black;
            this.btnAddPerson.Value = "";
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // DataGridViewFilter
            // 
            this.DataGridViewFilter.Location = new System.Drawing.Point(13, 194);
            this.DataGridViewFilter.Name = "DataGridViewFilter";
            this.DataGridViewFilter.Size = new System.Drawing.Size(345, 41);
            this.DataGridViewFilter.TabIndex = 4;
            // 
            // frmManagePeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DataGridViewFilter);
            this.Controls.Add(this.sbPeople);
            this.Controls.Add(this.screenHeader1);
            this.Controls.Add(this.btnAddPerson);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmManagePeople";
            this.Text = "Manage People";
            this.Load += new System.EventHandler(this.frmManagePeople_Load);
            this.cmsPerson.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private UserControls.Shared.IconButton btnAddPerson;
        private UserControls.Shared.ScreenHeader screenHeader1;
        private UserControls.Shared.ManagementScreenBody sbPeople;
        private System.Windows.Forms.ContextMenuStrip cmsPerson;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem sendEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phoneCallToolStripMenuItem;
        private UserControls.Shared.DataGridViewFilter DataGridViewFilter;
    }
}