namespace DVLD.UI.Layout
{
    partial class MainForm
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
            this.CenterControlContainer = new DVLD.UI.UserControls.Shared.CenterControlContainer();
            this.nav = new DVLD.UI.UserControls.Shared.NavigationMenu();
            this.lbTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CenterControlContainer
            // 
            this.CenterControlContainer.AutoScroll = true;
            this.CenterControlContainer.BackColor = System.Drawing.Color.White;
            this.CenterControlContainer.Direction = DVLD.UI.Utils.Presentation.clsPresentationUtils.enDirection.All;
            this.CenterControlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CenterControlContainer.ForeColor = System.Drawing.Color.White;
            this.CenterControlContainer.Location = new System.Drawing.Point(0, 0);
            this.CenterControlContainer.Name = "CenterControlContainer";
            this.CenterControlContainer.Size = new System.Drawing.Size(722, 316);
            this.CenterControlContainer.TabIndex = 1;
            // 
            // nav
            // 
            this.nav.Dock = System.Windows.Forms.DockStyle.Top;
            this.nav.Location = new System.Drawing.Point(0, 0);
            this.nav.Name = "nav";
            this.nav.Size = new System.Drawing.Size(722, 48);
            this.nav.TabIndex = 6;
            this.nav.OnNavigate += new System.Action<object>(this.nav_OnNavigate);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.BackColor = System.Drawing.Color.White;
            this.lbTitle.Font = new System.Drawing.Font("Magneto", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.Crimson;
            this.lbTitle.Location = new System.Drawing.Point(292, 158);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(124, 45);
            this.lbTitle.TabIndex = 3;
            this.lbTitle.Text = "Main";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 316);
            this.Controls.Add(this.nav);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.CenterControlContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private UserControls.Shared.CenterControlContainer CenterControlContainer;
        private UserControls.Shared.NavigationMenu nav;
        private System.Windows.Forms.Label lbTitle;
    }
}