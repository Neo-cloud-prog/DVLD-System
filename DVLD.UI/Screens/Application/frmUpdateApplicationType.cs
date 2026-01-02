using System;
using DVLD.Core.Entities.Application;
using DVLD.UI.Screens.Basic;

namespace DVLD.UI.Screens.Application
{
    public partial class frmUpdateApplicationType : BaseForm<EventArgs>
    {
        private int _AppTypeID = -1;
        private clsApplicationType ApplicationType = new clsApplicationType();

        public frmUpdateApplicationType(int AppTypeID)
        {
            InitializeComponent();
            _AppTypeID = AppTypeID;
        }

        private void _ShowAppTypeInfo()
        {
            lbAppTypeID.Text = _AppTypeID.ToString();
            tbTitle.Text = ApplicationType.Title;
            tbFees.Text = Convert.ToInt32(ApplicationType.Fees).ToString();
        }

        private void frmUpdateApplicationType_Load(object sender, EventArgs e)
        {
            ApplicationType = clsApplicationType.Find(_AppTypeID);
            _ShowAppTypeInfo();
        }

        private void _FillAppType()
        {
            ApplicationType.Title = tbTitle.Text;
            ApplicationType.Fees = Convert.ToDecimal(tbFees.Text);
        }

        private void ibtnSave_OnClick(object sender, EventArgs e)
        {
            _FillAppType();
            if (ApplicationType.Save())
            {
                TriggerDataChanged(EventArgs.Empty);
            }
        }

        private void ibtnClose_OnClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
