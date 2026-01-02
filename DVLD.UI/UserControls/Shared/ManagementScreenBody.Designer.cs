namespace DVLD.UI.UserControls.Shared
{
    partial class ManagementScreenBody
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagementScreenBody));
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.Records = new DVLD.UI.UserControls.Shared.DataGridViewCounter();
            this.btnClose = new DVLD.UI.UserControls.Shared.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView
            // 
            this.DataGridView.AllowUserToAddRows = false;
            this.DataGridView.BackgroundColor = System.Drawing.Color.White;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.DataGridView.Location = new System.Drawing.Point(0, 0);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView.Size = new System.Drawing.Size(775, 119);
            this.DataGridView.TabIndex = 5;
            // 
            // Records
            // 
            this.Records.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Records.Location = new System.Drawing.Point(3, 141);
            this.Records.Name = "Records";
            this.Records.Size = new System.Drawing.Size(109, 34);
            this.Records.TabIndex = 12;
            // 
            // btnClose
            // 
            this.btnClose.BakColor = System.Drawing.Color.Tomato;
            this.btnClose.Icon = ((System.Drawing.Image)(resources.GetObject("btnClose.Icon")));
            this.btnClose.IconSize = new System.Drawing.Size(24, 24);
            this.btnClose.Location = new System.Drawing.Point(664, 141);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(108, 43);
            this.btnClose.TabIndex = 7;
            this.btnClose.TextColor = System.Drawing.Color.Black;
            this.btnClose.Value = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ManagementScreenBody
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Records);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.DataGridView);
            this.Name = "ManagementScreenBody";
            this.Size = new System.Drawing.Size(775, 188);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.DataGridView DataGridView;
        private IconButton btnClose;
        private DataGridViewCounter Records;
    }
}
