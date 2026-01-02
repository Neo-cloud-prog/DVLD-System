using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.UI.Screens.License.Local
{
    public partial class frmLocalDrivingLicenseInfo : Form
    {
        private int _LicenseID = -1;

        public frmLocalDrivingLicenseInfo(int LicenseID)
        {
            InitializeComponent();
            _LicenseID = LicenseID;
        }

        private void frmLocalDrivingLicenseInfo_Load(object sender, EventArgs e)
        {
            DrivingLicenseInfo.LoadLicenseInfoByID(_LicenseID);
        }
    }
}
