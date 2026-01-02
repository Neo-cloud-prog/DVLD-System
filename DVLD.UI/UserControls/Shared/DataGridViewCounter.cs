using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.UI.UserControls.Shared
{
    public partial class DataGridViewCounter : UserControl
    {
        private DataGridView _DataSource;

        public DataGridViewCounter()
        {
            InitializeComponent();
        }

        private void _SetCount()
        {
            lbCount.Text = _DataSource.Rows.Count.ToString();
        }

        [Browsable(true)]
        [Category("Custom")]
        [Description("Sets the data source.")]
        [DefaultValue(null)]
        public DataGridView DataSource
        {
            get { return _DataSource; }
            set
            {
                _DataSource = value;
                _SetCount();
            }
        }

        public void RefreshCount()
        {
            _SetCount();
        }
    }
}
