using DVLD.Core.Entities.User;

namespace DVLD.UI.Helpers.Session
{
    internal static class clsAppSession
    {
        public static clsUser CurrentUser { get; private set; }

        public static void LoadCurrentUser()
        {
            CurrentUser = clsUserSession.Get(); 
        }

        public static void SetCurrentUser(clsUser User)
        {
            CurrentUser = User;
        }

        public static void Clear()
        {
            CurrentUser = null;
        }

        public static bool IsAuthenticated => CurrentUser != null;
    }
}
