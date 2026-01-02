using System;
using System.Windows.Forms;
using DVLD.Core.Entities.User;
using DVLD.UI.Helpers.Session;

namespace DVLD.UI.Screens.User
{
    public partial class frmCurrentUserInfo : Form
    {
        private int _UserID = -1;

        public frmCurrentUserInfo(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
        }

        private void frmCurrentUserInfo_Load(object sender, EventArgs e)
        {
            clsUser User;
            if (_UserID == clsAppSession.CurrentUser.ID)
            {
                User = clsAppSession.CurrentUser;
            }
            else
            {
                User = clsUser.Find(_UserID);
            }
            UserInformation.LoadUserById(User.ID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
