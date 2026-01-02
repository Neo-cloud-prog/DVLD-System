using System;

namespace DVLD.UI.Events.User
{
    public class clsUserEventArgs : EventArgs
    {
        public int UserID { get; set; }

        public clsUserEventArgs(int UserID)
        {
            this.UserID = UserID;
        }
    }
}
