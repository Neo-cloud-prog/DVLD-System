using System.Windows.Forms;
using DVLD.Core.Entities.Driver;
using DVLD.Core.Entities.License;
using DVLD.Core.Entities.User;
using DVLD.UI.Helpers.UI.Images;
using DVLD.UI.Helpers.UI.Picturebox;

namespace DVLD.UI.UserControls.License.International
{
    public partial class InternationalDrivingLicenseInfo : UserControl
    {
        public InternationalDrivingLicenseInfo()
        {
            InitializeComponent();
        }

        private void _FillLicenseInfo(int InternationalLicenseID)
        {
            clsInternationalLicense InternationalLicense = clsInternationalLicense.Find(InternationalLicenseID);
            clsDriver Driver = clsDriver.Find(InternationalLicense.DriverID);
            clsPerson Person = clsPerson.Find(Driver.PersonID);
            lbFullName.Text = Person.FirstName + " " + Person.SecondName + " " + Person.ThirdName + " " + Person.LastName;
            lbILicenseID.Text = InternationalLicense.ID.ToString();
            lbNationalNo.Text = Person.NationalNo;
            lbGender.Text = Person.Gender == 0 ? "Male" : "Female";
            lbIssueDate.Text = InternationalLicense.IssueDate.ToString();
            lbAppID.Text = InternationalLicense.ApplicationID.ToString();
            lbIsActive.Text = InternationalLicense.IsActive ? "Yes" : "No";
            lbDataOfBirth.Text = Person.DateOfBirth.ToString();
            lbDriverID.Text = Driver.ID.ToString();
            lbExpirationDate.Text = InternationalLicense.ExpirationDate.ToString();
            clsPictureBoxImageLoader PictureBoxImageLoader = new clsPictureBoxImageLoader(pbPerson);
            clsImageHelper ImageHelper = new clsImageHelper(PictureBoxImageLoader);
            ImageHelper.TryLoadImage(Person.ImagePath, Person.Gender);
        }

        public void LoadInternationalInfoByID(int InternationalLicenseID)
        {
            _FillLicenseInfo(InternationalLicenseID);
        }
    }
}
