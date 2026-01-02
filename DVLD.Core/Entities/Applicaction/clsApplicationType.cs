using System.Data;
using DVLD.Data.Entities.Applicaction;

namespace DVLD.Core.Entities.Application
{
    public class clsApplicationType
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public decimal Fees { get; set; }

        public clsApplicationType()
        {
            this.ID = -1;
            this.Title = "";
            this.Fees = 0;
        }

        private clsApplicationType(int ID, string Title, decimal Fees)
        {
            this.ID = ID;
            this.Title = Title;
            this.Fees = Fees;
        }

        public static DataTable GetAllApplicationTypes()
        {
            return clsApplicationTypeDataAccess.GetAllApplicationTypes();
        }

        public static clsApplicationType Find(int ID)
        {
            string Title = "";
            decimal Fees = 0;

            if (clsApplicationTypeDataAccess.GetApplicationTypeInfoByID(ID, ref Title, ref Fees))
                return new clsApplicationType(ID, Title, Fees);
            else
                return null;
        }

        public bool Save()
        {
            return clsApplicationTypeDataAccess.UpdateApplicationType(this.ID, this.Title, this.Fees);
        }
    }
}
