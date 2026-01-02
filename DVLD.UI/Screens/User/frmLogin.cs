using System;
using System.Windows.Forms;
using DVLD.Core.Entities.User;
using DVLD.UI.Layout;
using DVLD.UI.Helpers.Session;
using DVLD.UI.Helpers.Validation;
using DVLD.Core.Services.User;

namespace DVLD.UI.Screens.User
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            SetupValidationRules();
        }

        private void SetupValidationRules()
        {
            LoginValidator.AddRule(clsAppValidationRules.GetRule(tbUserName, LoginErrorProvider, clsAppValidationRules.enRuleType.FilledField));
            LoginValidator.AddRule(clsAppValidationRules.GetRule(tbPassword, LoginErrorProvider, clsAppValidationRules.enRuleType.ValidePassword));
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            clsUser LogedUser = clsAppSession.CurrentUser;
            if (LogedUser != null && LogedUser.IsRemembered)
            {
                tbUserName.Text = LogedUser.Name;
                tbPassword.Text = LogedUser.Password;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!LoginValidator.ValidateAll())
            { 
                return;
            }

            clsUser User = clsLoginService.Authenticate(tbUserName.Text, tbPassword.Text);

            if (User != null)
            {
                if (!User.IsActive)
                {
                    MessageBox.Show("This user is not active");
                    return;
                }
                User.IsRemembered = chkRememberMe.Checked;
                User.IsLogin = true;
                User.Save();
                clsUserSession.Save(User.ID);
                clsAppSession.SetCurrentUser(User);
                MainForm Main = new MainForm();
                this.Hide();
                Main.Show();
                Main.FormClosed += (s, args) => this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
        }

        private void txtBoxForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

        private void chkRememberMe_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                chkRememberMe.Checked = !chkRememberMe.Checked;
            }
        }

        private void ValidateUserName(object sender, EventArgs e)
        {
            LoginValidator.ValidateRuleIndex(0);
        }

        private void ValidatePassword(object sender, EventArgs e)
        {
            LoginValidator.ValidateRuleIndex(1);
        }
    }
}
