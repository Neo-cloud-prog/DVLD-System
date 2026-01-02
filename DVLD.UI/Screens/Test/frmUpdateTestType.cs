using System;
using DVLD.Core.Entities.Test;
using DVLD.UI.Screens.Basic;

namespace DVLD.UI.Screens.Test
{
    public partial class frmUpdateTestType : BaseForm<EventArgs>
    {
        private int _TestTypeID = -1;
        private clsTestType _TestType = new clsTestType();

        public frmUpdateTestType(int TestTypeID)
        {
            InitializeComponent();
            _TestTypeID = TestTypeID;
        }

        private void _ShowTestTypeInfo()
        {
            lbTestTypeID.Text = _TestTypeID.ToString();
            tbTitle.Text = _TestType.Title;
            tbDescription.Text = _TestType.Description;
            tbFees.Text = Convert.ToInt32(_TestType.Fees).ToString();
        }

        private void frmUpdateTestType_Load(object sender, EventArgs e)
        {
            _TestType = clsTestType.Find(_TestTypeID);
            _ShowTestTypeInfo();
        }

        private void _FillTestType()
        {
            _TestType.Title = tbTitle.Text;
            _TestType.Description = tbDescription.Text;
            _TestType.Fees = Convert.ToDecimal(tbFees.Text);
        }

        private void ibtnSave_OnClick(object sender, EventArgs e)
        {
            _FillTestType();
            if (_TestType.Save())
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
