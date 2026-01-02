using System.Data;
using DVLD.Core.Utils.String;
using DVLD.Data.Entities.User;
using DVLD.Core.Enums;

namespace DVLD.Core.Entities.User
{
    public class clsUser
    {
        public enMode Mode = enMode.AddNew;

        public int ID { set; get; }
        public int PersonID { set; get; }
        public string Name { set; get; }
        public string Password { set; get; }
        public string HashedPassword { set; get; }
        public bool IsActive { set; get; }
        public bool IsRemembered { set; get; }
        public bool IsLogin { set; get; }


        public clsUser()
        {
            this.ID = -1;
            this.PersonID = -1;
            this.Name = "";
            this.Password = "";
            this.HashedPassword = "";
            this.IsActive = true;
            this.IsRemembered = false;
            this.IsLogin = false;
            Mode = enMode.AddNew;
        }

        private clsUser(int ID, int PersonID, string Name, string Password, bool IsActive, bool IsRemembered,  bool IsLogin)
        {
            this.ID = ID;
            this.PersonID = PersonID;
            this.Name = Name;
            this.Password = clsStringUtils.DecryptText(Password);
            this.IsActive = IsActive;
            this.IsRemembered = IsRemembered;
            this.IsLogin = IsLogin;
            Mode = enMode.Update;
        }

        private bool _AddNewUser()
        {
            this.ID = clsUserDataAccess.AddNewUser(this.PersonID, this.Name, clsStringUtils.EncryptText(this.Password), this.IsActive);
            return (this.ID != -1);
        }

        private bool _UpdateUser()
        {
            return clsUserDataAccess.UpdateUser(this.ID, this.PersonID, this.Name, clsStringUtils.EncryptText(this.Password), this.IsActive, this.IsRemembered, this.IsLogin);
        }

        public static clsUser Find(int ID)
        {
            string UserName = "", Password = "";
            int PersonID = -1;
            bool IsActive = false;
            bool IsRemembered = false;
            bool IsLogin = false;

            if (clsUserDataAccess.GetUserInfoByID(ID, ref PersonID, ref UserName, ref Password, ref IsActive, ref IsRemembered, ref IsLogin))
                return new clsUser(ID, PersonID, UserName, Password, IsActive, IsRemembered, IsLogin);
            else
                return null;
        }

        public static clsUser FindByPersonID(int PersonID)
        {
            string UserName = "", Password = "";
            int UserID = -1;
            bool IsActive = false;
            bool IsRemembered = false;
            bool IsLogin = false;

            if (clsUserDataAccess.GetUserInfoByPersonID(PersonID, ref UserID, ref UserName, ref Password, ref IsActive, ref IsRemembered, ref IsLogin))
                return new clsUser(UserID, PersonID, UserName, Password, IsActive, IsRemembered, IsLogin);
            else
                return null;
        }

        public static clsUser Find(string UserName, string Password)
        {
            int UsreID = -1;
            int PersonID = -1;
            bool IsActive = false;
            bool IsRemembered = false;
            bool IsLogin = false;

            if (clsUserDataAccess.GetUserInfoByUserNameAndPasswod(UserName, clsStringUtils.EncryptText(Password), ref PersonID, ref UsreID, ref IsActive, ref IsRemembered, ref IsLogin))
                return new clsUser(UsreID, PersonID, UserName, Password, IsActive, IsRemembered, IsLogin);
            else
                return null;
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewUser())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateUser();
            }
            return false;
        }

        public static bool DeleteUser(int UsreID)
        {
            return clsUserDataAccess.DeleteUser(UsreID);
        }

        public static bool IsUserExist(int UsreID)
        {
            return clsUserDataAccess.IsUserExist(UsreID);
        }

        public static bool IsUserExist(string UserName, string Password)
        {
            return clsUserDataAccess.IsUserExist(UserName, clsStringUtils.EncryptText(Password));
        }

        public static DataTable GetAllUsers()
        {
            return clsUserDataAccess.GetAllUsers();
        }

        public static DataTable GetAllUsersWithPeople()
        {
            return clsUserDataAccess.GetAllUsersWithPeople();
        }
    }
}
