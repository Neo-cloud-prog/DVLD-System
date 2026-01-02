using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DVLD.UI.Utils.Presentation;
using DVLD.UI.Utils.Validation;

namespace DVLD.UI.UserControls.Shared
{
    public partial class DataGridViewFilter : UserControl
    {
        DataView _DataView;
        DataTable _OriginalDataTable;
        DataGridView _DataGridView;

        public DataGridViewFilter()
        {
            InitializeComponent();
        }

        [Browsable(true)]
        [Category("Custom")]
        [Description("Sets the data source.")]
        [DefaultValue(null)]
        public DataGridView DataGridView
        {
            get { return _DataGridView; }
            set
            {
                _DataGridView = value;
                if (_DataGridView != null)
                {
                    tbSearchText.Visible = false;
                }
            }
        }

        private void _PrepareComboBox(DataTable Table = null, string[] SelectedColumns = null)
        {
            cmbFilter.Items.Clear();
            cmbFilter.Items.Add("None");

            if (Table != null)
            {
                var ColumnNames = (SelectedColumns == null || SelectedColumns.Length == 0)
                    ? Table.Columns.Cast<DataColumn>().Select(col => col.ColumnName).ToArray()
                    : SelectedColumns;

                cmbFilter.Items.AddRange(ColumnNames);
            } else
            {
                cmbFilter.Enabled = false;
            }

            cmbFilter.SelectedIndex = 0;
        }

        public void Bind(DataGridView DataGridView, string[] SelectedColumns = default)
        {
            DataTable Table = DataGridView.DataSource is DataTable ? (DataTable)DataGridView.DataSource : null;

            _DataGridView = DataGridView;

            _OriginalDataTable = Table?.Copy();

            _DataView = Table?.DefaultView;

            _PrepareComboBox(Table, SelectedColumns);
        }

        private void ApplyFilter()
        {
            string SelectedItem = cmbFilter.SelectedItem.ToString();

            if (_DataView == null || _DataView.Table.Rows.Count == 0 || string.IsNullOrWhiteSpace(SelectedItem) || cmbFilter.SelectedIndex <= 0)
                return;

            string ColumnName = SelectedItem;

            string FilterText = tbSearchText.Text.Trim();

            Type ColumnType = _DataView.Table.Columns[ColumnName].DataType;

            string RowFilter = "";

            try
            {
                if (tbSearchText.Text != "") 
                {
                    if (ColumnType == typeof(string))
                    {
                        FilterText = FilterText.Replace("'", "''");
                        RowFilter = $"[{ColumnName}] Like '{FilterText}%'";
                    }
                    else if (clsValidateUtils.IsNumericType(ColumnType))
                    {
                        if (int.TryParse(FilterText, out int Result))
                        {
                            RowFilter = $"{ColumnName} = {Result}";
                        }
                        else
                        {
                            clsPresentationUtils.PreventEnterStringInTextBox(tbSearchText, true);
                            return;
                        }
                    }
                    else if (ColumnType == typeof(bool))
                    {
                        FilterText = cmbBooleanFilter.SelectedItem.ToString();

                        if (FilterText == "1" || FilterText.Equals("true", StringComparison.OrdinalIgnoreCase) || FilterText == "Yes")
                            RowFilter = $"{ColumnName} = true";
                        else if (FilterText == "0" || FilterText.Equals("false", StringComparison.OrdinalIgnoreCase) || FilterText == "No")
                            RowFilter = $"{ColumnName} = false";
                        else
                            RowFilter = "1=1";
                    }
                    else if (ColumnType == typeof(DateTime))
                    {
                        string FormattedDate = dtpFilter.Value.ToString("d");
                        RowFilter = $"CONVERT({ColumnName}, 'System.String') LIKE '{FormattedDate}%'";
                    }
                }

                _DataView.RowFilter = RowFilter;
                _DataGridView.DataSource = _DataView;
                
            }
            catch
            {
                // do something
            }
        }

        private void tbSearchText_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool IsNoneSelected = cmbFilter.SelectedIndex == 0;
            tbSearchText.Visible = !IsNoneSelected;
            cmbBooleanFilter.Visible = false;
            dtpFilter.Visible = false;
            tbSearchText.BringToFront();

            if (!IsNoneSelected)
            {
                DataColumn DataColumn = _DataView.Table.Columns[cmbFilter.SelectedItem.ToString()];

                if (DataColumn != null)
                {
                    if (DataColumn.DataType == typeof(bool))
                    {
                        cmbBooleanFilter.Visible = true;
                        cmbBooleanFilter.SelectedIndex = 0;
                        cmbBooleanFilter.BringToFront();
                    }

                    if (DataColumn.DataType == typeof(DateTime))
                    {
                        dtpFilter.Visible = true;
                        dtpFilter.BringToFront();
                    }
                }
            }
            tbSearchText.Text = "";
            tbSearchText.Focus();
        }

        private void cmbBooleanFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void dtpFilter_ValueChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }
    }
}