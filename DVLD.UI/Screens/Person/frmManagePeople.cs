using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using DVLD.Core.Entities.User;
using DVLD.UI.Events.Person;
using DVLD.UI.Helpers.UI.GridView;
using DVLD.UI.UserControls.Shared;

namespace DVLD.UI.Screens.Person
{
    public partial class frmManagePeople : Form
    {
        public frmManagePeople()
        {
            InitializeComponent();
        }

        private void LoadPeople()
        {
            DataTable PeopleTable = clsPerson.GetAllPeopleWithCountries();
            sbPeople.LoadData(PeopleTable, new List<clsGridColumnDefinition>
            {
                new clsGridColumnDefinition("dcPersonID", "PersonID", "PersonID"),
                new clsGridColumnDefinition("dcNationalNo", "NationalNo", "NationalNo"),
                new clsGridColumnDefinition("dcFirstName", "FirstName", "FirstName"),
                new clsGridColumnDefinition("dcSecondName", "SecondName", "SecondName"),
                new clsGridColumnDefinition("dcThirdName", "ThirdName", "ThirdName"),
                new clsGridColumnDefinition("dcLastName", "LastName", "LastName"),
                new clsGridColumnDefinition("dcGender", "Gender", "GenderText"),
                new clsGridColumnDefinition("dcDateOfBirth", "DateOfBirth", "DateOfBirth"),
                new clsGridColumnDefinition("dcNationality", "Nationality", "CountryName"),
                new clsGridColumnDefinition("dcPhone", "Phone", "Phone"),
                new clsGridColumnDefinition("dcEmail", "Email", "Email"),
            });
            DataGridViewFilter.Bind(sbPeople.DataGridView);
        }

        private void frmManagePeople_Load(object sender, EventArgs e)
        {
            LoadPeople();
        }

        private void AddUpdatePerson(int PersonID)
        {
            frmAddUpdatePerson AddUpdatePerson = new frmAddUpdatePerson(PersonID);
            AddUpdatePerson.OnDataChanged += OnPersonChanged;
            AddUpdatePerson.ShowDialog();
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            AddUpdatePerson(-1);
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPersonDetails PersonDetails = new frmPersonDetails((int)sbPeople.DataGridView.SelectedRows[0].Cells[0].Value);
            PersonDetails.OnDataChanged += OnPersonChanged;
            PersonDetails.ShowDialog();
        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnAddPerson_Click(sender, e);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUpdatePerson((int)sbPeople.DataGridView.SelectedRows[0].Cells[0].Value);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = (int)sbPeople.DataGridView.SelectedRows[0].Cells[0].Value;
            if (clsPerson.DeletePerson(PersonID))
            {
                MessageBox.Show("User has been deleted successfuly");

            }
            else
            {
                MessageBox.Show("You cannot delete this person because it is linked to an external relationships");
            }
            LoadPeople();
        }

        private void OnPersonChanged(object sender, clsPersonEventArgs e)
        {
            LoadPeople();
        }

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not yet imeplemented");
        }

        private void phoneCallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not yet imeplemented");
        }
    }
}
