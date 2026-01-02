using DVLD.Core.Entities.Applicaction;
using DVLD.Core.Entities.Driver;
using DVLD.Core.Entities.License;
using DVLD.Core.Entities.User;
using DVLD.Core.Enums;

namespace DVLD.Core.Services.Application
{
    // Here are the application services because the class is stateless this design from my mind I do not know if it is correct
    public class clsLocalDrivingLicenseApplicationSevice
    {
        public enum enIssueLocalDrivingLicenseApplicationSaveResult
        {
            Success,
            ArleadyHasApplictionOntheSameLicenseClass,
            LicenseClassIsAlreadyExist,
            ApplicationSaveFailed,
            LocalDrivingLicenseApplicationSaveFailed
        }

        public class IssueLocalDrivingLicenseApplicationResult
        {
            public enIssueLocalDrivingLicenseApplicationSaveResult Result { get; set; }
            public int ApplicationID { get; set; }
            public int LocalDrivingLicenseApplicationID { get; set; }
            public int LastApplicationID { get; set; }

            public IssueLocalDrivingLicenseApplicationResult(enIssueLocalDrivingLicenseApplicationSaveResult Result, int LastApplicationID = -1, int ApplicationID = -1, int LocalDrivingLicenseApplicationID = -1)
            {
                this.Result = Result;
                this.ApplicationID = ApplicationID;
                this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
                this.LastApplicationID = LastApplicationID;
            }
        }

        public static IssueLocalDrivingLicenseApplicationResult IssueNewApplication(int LocalDrivingAppLicationID, int PersonID, int LicenseClassID, decimal AppFees, int UserID)
        {
            clsDriver Driver = clsDriver.FindByPersonID(PersonID);
            clsPerson Person = clsPerson.Find(PersonID);
            int SelectedLicenseClassID = clsLicenseClass.Find(LicenseClassID).ID;
            int LastApplicationID = Person.HasApplicationOfSameLicenseClass(SelectedLicenseClassID);

            if (LastApplicationID != -1 && clsApplication.Find(LastApplicationID).Status != (byte)enApplicationStatus.Cancelled)
            {
                return new IssueLocalDrivingLicenseApplicationResult(enIssueLocalDrivingLicenseApplicationSaveResult.ArleadyHasApplictionOntheSameLicenseClass, LastApplicationID);
            }

            if (Driver != null)
            {
                if (Driver.HasLicenseClass(SelectedLicenseClassID))
                {
                    return new IssueLocalDrivingLicenseApplicationResult(enIssueLocalDrivingLicenseApplicationSaveResult.LicenseClassIsAlreadyExist);
                }
            }

            clsLocalDrivingLicenseApplication LocalDrivingLicenseApplication = LocalDrivingAppLicationID == -1 ? new clsLocalDrivingLicenseApplication() : clsLocalDrivingLicenseApplication.Find(LocalDrivingAppLicationID);
            clsApplication Application = new clsApplication();

            if (LocalDrivingAppLicationID == -1)
            {
                Application.PersonID = PersonID;
                Application.ApplicationTypeID = (int)enApplicationType.NewLocalDrivingLicense;
                Application.PaidFees = AppFees;
                Application.UserID = UserID;

                if (!Application.Save())
                {
                    return new IssueLocalDrivingLicenseApplicationResult(enIssueLocalDrivingLicenseApplicationSaveResult.ApplicationSaveFailed);
                }

                LocalDrivingLicenseApplication.ApplicationID = Application.ID;
            }

            LocalDrivingLicenseApplication.LicenseClassID = SelectedLicenseClassID;

            if (!LocalDrivingLicenseApplication.Save())
            {
                return new IssueLocalDrivingLicenseApplicationResult(enIssueLocalDrivingLicenseApplicationSaveResult.LocalDrivingLicenseApplicationSaveFailed);
            }

            return new IssueLocalDrivingLicenseApplicationResult(enIssueLocalDrivingLicenseApplicationSaveResult.Success, LastApplicationID, LocalDrivingLicenseApplication.ID, Application.ID);
        }
    }
}
