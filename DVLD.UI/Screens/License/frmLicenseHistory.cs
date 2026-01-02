using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using DVLD.Core.Entities.Driver;
using DVLD.UI.Helpers.UI.GridView;
using DVLD.UI.UserControls.Shared;
using DVLD.UI.Screens.License.International;
using DVLD.UI.Screens.License.Local;

namespace DVLD.UI.Screens.License
{
    public partial class frmLicenseHistory : Form
    {
        private int _PersonID = -1;
        clsDriver _Driver;

        public frmLicenseHistory(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;
        }

        private void _LoadLocalDrivingLicense()
        {
            DataTable LocalDrivingLicensesTable = _Driver.GetAllLicenses();
            sbLocalLicense.LoadData(LocalDrivingLicensesTable, new List<clsGridColumnDefinition>
            {
                new clsGridColumnDefinition("dcLocalLicesneID", "lic.ID", "LicenseID"),
                new clsGridColumnDefinition("dcApplicationID", "App.ID", "ApplicationID"),
                new clsGridColumnDefinition("dcClassName", "Class Name", "ClassName"),
                new clsGridColumnDefinition("dcIssueDate", "Issue Date", "IssueDate"),
                new clsGridColumnDefinition("dcExpirationDate", "Expiration Date", "ExpirationDate"),
                new clsGridColumnDefinition("dcIsActive", "Is Active", "IsActive", clsGridColumnDefinition.enColumnType.Checkbox),
            });
        }

        private void _LoadInternationalDrivingLicense()
        {
            DataTable InternationalDrivingLicensesTable = _Driver.GetAllInternationalLicenses();
            sbInternationalLicenses.LoadData(InternationalDrivingLicensesTable, new List<clsGridColumnDefinition>
            {
                new clsGridColumnDefinition("dcInternationalLicenseID", "Int License ID", "InternationalLicenseID"),
                new clsGridColumnDefinition("dcApplicationID", "Application ID", "ApplicationID"),
                new clsGridColumnDefinition("dcIssuedUsingLocalLicenseID", "L.License ID", "IssuedUsingLocalLicenseID"),
                new clsGridColumnDefinition("dcIssueDate", "Issue Date", "IssueDate"),
                new clsGridColumnDefinition("dcExpirationDate", "Expiration Date", "ExpirationDate"),
                new clsGridColumnDefinition("dcIsActive", "Is Active", "IsActive", clsGridColumnDefinition.enColumnType.Checkbox),
            });
        }

        private void frmLicenseHistory_Load(object sender, EventArgs e)
        {
            if(_PersonID == -1)
            {
                return;
            }

            PersonDetailsWithFilter.LoadPersonByID(_PersonID);
            _Driver = clsDriver.FindByPersonID(_PersonID);

            if (_Driver == null)
            {
                return;
            }

            _LoadLocalDrivingLicense();
            _LoadInternationalDrivingLicense();
        }

        private void ibtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showLicenseInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagementScreenBody SourceControl = (ManagementScreenBody)cmsLicense.SourceControl;
            int SelectedLicenseID = (int)SourceControl.DataGridView.SelectedRows[0].Cells[0].Value;
            Form FormToShow = new Form();

            if (SourceControl == sbLocalLicense)
            {
                FormToShow = new frmLocalDrivingLicenseInfo(SelectedLicenseID);
            } else
            {
                FormToShow = new frmInternationalDrivingLicenseInfo(SelectedLicenseID);
            }
            FormToShow.ShowDialog();
        }
    }
}
