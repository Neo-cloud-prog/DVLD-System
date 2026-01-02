using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using DVLD.Core.Entities.Driver;
using DVLD.UI.Screens.Person;
using DVLD.UI.Helpers.UI.GridView;
using DVLD.UI.UserControls.Shared;
using DVLD.UI.Events.Person;

namespace DVLD.UI.Screens.Driver
{
    public partial class frmManageDrivers : Form
    {
        public frmManageDrivers()
        {
            InitializeComponent();
        }

        private void LoadDrivers()
        {
            DataTable DriversTable = clsDriver.GetAllDrivers();
            sbDrivers.LoadData(DriversTable, new List<clsGridColumnDefinition>
            {
                new clsGridColumnDefinition("dcDriverID", "DriverID", "DriverID"),
                new clsGridColumnDefinition("dcPersonID", "PersonID", "PersonID"),
                new clsGridColumnDefinition("dcNationalNo", "NationalNo", "NationalNo"),
                new clsGridColumnDefinition("dcFullName", "FullName", "FullName"),
                new clsGridColumnDefinition("dcDate", "Date", "CreatedDate"),
                new clsGridColumnDefinition("dcActiveLicenses", "Active Licenses", "NumberOfActiveLicenses" )
            });
            DataGridViewFilter.Bind(sbDrivers.DataGridView);
        }

        private void frmManageDrivers_Load(object sender, EventArgs e)
        {
            LoadDrivers();
        }

        private void showPersonInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPersonDetails PersonDetails = new frmPersonDetails((int)sbDrivers.DataGridView.SelectedRows[0].Cells[1].Value);
            PersonDetails.OnDataChanged += OnPersonChanged;
            PersonDetails.ShowDialog();
        }

        private void OnPersonChanged(object sender, clsPersonEventArgs e)
        {
            LoadDrivers();
        }

        private void issueInternationalLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not yet implemented");
        }

        private void sToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not yet implemented");
        }
    }
}
