using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using DVLD.Core.Entities.User;
using DVLD.UI.Events.User;
using DVLD.UI.Helpers.UI.GridView;

namespace DVLD.UI.Screens.User
{
    public partial class frmManageUsers : Form
    {

        private int _UserID = -1;

        public frmManageUsers()
        {
            InitializeComponent();
        }

        private void LoadUsers()
        {
            DataTable UsersTable = clsUser.GetAllUsersWithPeople();
            sbUsers.LoadData(UsersTable, new List<clsGridColumnDefinition>
            {
                new clsGridColumnDefinition("dcUserID", "UserID", "UserID"),
                new clsGridColumnDefinition("dcPersonID", "PersonID", "PersonID"),
                new clsGridColumnDefinition("dcFullName", "FullName", "FullName"),
                new clsGridColumnDefinition("dcUserName", "UserName", "UserName"),
                new clsGridColumnDefinition("dcIsActive", "Is Active", "IsActive", clsGridColumnDefinition.enColumnType.Checkbox)
            });
            DataGridViewFilter.Bind(sbUsers.DataGridView);
        }

        private void frmManageUsers_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            frmAddUpdateUser AddNewUser = new frmAddUpdateUser(-1);
            AddNewUser.OnDataChanged += OnUserChanged;
            AddNewUser.ShowDialog();
        }

        private void OnUserChanged(object sender, clsUserEventArgs e)
        {
            LoadUsers();
        }

        private void cmsUser_Opening(object sender, CancelEventArgs e)
        {
            _UserID = (int)sbUsers.DataGridView.SelectedRows[0].Cells[0].Value;
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCurrentUserInfo CurrentUserInfo = new frmCurrentUserInfo(_UserID);
            CurrentUserInfo.ShowDialog();
        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateUser AddNewUser = new frmAddUpdateUser(-1);
            AddNewUser.OnDataChanged += OnUserChanged;
            AddNewUser.ShowDialog();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = (int)sbUsers.DataGridView.SelectedRows[0].Cells[1].Value;
            frmAddUpdateUser UpdateUser = new frmAddUpdateUser(_UserID, PersonID);
            UpdateUser.OnDataChanged += OnUserChanged;
            UpdateUser.ShowDialog();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsUser.DeleteUser(_UserID))
            {
                MessageBox.Show("User has been deleted successfuly");
                LoadUsers();
            } 
            else
            {
                MessageBox.Show("You cannot delete this user because it is linked to an external relationships");
            }
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePassword ChangePassword = new frmChangePassword(_UserID);
            ChangePassword.OnDataChanged += (s, args) => LoadUsers();
            ChangePassword.ShowDialog();
        }
    }
}
