using System.Data;
using DVLD.Data.Entities.Applicaction;
using DVLD.Core.Enums;

namespace DVLD.Core.Entities.Applicaction
{
    // I didn't make it a service because it maintains the status 
    public class clsLocalDrivingLicenseApplication
    {
        public enMode Mode = enMode.AddNew;

        public int ID { set; get; }
        public int ApplicationID { set; get; }
        public int LicenseClassID { set; get; }

        public clsLocalDrivingLicenseApplication()
        {
            this.ID = -1;
            this.ApplicationID = -1;
            this.LicenseClassID = -1;
            Mode = enMode.AddNew;
        }

        private clsLocalDrivingLicenseApplication(int ID, int ApplicationID, int LicenseClassID)
        {
            this.ID = ID;
            this.ApplicationID = ApplicationID;
            this.LicenseClassID = LicenseClassID;
            Mode = enMode.Update;
        }

        private bool _AddNewLocalDrivingLicenseApplication()
        {
            this.ID = clsLocalDrivingLicenseApplicationDataAccess.AddNewLocalDrivingLicenseApplication(this.ApplicationID, this.LicenseClassID);
            return (this.ID != -1);
        }

        private bool _UpdateLocalDrivingLicenseApplicationn()
        {
            return clsLocalDrivingLicenseApplicationDataAccess.UpdateLocalDrivingLicenseApplication(this.ID, this.ApplicationID, this.LicenseClassID);
        }

        public static clsLocalDrivingLicenseApplication Find(int ID)
        {
            int ApplicationID = -1, LicenseClassID = -1;

            if (clsLocalDrivingLicenseApplicationDataAccess.GetLocalDrivingLicenseApplicationInfoByID(ID, ref ApplicationID, ref LicenseClassID))
                return new clsLocalDrivingLicenseApplication(ID, ApplicationID, LicenseClassID);
            else
                return null;
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewLocalDrivingLicenseApplication())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateLocalDrivingLicenseApplicationn();
            }
            return false;
        }

        public static DataTable GetAllLocalDrivingLicenseApplications()
        {
            return clsLocalDrivingLicenseApplicationDataAccess.GetLocalDrivingLicenseApplications();
        }

        /**
             * Retrieve all LocalDrivingLicenseApplications details including ClassName and PassedTestCount and Status and FullName and NationalNo information.
             * Join: LacalDrivingLicenseApplications, Applications, People
        */
        public static DataTable GetAllLocalDrivingLicenseApplicationsDetails()
        {
            return clsLocalDrivingLicenseApplicationDataAccess.GetAllLocalDrivingLicenseApplicationsDetails();
        }

        public DataTable GetAllTestAppointmentsByTestType(int TestType)
        {
            return clsLocalDrivingLicenseApplicationDataAccess.GetAllTestAppointmentsByLocalDrivingLicenseIDAndTestType(this.ID, TestType);
        }

        public static bool DeleteLocalLicenseApplication(int LocalDrivingLicenseAppID)
        {
            return clsLocalDrivingLicenseApplicationDataAccess.DeleteLocalLicenseApplication(LocalDrivingLicenseAppID);
        }
    }
}
