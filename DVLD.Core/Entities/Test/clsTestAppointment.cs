using System;
using System.Data;
using DVLD.Data.Entities.Test;
using DVLD.Core.Enums;

namespace DVLD.Core.Entities.Test
{
    public class clsTestAppointment
    {
        public int ID { get; set; }
        public int TestTypeID { get; set; }
        public int LocalDrivingLicenseApplicationID { get; set; }
        public DateTime AppointmentDate { get; set; }
        public decimal PaidFees { get; set; }
        public int CreatedByUserID { get; set; }
        public bool IsLocked { get; set; }
        public int RetakeTestAppointmentID { get; set; }

        private enMode _Mode;

        public enum enReplaceFor { Lost = 3, Damaged = 4 }

        public clsTestAppointment()
        {
            this.ID = -1;
            this.TestTypeID = -1;
            this.LocalDrivingLicenseApplicationID = -1;
            this.AppointmentDate = DateTime.Now;
            this.PaidFees = 0;
            this.CreatedByUserID = -1;
            this.IsLocked = false;
            this.RetakeTestAppointmentID = -1;
            _Mode = enMode.AddNew;
        }

        private clsTestAppointment(int ID, int TestTypeID, int LocalDrivingLicenseApplicationID, DateTime AppointmentDate, decimal PaidFees, int CreatedByUserID, bool IsLocked, int RetakeTestAppointmentID)
        {
            this.ID = ID;
            this.TestTypeID = TestTypeID;
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            this.AppointmentDate = AppointmentDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;
            this.IsLocked = IsLocked;
            this.RetakeTestAppointmentID = RetakeTestAppointmentID;
            _Mode = enMode.Update;
        }

        private bool _AddNewTestAppointment()
        {
            this.ID = clsTestAppointmentDataAccess.AddNewTestAppointment(this.TestTypeID, this.LocalDrivingLicenseApplicationID, this.AppointmentDate, this.PaidFees, this.CreatedByUserID, this.IsLocked, this.RetakeTestAppointmentID);
            return (this.ID != -1);
        }

        private bool _UpdateTestAppointment()
        {
            return clsTestAppointmentDataAccess.UpdatedTestAppointment(this.ID, this.AppointmentDate, this.IsLocked);
        }

        public bool Save()
        {
            switch (this._Mode)
            {
                case enMode.AddNew:
                    if (_AddNewTestAppointment())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateTestAppointment();
            }
            return false;
        }

        public static clsTestAppointment Find(int ID)
        {
            int TestTypeID = -1, LocalDrivingLicenseApplicationID = -1, CreatedByUserID = -1;
            DateTime AppointmentDate = DateTime.Now;
            decimal PaidFees = 0;
            bool IsLocked = false;
            int RetakeTestAppointmentID = -1;

            if (clsTestAppointmentDataAccess.GetTestAppointmentInfoByID(ID, ref TestTypeID, ref LocalDrivingLicenseApplicationID, ref AppointmentDate, ref PaidFees, ref CreatedByUserID, ref IsLocked, ref RetakeTestAppointmentID))
                return new clsTestAppointment(ID, TestTypeID, LocalDrivingLicenseApplicationID, AppointmentDate, PaidFees, CreatedByUserID, IsLocked, RetakeTestAppointmentID);
            else
                return null;
        }

        public static clsTestAppointment GetLastUnlockedAppointemnt(int LocalDrivingLicenseApplicationID)
        {
            int TestAppointmentID = -1, TestTypeID = -1, CreatedByUserID = -1;
            DateTime AppointmentDate = DateTime.Now;
            decimal PaidFees = 0;
            bool IsLocked = false;
            int RetakeTestAppointmentID = -1;

            if (clsTestAppointmentDataAccess.GetTestAppointmentInfoByLocalDrivingAppIDAndUnlocked(LocalDrivingLicenseApplicationID, ref TestAppointmentID, ref TestTypeID , ref AppointmentDate, ref PaidFees, ref CreatedByUserID, ref IsLocked, ref RetakeTestAppointmentID))
                return new clsTestAppointment(TestAppointmentID, TestTypeID, LocalDrivingLicenseApplicationID, AppointmentDate, PaidFees, CreatedByUserID, IsLocked, RetakeTestAppointmentID);
            else
                return null;
        }

        public static clsTestAppointment GetLastLockedAppointemnt(int LocalDrivingLicenseApplicationID)
        {
            int TestAppointmentID = -1, TestTypeID = -1, CreatedByUserID = -1;
            DateTime AppointmentDate = DateTime.Now;
            decimal PaidFees = 0;
            bool IsLocked = false;
            int RetakeTestAppointmentID = -1;

            if (clsTestAppointmentDataAccess.GetTestAppointmentInfoByLocalDrivingAppIDAndLocked(LocalDrivingLicenseApplicationID, ref TestAppointmentID, ref TestTypeID, ref AppointmentDate, ref PaidFees, ref CreatedByUserID, ref IsLocked, ref RetakeTestAppointmentID))
                return new clsTestAppointment(TestAppointmentID, TestTypeID, LocalDrivingLicenseApplicationID, AppointmentDate, PaidFees, CreatedByUserID, IsLocked, RetakeTestAppointmentID);
            else
                return null;
        }

        public static DataTable GetAllTestAppointments()
        {
            return clsTestAppointmentDataAccess.GetAllTestAppointments();
        }
    }
}
