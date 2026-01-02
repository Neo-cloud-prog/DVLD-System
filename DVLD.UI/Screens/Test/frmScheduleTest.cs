using System;
using System.Windows.Forms;
using DVLD.Core.Enums;
using DVLD.UI.Screens.Basic;

namespace DVLD.UI.Screens.Test
{
    public partial class frmScheduleTest : BaseForm<EventArgs>
    {
        private DataGridViewRow _SelectedAppRow;
        private enTestType _TestType;
        private enTestAppointmentOperation _TestAppointmentOperation;
        private int _SelectedTestAppointmentID = -1;

        public frmScheduleTest(DataGridViewRow SelectedAppRow, enTestAppointmentOperation TestAppointmentOperation = enTestAppointmentOperation.ScheduleTest, int SelectedTestAppointmentID = -1)
        {
            InitializeComponent();
            _SelectedAppRow = SelectedAppRow;
            _TestType = (enTestType)_SelectedAppRow.Cells[5].Value;
            _TestAppointmentOperation = TestAppointmentOperation;
            _SelectedTestAppointmentID = SelectedTestAppointmentID;
        }

        private void frmScheduleTest_Load(object sender, EventArgs e)
        {
            ucScheduleTest.Prepar(_SelectedAppRow, _TestType, _TestAppointmentOperation, _SelectedTestAppointmentID);
        }

        private void frmScheduleTest_FormClosed(object sender, FormClosedEventArgs e)
        {
            if ((bool)this.Tag)
            {
                TriggerDataChanged(EventArgs.Empty);
            }
        }

        private void ibtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
