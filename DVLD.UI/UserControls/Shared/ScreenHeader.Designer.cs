namespace DVLD.UI.UserControls.Shared
{
    partial class ScreenHeader
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
            this.CenterControlContainer = new DVLD.UI.UserControls.Shared.CenterControlContainer();
            this.lbTitle = new System.Windows.Forms.Label();
            this.pbScreen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // CenterControlContainer
            // 
            this.CenterControlContainer.AutoScroll = true;
            this.CenterControlContainer.BackColor = System.Drawing.Color.White;
            this.CenterControlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CenterControlContainer.Location = new System.Drawing.Point(0, 0);
            this.CenterControlContainer.Name = "CenterControlContainer";
            this.CenterControlContainer.Size = new System.Drawing.Size(477, 155);
            this.CenterControlContainer.TabIndex = 0;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Victor Mono", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.Crimson;
            this.lbTitle.Location = new System.Drawing.Point(199, 121);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(67, 26);
            this.lbTitle.TabIndex = 3;
            this.lbTitle.Text = "Title";
            // 
            // pbScreen
            // 
            this.pbScreen.Image = global::DVLD.UI.Properties.Resources.People;
            this.pbScreen.Location = new System.Drawing.Point(163, 12);
            this.pbScreen.Name = "pbScreen";
            this.pbScreen.Size = new System.Drawing.Size(140, 106);
            this.pbScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbScreen.TabIndex = 2;
            this.pbScreen.TabStop = false;
            // 
            // ScreenHeader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.pbScreen);
            this.Controls.Add(this.CenterControlContainer);
            this.Name = "ScreenHeader";
            this.Size = new System.Drawing.Size(477, 155);
            this.Load += new System.EventHandler(this.ScreenHeader_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbScreen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CenterControlContainer CenterControlContainer;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.PictureBox pbScreen;
    }
}
