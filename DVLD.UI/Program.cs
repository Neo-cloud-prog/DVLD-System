using System;
using System.Windows.Forms;
using DVLD.UI.Layout;
using DVLD.UI.Screens.User;
using DVLD.UI.Helpers.Session;

namespace DVLD.UI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();

            Application.SetCompatibleTextRenderingDefault(false);

            clsAppSession.LoadCurrentUser();

            if (clsAppSession.CurrentUser == null || !clsAppSession.CurrentUser.IsLogin || !clsAppSession.CurrentUser.IsRemembered)
            {
                Application.Run(new frmLogin());
            }
            else
            {
                Application.Run(new MainForm());
            }
        }
    }
}
