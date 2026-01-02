using System;
using System.Windows.Forms;
using DVLD.Core.Entities.User;
using DVLD.UI.Helpers.Session;
using DVLD.UI.Screens.Application;
using DVLD.UI.Screens.Application.International;
using DVLD.UI.Screens.Application.Local;
using DVLD.UI.Screens.Driver;
using DVLD.UI.Screens.License.Local;
using DVLD.UI.Screens.Person;
using DVLD.UI.Screens.Test;
using DVLD.UI.Screens.User;
using DVLD.UI.UserControls.Shared;

namespace DVLD.UI.Layout
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void _ShowScreen(object Screen)
        {
            switch(Screen)
            {
                case NavigationMenu.Screens.AccountSettings.Login:
                    if (!clsAppSession.CurrentUser.IsRemembered)
                    {
                        clsUserSession.Delete();
                    }

                    clsAppSession.CurrentUser.IsLogin = false;

                    clsAppSession.CurrentUser.Save();

                    clsAppSession.SetCurrentUser(null);

                    this.Hide();

                    frmLogin Login = new frmLogin();

                    Login.Show();

                    break;
                case NavigationMenu.Screens.AccountSettings.CurrentUserInfo:
                    frmCurrentUserInfo CurrentUserInfo = new frmCurrentUserInfo(clsAppSession.CurrentUser.ID);
                    CurrentUserInfo.ShowDialog();
                    break;
                case NavigationMenu.Screens.AccountSettings.ChangePassword:
                    frmChangePassword ChangePassword = new frmChangePassword(clsAppSession.CurrentUser.ID);
                    ChangePassword.ShowDialog();
                    break;
                case NavigationMenu.Screens.Main.People:
                    frmManagePeople ManagePeople = new frmManagePeople();
                    ManagePeople.ShowDialog();
                    break;
                case NavigationMenu.Screens.Main.Users:
                    frmManageUsers ManageUsers = new frmManageUsers();
                    ManageUsers.ShowDialog();
                    break;
                case NavigationMenu.Screens.Main.Drivers:
                    frmManageDrivers ManageDrivers = new frmManageDrivers();
                    ManageDrivers.ShowDialog();
                    break;
                case NavigationMenu.Screens.Applications.ManageApplicationTypes:
                    frmManageApplicationTypes ManageApplicationTypes = new frmManageApplicationTypes();
                    ManageApplicationTypes.ShowDialog();
                    break;
                case NavigationMenu.Screens.Applications.DetainLicenses:
                    frmDetainLicense DetainLicense = new frmDetainLicense();
                    DetainLicense.ShowDialog();
                    break;
                case NavigationMenu.Screens.Applications.ManageDetainedLicenses:
                    frmManageDetainedLicenses ManageDetainedLicenses = new frmManageDetainedLicenses();
                    ManageDetainedLicenses.ShowDialog();
                    break;
                case NavigationMenu.Screens.Applications.ReleaseDetainedLicense:
                    frmReleaseDetainedLicense ReleaseDetainedLicense = new frmReleaseDetainedLicense(-1);
                    ReleaseDetainedLicense.ShowDialog();
                    break;
                case NavigationMenu.Screens.Applications.RetakeTest:
                    frmLocalDrivingLicenseApplocations LocalDrivingLicenseAppsForRetakeTest = new frmLocalDrivingLicenseApplocations();
                    LocalDrivingLicenseAppsForRetakeTest.ShowDialog();
                    break;
                case NavigationMenu.Screens.Applications.LocalLicense:
                    frmLocalDrivingLicense LocalDrivingLicense = new frmLocalDrivingLicense(-1);
                    LocalDrivingLicense.ShowDialog();
                    break;
                case NavigationMenu.Screens.Applications.LocalDrivingLicenseApplocations:
                    frmLocalDrivingLicenseApplocations LocalDrivingLicenseApplocations = new frmLocalDrivingLicenseApplocations();
                    LocalDrivingLicenseApplocations.ShowDialog();
                    break;
                case NavigationMenu.Screens.Applications.ManageTestTypes:
                    frmManageTestTypes ManageTestTypes = new frmManageTestTypes();
                    ManageTestTypes.ShowDialog();
                    break;
                case NavigationMenu.Screens.Applications.ReplacementForLostLicesen:
                    frmReplacementForLostLicense ReplacementForLostLicense = new frmReplacementForLostLicense();
                    ReplacementForLostLicense.ShowDialog();
                    break;
                case NavigationMenu.Screens.Applications.IntenationalLicense:
                    frmInternationalLicenseApplication InternationalLicenseApplication = new frmInternationalLicenseApplication();
                    InternationalLicenseApplication.ShowDialog();
                    break;
                case NavigationMenu.Screens.Applications.RenewDrivingLicense:
                    frmRenewLicenseApplication RenewLicenseApplication = new frmRenewLicenseApplication();
                    RenewLicenseApplication.ShowDialog();
                    break;
                case NavigationMenu.Screens.Applications.InternationalDrivingLicenseApplicaitons:
                    frmInternationalDrivingLicenseApplicaitons InternationalDrivingLicenseApplicaitons = new frmInternationalDrivingLicenseApplicaitons();
                    InternationalDrivingLicenseApplicaitons.ShowDialog();
                    break;
            }
        }

        private void nav_OnNavigate(object Screen)
        {
            _ShowScreen(Screen);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CenterControlContainer.Controls.Add(lbTitle);
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            CenterControlContainer.Controls.Clear();
            CenterControlContainer.Controls.Add(lbTitle);
        }
    }
}
