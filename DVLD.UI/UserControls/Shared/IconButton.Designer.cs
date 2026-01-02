namespace DVLD.UI.UserControls.Shared
{
    partial class IconButton
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IconButton));
            this.IconBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IconBtn
            // 
            this.IconBtn.BackColor = System.Drawing.Color.Snow;
            this.IconBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.IconBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IconBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IconBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IconBtn.ForeColor = System.Drawing.Color.Black;
            this.IconBtn.Image = ((System.Drawing.Image)(resources.GetObject("IconBtn.Image")));
            this.IconBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IconBtn.Location = new System.Drawing.Point(0, 0);
            this.IconBtn.Name = "IconBtn";
            this.IconBtn.Size = new System.Drawing.Size(108, 43);
            this.IconBtn.TabIndex = 2;
            this.IconBtn.Text = "button";
            this.IconBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.IconBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.IconBtn.UseVisualStyleBackColor = false;
            // 
            // IconButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.IconBtn);
            this.Name = "IconButton";
            this.Size = new System.Drawing.Size(108, 43);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button IconBtn;
    }
}
