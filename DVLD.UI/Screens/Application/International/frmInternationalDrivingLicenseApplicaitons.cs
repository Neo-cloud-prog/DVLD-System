using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using DVLD.Core.Entities.License;
using DVLD.Core.Entities.Driver;
using DVLD.UI.Helpers.UI.GridView;
using DVLD.UI.Screens.Person;
using DVLD.UI.Screens.License.International;
using DVLD.UI.Screens.License;

namespace DVLD.UI.Screens.Application.International
{
    public partial class frmInternationalDrivingLicenseApplicaitons : Form
    {
        private DataGridViewRow _SelectedRow;

        public frmInternationalDrivingLicenseApplicaitons()
        {
            InitializeComponent();
        }

        private void _LoadInternationalDrivingLicenseApplications()
        {
            DataTable InternationalDrivingLicenseApplicationsTable = clsInternationalLicense.GetAllInternationalLicenses();

            sbInternationalLicenseApplications.LoadData(InternationalDrivingLicenseApplicationsTable, new List<clsGridColumnDefinition>
            {
                new clsGridColumnDefinition("dcInternationalLicenseID", "International ID", "InternationalLicenseID"),
                new clsGridColumnDefinition("dcApplicationID", "Application ID", "ApplicationID"),
                new clsGridColumnDefinition("dcDriverID", "Driver ID", "DriverID"),
                new clsGridColumnDefinition("dcIssuedUsingLocalLicenseID", "L.License ID", "IssuedUsingLocalLicenseID"),
                new clsGridColumnDefinition("dcIssueDate", "Issue Date", "IssueDate"),
                new clsGridColumnDefinition("dcExpirationDate", "Expiration Date", "ExpirationDate"),
                new clsGridColumnDefinition("dcIsActive", "Is Active", "IsActive", clsGridColumnDefinition.enColumnType.Checkbox),
            });

            DataGridViewFilter.Bind(sbInternationalLicenseApplications.DataGridView);
        }

        private void frmInternationalDrivingLicenseApplicaitons_Load(object sender, EventArgs e)
        {
            _LoadInternationalDrivingLicenseApplications();
        }

        private void btnAddLoacalLicenseApplication_Click(object sender, EventArgs e)
        {
            frmInternationalLicenseApplication InternationalLicenseApplication = new frmInternationalLicenseApplication();
            InternationalLicenseApplication.OnDataChanged += (s, args) => _LoadInternationalDrivingLicenseApplications();
            InternationalLicenseApplication.ShowDialog();
        }

        private void cmsInternationalLicenseApplication_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            _SelectedRow = sbInternationalLicenseApplications.DataGridView.SelectedRows[0];
        }

        private void showPersonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPersonDetails PersonDetails = new frmPersonDetails(clsDriver.Find((int)_SelectedRow.Cells[2].Value).PersonID);
            PersonDetails.ShowDialog();
        }

        private void showLicenseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInternationalDrivingLicenseInfo InternationalDrivingLicenseInfo = new frmInternationalDrivingLicenseInfo((int)_SelectedRow.Cells[0].Value);
            InternationalDrivingLicenseInfo.ShowDialog();
        }

        private void showPersonLicenseHistoryApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLicenseHistory LicenseHistory = new frmLicenseHistory(clsDriver.Find((int)_SelectedRow.Cells[2].Value).PersonID);
            LicenseHistory.ShowDialog();
        }
    }
}
