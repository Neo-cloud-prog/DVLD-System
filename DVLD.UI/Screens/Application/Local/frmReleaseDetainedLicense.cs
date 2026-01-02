using System;
using System.Windows.Forms;
using DVLD.Core.Entities.Application;
using DVLD.Core.Entities.Driver;
using DVLD.Core.Entities.License;
using DVLD.Core.Enums;
using DVLD.Core.Services.License;
using DVLD.UI.Events.License;
using DVLD.UI.Helpers.Session;
using DVLD.UI.Screens.Basic;
using DVLD.UI.Screens.License;
using DVLD.UI.Screens.License.Local;

namespace DVLD.UI.Screens.Application.Local
{
    public partial class frmReleaseDetainedLicense : BaseForm<EventArgs>
    {
        private int _LicenseID = -1;
        private clsApplicationType _ApplicationType = clsApplicationType.Find((int)enApplicationType.ReleaseDetainedDrivingLicense);
        private clsDetainedLicense _DetainedLicense;
        private clsLicense _License;
        private clsDriver _Driver;

        public frmReleaseDetainedLicense(int LicenseID)
        {
            InitializeComponent();
            _LicenseID = LicenseID;
        }

        private void ibtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void _FillReleaseDetainedLicenseBasicInfo(int LicenseID)
        {
            _DetainedLicense = clsDetainedLicense.FindByLicenseID(LicenseID);
            _License = clsLicense.Find(_DetainedLicense.LicenseID);
            _Driver = clsDriver.Find(_License.DriverID);

            lbDetainID.Text = _DetainedLicense.ID.ToString();
            lbDetainDate.Text = _DetainedLicense.DetainDate.ToString();
            lbAppFees.Text = Convert.ToInt32(_ApplicationType.Fees).ToString();
            lbTotalFees.Text = Convert.ToInt32(_DetainedLicense.FineFees + _ApplicationType.Fees).ToString();
            lbLicenseID.Text = _LicenseID.ToString();
            lbUserName.Text = clsAppSession.CurrentUser.Name;
            lbFineFees.Text = Convert.ToInt32(_DetainedLicense.FineFees).ToString();
        }

        private void DrivingLicenseInfoWithFilter_OnLicenseFound(object sender, clsLicenseEventArgs e)
        {
            _LicenseID = e.LicenseID;

            _FillReleaseDetainedLicenseBasicInfo(_LicenseID);

            if (_DetainedLicense == null || _DetainedLicense.IsReleased)
            {
                MessageBox.Show("This license is not detained");
                ibtnRelease.Enabled = false;
                return;
            }
            else
            {
                ibtnRelease.Enabled = true;
            }

            lnkShowLicenseHistory.Enabled = true;
        }

        private void ibtnRelease_Click(object sender, EventArgs e)
        {
            clsLicenseService.ReleaseDetainedLicenseResult ReleaseDetainedLicense = clsLicenseService.ReleaseLicense(_Driver, _ApplicationType, _DetainedLicense, _License, clsAppSession.CurrentUser.ID);

            switch(ReleaseDetainedLicense.Result)
            {
                case clsLicenseService.enReleaseDetainedLicenseResult.ApplicationSaveFailed:
                    MessageBox.Show("Application save failed");
                    return;
                case clsLicenseService.enReleaseDetainedLicenseResult.ReleaseOperationFailed:
                    MessageBox.Show("Release Operation Failed");
                    return;
                default:
                    MessageBox.Show("Released successfuly");
                    lbRDLAppID.Text = ReleaseDetainedLicense.ApplicationID.ToString();
                    lnkShowLicenseInfo.Enabled = true;
                    TriggerDataChanged(EventArgs.Empty);
                    break;
            }
        }

        private void lnkShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenseHistory LicenseHistory = new frmLicenseHistory(_Driver.PersonID);
            LicenseHistory.ShowDialog();
        }

        private void lnkShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLocalDrivingLicenseInfo LocalDrivingLicenseInfo = new frmLocalDrivingLicenseInfo(_LicenseID);
            LocalDrivingLicenseInfo.ShowDialog();
        }

        private void frmReleaseDetainedLicense_Load(object sender, EventArgs e)
        {
            if(_LicenseID != -1)
            {
                DrivingLicenseInfoWithFilter.LoadLicenseInfoByID(_LicenseID);
                _FillReleaseDetainedLicenseBasicInfo(_LicenseID);
                lnkShowLicenseHistory.Enabled = true;
            }
        }
    }
}
