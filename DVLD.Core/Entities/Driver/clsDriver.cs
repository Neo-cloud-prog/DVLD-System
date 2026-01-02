using System;
using System.Data;
using DVLD.Data.Entities.Driver;
using DVLD.Core.Enums;

namespace DVLD.Core.Entities.Driver
{
    public class clsDriver
    {
        public enMode Mode = enMode.AddNew;

        public int ID { set; get; }
        public int CreatedByUserID { set; get; }
        public DateTime CreatedDate { set; get; }
        public int PersonID { set; get; }

        public clsDriver()
        {
            this.ID = -1;
            this.CreatedByUserID = -1;
            this.CreatedDate = DateTime.Now;
            this.PersonID = -1;
            Mode = enMode.AddNew;
        }

        private clsDriver(int ID, int CreatedByUserID, DateTime CreatedDate, int PersonID)
        {
            this.ID = ID;
            this.CreatedByUserID = CreatedByUserID;
            this.CreatedDate = CreatedDate;
            this.PersonID = PersonID;
            Mode = enMode.Update;
        }

        private bool _AddNewDriver()
        {
            this.ID = clsDriverDataAccess.AddNewDriver(this.PersonID, this.CreatedByUserID, this.CreatedDate);
            return (this.ID != -1);
        }

        public static clsDriver Find(int ID)
        {
            int CreatedByUserID = -1, PersonID = -1;
            DateTime CreatedDate = DateTime.Now;

            if (clsDriverDataAccess.GetDriverInfoByID(ID, ref CreatedByUserID, ref CreatedDate, ref PersonID))
                return new clsDriver(ID, CreatedByUserID, CreatedDate, PersonID);
            else
                return null;
        }

        public static clsDriver FindByPersonID(int PersonID)
        {
            int DriverID = -1, CreatedByUserID = -1;
            DateTime CreatedDate = DateTime.Now;

            if (clsDriverDataAccess.GetDriverInfoByPerosnID(PersonID, ref DriverID, ref CreatedByUserID, ref CreatedDate))
                return new clsDriver(DriverID, CreatedByUserID, CreatedDate, PersonID);
            else
                return null;
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewDriver())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
            }
            return false;
        }

        public static bool DeleteDriver(int DriverID)
        {
            return clsDriverDataAccess.DeleteDriver(DriverID);
        }

        public static bool IsDriverExist(int DriverID)
        {
            return clsDriverDataAccess.IsDriverExist(DriverID);
        }

        public static DataTable GetAllDrivers()
        {
            return clsDriverDataAccess.GetAllDrivers();
        }

        public DataTable GetAllInternationalLicenses()
        { 
        
            return clsDriverDataAccess.GetAllInternationalLicenses(this.ID);
        }

        public DataTable GetAllLicenses()
        {

            return clsDriverDataAccess.GetAllLicenses(this.ID);
        }

        public bool HasLicenseClass(int LicenseClassID)
        {
            return clsDriverDataAccess.IsDriverHasLicenseClassID(this.ID, LicenseClassID);
        }

        public bool HasActiveLicenseOfTheSameClassType(int LicenseClassID)
        {
            return clsDriverDataAccess.IsDriverHasActiveLicenseOfTheSameClassType(this.ID, LicenseClassID);
        }

        public int HasActivInternationalLicense()
        {
            return clsDriverDataAccess.IsDriverHasActivInternationalLicense(this.ID);
        }
    }
}
