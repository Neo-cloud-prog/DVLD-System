using System;
using System.Windows.Forms;
using DVLD.Core.Entities.Application;
using DVLD.Core.Entities.Driver;
using DVLD.Core.Entities.License;
using DVLD.Core.Entities.User;
using DVLD.Core.Services.License;
using DVLD.UI.Events.License;
using DVLD.UI.Helpers.Session;
using DVLD.UI.Screens.Basic;
using DVLD.UI.Screens.License;
using DVLD.UI.Screens.License.International;
using static DVLD.Core.Services.License.clsLicenseService;

namespace DVLD.UI.Screens.Application.International
{
    public partial class frmInternationalLicenseApplication : BaseForm<clsLicenseEventArgs>
    {
        private int _LicenseID = -1;
        private int _DefaultApplicationType = 6;
        private clsLicense _LocalLicense;
        private clsApplicationType _ApplicationType;
        private clsInternationalLicense _InternationalLicense;

        public frmInternationalLicenseApplication()
        {
            InitializeComponent();
        }

        private void _LoadApplicationBasicInfo()
        {
            string DateFormat = "dd/MMMM/yyyy";
            string CurrentDate = DateTime.Now.ToString(DateFormat);
            _ApplicationType = clsApplicationType.Find(_DefaultApplicationType);
            lbAppDate.Text = CurrentDate;
            lbIssueDate.Text = CurrentDate;
            lbAppFees.Text = Convert.ToInt32(_ApplicationType.Fees).ToString();
            lbExpDate.Text = DateTime.Now.AddYears(1).ToString(DateFormat);
            lbUsername.Text = clsAppSession.CurrentUser.Name;
        }

        private void frmInternationalLicenseApplication_Load(object sender, EventArgs e)
        {
            _LoadApplicationBasicInfo();
        }

        private void DrivingLicenseInfoWithFilter_OnLicenseFound(object sender, clsLicenseEventArgs e)
        {
            _LicenseID = e.LicenseID;
            _LocalLicense = clsLicense.Find(_LicenseID);
            lbLocalLicenseID.Text = _LicenseID.ToString();
            lnkShowLicenseHistory.Enabled = true;
        }

        private void ibtnIssue_OnClick(object sender, EventArgs e)
        {
            int ActiveInternationalLicenseID = -1;
            InternationalLicenseResult InternationalLicenseResult = clsLicenseService.IssueInternationalLicense(_LocalLicense, _ApplicationType, clsAppSession.CurrentUser.ID, ref ActiveInternationalLicenseID);
            
            switch(InternationalLicenseResult.Result)
            {
                case enIssueInternationalLicenseResult.InactiveLicense:
                    MessageBox.Show("This is not active");
                    return;
                case enIssueInternationalLicenseResult.ExpiredLicense:
                    MessageBox.Show("This is expired");
                    return;
                case enIssueInternationalLicenseResult.LicenseClassTypeIsNotOrdinary:
                    MessageBox.Show("Please choose license class type as ordinary class to issue international license");
                    return;
                case enIssueInternationalLicenseResult.AlreadyHaveAnActiveInternationalLicense:
                    MessageBox.Show("This person already have an active international license with ID = " + ActiveInternationalLicenseID);
                    return;
                case enIssueInternationalLicenseResult.ApplicationSaveFailed:
                    MessageBox.Show("Application Save Failed");
                    return;
                case enIssueInternationalLicenseResult.IssueOperationFailed:
                    MessageBox.Show("Issue Operation Failed");
                    return;
                case enIssueInternationalLicenseResult.Success:
                    lbILAppID.Text = InternationalLicenseResult.Application.ID.ToString();
                    _InternationalLicense = InternationalLicenseResult.InternationalLicense;
                    lbInternationalLicesneID.Text = _InternationalLicense.ID.ToString();
                    lnkShowLicenseInfo.Enabled = true;
                    TriggerDataChanged(new clsLicenseEventArgs(_InternationalLicense.ID));
                    break;
            }
        }

        private void lnkShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmInternationalDrivingLicenseInfo InternationalDrivingLicenseInfo = new frmInternationalDrivingLicenseInfo(_InternationalLicense.ID);
            InternationalDrivingLicenseInfo.ShowDialog();
        }

        private void lnkShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenseHistory LicenseHistory = new frmLicenseHistory(clsDriver.Find(_LocalLicense.DriverID).PersonID);
            LicenseHistory.ShowDialog();
        }

        private void ibtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
