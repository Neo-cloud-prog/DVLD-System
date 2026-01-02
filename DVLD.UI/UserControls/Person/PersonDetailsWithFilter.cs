using System;
using System.Data;
using System.Windows.Forms;
using DVLD.Core.Entities.User;
using DVLD.Core.Enums;
using DVLD.UI.Events.Person;
using DVLD.UI.Screens.Person;
using DVLD.UI.UserControls.Shared;
using DVLD.UI.Utils.Presentation;

namespace DVLD.UI.UserControls.Person
{
    public partial class PersonDetailsWithFilter : BaseUserControl<clsPersonEventArgs>
    {
        DataTable _PeopleTable;

        public PersonDetailsWithFilter()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            _PeopleTable = clsPerson.GetAllPeople();
            cmbFilter.Items.Add("PersonID");
            cmbFilter.Items.Add("NationalNo");
            cmbFilter.Items.Add("Phone");
            cmbFilter.Items.Add("Email");
            cmbFilter.SelectedIndex = 0;
        }

        private void ibtnSearch_OnClick(object sender, EventArgs e)
        {
            if (_PeopleTable == null || cmbFilter.SelectedItem == null || string.IsNullOrWhiteSpace(tbSearchText.Text))
        return;

            string SelectedColumn = cmbFilter.SelectedItem.ToString();
            string FilterValue = tbSearchText.Text;

            Type ColumnType = _PeopleTable.Columns[SelectedColumn].DataType;


            DataView View = new DataView(_PeopleTable);

            if (ColumnType == typeof(string))
            {
                FilterValue = FilterValue.Replace("'", "''");
                View.RowFilter = $"{SelectedColumn} LIKE '%{FilterValue}%'";
            }
            else if (ColumnType == typeof(int))
            {
                if (int.TryParse(FilterValue, out int Value))
                {
                    View.RowFilter = $"{SelectedColumn} = {Value}";
                }
                else
                {
                    return;
                }
            }

            DataTable FilteredTable = View.ToTable();

            if (FilteredTable.Rows.Count > 0)
            {
                int PersonID = Convert.ToInt32(FilteredTable.Rows[0]["PersonID"]);
                PersonDetails.LoadPersonByID(PersonID);
                TriggerDataChanged(new clsPersonEventArgs(PersonID));
            }
            else
            {
                MessageBox.Show("No matching results found");
            }
        }

        private void ibtnAddNewPerson_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson AddUpdatePerson = new frmAddUpdatePerson(-1);

            AddUpdatePerson.OnDataChanged += (s, args) =>
            {
                LoadPersonByID(args.PersonID, enMode.AddNew);
            };

            AddUpdatePerson.ShowDialog();
        }

        private void PersonDetailsWithFilter_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadPersonByID(int PersonID, enMode Mode = enMode.Update)
        {
            gbFillter.Enabled = Mode != enMode.Update;
            cmbFilter.SelectedIndex = 0;
            tbSearchText.Text = PersonID.ToString();
            PersonDetails.LoadPersonByID(PersonID);
        }

        private void tbSearchText_TextChanged(object sender, EventArgs e)
        {
            DataColumn DataColumn = _PeopleTable.Columns[cmbFilter.SelectedItem.ToString()];
            _ = DataColumn != null && DataColumn.DataType == typeof(int) && clsPresentationUtils.PreventEnterStringInTextBox(tbSearchText);
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbSearchText.Clear();
        }
    }
}
