using System;
using DVLD.Core.Entities.Applicaction;
using DVLD.Core.Entities.Application;
using DVLD.Core.Entities.Driver;
using DVLD.Core.Entities.License;
using DVLD.Core.Entities.User;
using DVLD.Core.Enums;

namespace DVLD.Core.Services.License
{
    public class clsLicenseService
    {
        public enum enDetainLicenseSaveResult
        {
            Success,
            DetainOperationFailed,
            InactiveLicense,
            ExpiredLicense,
            LicenseNotFound
        }

        public class DetainLicenseResult
        {
            public enDetainLicenseSaveResult Result { get; set; }
            public clsDetainedLicense DetainedLicense { get; set; }

            public DetainLicenseResult(enDetainLicenseSaveResult Result, clsDetainedLicense DetainedLicense = null)
            {
                this.Result = Result;
                this.DetainedLicense = DetainedLicense;
            }
        }

        public static DetainLicenseResult DetainLicense(int LicenseID, DateTime DetainDate, decimal FineFees, int UserID)
        {
            clsLicense License = clsLicense.Find(LicenseID);

            if (License == null)
                return new DetainLicenseResult(enDetainLicenseSaveResult.LicenseNotFound);

            if (!License.IsActive)
                return new DetainLicenseResult(enDetainLicenseSaveResult.InactiveLicense);

            if (License.ExpirationDate < DateTime.Now)
                return new DetainLicenseResult(enDetainLicenseSaveResult.ExpiredLicense);

            clsDetainedLicense DetainedLicense = new clsDetainedLicense
            {
                LicenseID = License.ID,
                DetainDate = DetainDate,
                FineFees = FineFees,
                CreatedByUserID = UserID,
                IsReleased = false
            };

            License.IsActive = false;

            if (DetainedLicense.Save() && License.Save())
            {
                return new DetainLicenseResult(enDetainLicenseSaveResult.Success, DetainedLicense);
            }
            
            return new DetainLicenseResult(enDetainLicenseSaveResult.DetainOperationFailed);
        }

        public enum enRenewLicenseResult
        {
            Success,
            LicenseNotEligibleForRenewal,
            ApplicationSaveFailed,
            RenewOperationFailed,
            OldLicenseSaveFailed
        }

        public class RenewLicenseResult
        {
            public enRenewLicenseResult Result { get; set; }
            public clsApplication Application { get; set; }
            public clsLicense OldLicense { get; set; }

            public RenewLicenseResult(
                enRenewLicenseResult result,
                clsApplication application = null,
                clsLicense oldLicense = null)
            {
                Result = result;
                Application = application;
                OldLicense = oldLicense;
            }
        }

        public static RenewLicenseResult RenewLicense(
            clsLicense OldLicense,
            clsApplicationType ApplicationType,
            clsLicenseClass LicenseClass,
            int UserID,
            string Notes)
        {
            clsDriver Driver = clsDriver.Find(OldLicense.DriverID);

            if (!OldLicense.IsActive || OldLicense.ExpirationDate >= DateTime.Now || Driver == null)
            {
                return new RenewLicenseResult(enRenewLicenseResult.LicenseNotEligibleForRenewal);
            }

            clsApplication Application = new clsApplication
            {
                PersonID = Driver.PersonID,
                ApplicationTypeID = ApplicationType.ID,
                Status = (int)enApplicationStatus.Completed,
                PaidFees = ApplicationType.Fees,
                UserID = UserID
            };

            if (!Application.Save())
            {
                return new RenewLicenseResult(enRenewLicenseResult.ApplicationSaveFailed);
            }

            clsLicense NewLicense = new clsLicense();
            NewLicense.Notes = Notes;
            NewLicense.ExpirationDate = DateTime.Now.AddYears(LicenseClass.DefaultValidityLength);
            NewLicense.IssueReason = (byte)enIssueReason.Renew;
            NewLicense.IsActive = true;
            NewLicense.ApplicationID = Application.ID;
            NewLicense.CreatedByUserID = UserID;
            NewLicense.PaidFees = ApplicationType.Fees;
            NewLicense.LicenseClassID = OldLicense.LicenseClassID;
            NewLicense.DriverID = OldLicense.DriverID;
            
            if (!NewLicense.Save())
            {
                return new RenewLicenseResult(enRenewLicenseResult.RenewOperationFailed);
            }

            OldLicense.IsActive = false;
            if (!OldLicense.Save())
            {
                return new RenewLicenseResult(enRenewLicenseResult.OldLicenseSaveFailed);
            }

            return new RenewLicenseResult(
                enRenewLicenseResult.Success,
                Application,
                NewLicense
            );
        }


        public enum enReplaceLicenseResult
        {
            Success,
            InactiveLicense,
            RepalceOperationFailed,
            ApplicationSaveFailed,
            OldLicesenSaveFaild,
            OldLicesenNotFound,
        }

        public class ReplaceLicenseResult
        {
            public enReplaceLicenseResult Result { get; set; }
            public clsApplication Application { get; set; }
            public clsLicense ReplacedLicense { get; set; }

            public ReplaceLicenseResult(
                enReplaceLicenseResult Result,
                clsApplication Application = null,
                clsLicense ReplacedLicense = null)
            {
                this.Result = Result;
                this.Application = Application;
                this.ReplacedLicense = ReplacedLicense;
            }
        }

        public static ReplaceLicenseResult ReplaceLicense(clsLicense OldLicense, enReplaceLicenseFor ReplaceLicenseFor, int UserID)
        {
            if (OldLicense == null)
            {
                return new ReplaceLicenseResult(enReplaceLicenseResult.OldLicesenNotFound);
            }

            if (OldLicense.IsActive)
            {
                clsDriver Driver = clsDriver.Find(OldLicense.DriverID);
                clsApplicationType ApplicationType = clsApplicationType.Find((int)ReplaceLicenseFor);

                clsApplication Application = new clsApplication
                {
                    PersonID = Driver.PersonID,
                    ApplicationTypeID = ApplicationType.ID,
                    Status = (int)enApplicationStatus.Completed,
                    PaidFees = ApplicationType.Fees,
                    UserID = UserID
                };

                if (!Application.Save())
                {
                    return new ReplaceLicenseResult(enReplaceLicenseResult.ApplicationSaveFailed);
                }

                clsLicense NewLicense = new clsLicense();
                NewLicense.Notes = OldLicense.Notes;
                NewLicense.ExpirationDate = OldLicense.ExpirationDate;
                NewLicense.IssueReason = (byte)ReplaceLicenseFor;
                NewLicense.IsActive = true;
                NewLicense.ApplicationID = Application.ID;
                NewLicense.CreatedByUserID = UserID;
                NewLicense.PaidFees = ApplicationType.Fees;
                NewLicense.LicenseClassID = OldLicense.LicenseClassID;
                NewLicense.DriverID = OldLicense.DriverID;

                if (!NewLicense.Save())
                {
                    return new ReplaceLicenseResult(enReplaceLicenseResult.RepalceOperationFailed);
                }

                OldLicense.IsActive = false;

                if (!OldLicense.Save())
                {
                    return new ReplaceLicenseResult(enReplaceLicenseResult.OldLicesenSaveFaild);
                }

                return new ReplaceLicenseResult(enReplaceLicenseResult.Success, Application, NewLicense);
            }
            else
            {
                return new ReplaceLicenseResult(enReplaceLicenseResult.InactiveLicense);
            }
        }

        public enum enIssueInternationalLicenseResult
        {
            Success,
            IssueOperationFailed,
            ApplicationSaveFailed,
            AlreadyHaveAnActiveInternationalLicense,
            InactiveLicense,
            ExpiredLicense,
            LicenseClassTypeIsNotOrdinary
        }

        public class InternationalLicenseResult
        {
            public enIssueInternationalLicenseResult Result { get; set; }
            public clsApplication Application { get; set; }
            public clsInternationalLicense InternationalLicense { get; set; }

            public InternationalLicenseResult(
                enIssueInternationalLicenseResult Result,
                clsApplication Application = null,
                clsInternationalLicense InternationalLicense = null)
            {
                this.Result = Result;
                this.Application = Application;
                this.InternationalLicense = InternationalLicense;
            }
        }

        public static InternationalLicenseResult IssueInternationalLicense(clsLicense LocalLicense, clsApplicationType ApplicationType, int UserID, ref int ActiveInternationalLicenseID)
        {
            clsDriver Driver = clsDriver.Find(LocalLicense.DriverID);
            if (LocalLicense != null && (ActiveInternationalLicenseID = Driver.HasActivInternationalLicense()) == -1)
            {
                if (!LocalLicense.IsActive)
                {
                    return new InternationalLicenseResult(enIssueInternationalLicenseResult.InactiveLicense);
                }

                if (LocalLicense.ExpirationDate < DateTime.Now)
                {
                    return new InternationalLicenseResult(enIssueInternationalLicenseResult.ExpiredLicense);
                }

                if (LocalLicense.LicenseClassID != (int)enLicenseClassType.Ordinary)
                {
                    return new InternationalLicenseResult(enIssueInternationalLicenseResult.LicenseClassTypeIsNotOrdinary);
                }

                clsApplication Application = new clsApplication();

                Application.PersonID = Driver.PersonID;
                Application.Status = (byte)enApplicationStatus.Completed;
                Application.ApplicationTypeID = (int)enApplicationType.NewInternationalLicense;
                Application.PaidFees = ApplicationType.Fees;
                Application.UserID = UserID;

                if (!Application.Save())
                {
                    return new InternationalLicenseResult(enIssueInternationalLicenseResult.ApplicationSaveFailed);
                }

                clsInternationalLicense InternationalLicense = new clsInternationalLicense();
                InternationalLicense.ApplicationID = Application.ID;
                InternationalLicense.DriverID = Driver.ID;
                InternationalLicense.IssuedUsingLocalLicenseID = LocalLicense.ID;
                InternationalLicense.CreatedByUserID = UserID;

                if (!InternationalLicense.Save())
                {
                    return new InternationalLicenseResult(enIssueInternationalLicenseResult.IssueOperationFailed);
                }

                return new InternationalLicenseResult(enIssueInternationalLicenseResult.Success, Application, InternationalLicense);
            }
            else
            {
                return new InternationalLicenseResult(enIssueInternationalLicenseResult.AlreadyHaveAnActiveInternationalLicense);
            }
        }

        public enum enIssueLocalLicenseFirstTimeResult
        {
            Success,
            IssueOperationFailed,
            ApplicationSaveFailed
        }

        public static enIssueLocalLicenseFirstTimeResult IssueLocalLicenseFirstTime(int LocalDrivingLicenseApplicationID, int UserID, string Notes)
        {
            clsLocalDrivingLicenseApplication LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplication.Find(LocalDrivingLicenseApplicationID);
            clsApplication Application = clsApplication.Find(LocalDrivingLicenseApplication.ApplicationID);
            clsPerson Person = clsPerson.Find(Application.PersonID);
            clsDriver Driver = clsDriver.FindByPersonID(Person.ID);
            clsLicenseClass LicenseClass = clsLicenseClass.Find(LocalDrivingLicenseApplication.LicenseClassID);
            bool IsDriverSaved = true;

            if (Driver == null)
            {
                Driver = new clsDriver();
                Driver.PersonID = Person.ID;
                Driver.CreatedByUserID = UserID;
                IsDriverSaved = Driver.Save();
            }

            clsLicense License = new clsLicense();
            License.ApplicationID = Application.ID;
            License.DriverID = Driver.ID;
            License.LicenseClassID = LicenseClass.ID;
            License.ExpirationDate = DateTime.Now.AddYears(LicenseClass.DefaultValidityLength);
            License.Notes = Notes;
            License.PaidFees = LicenseClass.Fees;
            License.IssueReason = (byte)enIssueReason.FirstTime;
            License.CreatedByUserID = UserID;

            if (License.Save() && IsDriverSaved)
            {
                Application.Status = (byte)enApplicationStatus.Completed;
                if(!Application.Save())
                {
                    return enIssueLocalLicenseFirstTimeResult.ApplicationSaveFailed;
                }
                return enIssueLocalLicenseFirstTimeResult.Success;
            } else
            {
                return enIssueLocalLicenseFirstTimeResult.IssueOperationFailed;
            }
        }

        public enum enReleaseDetainedLicenseResult
        {
            Success,
            ReleaseOperationFailed,
            ApplicationSaveFailed
        }

        public class ReleaseDetainedLicenseResult
        {
            public enReleaseDetainedLicenseResult Result { get; set; }
            public int ApplicationID { get; set; }

            public ReleaseDetainedLicenseResult(
                enReleaseDetainedLicenseResult Result,
                int ApplicationID = -1)
            {
                this.Result = Result;
                this.ApplicationID = ApplicationID;
            }
        }

        public static ReleaseDetainedLicenseResult ReleaseLicense(clsDriver Driver, clsApplicationType ApplicationType, clsDetainedLicense DetainedLicense, clsLicense License, int UserID)
        {
            clsApplication Application = new clsApplication();
            Application.PersonID = Driver.PersonID;
            Application.ApplicationTypeID = (int)enApplicationType.ReleaseDetainedDrivingLicense;
            Application.Status = (int)enApplicationStatus.Completed;
            Application.PaidFees = ApplicationType.Fees;
            Application.UserID = UserID;

            if (!Application.Save())
            {
                return new ReleaseDetainedLicenseResult(enReleaseDetainedLicenseResult.ApplicationSaveFailed);
            }

            DetainedLicense.IsReleased = true;
            DetainedLicense.ReleaseDate = DateTime.Now;
            DetainedLicense.ReleasedByUserID = UserID;
            DetainedLicense.ReleaseApplicationID = Application.ID;
            License.IsActive = true;

            if (!(DetainedLicense.Save() && License.Save()))
            {
                return new ReleaseDetainedLicenseResult(enReleaseDetainedLicenseResult.ReleaseOperationFailed);
            }

            return new ReleaseDetainedLicenseResult(enReleaseDetainedLicenseResult.Success, Application.ID);
        }
    }
}