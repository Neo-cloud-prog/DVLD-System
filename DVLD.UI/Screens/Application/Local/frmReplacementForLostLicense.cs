using System;
using System.Windows.Forms;
using DVLD.Core.Entities.Application;
using DVLD.Core.Entities.License;
using DVLD.Core.Enums;
using DVLD.Core.Services.License;
using DVLD.UI.Helpers.Session;
using DVLD.UI.Screens.License.Local;

namespace DVLD.UI.Screens.Application.Local
{
    public partial class frmReplacementForLostLicense : Form
    {
        private int _LicenseID = -1;
        private clsApplicationType _ApplicationType;
        private clsLicense _OldLicense;
        private int _ReplaceFor = 4;

        public frmReplacementForLostLicense()
        {
            InitializeComponent();
        }

        private void _LoadApplicationBasicInfoForLicenseReplacement()
        {
            string DateFormat = "dd/MMMM/yyyy";
            string CurrentDate = DateTime.Now.ToString(DateFormat);
            _ApplicationType = clsApplicationType.Find(_ReplaceFor);
            lbAppDate.Text = CurrentDate;
            lbAppFees.Text = Convert.ToInt32(_ApplicationType.Fees).ToString();
            lbUsername.Text = clsAppSession.CurrentUser.Name;
        }

        private void frmReplacementForLostLicense_Load(object sender, EventArgs e)
        {
            _LoadApplicationBasicInfoForLicenseReplacement();
        }

        private void ibtnSave_OnClick(object sender, EventArgs e)
        {
            enReplaceLicenseFor ReplaceLicenseFor  = rbDamagedLicense.Checked ? enReplaceLicenseFor.Damaged : enReplaceLicenseFor.Lost;
            clsLicenseService.ReplaceLicenseResult ReplaceLicenseResult = clsLicenseService.ReplaceLicense(_OldLicense, ReplaceLicenseFor, clsAppSession.CurrentUser.ID);

            switch(ReplaceLicenseResult.Result)
            {
                case clsLicenseService.enReplaceLicenseResult.OldLicesenNotFound:
                    MessageBox.Show("Old Licesen Not Found");
                    return;
                case clsLicenseService.enReplaceLicenseResult.OldLicesenSaveFaild:
                    MessageBox.Show("Old Licesen Save Faild");
                    return;
                case clsLicenseService.enReplaceLicenseResult.InactiveLicense:
                    MessageBox.Show("This license is not active");
                    return;
                case clsLicenseService.enReplaceLicenseResult.ApplicationSaveFailed:
                    MessageBox.Show("Application Save Failed");
                    return;
                case clsLicenseService.enReplaceLicenseResult.RepalceOperationFailed:
                    MessageBox.Show("Repalce Operation Failed");
                    return;
                default:
                    MessageBox.Show("Replacment saved successfuly");
                    break;
            }

            lbLRAppID.Text = ReplaceLicenseResult.Application.ID.ToString();
            lbReplacedLicesneID.Text = ReplaceLicenseResult.ReplacedLicense.ID.ToString();

            lnkShowLicenseInfo.Enabled = true;
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            _ReplaceFor = Convert.ToInt32(radioButton.Tag);
        }

        private void lnkShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLocalDrivingLicenseInfo LocalDrivingLicenseInfo = new frmLocalDrivingLicenseInfo(_OldLicense.ID);
            LocalDrivingLicenseInfo.ShowDialog();
        }

        private void ibtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
