using System;
using System.Windows.Forms;
using DVLD.Core.Entities.Driver;
using DVLD.Core.Entities.License;
using DVLD.Core.Services.License;
using DVLD.UI.Events.License;
using DVLD.UI.Helpers.Session;
using DVLD.UI.Helpers.Validation;
using DVLD.UI.Screens.Basic;
using static DVLD.Core.Services.License.clsLicenseService;

namespace DVLD.UI.Screens.License.Local
{
    public partial class frmDetainLicense : BaseForm<EventArgs>
    {
        private int _LicenseID = -1;
        private bool _HasValidationError = true;

        public frmDetainLicense()
        {
            InitializeComponent();
        }

        public void InitializeDetainInfo()
        {
            lbDetainDate.Text = DateTime.Now.ToString();
            lbCreatedByUserID.Text = clsAppSession.CurrentUser.Name;
        }

        public void DetainLicenseByID(int LicenseID)
        {
            if (_HasValidationError)
            {
                return;
            }

            lbLicenseID.Text = LicenseID.ToString();

            clsLicenseService.DetainLicenseResult DetainLicenseSaveResult = clsLicenseService.DetainLicense(LicenseID, Convert.ToDateTime(lbDetainDate.Text), Convert.ToDecimal(tbFineFees.Text), clsAppSession.CurrentUser.ID);

            switch (DetainLicenseSaveResult.Result)
            {
                case enDetainLicenseSaveResult.InactiveLicense:
                    MessageBox.Show("This licence is not activated");
                    return;
                case enDetainLicenseSaveResult.ExpiredLicense:
                    MessageBox.Show("This license Is Expired");
                    return;
                case enDetainLicenseSaveResult.LicenseNotFound:
                    MessageBox.Show("This license Is Not Exist");
                    return;
                case enDetainLicenseSaveResult.DetainOperationFailed:
                    MessageBox.Show("Detain Operation Failed");
                    return;
                default:
                    MessageBox.Show("Saved successfully");
                    lbDetainID.Text = DetainLicenseSaveResult.DetainedLicense.ID.ToString();
                    break;
            }
        }

        private void ValidateFees(object sender, EventArgs e)
        {
            _HasValidationError = !clsAppValidationRules.GetRule(tbFineFees, DetainErrorProvider, clsAppValidationRules.enRuleType.IsNumber).Validate();
        }

        private void ibtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DrivingLicenseInfoWithFilter_OnLicenseFound(object sender, clsLicenseEventArgs e)
        {
            _LicenseID = e.LicenseID;
            gbDetainInfo.Focus();
        }

        private void frmDetainLicense_Load(object sender, EventArgs e)
        {
            InitializeDetainInfo();
            lnkShowLicenseHistory.Enabled = true;
        }

        private void ibtnDetain_Click(object sender, EventArgs e)
        {
            DetainLicenseByID(_LicenseID);
            lnkShowLicenseInfo.Enabled = true;
            TriggerDataChanged(EventArgs.Empty);
        }

        private void lnkShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenseHistory LicenseHistory = new frmLicenseHistory(clsDriver.Find(clsLicense.Find(_LicenseID).DriverID).PersonID);
            LicenseHistory.ShowDialog();
        }

        private void lnkShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLocalDrivingLicenseInfo LocalDrivingLicenseInfo = new frmLocalDrivingLicenseInfo(_LicenseID);
            LocalDrivingLicenseInfo.ShowDialog();
        }
    }
}
