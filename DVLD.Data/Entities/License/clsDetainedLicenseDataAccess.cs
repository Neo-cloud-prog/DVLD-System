using System;
using System.Data.SqlClient;
using System.Data;
using DVLD.Data.Helpers.DB;

namespace DVLD.Data.Entities.License
{
    public class clsDetainedLicenseDataAccess
    {
        public static bool GetDetainedLicenseInfoByID(int DetainID, ref int LicenseID, ref DateTime DetainDate, ref decimal FineFees, ref int CreatedByUserID, ref bool IsReleased, ref DateTime ReleaseDate, ref int ReleasedByUserID, ref int ReleaseApplicationID)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT * FROM DetainedLicenses WHERE DetainID = @DetainID";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@DetainID", DetainID);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;
                    LicenseID = (int)Reader["LicenseID"];
                    DetainDate = (DateTime)Reader["DetainDate"];
                    FineFees = (decimal)Reader["FineFees"];
                    CreatedByUserID = (int)Reader["CreatedByUserID"];
                    IsReleased = (bool)Reader["IsReleased"];
                    ReleaseDate = clsDataReaderHelper.GetValueOrDefault<DateTime>(Reader["ReleaseDate"], DateTime.MinValue);
                    ReleasedByUserID = clsDataReaderHelper.GetValueOrDefault<int>(Reader["ReleasedByUserID"], -1);
                    ReleaseApplicationID = clsDataReaderHelper.GetValueOrDefault<int>(Reader["ReleaseApplicationID"], -1);
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

        public static bool GetDetainedLicenseInfoByLicenseID(int LicenseID, ref int DetainID, ref DateTime DetainDate, ref decimal FineFees, ref int CreatedByUserID, ref bool IsReleased, ref DateTime ReleaseDate, ref int ReleasedByUserID, ref int ReleaseApplicationID)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT * FROM DetainedLicenses WHERE LicenseID = @LicenseID";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;
                    DetainID = (int)Reader["DetainID"];
                    DetainDate = (DateTime)Reader["DetainDate"];
                    FineFees = (decimal)Reader["FineFees"];
                    CreatedByUserID = (int)Reader["CreatedByUserID"];
                    IsReleased = (bool)Reader["IsReleased"];
                    ReleaseDate = clsDataReaderHelper.GetValueOrDefault<DateTime>(Reader["ReleaseDate"], DateTime.MinValue);
                    ReleasedByUserID = clsDataReaderHelper.GetValueOrDefault<int>(Reader["ReleasedByUserID"], -1);
                    ReleaseApplicationID = clsDataReaderHelper.GetValueOrDefault<int>(Reader["ReleaseApplicationID"], -1);
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

        public static int AddNewDetainedLicense(int LicenseID, DateTime DetainDate, decimal FineFees, int CreatedByUserID, bool IsReleased, DateTime ReleaseDate, int ReleasedByUserID, int ReleaseApplicationID)
        {
            int DetainedLicenseID = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"INSERT INTO [dbo].[DetainedLicenses]
                                         ([LicenseID]
                                         ,[DetainDate]
                                         ,[FineFees]
                                         ,[CreatedByUserID]
                                         ,[IsReleased]
                                         ,[ReleaseDate]
                                         ,[ReleasedByUserID]
                                         ,[ReleaseApplicationID])
                            VALUES
                                         (@LicenseID
                                         ,@DetainDate
                                         ,@FineFees
                                         ,@CreatedByUserID
                                         ,@IsReleased
                                         ,@ReleaseDate
                                         ,@ReleasedByUserID
                                         ,@ReleaseApplicationID)
                             SELECT SCOPE_IDENTITY();";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@LicenseID", LicenseID);
            Command.Parameters.AddWithValue("@DetainDate", DetainDate);
            Command.Parameters.AddWithValue("@FineFees", FineFees);
            Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            Command.Parameters.AddWithValue("@IsReleased", IsReleased);
            if(ReleaseDate == DateTime.MinValue)
            {
                Command.Parameters.AddWithValue("@ReleaseDate", DBNull.Value);
            } else
            {
                Command.Parameters.AddWithValue("@ReleaseDate", ReleaseDate);
            }

            if (ReleasedByUserID == -1)
            {
                Command.Parameters.AddWithValue("@ReleasedByUserID", DBNull.Value);
            }
            else
            {
                Command.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID);
            }

            if (ReleaseApplicationID == -1)
            {
                Command.Parameters.AddWithValue("@ReleaseApplicationID", DBNull.Value);
            }
            else
            {
                Command.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID);
            }

            try
            {
                Connection.Open();

                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int InsertedID))
                {
                    DetainedLicenseID = InsertedID;
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
                Connection.Close();
            }
            return DetainedLicenseID;
        }

        public static bool UpdatedDetainedLicense(int DetainID, int LicenseID, DateTime DetainDate, decimal FineFees, int CreatedByUserID, bool IsReleased, DateTime ReleaseDate, int ReleasedByUserID, int ReleaseApplicationID)
        {

            int RowsAffected = 0;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"UPDATE [dbo].[DetainedLicenses]
                                SET [LicenseID] = @LicenseID
                                   ,[DetainDate] = @DetainDate
                                   ,[FineFees] = @FineFees
                                   ,[CreatedByUserID] = @CreatedByUserID
                                   ,[IsReleased] = @IsReleased
                                   ,[ReleaseDate] = @ReleaseDate
                                   ,[ReleasedByUserID] = @ReleasedByUserID
                                   ,[ReleaseApplicationID] = @ReleaseApplicationID
                             WHERE DetainID = @DetainID";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@DetainID", DetainID);
            Command.Parameters.AddWithValue("@LicenseID", LicenseID);
            Command.Parameters.AddWithValue("@DetainDate", DetainDate);
            Command.Parameters.AddWithValue("@FineFees", FineFees);
            Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            Command.Parameters.AddWithValue("@IsReleased", IsReleased);
            Command.Parameters.AddWithValue("@ReleaseDate", ReleaseDate);
            Command.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID);
            Command.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID);

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

        public static DataTable GetAllDetainedLicenses()
        {
            DataTable DetainedLicensesTable = new DataTable();

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT DetainedLicenses.DetainID, DetainedLicenses.LicenseID, DetainedLicenses.DetainDate, DetainedLicenses.IsReleased, DetainedLicenses.FineFees, DetainedLicenses.ReleaseDate, People.NationalNo, People.FirstName + ' ' + People.SecondName + ' ' + People.ThirdName + ' ' + People.LastName as FullName, 
                         DetainedLicenses.ReleaseApplicationID
FROM            DetainedLicenses INNER JOIN
                         Licenses ON DetainedLicenses.LicenseID = Licenses.LicenseID INNER JOIN
                         Drivers ON Licenses.DriverID = Drivers.DriverID INNER JOIN
                         People ON Drivers.PersonID = People.PersonID";

            SqlCommand Command = new SqlCommand(Query, Connection);

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                {
                    DetainedLicensesTable.Load(Reader);
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
            return DetainedLicensesTable;
        }
    }
}
