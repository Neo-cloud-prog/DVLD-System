using System.Windows.Forms;
using DVLD.Core.Entities.Driver;
using DVLD.Core.Entities.License;
using DVLD.Core.Entities.User;
using DVLD.Core.Enums;
using DVLD.UI.Helpers.Shared;
using DVLD.UI.Helpers.UI.Images;
using DVLD.UI.Helpers.UI.Picturebox;

namespace DVLD.UI.UserControls.License.Local
{
    public partial class DrivingLicenseInfo : UserControl
    {
        public DrivingLicenseInfo()
        {
            InitializeComponent();
        }

        private void _FillLicenseInfo(int LicenseID)
        {
            clsLicense License = clsLicense.Find(LicenseID);
            clsDriver Driver = clsDriver.Find(License.DriverID);
            clsPerson Person = clsPerson.Find(Driver.PersonID);
            lbClass.Text = License.LicenseClassName;
            lbFullName.Text = Person.FirstName + " " + Person.SecondName + " " + Person.ThirdName + " " + Person.LastName;
            lbLicenseID.Text = License.ID.ToString();
            lbNationalNo.Text = Person.NationalNo;
            lbGender.Text = Person.Gender == 0 ? "Male" : "Female";
            lbIssueDate.Text = License.IssueDate.ToString();
            lbIssueReason.Text = clsHandleApplicationEnums.GetApplicationTypeName((enIssueReason)License.IssueReason);
            lbNotes.Text = License.Notes;
            lbIsActive.Text = License.IsActive ? "Yes" : "No";
            lbDataOfBirth.Text = Person.DateOfBirth.ToString();
            lbDriverID.Text = Driver.ID.ToString();
            lbExpirationDate.Text = License.ExpirationDate.ToString();
            clsPictureBoxImageLoader PictureBoxImageLoader = new clsPictureBoxImageLoader(pbPerson);
            clsImageHelper ImageHelper = new clsImageHelper(PictureBoxImageLoader);
            ImageHelper.TryLoadImage(Person.ImagePath, Person.Gender);
        }

        public void LoadLicenseInfoByID(int LicenseID)
        {
            _FillLicenseInfo(LicenseID);
        }
    }
}
