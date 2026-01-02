using System;
using System.Windows.Forms;
using DVLD.Core.Entities.Application;

namespace DVLD.UI.Screens.Application
{
    public partial class frmManageApplicationTypes : Form
    {
        public frmManageApplicationTypes()
        {
            InitializeComponent();
        }

        private void _LoadApplicationTypes()
        {
            sbApplicationTypes.DataGridView.DataSource = clsApplicationType.GetAllApplicationTypes();
        }

        private void frmManageApplicationTypes_Load(object sender, EventArgs e)
        {
            _LoadApplicationTypes();
        }

        private void editAppTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int SelectedTestTypeID = (int)sbApplicationTypes.DataGridView.SelectedRows[0].Cells[0].Value;
            frmUpdateApplicationType UpdateApplicationType = new frmUpdateApplicationType(SelectedTestTypeID);
            UpdateApplicationType.OnDataChanged += (s, args) => _LoadApplicationTypes();
            UpdateApplicationType.ShowDialog();
        }
    }
}
