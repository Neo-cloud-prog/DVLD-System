using System;
using System.Windows.Forms;
using DVLD.UI.Events.License;
using DVLD.UI.Helpers.Session;
using DVLD.UI.Screens.Basic;
using static DVLD.Core.Services.License.clsLicenseService;

namespace DVLD.UI.Screens.License.Local
{
    public partial class frmIssueLocalLicenseFirstTime : BaseForm<clsLocalDrivingLicenseApplicationEventArgs>
    {
        DataGridViewRow _SelectedAppRow;

        public frmIssueLocalLicenseFirstTime(DataGridViewRow SelectedAppRow)
        {
            InitializeComponent();
            _SelectedAppRow = SelectedAppRow;
        }

        private void frmIssueLocalLicenseFirstTime_Load(object sender, EventArgs e)
        {
            ApplicationDetails.LoadInfo(_SelectedAppRow);
        }

        private void ibtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ibtnSave_Click(object sender, EventArgs e)
        {
            int LocalDrivingLicenseAppID = Convert.ToInt32(_SelectedAppRow.Cells[0].Value);
            enIssueLocalLicenseFirstTimeResult IssueLocalLicenseFirstTimeResult = IssueLocalLicenseFirstTime(LocalDrivingLicenseAppID, clsAppSession.CurrentUser.ID, tbNotes.Text);

            switch(IssueLocalLicenseFirstTimeResult)
            {
                case enIssueLocalLicenseFirstTimeResult.IssueOperationFailed:
                    MessageBox.Show("Issue Operation Failed");
                    return;
                case enIssueLocalLicenseFirstTimeResult.ApplicationSaveFailed:
                    MessageBox.Show("Application Save Failed");
                    return;
                default:
                    TriggerDataChanged(new clsLocalDrivingLicenseApplicationEventArgs(LocalDrivingLicenseAppID));
                    MessageBox.Show("License has been added successfuly");
                    break;
            }
        }
    }
}
