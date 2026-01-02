using System.Data;
using DVLD.Data.Entities.Test;

namespace DVLD.Core.Entities.Test
{
    public class clsTestType
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Fees { get; set; }

        public clsTestType()
        {
            this.ID = -1;
            this.Title = "";
            this.Description = "";
            this.Fees = 0;
        }

        private clsTestType(int ID, string Title, string Description, decimal Fees)
        {
            this.ID = ID;
            this.Title = Title;
            this.Description = Description;
            this.Fees = Fees;
        }

        public static DataTable GetAllTestTypes()
        {
            return clsTestTypeDataAccess.GetAllTestTypes();
        }

        public static clsTestType Find(int ID)
        {
            string Title = "";
            string Description = "";
            decimal Fees = 0;

            if (clsTestTypeDataAccess.GetTestTypeInfoByID(ID, ref Title, ref Description, ref Fees))
                return new clsTestType(ID, Title, Description, Fees);
            else
                return null;
        }

        public bool Save()
        {
            return clsTestTypeDataAccess.UpdateTestType(this.ID, this.Title, this.Description, this.Fees);
        }
    }
}
