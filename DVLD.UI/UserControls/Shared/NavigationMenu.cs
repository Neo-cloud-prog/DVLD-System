using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD.UI.Layout;
using DVLD.UI.Screens.User;

namespace DVLD.UI.UserControls.Shared
{
    public partial class NavigationMenu : UserControl
    {
        public struct Screens
        {
            public enum Main
            {
                People,
                Users,
                Drivers
            }

            public enum AccountSettings
            {
                CurrentUserInfo,
                ChangePassword,
                Login
            }

            public enum Applications
            {
                ManageApplicationTypes,
                DetainLicenses,
                LocalLicense,
                LocalDrivingLicenseApplocations,
                ManageTestTypes,
                ReplacementForLostLicesen,
                IntenationalLicense,
                RenewDrivingLicense,
                InternationalDrivingLicenseApplicaitons,
                ReleaseDetainedLicense,
                ManageDetainedLicenses,
                RetakeTest
            }
        }

        public event Action<object> OnNavigate;

        public NavigationMenu()
        {
            InitializeComponent();
        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnNavigate?.Invoke(Screens.Main.People);
        }

        private void singOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnNavigate?.Invoke(Screens.AccountSettings.Login);
        }

        private void currentUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnNavigate?.Invoke(Screens.AccountSettings.CurrentUserInfo);
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnNavigate?.Invoke(Screens.AccountSettings.ChangePassword);
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnNavigate?.Invoke(Screens.Main.Users);
        }

        private void driversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnNavigate?.Invoke(Screens.Main.Drivers);
        }

        private void manageApplicationTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnNavigate?.Invoke(Screens.Applications.ManageApplicationTypes);
        }

        private void detainLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnNavigate?.Invoke(Screens.Applications.DetainLicenses);
        }

        private void localeLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnNavigate?.Invoke(Screens.Applications.LocalLicense);
        }

        private void localDrivingLicenseApplocationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnNavigate?.Invoke(Screens.Applications.LocalDrivingLicenseApplocations);
        }

        private void manageTestTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnNavigate?.Invoke(Screens.Applications.ManageTestTypes);
        }

        private void rempToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnNavigate?.Invoke(Screens.Applications.ReplacementForLostLicesen);
        }

        private void intenationalLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnNavigate?.Invoke(Screens.Applications.IntenationalLicense);
        }

        private void renewDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnNavigate?.Invoke(Screens.Applications.RenewDrivingLicense);
        }

        private void internationalLicenseApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnNavigate?.Invoke(Screens.Applications.InternationalDrivingLicenseApplicaitons);
        }

        private void releaseDetainedLicensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnNavigate?.Invoke(Screens.Applications.ReleaseDetainedLicense);
        }

        private void manageDetainedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnNavigate?.Invoke(Screens.Applications.ManageDetainedLicenses);
        }

        private void retakeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnNavigate?.Invoke(Screens.Applications.RetakeTest);
        }

        private void releaseDetainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnNavigate?.Invoke(Screens.Applications.ReleaseDetainedLicense);
        }
    }
}