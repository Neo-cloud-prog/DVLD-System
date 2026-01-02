using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.UI.Screens.Application.Local
{
    public partial class frmLocalLicesneApplicationInfo : Form
    {
        private DataGridViewRow _LocalLicenseApplicationDetailsRecord;

        public frmLocalLicesneApplicationInfo(DataGridViewRow LocalLicenseApplicationDetailsRecord)
        {
            InitializeComponent();
            _LocalLicenseApplicationDetailsRecord = LocalLicenseApplicationDetailsRecord;
        }

        private void frmLocalLicesneApplicationInfo_Load(object sender, EventArgs e)
        {
            ApplicationDetails.LoadInfo(_LocalLicenseApplicationDetailsRecord);
        }

        private void ibtnClose_OnClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
