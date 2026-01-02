using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using DVLD.Core.Entities.Person;
using DVLD.Core.Entities.User;
using DVLD.UI.Helpers.UI.Picturebox;
using DVLD.UI.Helpers.UI.Images;
using DVLD.UI.Utils.IO;
using DVLD.UI.UserControls.Shared;
using DVLD.UI.Events.Person;
using DVLD.UI.Helpers.Validation;
using DVLD.Core.Enums;
using DVLD.UI.Screens.Basic;

namespace DVLD.UI.Screens.Person
{
    public partial class frmAddUpdatePerson : BaseForm<clsPersonEventArgs>
    {
        private int _PersonID = -1;

        private enMode _Mode;

        private clsPerson _Person = new clsPerson();

        private string _SelectedImageFilePath = "";

        private string _DestinationImageFilePath = @"C:\DVLD_Images\";

        public frmAddUpdatePerson(int PersonID)
        {
            InitializeComponent();
            SetupValidationRules();

            _PersonID = PersonID;

            if(_PersonID == -1)
            {
                _Mode = enMode.AddNew;
            } 
            else
            {
                _Mode = enMode.Update;
                _Person = clsPerson.Find(_PersonID);
            }
        }

        private void SetupValidationRules()
        {
            AddUpdatePersonValidator.Clear();
            if (_Mode == enMode.AddNew)
                AddUpdatePersonValidator.AddRule(clsAppValidationRules.GetRule(tbNationalNo, AddUpdatePersonErrorProvider, clsAppValidationRules.enRuleType.NationalNumberNotExist));
            AddUpdatePersonValidator.AddRule(clsAppValidationRules.GetRule(tbEmail, AddUpdatePersonErrorProvider, clsAppValidationRules.enRuleType.ValideEmail));
        }


        private bool _IsNull(object obj)
        {
            return obj == null;
        }

        private bool _IsAddMode()
        {
            return this._Mode == enMode.AddNew;
        }

        private bool IsNullOrAddMode(object obj)
        {
            return _IsNull(obj) || _IsAddMode();
        }

        private void _FillPersonGroupBox(clsPerson Person)
        {
            lbPersonID.Text = IsNullOrAddMode(Person) ? "N/A" : Person.ID.ToString();
            tbFirst.Text = IsNullOrAddMode(Person) ? "" : Person.FirstName;
            tbSecond.Text = IsNullOrAddMode(Person) ? "" : Person.SecondName;
            tbThird.Text = IsNullOrAddMode(Person) ? "" : Person.ThirdName;
            tbLast.Text = IsNullOrAddMode(Person) ? "" : Person.LastName;
            tbNationalNo.Text = IsNullOrAddMode(Person) ? "" : Person.NationalNo;

            dtpDateOfBirth.MaxDate = DateTime.Now.AddYears(-18);
            dtpDateOfBirth.MinDate = DateTime.Now.AddYears(-100);
            dtpDateOfBirth.Value = IsNullOrAddMode(Person) ? dtpDateOfBirth.MaxDate : Person.DateOfBirth;

            if (Person.Gender == 1)
            {
                rbFemale.Checked = true;
            }

            tbPhone.Text = IsNullOrAddMode(Person) ? "" : Person.Phone;
            tbEmail.Text = IsNullOrAddMode(Person) ? "" : Person.Email;

            DataTable CountriesTable = clsCountry.GetAllCountries();
            cmbCountries.DataSource = CountriesTable;
            cmbCountries.DisplayMember = CountriesTable.Columns[1].ColumnName;
            cmbCountries.SelectedIndex = IsNullOrAddMode(Person) ? cmbCountries.FindString("Jordan") : cmbCountries.FindString(clsCountry.Find(Person.NationalityCountryID).Name);


            tbAddress.Text = IsNullOrAddMode(Person) ? "" : Person.Address;

            clsPictureBoxImageLoader PictureBoxImageLoader = new clsPictureBoxImageLoader(pbPerson);
            clsImageHelper ImageHelper = new clsImageHelper(PictureBoxImageLoader);
            bool IsImageLoaded = ImageHelper.TryLoadImage(Person.ImagePath, Person.Gender);

            lnkRemoveImage.Visible = _Mode == enMode.Update && IsImageLoaded;

            if (!_IsAddMode())
            {
                _DestinationImageFilePath = Person.ImagePath;
            }
        }

        private void _ChangeScreenTitleAccordingMode(enMode Mode)
        {
            if (Mode == enMode.AddNew)
            {
                lbTitle.Text = "Add Person";
            }
            else
            {
                lbTitle.Text = "Update Person";
            }
        }

        private void frmAddUpdatePerson_Load(object sender, EventArgs e)
        {
            _ChangeScreenTitleAccordingMode(_Mode);
            _FillPersonGroupBox(_Person);
            CenterControlContainer.Controls.Add(lbTitle);
        }

        private void _PreparPersonInfo()
        {
            _Person.FirstName = tbFirst.Text;
            _Person.SecondName = tbSecond.Text;
            _Person.ThirdName = tbThird.Text;
            _Person.LastName = tbLast.Text;
            _Person.NationalNo = tbNationalNo.Text;
            _Person.DateOfBirth = DateTime.Parse(dtpDateOfBirth.Text);
            _Person.Gender = rbMale.Checked ? (byte)0 : (byte)1;
            _Person.Phone = tbPhone.Text;
            _Person.Email = tbEmail.Text;
            _Person.NationalityCountryID = cmbCountries.SelectedIndex + 1;
            _Person.Address = tbAddress.Text;
            if (clsFileUtils.FileExists(_Person.ImagePath) && _SelectedImageFilePath != "")
            {
                clsFileUtils.DeleteFile(_Person.ImagePath);
            }
            _Person.ImagePath = !lnkRemoveImage.Visible && _SelectedImageFilePath == "" ? "" : _DestinationImageFilePath;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_Mode == enMode.Update)
            {
                SetupValidationRules();
            }

            if (!AddUpdatePersonValidator.ValidateAll())
            {
                return;
            }

            _PreparPersonInfo();

            if (_Person.Save())
            {
                if (_Mode == enMode.AddNew)
                {
                    _ChangeScreenTitleAccordingMode((_Mode = enMode.Update));
                }

                if (_SelectedImageFilePath != "")
                {
                    clsFileUtils.CopyFile(_SelectedImageFilePath, _DestinationImageFilePath);
                    _SelectedImageFilePath = "";
                }

                if (_Person.ImagePath == "")
                {
                    clsFileUtils.DeleteFile(_DestinationImageFilePath);
                }

                MessageBox.Show("Person saved successfuly");
                TriggerDataChanged(new clsPersonEventArgs(_Person.ID));
            }
            else
            {
                MessageBox.Show("Error");
            }

            lbPersonID.Text = _Person.ID.ToString();
        }

        private void lnkSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (OpenFileDialogImage.ShowDialog() == DialogResult.OK)
            {
                _SelectedImageFilePath = OpenFileDialogImage.FileName;
                _DestinationImageFilePath += Guid.NewGuid().ToString() + Path.GetExtension(_SelectedImageFilePath);
                pbPerson.Image = Image.FromFile(_SelectedImageFilePath);
                lnkRemoveImage.Visible = true;
            }
        }

        private void lnkRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbPerson.Image = Properties.Resources.unknown;
            _SelectedImageFilePath = "";
            lnkRemoveImage.Visible = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CheckIfFieldFull_Leave(object sender, EventArgs e)
        {
            TextBox CurrentTextBox = (TextBox)sender;
            clsAppValidationRules.GetRule(CurrentTextBox, AddUpdatePersonErrorProvider, clsAppValidationRules.enRuleType.FilledField).Validate();
        }

        private void tbNationalNo_Leave(object sender, EventArgs e)
        {
            AddUpdatePersonValidator.ValidateRuleIndex(0);
        }

        private void tbEmail_Leave(object sender, EventArgs e)
        {
            AddUpdatePersonValidator.ValidateRuleIndex(1);
        }

        private void RedioButton_Click(object sender, EventArgs e)
        {
            pbPerson.Image = clsPictureBoxImageLoader.SetPictureBoxImageAccordingGender(((RadioButton)sender).Text);
        }
    }
}
