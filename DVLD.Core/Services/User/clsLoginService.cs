using DVLD.Core.Entities.User;

namespace DVLD.Core.Services.User
{
    public class clsLoginService
    {
        public static clsUser Authenticate(string Username, string Password)
        {
            clsUser User = clsUser.Find(Username, Password);
            if (User == null)
                return null;

            return User;
        }
    }
}
