using System.Data;
using DVLD.Data.Entities.License;

namespace DVLD.Core.Entities.License
{
    public class clsLicenseClass
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte MinimumAllowedAge { get; set; }
        public byte DefaultValidityLength { get; set; }
        public decimal Fees { get; set; }

        public clsLicenseClass()
        {
            this.ID = -1;
            this.Name = "";
            this.Description = "";
            this.MinimumAllowedAge = 18;
            this.DefaultValidityLength = 1;
            this.Fees = 0;
        }

        private clsLicenseClass(int ID, string Name, string Description, byte MinimumAllowedAge, byte DefaultValidityLength, decimal Fees)
        {
            this.ID = ID;
            this.Name = Name;
            this.Description = Description;
            this.MinimumAllowedAge = MinimumAllowedAge;
            this.DefaultValidityLength = DefaultValidityLength;
            this.Fees = Fees;
        }

        public static clsLicenseClass Find(string ClassName)
        {
            int LicenseClassID = -1;
            string Description = "";
            byte MinimumAllowedAge = 18;
            byte DefaultValidityLength = 1;
            decimal Fees = 0;

            if (clsLicenseClassDataAccess.GetLicenseClassInfoByClassName(ClassName, ref LicenseClassID, ref Description, ref MinimumAllowedAge, ref DefaultValidityLength, ref Fees))
                return new clsLicenseClass(LicenseClassID, ClassName, Description, MinimumAllowedAge, DefaultValidityLength, Fees);
            else
                return null;
        }

        public static clsLicenseClass Find(int LicenseClassID)
        {
            string ClassName = "", Description = "";
            byte MinimumAllowedAge = 18;
            byte DefaultValidityLength = 1;
            decimal Fees = 0;

            if (clsLicenseClassDataAccess.GetLicenseClassInfoByID(LicenseClassID, ref ClassName, ref Description, ref MinimumAllowedAge, ref DefaultValidityLength, ref Fees))
                return new clsLicenseClass(LicenseClassID, ClassName, Description, MinimumAllowedAge, DefaultValidityLength, Fees);
            else
                return null;
        }

        public static DataTable GetClasses()
        {
            return clsLicenseClassDataAccess.GetClasses();
        }
    }
}
