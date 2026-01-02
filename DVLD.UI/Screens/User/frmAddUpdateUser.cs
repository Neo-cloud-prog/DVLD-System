using System;
using System.Windows.Forms;
using DVLD.Core.Entities.User;
using DVLD.UI.Events.Person;
using DVLD.UI.Events.User;
using DVLD.UI.Helpers.Validation;
using DVLD.Core.Enums;
using DVLD.UI.Screens.Basic;

namespace DVLD.UI.Screens.User
{
    public partial class frmAddUpdateUser : BaseForm<clsUserEventArgs>
    {

        private int _UserID = -1;

        private int _PersonID = -1;

        private enMode _Mode;

        private clsUser _User;

        public frmAddUpdateUser(int UserID, int PersonID = -1)
        {
            InitializeComponent();
            SetupValidationRules();
            _UserID = UserID;
            _PersonID = PersonID;
            _Mode = _UserID == -1 ? enMode.AddNew : enMode.Update;
            _User = _Mode == enMode.AddNew ? new clsUser() : clsUser.Find(_UserID);
        }

        private void _ChangeScreenTitleAccordingMode(enMode Mode)
        {
            if (Mode == enMode.AddNew)
            {
                lbTitle.Text = "Add New User";
            }
            else
            {
                lbTitle.Text = "Update User";
            }
        }

        private void SetupValidationRules()
        {
            AddNewUserValidator.AddRule(clsAppValidationRules.GetRule(tbUserName, AddNewUserErrorProvider, clsAppValidationRules.enRuleType.FilledField));
            AddNewUserValidator.AddRule(clsAppValidationRules.GetRule(tbPassword, AddNewUserErrorProvider, clsAppValidationRules.enRuleType.ValidePassword));
            AddNewUserValidator.AddRule(clsAppValidationRules.GetRule(tbConfirmPassword, AddNewUserErrorProvider, clsAppValidationRules.enRuleType.ConfirmPasswordShouldEqualToPassword));
        }

        private void _PreparUserInfo()
        {
            _User.PersonID = _PersonID;
            _User.Name = tbUserName.Text;
            _User.Password = tbPassword.Text;
            _User.IsActive = chkIsActive.Checked;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_Mode == enMode.AddNew)
            {
                if (clsUser.FindByPersonID(_PersonID) != null)
                {
                    MessageBox.Show("This person already has a user, choose another one");
                    return;
                }
            }

            if (AddNewUserTab.SelectedIndex < AddNewUserTab.TabCount - 1)
            {
                AddNewUserTab.SelectedIndex += 1;
                btnSave.Enabled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!AddNewUserValidator.ValidateAll())
            {
                return;
            }

            _PreparUserInfo();
            if(_User.Save())
            {
                MessageBox.Show("User Saved Successfuly");

                TriggerDataChanged(new clsUserEventArgs(_User.ID));

                if(_Mode == enMode.AddNew)
                {
                    lbUserID.Text = _User.ID.ToString();
                    _ChangeScreenTitleAccordingMode((_Mode = enMode.Update));
                }
            }
            else
            {
                MessageBox.Show("Something Went Wrong");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbUserName_Leave(object sender, EventArgs e)
        {
            AddNewUserValidator.ValidateRuleIndex(0);
        }

        private void tbPassword_Leave(object sender, EventArgs e)
        {
            AddNewUserValidator.ValidateRuleIndex(1);
        }

        private void tbConfirmPassword_Leave(object sender, EventArgs e)
        {
            AddNewUserValidator.ValidateRuleIndex(2);
        }

        private void _FillUserInfoInUI()
        {
            tbUserName.Text = _User.Name;
            tbPassword.Text = _User.Password;
            tbConfirmPassword.Text = tbPassword.Text;
            chkIsActive.Checked = _User.IsActive;
        }

        private void frmAddUpdateUser_Load(object sender, EventArgs e)
        {
            _ChangeScreenTitleAccordingMode(_Mode);
            if(_Mode == enMode.Update)
            {
                PersonDetailsWithFilter.LoadPersonByID(_PersonID);
                _FillUserInfoInUI();
                btnSave.Enabled = true;
            }
        }
    }
}
