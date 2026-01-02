using System.Windows.Forms;
using DVLD.Core.Entities.User;

namespace DVLD.UI.UserControls.User
{
    public partial class UserInformation : UserControl
    {
        public UserInformation()
        {
            InitializeComponent();
        }

        private void _FillUserDetails(clsUser User)
        {
            lbUserID.Text = User.ID.ToString();
            lbUsername.Text = User.Name;
            lbIsAvtive.Text = (User.IsActive ? "Yes" : "No");
        }

        public void LoadUserById(int ID)
        {
            clsUser clsUser = clsUser.Find(ID);
            PersonDetails.LoadPersonByID(clsUser.PersonID);
            _FillUserDetails(clsUser);
        }
    }
}
