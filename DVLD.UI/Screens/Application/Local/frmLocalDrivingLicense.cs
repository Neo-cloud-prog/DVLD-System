using System;
using System.Data;
using System.Windows.Forms;
using DVLD.Core.Entities.Applicaction;
using DVLD.Core.Entities.Application;
using DVLD.Core.Entities.License;
using DVLD.Core.Enums;
using DVLD.Core.Services.Application;
using DVLD.UI.Events.License;
using DVLD.UI.Events.Person;
using DVLD.UI.Helpers.Session;
using DVLD.UI.Screens.Basic;

namespace DVLD.UI.Screens.Application.Local
{
    public partial class frmLocalDrivingLicense : BaseForm<clsLocalDrivingLicenseApplicationEventArgs>
    {
        private int _LocalDrivingAppLicationID = -1;
        private int _PersonID = -1;
        private decimal _AppFees;
        private clsLocalDrivingLicenseApplication _LocalDrivingLicenseApplication;

        public frmLocalDrivingLicense(int LocalDrivingAppLicationID)
        {
            InitializeComponent();
            _LocalDrivingAppLicationID = LocalDrivingAppLicationID;
        }

        private void _FillComboboxWihtLicensesClassName()
        {
            DataTable LicenseClassesTable = clsLicenseClass.GetClasses();
            cmbLicenseClasses.Items.Clear();
            foreach (DataRow Row in LicenseClassesTable.Rows)
            {
                cmbLicenseClasses.Items.Add(Row[1].ToString());
            }
            cmbLicenseClasses.SelectedIndex = 2;
        }

        private void _FillApplicationInitialInfo()
        {
            _FillComboboxWihtLicensesClassName();
            lbAppDate.Text = DateTime.Now.ToString();
            _AppFees = clsApplicationType.Find((int)enApplicationType.NewLocalDrivingLicense).Fees;
            lbAppFees.Text = Convert.ToInt32(_AppFees).ToString();
            lbUserName.Text = clsAppSession.CurrentUser.Name;  
            
            if(_LocalDrivingAppLicationID != -1)
            {
                lbAppID.Text = _LocalDrivingLicenseApplication.ApplicationID.ToString();
                cmbLicenseClasses.SelectedIndex = _LocalDrivingLicenseApplication.LicenseClassID - 1;
            }
        }

        private void frmLocalDrivingLicense_Load(object sender, EventArgs e)
        {
            ibtnSave.Enabled = false;
            if(_LocalDrivingAppLicationID != -1)
            {
                _LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplication.Find(_LocalDrivingAppLicationID);
                _PersonID = clsApplication.Find(_LocalDrivingLicenseApplication.ApplicationID).PersonID;
                PersonDetailsWithFilter.LoadPersonByID(_PersonID);
            }
            _FillApplicationInitialInfo();
        }

        private void ibnClose_OnClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (tabLocalLicenseApp.SelectedIndex < tabLocalLicenseApp.TabCount - 1)
            {
                tabLocalLicenseApp.SelectedIndex += 1;
            }
        }

        private void ibtnSave_OnClick(object sender, EventArgs e)
        {

            clsLocalDrivingLicenseApplicationSevice.IssueLocalDrivingLicenseApplicationResult IssueLocalDrivingLicenseApplicationResult = clsLocalDrivingLicenseApplicationSevice.IssueNewApplication(_LocalDrivingAppLicationID, _PersonID, cmbLicenseClasses.SelectedIndex + 1, _AppFees, clsAppSession.CurrentUser.ID);

            switch(IssueLocalDrivingLicenseApplicationResult.Result)
            {
                case clsLocalDrivingLicenseApplicationSevice.enIssueLocalDrivingLicenseApplicationSaveResult.ArleadyHasApplictionOntheSameLicenseClass:
                    MessageBox.Show("You arleady have an appliction on the same license class = " + IssueLocalDrivingLicenseApplicationResult.LastApplicationID);
                    return;
                case clsLocalDrivingLicenseApplicationSevice.enIssueLocalDrivingLicenseApplicationSaveResult.LicenseClassIsAlreadyExist:
                    MessageBox.Show("This license class is already exist");
                    return;
                case clsLocalDrivingLicenseApplicationSevice.enIssueLocalDrivingLicenseApplicationSaveResult.ApplicationSaveFailed:
                    MessageBox.Show("Application Save Failed");
                    return;
                case clsLocalDrivingLicenseApplicationSevice.enIssueLocalDrivingLicenseApplicationSaveResult.LocalDrivingLicenseApplicationSaveFailed:
                    MessageBox.Show("Local Driving License Application Save Failed");
                    return;
                default:
                    MessageBox.Show("Application Saved Successfuly");

                    if (_LocalDrivingAppLicationID == -1)
                    {
                        lbAppID.Text = IssueLocalDrivingLicenseApplicationResult.ApplicationID.ToString();
                    }

                    ibtnSave.Enabled = false;

                    TriggerDataChanged(new clsLocalDrivingLicenseApplicationEventArgs(IssueLocalDrivingLicenseApplicationResult.LocalDrivingLicenseApplicationID));
                    break;
            }
        }

        private void tabLocalLicenseApp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabLocalLicenseApp.SelectedIndex == 1 && _LocalDrivingAppLicationID == -1)
            {
                ibtnSave.Enabled = true;
            }
            else
            {
                ibtnSave.Enabled = false;
            }
        }

        private void PersonDetailsWithFilter_OnPersonFound(object sender, clsPersonEventArgs e)
        {
            _PersonID = e.PersonID;
        }

        private void cmbLicenseClasses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(_LocalDrivingAppLicationID != -1)
            {
                if (_LocalDrivingLicenseApplication.LicenseClassID != cmbLicenseClasses.SelectedIndex + 1)
                {
                    ibtnSave.Enabled = true;
                }
                else
                {
                    ibtnSave.Enabled = false;
                }
            }
        }
    }
}
