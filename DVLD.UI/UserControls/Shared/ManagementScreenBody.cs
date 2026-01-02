using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DVLD.UI.Helpers.UI.GridView;
using DVLD.UI.Utils.Presentation;

namespace DVLD.UI.UserControls.Shared
{
    public partial class ManagementScreenBody : UserControl
    {
        private ContextMenuStrip _DataGridViewContextMenu;

        public ManagementScreenBody()
        {
            InitializeComponent();
            btnClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Records.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            DataGridView.ReadOnly = true;
        }

        [Browsable(true)]
        [Category("Custom")]
        [Description("Sets the context menu strip for data grid view")]
        [DefaultValue(null)]
        public ContextMenuStrip DataGridViewContextMenu
        {
            get => _DataGridViewContextMenu;
            set
            {
                _DataGridViewContextMenu = value;
                DataGridView.ContextMenuStrip = value;
            }
        }

        [Browsable(true)]
        [Category("Custom")]
        [Description("Sets the button visibility")]
        [DefaultValue(null)]
        public bool HideCloseButton
        {
            get => btnClose.Visible;
            set => btnClose.Visible = value;
        }

        private void _LoadColumns(List<clsGridColumnDefinition> Columns)
        {
            DataGridView.Columns.Clear();

            foreach (clsGridColumnDefinition Column in Columns)
            {
                DataGridViewColumn dgvColumn = null;

                switch (Column.Type)
                {
                    case clsGridColumnDefinition.enColumnType.Checkbox:
                        dgvColumn = new DataGridViewCheckBoxColumn();
                        break;
                    case clsGridColumnDefinition.enColumnType.Combo:
                        dgvColumn = new DataGridViewComboBoxColumn();
                        break;
                    case clsGridColumnDefinition.enColumnType.Button:
                        dgvColumn = new DataGridViewButtonColumn();
                        break;
                    case clsGridColumnDefinition.enColumnType.Image:
                        dgvColumn = new DataGridViewImageColumn();
                        break;
                    case clsGridColumnDefinition.enColumnType.Link:
                        dgvColumn = new DataGridViewLinkColumn();
                        break;
                    default:
                        dgvColumn = new DataGridViewTextBoxColumn();
                        break;
                }

                dgvColumn.Name = Column.ColumnName;
                dgvColumn.DataPropertyName = Column.DataProperty;
                dgvColumn.HeaderText = Column.HeaderText;
                dgvColumn.ReadOnly = Column.ReadOnly;

                DataGridView.Columns.Add(dgvColumn);
            }

            clsPresentationUtils.DistributeColumnsInDataGridView(DataGridView);
        }

        public void LoadData(DataTable Table, List<clsGridColumnDefinition> Columns)
        {
            if (Table.Rows.Count > 0)
            {
                _LoadColumns(Columns);

                Table = Table.DefaultView.ToTable(false, Columns.Select(Col => Col.DataProperty).ToArray());

                DataGridView.DataSource = Table;

                foreach (clsGridColumnDefinition Column in Columns)
                {
                    if (DataGridView.Columns.Contains(Column.ColumnName))
                    {
                        DataGridView.Columns[Column.ColumnName].Visible = true;
                    }
                    else
                    {
                        Console.WriteLine($"Column '{Column.ColumnName}' not found in DataGridView");
                    }
                }
                Records.DataSource = DataGridView;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            FindForm()?.Close();
        }
    }
}