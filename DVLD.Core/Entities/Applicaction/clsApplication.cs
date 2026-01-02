using System;
using System.Data;
using DVLD.Data.Entities.Applicaction;
using DVLD.Core.Enums;

namespace DVLD.Core.Entities.Applicaction
{
    public class clsApplication
    {
        public enMode Mode = enMode.AddNew;

        public int ID { set; get; }
        public int PersonID { set; get; }
        public DateTime Date { set; get; }
        public int ApplicationTypeID { set; get; }
        public byte Status { set; get; }
        public DateTime LastStatusDate { set; get; }
        public decimal PaidFees { set; get; }
        public int UserID { set; get; }


        public clsApplication()
        {
            this.ID = -1;
            this.PersonID = -1;
            this.Date = DateTime.Now;
            this.ApplicationTypeID = -1;
            this.Status = 1;
            this.LastStatusDate = DateTime.Now;
            this.PaidFees = 0;
            this.UserID = -1;
            Mode = enMode.AddNew;
        }

        private clsApplication(int ID, int PersonID, DateTime Date, int ApplicationTypeID, byte Status, DateTime LastStatusDate, decimal PaidFees, int UserID)
        {
            this.ID = ID;
            this.PersonID = PersonID;
            this.Date = Date;
            this.ApplicationTypeID = ApplicationTypeID;
            this.Status = Status;
            this.LastStatusDate = LastStatusDate;
            this.PaidFees = PaidFees;
            this.UserID = UserID;
            Mode = enMode.Update;
        }

        private bool _AddNewApplication()
        {
            this.ID = clsApplicationDataAccess.AddNewApplication(this.PersonID, this.Date, this.ApplicationTypeID, this.Status, this.LastStatusDate, this.PaidFees, this.UserID);
            return (this.ID != -1);
        }

        private bool _UpdateApplication()
        {
            return clsApplicationDataAccess.UpdateApplication(this.ID, this.PersonID, this.Date, this.ApplicationTypeID, this.Status, this.LastStatusDate, this.PaidFees, this.UserID);
        }

        public static clsApplication Find(int ID)
        {
            int PersonID = -1, ApplicationTypeID = -1, UserID = -1;
            DateTime Date = DateTime.Now, LastStatusDate = DateTime.Now;
            byte Status = 0;
            decimal PaidFees = 0;

            if (clsApplicationDataAccess.GetApplicationInfoByID(ID, ref PersonID, ref Date, ref ApplicationTypeID, ref Status, ref LastStatusDate, ref PaidFees, ref UserID))
                return new clsApplication(ID, PersonID, Date, ApplicationTypeID, Status, LastStatusDate, PaidFees, UserID);
            else
                return null;
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewApplication())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateApplication();
            }
            return false;
        }

        public static DataTable GetAllApplications()
        {
            return clsApplicationDataAccess.GetAllApplications();
        }

        public static bool DeleteApplication(int AppID)
        {
            return clsApplicationDataAccess.DeleteApplication(AppID);
        }
    }
}
