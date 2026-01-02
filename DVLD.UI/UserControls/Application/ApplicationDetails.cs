using System;
using System.Windows.Forms;
using DVLD.Core.Entities.Applicaction;
using DVLD.Core.Entities.Application;
using DVLD.Core.Entities.License;
using DVLD.Core.Entities.User;
using DVLD.Core.Enums;
using DVLD.UI.Helpers.Session;
using DVLD.UI.Screens.License.Local;
using DVLD.UI.Screens.Person;

namespace DVLD.UI.UserControls.Application
{
    public partial class ApplicationDetails : UserControl
    {
        private clsLocalDrivingLicenseApplication _LocalDrivingLicenseApplication;
        private clsApplication _Application;
        private clsApplicationType _ApplicationType;
        private clsPerson _Person;

        public ApplicationDetails()
        {
            InitializeComponent();
        }

        public void IncreasePassedTestsCount()
        {
            lbPassedTests.Text = (Convert.ToInt32(lbPassedTests.Text.Substring(0, 1)) + 1) + "/3";
        }

        private void _ConfigurationsAccordingAppStatus(enApplicationStatus ApplicationStatus)
        {
            if (ApplicationStatus == enApplicationStatus.Completed)
            {
                lnkLicenseInfo.Enabled = true;
            }
            //...
        }

        public void LoadInfo(DataGridViewRow LocalLicenseApplicationDetailsRecord)
        {
            int LocalLicenseApplicationID = (int)LocalLicenseApplicationDetailsRecord.Cells[0].Value;
            _LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplication.Find(LocalLicenseApplicationID);
            _Application = clsApplication.Find(_LocalDrivingLicenseApplication.ApplicationID);
            _ApplicationType = clsApplicationType.Find(_Application.ApplicationTypeID);
            _Person = clsPerson.Find(_Application.PersonID);
            _FillDrivingLicenseApplicationInfo(LocalLicenseApplicationDetailsRecord);
            _FillApplicationBasicInfo(LocalLicenseApplicationDetailsRecord);
            _ConfigurationsAccordingAppStatus((enApplicationStatus)_Application.Status);
        }

        private void _FillDrivingLicenseApplicationInfo(DataGridViewRow LocalLicenseApplicationDetailsRecord)
        {
            lbLDLAppID.Text = LocalLicenseApplicationDetailsRecord.Cells[0].Value.ToString();
            lbLicenseClassName.Text = LocalLicenseApplicationDetailsRecord.Cells[1].Value.ToString();
            lbPassedTests.Text = LocalLicenseApplicationDetailsRecord.Cells[5].Value.ToString() + lbPassedTests.Text.Substring(1);
        }

        private void _FillApplicationBasicInfo(DataGridViewRow LocalLicenseApplicationDetailsRecord)
        {
            lbAppID.Text = _Application.ID.ToString();
            lbStatus.Text = LocalLicenseApplicationDetailsRecord.Cells[6].Value.ToString();
            lbFees.Text = _ApplicationType.Fees.ToString();
            lbApplicationType.Text = _ApplicationType.Title;
            lbApplicantFullName.Text = LocalLicenseApplicationDetailsRecord.Cells[3].Value.ToString();
            lbDate.Text = _Application.Date.ToString();
            lbLastStatusDate.Text = _Application.LastStatusDate.ToString();
            lbUserName.Text = clsAppSession.CurrentUser.Name;
        }

        private void lnkPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPersonDetails PersonDetails = new frmPersonDetails(_Person.ID);
            PersonDetails.ShowDialog();
        }

        private void lnkLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            clsLicense License = clsLicense.FindByAppID(_Application.ID);
            frmLocalDrivingLicenseInfo LocalDrivingLicenseInfo = new frmLocalDrivingLicenseInfo(License.ID);
            LocalDrivingLicenseInfo.ShowDialog();
        }
    }
}
