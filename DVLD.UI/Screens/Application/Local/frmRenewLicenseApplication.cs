using System;
using System.Windows.Forms;
using DVLD.Core.Entities.Application;
using DVLD.Core.Entities.License;
using DVLD.Core.Services.License;
using DVLD.UI.Helpers.Session;
using DVLD.UI.Screens.License.Local;

namespace DVLD.UI.Screens.Application.Local
{
    public partial class frmRenewLicenseApplication : Form
    {
        private int _DefaultApplicationType = 2;
        private clsApplicationType _ApplicationType;
        private clsLicense _OldLicense;
        private clsLicenseClass _LicenseClass;
        string DateFormat = "dd/MMMM/yyyy";

        public frmRenewLicenseApplication()
        {
            InitializeComponent();
        }

        private void _LoadApplicationBasicInfo()
        {
            _ApplicationType = clsApplicationType.Find(_DefaultApplicationType);
            string CurrentDate = DateTime.Now.ToString(DateFormat);
            lbAppDate.Text = CurrentDate;
            lbIssueDate.Text = CurrentDate;
            lbAppFees.Text = Convert.ToInt32(_ApplicationType.Fees).ToString();
            lbUsername.Text = clsAppSession.CurrentUser.Name;
        }

        private void frmRenewLicenseApplication_Load(object sender, EventArgs e)
        {
            _LoadApplicationBasicInfo();
        }

        private void lnkShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLocalDrivingLicenseInfo LocalDrivingLicenseInfo = new frmLocalDrivingLicenseInfo(_OldLicense.ID);
            LocalDrivingLicenseInfo.ShowDialog();
        }

        private void ibtnClose_OnClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ibtnRenew_OnClick(object sender, EventArgs e)
        {
            clsLicenseService.RenewLicenseResult RenewLicenseResult = clsLicenseService.RenewLicense(_OldLicense, _ApplicationType, _LicenseClass, clsAppSession.CurrentUser.ID, tbNotes.Text);
            switch (RenewLicenseResult.Result)
            {
                case clsLicenseService.enRenewLicenseResult.Success:
                    lbRLAppID.Text = RenewLicenseResult.Application.ID.ToString();
                    lbRenewedLicesneID.Text = RenewLicenseResult.OldLicense.ID.ToString();
                    lnkShowLicenseInfo.Enabled = true;
                    MessageBox.Show("License renewed successfully.");
                    break;

                case clsLicenseService.enRenewLicenseResult.LicenseNotEligibleForRenewal:
                    MessageBox.Show("License is not eligible for renewal.");
                    break;

                case clsLicenseService.enRenewLicenseResult.ApplicationSaveFailed:
                    MessageBox.Show("Failed to save application.");
                    break;

                case clsLicenseService.enRenewLicenseResult.RenewOperationFailed:
                    MessageBox.Show("Failed to renew license.");
                    break;

                case clsLicenseService.enRenewLicenseResult.OldLicenseSaveFailed:
                    MessageBox.Show("Failed to save old license data.");
                    break;
            }
        }
    }
}
