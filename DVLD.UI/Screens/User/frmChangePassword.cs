using System;
using System.Windows.Forms;
using DVLD.Core.Entities.User;
using DVLD.UI.Helpers.Session;
using DVLD.UI.Helpers.Validation;
using DVLD.UI.Screens.Basic;

namespace DVLD.UI.Screens.User
{
    public partial class frmChangePassword : BaseForm<EventArgs>
    {
        private int _UserID = -1;
        private clsUser _User;

        public frmChangePassword(int UserID)
        {
            InitializeComponent();
            SetupValidationRules();
            _UserID = UserID;
        }

        private void SetupValidationRules()
        {
            PasswordValidator.AddRule(clsAppValidationRules.GetRule(tbCurrentPassword, PasswordErrorProvider, clsAppValidationRules.enRuleType.PasswordShouldEqualToCurrentPassword));
            PasswordValidator.AddRule(clsAppValidationRules.GetRule(tbNewPassword, PasswordErrorProvider, clsAppValidationRules.enRuleType.ValidePassword));
            PasswordValidator.AddRule(clsAppValidationRules.GetRule(tbConfirmPassword, PasswordErrorProvider, clsAppValidationRules.enRuleType.ConfirmPasswordShouldEqualToPassword));
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            if (_UserID == clsAppSession.CurrentUser.ID)
            {
                _User = clsAppSession.CurrentUser;
            }
            else
            {
                _User = clsUser.Find(_UserID);
            }
            UserInformation.LoadUserById(_User.ID);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!PasswordValidator.ValidateAll())
            {
                return;
            }
            _User.Password = tbConfirmPassword.Text;
            if(_User.Save())
            {
                MessageBox.Show("Password updated successfuly");
                TriggerDataChanged(EventArgs.Empty);
            }
        }

        private void ValidateCurrentPassword(object sender, EventArgs e)
        {
            PasswordValidator.ValidateRuleIndex(0);
        }

        private void ValidateNewPassword(object sender, EventArgs e)
        {
            PasswordValidator.ValidateRuleIndex(1);
        }

        private void ValidateConfirmPassword(object sender, EventArgs e)
        {
            PasswordValidator.ValidateRuleIndex(2);
        }

        private void txtBoxForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave_Click(sender, e);
            }
        }
    }
}
