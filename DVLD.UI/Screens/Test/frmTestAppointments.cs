using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using DVLD.Core.Entities.Applicaction;
using DVLD.Core.Entities.Test;
using DVLD.Core.Enums;
using DVLD.UI.Helpers.Shared;

namespace DVLD.UI.Screens.Test
{
    public partial class frmTestAppointments : Form
    {
        private DataGridViewRow _SelectedAppRow;
        private int _SelectedTestAppointmentID;
        private int _PassedTests = -1;
        private clsTest _Test;
        public event Action<int> OnTestPassed;
        private enTestType _TestType;

        public frmTestAppointments(DataGridViewRow SelectedAppRow)
        {
            InitializeComponent();
            _SelectedAppRow = SelectedAppRow;
            _PassedTests = (int)SelectedAppRow.Cells[5].Value;
            _TestType = (enTestType)_PassedTests;
        }

        private void _PraperAppointmentPageAccordingTestType()
        {
            ApplicationDetails.LoadInfo(_SelectedAppRow);
        }

        private void _LoadTestAppointments()
        {
            int LocalDrivingLicenseAppID = (int)_SelectedAppRow.Cells[0].Value;
            clsLocalDrivingLicenseApplication LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplication.Find(LocalDrivingLicenseAppID);
            if(LocalDrivingLicenseApplication == null)
            {
                return;
            }
            DataTable TestAppointmentsTable = LocalDrivingLicenseApplication.GetAllTestAppointmentsByTestType((int)_TestType + 1);
            sbAppointments.DataGridView.DataSource = TestAppointmentsTable;
        }

        private void _HanlePassedTestsOnTestPassed()
        {
            if(_Test.TestResult)
            {
                ApplicationDetails.IncreasePassedTestsCount();
            }
        }

        private void _HandleTests()
        {
            if(sbAppointments.DataGridView.Rows.Count > 0)
            {
                int AppointmentID = (int)sbAppointments.DataGridView.Rows[0].Cells[0].Value;
                clsTestAppointment TestAppointment = clsTestAppointment.Find(AppointmentID);
                _Test = clsTest.FindByTestAppointmentID(AppointmentID);
                if(TestAppointment != null && !TestAppointment.IsLocked)
                {
                    ibtnAddAppointment.Enabled = false;
                }
                else
                {
                    if (_Test != null)
                    {
                        if (_Test.TestResult)
                        {
                            ibtnAddAppointment.Enabled = false;
                        } else
                        {
                            ibtnAddAppointment.Enabled = true;
                        }
                    }
                }
            }
        }

        private void _PraperTestAppoinrmentsScreen()
        {
            clsControlHelper.PraperHeaderScreenAccordingTestType(_TestType, ScreenHeader);
            _LoadTestAppointments();
            _PraperAppointmentPageAccordingTestType();
            _HandleTests();
        }

        private void frmTestAppointments_Load(object sender, EventArgs e)
        {
            _PraperTestAppoinrmentsScreen();
        }

        private void ibtnAddAppointment_OnClick(object sender, EventArgs e)
        {
            enTestAppointmentOperation TestAppointmentOperation;
            bool IsLastTestLocked = false;

            if (sbAppointments.DataGridView.Rows.Count > 0)
            {
                IsLastTestLocked = (bool)sbAppointments.DataGridView.SelectedRows[0].Cells[3].Value;
            }

            if (!IsLastTestLocked)
            {
                TestAppointmentOperation = enTestAppointmentOperation.ScheduleTest;
            } else
            {
                TestAppointmentOperation = enTestAppointmentOperation.ScheduleRetakeTest;
            }
            frmScheduleTest ScheduleTest = new frmScheduleTest(_SelectedAppRow, TestAppointmentOperation);
            ScheduleTest.OnDataChanged += (s, args) => {
                _LoadTestAppointments();
                _HandleTests();
            };
            ScheduleTest.ShowDialog();
        }

        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTakeTest TakeTest = new frmTakeTest(_SelectedAppRow, enTestAppointmentOperation.TakeTest, _SelectedTestAppointmentID);
            TakeTest.OnDataChanged += (s, args) => {
                _LoadTestAppointments();
                _HandleTests();
                _HanlePassedTestsOnTestPassed();
            };
            TakeTest.ShowDialog();
        }

        private void cmsTest_Opening(object sender, CancelEventArgs e)
        {
            _SelectedTestAppointmentID = (int)sbAppointments.DataGridView.SelectedRows[0].Cells[0].Value;
        }

        private void frmTestAppointments_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_Test != null && _Test.TestResult == true)
            {
                OnTestPassed?.Invoke(_Test.ID);
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmScheduleTest EditTest = new frmScheduleTest(_SelectedAppRow, enTestAppointmentOperation.EditTest, _SelectedTestAppointmentID);
            EditTest.OnDataChanged += (s, args) =>
            {
                _LoadTestAppointments();
            };
            EditTest.ShowDialog();
        }
    }
}
