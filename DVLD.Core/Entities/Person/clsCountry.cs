using System.Data;
using DVLD.Data.Entities.Person;

namespace DVLD.Core.Entities.Person
{
    public class clsCountry
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public clsCountry()
        {
            this.ID = -1;
            this.Name = "";
        }

        private clsCountry(int ID, string Name)
        {
            this.ID = ID;
            this.Name = Name;
        }

        public static clsCountry Find(int ID)
        {
            string CountryName = "";

            if (clsCountryDataAccess.GetCountyInfoByID(ID, ref CountryName))
                return new clsCountry(ID, CountryName);
            else
                return null;
        }

        public static clsCountry Find(string CountryName)
        {
            int ID = -1;

            if (clsCountryDataAccess.GetCountyInfoByName(CountryName, ref ID))
                return new clsCountry(ID, CountryName);
            else
                return null;
        }

        public static DataTable GetAllCountries()
        {
            return clsCountryDataAccess.GetAllCountries();
        }
    }
}
