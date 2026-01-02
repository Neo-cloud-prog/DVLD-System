using System;
using System.Data;
using System.Data.SqlClient;
using DVLD.Data.Helpers.DB;

namespace DVLD.Data.Entities.User
{
    public class clsPersonDataAccess
    {
        public static bool GetPersonInfoByID(int PersonID, ref string NationalNo, ref string FirstName, ref string SecondName, ref string ThirdName, ref string LastName, ref DateTime DateOfBirth, ref byte Gender, ref string Address, ref string Phone, ref string Email, ref int NationalityCountryID, ref string ImagePath)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT * FROM People WHERE PersonID = @PersonID";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;
                    NationalNo = (string)Reader["NationalNo"];
                    FirstName = (string)Reader["FirstName"];
                    SecondName = clsDataReaderHelper.GetValueOrDefault<string>(Reader["SecondName"], "");
                    ThirdName = clsDataReaderHelper.GetValueOrDefault<string>(Reader["ThirdName"], "");
                    LastName = (string)Reader["LastName"];
                    DateOfBirth = (DateTime)Reader["DateOfBirth"];
                    Gender = (byte)Reader["Gender"];
                    Address = (string)Reader["Address"];
                    Phone = clsDataReaderHelper.GetValueOrDefault<string>(Reader["Phone"], "");
                    Email = clsDataReaderHelper.GetValueOrDefault<string>(Reader["Email"], "");
                    NationalityCountryID = (int)Reader["NationalityCountryID"];
                    ImagePath = clsDataReaderHelper.GetValueOrDefault<string>(Reader["ImagePath"], "");
                }
                else
                {
                    IsFound = false;
                }
                Reader.Close();
            }
            catch (Exception ex)
            {
                IsFound = false;
            }
            finally
            {
                Connection.Close();
            }
            return IsFound;
        }

        public static bool GetPersonInfoByNationalNo(string NationalNo, ref int PersonID, ref string FirstName, ref string SecondName, ref string ThirdName, ref string LastName, ref DateTime DateOfBirth, ref byte Gender, ref string Address, ref string Phone, ref string Email, ref int NationalityCountryID, ref string ImagePath)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT * FROM People WHERE NationalNo = @NationalNo";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@NationalNo", NationalNo);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;
                    PersonID = (int)Reader["PersonID"];
                    FirstName = (string)Reader["FirstName"];
                    SecondName = clsDataReaderHelper.GetValueOrDefault<string>(Reader["SecondName"], "");
                    ThirdName = clsDataReaderHelper.GetValueOrDefault<string>(Reader["ThirdName"], "");
                    LastName = (string)Reader["LastName"];
                    DateOfBirth = (DateTime)Reader["DateOfBirth"];
                    Gender = (byte)Reader["Gender"];
                    Address = (string)Reader["Address"];
                    Phone = clsDataReaderHelper.GetValueOrDefault<string>(Reader["Phone"], "");
                    Email = clsDataReaderHelper.GetValueOrDefault<string>(Reader["Email"], "");
                    NationalityCountryID = (int)Reader["NationalityCountryID"];
                    ImagePath = clsDataReaderHelper.GetValueOrDefault<string>(Reader["ImagePath"], "");

                }
                else
                {
                    IsFound = false;
                }
                Reader.Close();
            }
            catch (Exception ex)
            {
                IsFound = false;
            }
            finally
            {
                Connection.Close();
            }
            return IsFound;
        }

        public static int AddNewPerson(string NationalNo, string FirstName, string SecondName, string ThirdName, string LastName, DateTime DateOfBirth, byte Gender, string Address, string Phone, string Email, int NationalityCountryID, string ImagePath)
        {
            int ID = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"INSERT INTO [dbo].[People]
                               ([NationalNo]
                               ,[FirstName]
                               ,[SecondName]
                               ,[ThirdName]
                               ,[LastName]
                               ,[DateOfBirth]
                               ,[Gender]
                               ,[Address]
                               ,[Phone]
                               ,[Email]
                               ,[NationalityCountryID]
                               ,[ImagePath])
                             VALUES
                               (@NationalNo
                               ,@FirstName
                               ,@SecondName
                               ,@ThirdName
                               ,@LastName
                               ,@DateOfBirth
                               ,@Gender
                               ,@Address
                               ,@Phone
                               ,@Email
                               ,@NationalityCountryID
                               ,@ImagePath);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@NationalNo", NationalNo);
            Command.Parameters.AddWithValue("@FirstName", FirstName);
            Command.Parameters.AddWithValue("@SecondName", SecondName);
            Command.Parameters.AddWithValue("@ThirdName", ThirdName);
            Command.Parameters.AddWithValue("@LastName", LastName);
            Command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            Command.Parameters.AddWithValue("@Gender", Gender);
            Command.Parameters.AddWithValue("@Address", Address);
            Command.Parameters.AddWithValue("@Phone", Phone);
            Command.Parameters.AddWithValue("@Email", Email);
            Command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);
            if (ImagePath == "")
            {
                Command.Parameters.AddWithValue("@ImagePath", DBNull.Value);
            } 
            else
            {
                Command.Parameters.AddWithValue("@ImagePath", ImagePath);
            }

            try
                {
                    Connection.Open();

                    object Result = Command.ExecuteScalar();

                    if (Result != null && int.TryParse(Result.ToString(), out int InsertedID))
                    {
                        ID = InsertedID;
                    }
                }
                catch (Exception ex)
                {
                }
                finally
                {
                    Connection.Close();
                }
            return ID;
        }

        public static bool UpdatePerson(int PersonID, string NationalNo, string FirstName, string SecondName, string ThirdName, string LastName, DateTime DateOfBirth, byte Gender, string Address, string Phone, string Email, int NationalityCountryID, string ImagePath)
        {

            int RowsAffected = 0;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"UPDATE [dbo].[People]
                               SET [NationalNo] = @NationalNo
                                  ,[FirstName] = @FirstName
                                  ,[SecondName] = @SecondName
                                  ,[ThirdName] = @ThirdName
                                  ,[LastName] = @LastName
                                  ,[DateOfBirth] = @DateOfBirth
                                  ,[Gender] = @Gender
                                  ,[Address] = @Address
                                  ,[Phone] = @Phone
                                  ,[Email] = @Email
                                  ,[NationalityCountryID] = @NationalityCountryID
                                  ,[ImagePath] = @ImagePath
                                   WHERE PersonID = @PersonID";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@PersonID", PersonID);
            Command.Parameters.AddWithValue("@NationalNo", NationalNo);
            Command.Parameters.AddWithValue("@FirstName", FirstName);
            Command.Parameters.AddWithValue("@SecondName", SecondName);
            Command.Parameters.AddWithValue("@ThirdName", ThirdName);
            Command.Parameters.AddWithValue("@LastName", LastName);
            Command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            Command.Parameters.AddWithValue("@Gender", Gender);
            Command.Parameters.AddWithValue("@Address", Address);
            Command.Parameters.AddWithValue("@Phone", Phone);
            Command.Parameters.AddWithValue("@Email", Email);
            Command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);
            if (ImagePath == "")
            {
                Command.Parameters.AddWithValue("@ImagePath", DBNull.Value);
            }
            else
            {
                Command.Parameters.AddWithValue("@ImagePath", ImagePath);
            }

            try
            {
                Connection.Open();
                RowsAffected = Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return false;
            }

            finally
            {
                Connection.Close();
            }

            return RowsAffected > 0;
        }

        public static bool DeletePerson(int PersonID)
        {
            int RowsAffected = 0;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "DELETE FROM People WHERE PersonID = @PersonID";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                Connection.Open();
                RowsAffected = Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                Connection.Close();
            }
            return RowsAffected > 0;
        }

        public static bool IsPersonExist(int PersonID)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT Found=1 FROM People WHERE PersonID = @PersonID";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                IsFound = Reader.HasRows;
                Reader.Close();
            }
            catch (Exception ex)
            {
                IsFound = false;
            }
            finally
            {
                Connection.Close();
            }
            return IsFound;
        }

        public static bool IsPersonExist(string NationlaNo)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT Found=1 FROM People WHERE NationlaNo = @NationlaNo";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@NationlaNo", NationlaNo);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                IsFound = Reader.HasRows;
                Reader.Close();
            }
            catch (Exception ex)
            {
                IsFound = false;
            }
            finally
            {
                Connection.Close();
            }
            return IsFound;
        }

        public static DataTable GetAllPeople()
        {
            DataTable PeopleTable = new DataTable();

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT * FROM People Order By PersonID DESC";

            SqlCommand Command = new SqlCommand(Query, Connection);

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                {
                    PeopleTable.Load(Reader);
                }
                Reader.Close();
            }

            catch (Exception ex)
            {
            }
            finally
            {
                Connection.Close();
            }
            return PeopleTable;
        }

        public static DataTable GetAllPeopleWithCountries()
        {
            DataTable PeopleTable = new DataTable();

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT        dbo.People.PersonID, dbo.People.NationalNo, dbo.People.FirstName, dbo.People.SecondName, dbo.People.ThirdName, dbo.People.LastName, dbo.People.DateOfBirth, dbo.People.Gender, dbo.People.Address, 
                         dbo.People.Phone, dbo.People.Email, dbo.People.NationalityCountryID, dbo.People.ImagePath, dbo.Countries.CountryName, 
                         CASE WHEN Gender = 0 THEN 'Male' WHEN Gender = 1 THEN 'Female' ELSE 'Unknow' END AS GenderText
FROM            dbo.People INNER JOIN
                         dbo.Countries ON dbo.People.NationalityCountryID = dbo.Countries.CountryID Order By PersonID DESC";

            SqlCommand Command = new SqlCommand(Query, Connection);

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                {
                    PeopleTable.Load(Reader);
                }
                Reader.Close();
            }

            catch (Exception ex)
            {
            }
            finally
            {
                Connection.Close();
            }
            return PeopleTable;
        }

        public static int IsPersonHasApplicationOfSameLicenseClass(int PersonID, int LicenseClassID)
        {
            int AppID = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT TOP (1) Applications.ApplicationID
FROM            Applications INNER JOIN
                         People ON Applications.ApplicantPersonID = People.PersonID INNER JOIN
                         LocalDrivingLicenseApplications ON Applications.ApplicationID = LocalDrivingLicenseApplications.ApplicationID
WHERE        People.PersonID = @PersonID and LocalDrivingLicenseApplications.LicenseClassID = @LicenseClassID Order By LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID DESC";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@PersonID", PersonID);
            Command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if(Reader.Read())
                {
                    AppID = (int)Reader["ApplicationID"];
                }

                Reader.Close();
            }

            catch (Exception ex)
            {
                AppID = -1;
            }
            finally
            {
                Connection.Close();
            }
            return AppID;
        }
    }
}
