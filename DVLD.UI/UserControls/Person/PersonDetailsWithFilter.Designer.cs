using DVLD.UI.Events.Person;

namespace DVLD.UI.UserControls.Person
{
    partial class PersonDetailsWithFilter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonDetailsWithFilter));
            this.PersonDetails = new DVLD.UI.UserControls.Person.PersonDetails();
            this.gbFillter = new System.Windows.Forms.GroupBox();
            this.ibtnAddNewPerson = new DVLD.UI.UserControls.Shared.IconButton();
            this.ibtnSearch = new DVLD.UI.UserControls.Shared.IconButton();
            this.tbSearchText = new System.Windows.Forms.TextBox();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbFillter.SuspendLayout();
            this.SuspendLayout();
            // 
            // PersonDetails
            // 
            this.PersonDetails.Location = new System.Drawing.Point(3, 77);
            this.PersonDetails.Name = "PersonDetails";
            this.PersonDetails.Size = new System.Drawing.Size(689, 244);
            this.PersonDetails.TabIndex = 0;
            // 
            // gbFillter
            // 
            this.gbFillter.Controls.Add(this.ibtnAddNewPerson);
            this.gbFillter.Controls.Add(this.ibtnSearch);
            this.gbFillter.Controls.Add(this.tbSearchText);
            this.gbFillter.Controls.Add(this.cmbFilter);
            this.gbFillter.Controls.Add(this.label1);
            this.gbFillter.Location = new System.Drawing.Point(3, 3);
            this.gbFillter.Name = "gbFillter";
            this.gbFillter.Size = new System.Drawing.Size(451, 64);
            this.gbFillter.TabIndex = 6;
            this.gbFillter.TabStop = false;
            this.gbFillter.Text = "Filter";
            // 
            // ibtnAddNewPerson
            // 
            this.ibtnAddNewPerson.BakColor = System.Drawing.Color.Snow;
            this.ibtnAddNewPerson.Icon = ((System.Drawing.Image)(resources.GetObject("ibtnAddNewPerson.Icon")));
            this.ibtnAddNewPerson.IconSize = new System.Drawing.Size(20, 20);
            this.ibtnAddNewPerson.Location = new System.Drawing.Point(399, 18);
            this.ibtnAddNewPerson.Name = "ibtnAddNewPerson";
            this.ibtnAddNewPerson.Size = new System.Drawing.Size(31, 28);
            this.ibtnAddNewPerson.TabIndex = 9;
            this.ibtnAddNewPerson.TextColor = System.Drawing.Color.Black;
            this.ibtnAddNewPerson.Value = "";
            this.ibtnAddNewPerson.Click += new System.EventHandler(this.ibtnAddNewPerson_Click);
            // 
            // ibtnSearch
            // 
            this.ibtnSearch.BakColor = System.Drawing.Color.Snow;
            this.ibtnSearch.Icon = ((System.Drawing.Image)(resources.GetObject("ibtnSearch.Icon")));
            this.ibtnSearch.IconSize = new System.Drawing.Size(20, 20);
            this.ibtnSearch.Location = new System.Drawing.Point(362, 18);
            this.ibtnSearch.Name = "ibtnSearch";
            this.ibtnSearch.Size = new System.Drawing.Size(31, 28);
            this.ibtnSearch.TabIndex = 8;
            this.ibtnSearch.TextColor = System.Drawing.Color.Black;
            this.ibtnSearch.Value = "";
            this.ibtnSearch.Click += new System.EventHandler(this.ibtnSearch_OnClick);
            // 
            // tbSearchText
            // 
            this.tbSearchText.Location = new System.Drawing.Point(216, 22);
            this.tbSearchText.Name = "tbSearchText";
            this.tbSearchText.Size = new System.Drawing.Size(140, 20);
            this.tbSearchText.TabIndex = 7;
            this.tbSearchText.TextChanged += new System.EventHandler(this.tbSearchText_TextChanged);
            // 
            // cmbFilter
            // 
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.Location = new System.Drawing.Point(89, 22);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(121, 21);
            this.cmbFilter.TabIndex = 6;
            this.cmbFilter.SelectedIndexChanged += new System.EventHandler(this.cmbFilter_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Filter By:";
            // 
            // PersonDetailsWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gbFillter);
            this.Controls.Add(this.PersonDetails);
            this.Name = "PersonDetailsWithFilter";
            this.Size = new System.Drawing.Size(698, 327);
            this.Load += new System.EventHandler(this.PersonDetailsWithFilter_Load);
            this.gbFillter.ResumeLayout(false);
            this.gbFillter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private PersonDetails PersonDetails;
        private System.Windows.Forms.GroupBox gbFillter;
        private Shared.IconButton ibtnAddNewPerson;
        private Shared.IconButton ibtnSearch;
        private System.Windows.Forms.TextBox tbSearchText;
        private System.Windows.Forms.ComboBox cmbFilter;
        private System.Windows.Forms.Label label1;
    }
}
