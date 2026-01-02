using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD.Core.Entities.User;
using DVLD.Core.Entities.Person;
using DVLD.UI.Screens.Person;
using DVLD.UI.Helpers.UI.Picturebox;
using DVLD.UI.Helpers.UI.Images;
using DVLD.UI.Events.Person;
using DVLD.UI.UserControls.Shared;

namespace DVLD.UI.UserControls.Person
{
    public partial class PersonDetails : BaseUserControl<clsPersonEventArgs>
    {
        private clsPerson _Person = new clsPerson();

        public PersonDetails()
        {
            InitializeComponent();
        }

        private void _FillPersonDetails(clsPerson Person)
        {
            lbPersonID.Text = Person.ID.ToString();
            lbFullName.Text = Person.FirstName + " " + Person.SecondName + " " + Person.ThirdName + " " + Person.LastName;
            lbNationalNo.Text = Person.NationalNo;
            lbGender.Text = (Person.Gender == 0 ? "Male" : "Female");
            lbEmail.Text = Person.Email;
            lbAddress.Text = Person.Address;
            lbDateOfBirth.Text = Person.DateOfBirth.Date.ToString();
            lbPhone.Text = Person.Phone;
            lbCountry.Text = clsCountry.Find(Person.NationalityCountryID).Name;
            clsPictureBoxImageLoader PictureBoxImageLoader = new clsPictureBoxImageLoader(pbPerson);
            clsImageHelper ImageHelper = new clsImageHelper(PictureBoxImageLoader);
            ImageHelper.TryLoadImage(Person.ImagePath, Person.Gender);
        }

        public void LoadPersonByID(int ID)
        {
            _Person = clsPerson.Find(ID);
            _FillPersonDetails(_Person);
        }

        private void lnkEditPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddUpdatePerson AddUpdatePerson = new frmAddUpdatePerson(_Person.ID);
            AddUpdatePerson.OnDataChanged += (s, args) => 
            {
                LoadPersonByID(args.PersonID);
                TriggerDataChanged(new clsPersonEventArgs(args.PersonID));
            };
            AddUpdatePerson.ShowDialog();
        }
    }
}
