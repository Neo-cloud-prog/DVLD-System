using System;
using System.ComponentModel;
using System.Windows.Forms;
using DVLD.Core.Entities.Applicaction;
using DVLD.Core.Entities.Application;
using DVLD.Core.Entities.Test;
using DVLD.Core.Enums;
using DVLD.UI.Helpers.Session;
using DVLD.UI.Helpers.Shared;

namespace DVLD.UI.UserControls.Test
{
    public partial class ucScheduleTest : UserControl
    {
        private int _RetakeTestAppFees = Convert.ToInt32(clsApplicationType.Find((int)enApplicationType.RetakeTest).Fees);
        private int _TestFees = 0;
        private enTestType _TestType;
        private enTestAppointmentOperation _TestAppointmentOperation;
        private clsLocalDrivingLicenseApplication _LocalDrivingLicenseApplication;
        private clsTestAppointment _LastLockedAppointemnt;
        private clsTestAppointment _LastUnLockedAppointemnt;

        public ucScheduleTest()
        {
            InitializeComponent();
        }

        [Browsable(true)]
        [Category("Custom")]
        [Description("Sets the padding of the group box.")]
        [DefaultValue(null)]
        public int GroupBoxHeight
        {
            get { return gbTestInfo.Height; }
            set
            {
                gbTestInfo.Height = value;
            }
        }

        public void LoadRetakeTestInitialInfo()
        {
            if(_TestAppointmentOperation != enTestAppointmentOperation.ScheduleRetakeTest)
            {
                _RetakeTestAppFees = 0;
            }
            lbRAppFees.Text = _RetakeTestAppFees.ToString();
            lbTotalFees.Text = (_RetakeTestAppFees + _TestFees).ToString();
        }

        public void Prepar(DataGridViewRow SelectedAppRow, enTestType TestType, enTestAppointmentOperation TestAppointmentOperation, int SelectedTestAppointmentID = -1)
        {
            _TestType = TestType;
            _TestAppointmentOperation = TestAppointmentOperation;

            gbTestInfo.Text = clsControlHelper.PraperHeaderScreenAccordingTestType(TestType, ScreenHeader, TestAppointmentOperation) + " Test";


            lbDLAppID.Text = SelectedAppRow.Cells[0].Value.ToString();
            lbClassName.Text = SelectedAppRow.Cells[1].Value.ToString();
            lbPersonName.Text = SelectedAppRow.Cells[3].Value.ToString();

            _LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplication.Find(int.Parse(lbDLAppID.Text));
            int NumberOfTrials = _LocalDrivingLicenseApplication == null ? 0 : _LocalDrivingLicenseApplication.GetAllTestAppointmentsByTestType((int)TestType + 1).Rows.Count;
            lbTrial.Text = NumberOfTrials.ToString();

            // you can use _TestType to know current test type id
            _TestFees = Convert.ToInt32(clsTestType.Find((int)TestType + 1).Fees);
            lbFees.Text = _TestFees.ToString();


            if (TestAppointmentOperation == enTestAppointmentOperation.ScheduleRetakeTest)
            {
                _LastLockedAppointemnt = clsTestAppointment.GetLastLockedAppointemnt(_LocalDrivingLicenseApplication.ID);
                gbRetakTestInfo.Enabled = true;
                dtpAppointmentDate.Value = _LastLockedAppointemnt.AppointmentDate.AddDays(2);
            }

            if (TestAppointmentOperation == enTestAppointmentOperation.EditTest)
            {
                _LastUnLockedAppointemnt = clsTestAppointment.Find(SelectedTestAppointmentID);
                dtpAppointmentDate.Value = _LastUnLockedAppointemnt.AppointmentDate;

                if (_LastUnLockedAppointemnt.IsLocked)
                {
                    lbMsgErrorForEdit.Visible = true;
                    ibtnSave.Enabled = false;
                }
            }

            if (_TestAppointmentOperation != enTestAppointmentOperation.TakeTest)
            {
                LoadRetakeTestInitialInfo();
            }
        }

        private void ibtnSave_Click(object sender, EventArgs e)
        {
            clsTestAppointment TestAppointment = _LastUnLockedAppointemnt;

            if (_TestAppointmentOperation != enTestAppointmentOperation.EditTest)
            {
                TestAppointment = new clsTestAppointment();
                TestAppointment.TestTypeID = (int)_TestType + 1;
                TestAppointment.LocalDrivingLicenseApplicationID = int.Parse(lbDLAppID.Text);
                TestAppointment.PaidFees = Convert.ToDecimal(lbFees.Text);
                TestAppointment.CreatedByUserID = clsAppSession.CurrentUser.ID;
            }

            TestAppointment.AppointmentDate = dtpAppointmentDate.Value;
            

            if (_TestAppointmentOperation == enTestAppointmentOperation.ScheduleRetakeTest)
            {
                clsApplication Application = new clsApplication();
                clsApplication ParentApplication = clsApplication.Find(_LocalDrivingLicenseApplication.ApplicationID);
                Application.PersonID = ParentApplication.PersonID;
                Application.ApplicationTypeID = (int)enApplicationType.RetakeTest;
                Application.Status = (int)enApplicationStatus.Completed;
                Application.PaidFees = _RetakeTestAppFees;
                Application.UserID = clsAppSession.CurrentUser.ID;
                TestAppointment.RetakeTestAppointmentID = Application.ID;

                if (Application.Save())
                {
                    MessageBox.Show("Application Done successfuly");
                } else
                {
                    return;
                }

                lbRTestAppID.Text = Application.ID.ToString();
            }

            if (TestAppointment.Save())
            {
                MessageBox.Show("Test Appointment Done successfuly");
            } else
            {
                return;
            }

            ibtnSave.Enabled = false;

            this.Parent.Tag = true;
        }
    }
}
