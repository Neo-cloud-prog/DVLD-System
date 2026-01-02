using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DVLD.Core.Entities.Applicaction;
using DVLD.Core.Entities.License;
using DVLD.UI.Screens.License;
using DVLD.UI.Screens.Test;
using DVLD.UI.Helpers.UI.GridView;
using DVLD.UI.Screens.License.Local;
using DVLD.Core.Entities.Driver;
using DVLD.Core.Enums;

namespace DVLD.UI.Screens.Application.Local
{
    public partial class frmLocalDrivingLicenseApplocations : Form
    {
        private int _ApplicationID = -1;
        private int _SelectedLocalLicenseAppID = -1;
        private clsLocalDrivingLicenseApplication _LocalDrivingLicenseApplication;
        private clsApplication _Application;
        private DataGridViewRow _SelectedRow;

        public frmLocalDrivingLicenseApplocations()
        {
            InitializeComponent();
        }

        private void _LoadLocalDrivingLicenseApplications()
        {
            DataTable LocalDrivingLicenseApplicationsTable = clsLocalDrivingLicenseApplication.GetAllLocalDrivingLicenseApplicationsDetails();
            sbLocalLicenseApplications.LoadData(LocalDrivingLicenseApplicationsTable, new List<clsGridColumnDefinition>
            {
                new clsGridColumnDefinition("dcLocalDrivingLicenseApplicationID", "L.D.L AppID", "LocalDrivingLicenseApplicationID"),
                new clsGridColumnDefinition("dcClassName", "Driving Class", "ClassName"),
                new clsGridColumnDefinition("dcNationalNo", "National No", "NationalNo"),
                new clsGridColumnDefinition("dcFullName", "FullName", "FullName"),
                new clsGridColumnDefinition("dcApplicationDate", "Application Date", "ApplicationDate"),
                new clsGridColumnDefinition("dcPassedTestCount", "Passed Tests", "PassedTestCount"),
                new clsGridColumnDefinition("dcStatus", "Status", "Status"),
            });
            string[] SelectedColumns = { "LocalDrivingLicenseApplicationID", "NationalNo", "FullName", "Status" };
            DataGridViewFilter.Bind(sbLocalLicenseApplications.DataGridView, SelectedColumns);
        }

        private void frmLocalDrivingLicenseApplocations_Load(object sender, EventArgs e)
        {
            _LoadLocalDrivingLicenseApplications();
        }

        private void btnAddLoacalLicenseApplication_OnClick(object sender, EventArgs e)
        {
            frmLocalDrivingLicense LocalDrivingLicense = new frmLocalDrivingLicense(-1);
            LocalDrivingLicense.OnDataChanged += (s, args) => _LoadLocalDrivingLicenseApplications();
            LocalDrivingLicense.ShowDialog();
        }

        private void showApplicationDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLocalLicesneApplicationInfo LocalLicesneApplicationInfo = new frmLocalLicesneApplicationInfo(_SelectedRow);
            LocalLicesneApplicationInfo.ShowDialog();
        }

        private void _NewApplicationConfiguration()
        {
            schedulTestsToolStripMenuItem.Enabled = true;
            cmsLocalLicenseApplication.Enabled = true;
            showLicenseToolStripMenuItem.Enabled = false;
            editToolStripMenuItem.Enabled = true;
            deleteApplicationToolStripMenuItem.Enabled = true;
            cancelApplicationToolStripMenuItem.Enabled = true;
        }

        private void _CancelledApplicationConfiguration()
        {
            cmsLocalLicenseApplication.Enabled = false;
        }

        private void _CompletedApplicationConfiguration()
        {
            editToolStripMenuItem.Enabled = false;
            deleteApplicationToolStripMenuItem.Enabled = false;
            cancelApplicationToolStripMenuItem.Enabled = false;
            issueDrivingLicenseToolStripMenuItem.Enabled = false;
            showLicenseToolStripMenuItem.Enabled = true;
            cmsLocalLicenseApplication.Enabled = true;
        }

        private void _HandleScheduleTestsEnabledStatus()
        {
            List<ToolStripMenuItem> ScheduleTestToolStripMenuItems = new List<ToolStripMenuItem>() { schedulVisionTestToolStripMenuItem, scheduleWriteenTestToolStripMenuItem, scheduleToolStripMenuItem, schedulTestsToolStripMenuItem };
            schedulVisionTestToolStripMenuItem.Enabled = false;
            scheduleWriteenTestToolStripMenuItem.Enabled = false;
            scheduleToolStripMenuItem.Enabled = false;
            int Index = (int)_SelectedRow.Cells[5].Value;
            ScheduleTestToolStripMenuItems[Index].Enabled = Index != ScheduleTestToolStripMenuItems.Count - 1;
        }

        private void _HandleIssueDrivingLicenseEnabledStatus()
        {
            int PassedTestCount = (int)_SelectedRow.Cells[5].Value;
            if (PassedTestCount == 3)
            {
                issueDrivingLicenseToolStripMenuItem.Enabled = true;
            }
        }

        private void _HandleEnabledStatusAccordingAppStatus()
        {
            string Status = (string)_SelectedRow.Cells[_SelectedRow.Cells.Count - 1].Value;

            switch(Status)
            {
                case "Cancelled":
                    _CancelledApplicationConfiguration();
                    break;
                case "Completed":
                    _CompletedApplicationConfiguration();
                    break;
                default:
                    _NewApplicationConfiguration();
                    break;
            }
        }

        private void cmsLocalLicenseApplication_Opening(object sender, CancelEventArgs e)
        {
            _SelectedRow = sbLocalLicenseApplications.DataGridView.SelectedRows[0];
            _HandleScheduleTestsEnabledStatus();
            _HandleIssueDrivingLicenseEnabledStatus();
            _HandleEnabledStatusAccordingAppStatus();
            _SelectedLocalLicenseAppID = (int)_SelectedRow.Cells[0].Value;
            _ApplicationID = clsApplication.Find(clsLocalDrivingLicenseApplication.Find(_SelectedLocalLicenseAppID).ApplicationID).ID;
            _LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplication.Find(_SelectedLocalLicenseAppID);
            _Application = clsApplication.Find(_LocalDrivingLicenseApplication.ApplicationID);
        }

        private void cancelApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _Application.Status = (byte)enApplicationStatus.Cancelled;
            _Application.Save();
            _LoadLocalDrivingLicenseApplications();
        }

        private void deleteApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsLocalDrivingLicenseApplication.DeleteLocalLicenseApplication(_SelectedLocalLicenseAppID);
            clsApplication.DeleteApplication(_ApplicationID);
            _LoadLocalDrivingLicenseApplications();
        }

        private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsLicense License = clsLicense.FindByAppID(_ApplicationID);
            frmLocalDrivingLicenseInfo LocalDrivingLicenseInfo = new frmLocalDrivingLicenseInfo(License.ID);
            LocalDrivingLicenseInfo.ShowDialog();
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLicenseHistory LicenseHistory = new frmLicenseHistory(_Application.PersonID);
            LicenseHistory.ShowDialog();
        }

        private void schedulTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTestAppointments TestAppointments = new frmTestAppointments(_SelectedRow);
            TestAppointments.OnTestPassed += (TestID) => _LoadLocalDrivingLicenseApplications();
            TestAppointments.ShowDialog();
        }

        private void issueDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIssueLocalLicenseFirstTime IssueLocalLicenseFirstTime = new frmIssueLocalLicenseFirstTime(_SelectedRow);
            IssueLocalLicenseFirstTime.OnDataChanged += (s, args) => _LoadLocalDrivingLicenseApplications();
            IssueLocalLicenseFirstTime.ShowDialog();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLocalDrivingLicense LocalDrivingLicense = new frmLocalDrivingLicense(_SelectedLocalLicenseAppID);
            LocalDrivingLicense.OnDataChanged += (s, args) => _LoadLocalDrivingLicenseApplications();
            LocalDrivingLicense.ShowDialog();
        }
    }
}
