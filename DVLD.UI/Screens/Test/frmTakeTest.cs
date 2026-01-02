using System;
using System.Windows.Forms;
using DVLD.Core.Entities.Test;
using DVLD.Core.Enums;
using DVLD.UI.Helpers.Session;
using DVLD.UI.Screens.Basic;

namespace DVLD.UI.Screens.Test
{
    public partial class frmTakeTest : BaseForm<EventArgs>
    {
        private DataGridViewRow _SelectedAppRow;
        private clsTestAppointment _TestAppointment;
        private int _SelectedTestAppointmentID = -1;
        enTestType _TestType;
        enTestAppointmentOperation _TestAppointmentOperation;

        public frmTakeTest(DataGridViewRow SelectedAppRow, enTestAppointmentOperation TestAppointmentOperation, int SelectedTestAppointmentID)
        {
            InitializeComponent();
            _SelectedAppRow = SelectedAppRow;
            _TestType = (enTestType)_SelectedAppRow.Cells[5].Value;
            _TestAppointmentOperation = TestAppointmentOperation;
            _SelectedTestAppointmentID = SelectedTestAppointmentID;
        }

        private void frmTakeTest_Load(object sender, EventArgs e)
        {
            ucScheduleTest.Prepar(_SelectedAppRow, _TestType, _TestAppointmentOperation);
            _TestAppointment = clsTestAppointment.Find(_SelectedTestAppointmentID);
            if (_TestAppointment.IsLocked)
            {
                clsTest Test = clsTest.FindByTestAppointmentID(_SelectedTestAppointmentID);
                lbTestID.Text = Test.ID.ToString();
                tbNotes.Text = Test.Notes;
                rbPass.Checked = Test.TestResult;
                ibtnSave.Enabled = false;
                tbNotes.Enabled = false;
                rbPass.Enabled = false;
                rbFail.Enabled = false;
            }
        }

        private void ibtnSave_OnClick(object sender, EventArgs e)
        {
            clsTest Test = new clsTest();
            Test.TestAppointmentID = _TestAppointment.ID;
            Test.TestResult = rbPass.Checked;
            Test.Notes = tbNotes.Text;
            Test.CreatedByUserID = clsAppSession.CurrentUser.ID;

            if(Test.Save())
            {
                MessageBox.Show("Test Done Successfuly");
            }

            lbTestID.Text = Test.ID.ToString();

            _TestAppointment.IsLocked = true;

            if (_TestAppointment.Save())
            {
                MessageBox.Show("Test Appointment Done Successfuly");
            }

            ibtnSave.Enabled = false;

            TriggerDataChanged(EventArgs.Empty);
        }

        private void ibtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
