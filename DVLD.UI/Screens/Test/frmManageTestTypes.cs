using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD.Core.Entities.Test;
using DVLD.UI.Screens.Application;
using DVLD.UI.Utils.Presentation;

namespace DVLD.UI.Screens.Test
{
    public partial class frmManageTestTypes : Form
    {
        public frmManageTestTypes()
        {
            InitializeComponent();
        }

        private void _LoadTestTypes()
        {
            sbTestTypes.DataGridView.DataSource = clsTestType.GetAllTestTypes();
        }
        private void frmManageTestTypes_Load(object sender, EventArgs e)
        {
            _LoadTestTypes();
        }

        private void editTestTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int SelectedTestTypeID = (int)sbTestTypes.DataGridView.SelectedRows[0].Cells[0].Value;
            frmUpdateTestType UpdateTestType = new frmUpdateTestType(SelectedTestTypeID);
            UpdateTestType.OnDataChanged += (s, args) => _LoadTestTypes();
            UpdateTestType.ShowDialog();
        }
    }
}
