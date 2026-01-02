using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.UI.Screens.License.International
{
    public partial class frmInternationalDrivingLicenseInfo : Form
    {
        private int _InternationalLicense = -1;

        public frmInternationalDrivingLicenseInfo(int InternationalLicense)
        {
            InitializeComponent();
            _InternationalLicense = InternationalLicense;
        }

        private void frmInternationalDrivingLicenseInfo_Load(object sender, EventArgs e)
        {
            InternationalDrivingLicenseInfo.LoadInternationalInfoByID(_InternationalLicense);
        }

        private void ibtnClose_OnClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
