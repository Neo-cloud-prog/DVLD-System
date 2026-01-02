using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Web;
using System.Windows.Forms;
using DVLD.Core.Entities.Driver;
using DVLD.Core.Entities.License;
using DVLD.UI.Helpers.UI.GridView;
using DVLD.UI.Screens.Application.Local;
using DVLD.UI.Screens.Person;

namespace DVLD.UI.Screens.License.Local
{
    public partial class frmManageDetainedLicenses : Form
    {
        private DataGridViewRow _SelectedRow;
        private clsLicense _License;
        private clsDriver _Driver;

        public frmManageDetainedLicenses()
        {
            InitializeComponent();
        }

        private void LoadDetainedLicenses()
        {
            DataTable DetainedLicensesTable = clsDetainedLicense.GetAllDetainedLicenses();
            sbDetainedLicenses.LoadData(DetainedLicensesTable, new List<clsGridColumnDefinition>
            {
                new clsGridColumnDefinition("dcDetainID", "D.ID", "DetainID"),
                new clsGridColumnDefinition("dcLicenseID", "L.ID", "LicenseID"),
                new clsGridColumnDefinition("dcDetainDate", "D.Date", "DetainDate"),
                new clsGridColumnDefinition("dcIsReleased", "Is Released", "IsReleased", clsGridColumnDefinition.enColumnType.Checkbox),
                new clsGridColumnDefinition("dcFineFees", "Fine Fees", "FineFees"),
                new clsGridColumnDefinition("dcReleaseDate", "Release Date", "ReleaseDate"),
                new clsGridColumnDefinition("dcNationalNo", "N.No", "NationalNo"),
                new clsGridColumnDefinition("dcFullName", "Full Name", "FullName"),
                new clsGridColumnDefinition("dcReleaseApplicationID", "Release App.ID", "ReleaseApplicationID")
            });
            string[] SelectedColumns = { "DetainID", "IsReleased", "NationalNo", "FullName", "ReleaseDate", "ReleaseApplicationID" };
            DataGridViewFilter.Bind(sbDetainedLicenses.DataGridView, SelectedColumns);
        }

        private void frmManageDetainedLicenses_Load(object sender, EventArgs e)
        {
            LoadDetainedLicenses();
        }

        private void cmsDetainedLicense_Opening(object sender, CancelEventArgs e)
        {
            _SelectedRow = sbDetainedLicenses.DataGridView.SelectedRows[0];

            bool IsReleased = (bool)_SelectedRow.Cells[3].Value;
            releaseDetainLicenseToolStripMenuItem.Enabled = !IsReleased;

            _License = clsLicense.Find((int)_SelectedRow.Cells[1].Value);
            _Driver = clsDriver.Find(_License.DriverID);
        }

        private void showPersonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPersonDetails PersonDetails = new frmPersonDetails(_Driver.PersonID);
            PersonDetails.ShowDialog();
        }

        private void showLicenseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLocalDrivingLicenseInfo LocalDrivingLicenseInfo = new frmLocalDrivingLicenseInfo(_License.ID);
            LocalDrivingLicenseInfo.ShowDialog();
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLicenseHistory LicenseHistory = new frmLicenseHistory(_Driver.PersonID);
            LicenseHistory.ShowDialog();
        }

        private void ibtnDetain_Click(object sender, EventArgs e)
        {
            frmDetainLicense DetainLicense = new frmDetainLicense();
            DetainLicense.OnDataChanged += (s, args) => LoadDetainedLicenses();
            DetainLicense.ShowDialog();
        }

        private void releaseDetainLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReleaseDetainedLicense ReleaseDetainedLicense = new frmReleaseDetainedLicense(_License.ID);
            ReleaseDetainedLicense.OnDataChanged += (s, args) => LoadDetainedLicenses();
            ReleaseDetainedLicense.ShowDialog();
        }

        private void ibtnRelease_Click(object sender, EventArgs e)
        {
            frmReleaseDetainedLicense ReleaseDetainedLicense = new frmReleaseDetainedLicense(-1);
            ReleaseDetainedLicense.OnDataChanged += (s, args) => LoadDetainedLicenses();
            ReleaseDetainedLicense.ShowDialog();
        }
    }
}
