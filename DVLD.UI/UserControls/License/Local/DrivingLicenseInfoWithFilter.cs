using System;
using DVLD.UI.Events.License;
using DVLD.UI.UserControls.Shared;
using DVLD.UI.Utils.Presentation;

namespace DVLD.UI.UserControls.License.Local
{
    public partial class DrivingLicenseInfoWithFilter : BaseUserControl<clsLicenseEventArgs>
    {
        public DrivingLicenseInfoWithFilter()
        {
            InitializeComponent();
        }

        public void LoadLicenseInfoByID(int LicenseID)
        {
            DrivingLicenseInfo.LoadLicenseInfoByID(LicenseID);
            tbSearchText.Text = LicenseID.ToString();
        }

        private void ibtnSearch_Click(object sender, EventArgs e)
        {
            int LicenseID = Convert.ToInt32(tbSearchText.Text);
            DrivingLicenseInfo.LoadLicenseInfoByID(LicenseID);
            TriggerDataChanged(new clsLicenseEventArgs(LicenseID));
        }

        private void tbSearchText_TextChanged(object sender, EventArgs e)
        {
            clsPresentationUtils.PreventEnterStringInTextBox(tbSearchText);
        }
    }
}
