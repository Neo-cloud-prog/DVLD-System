using System;

namespace DVLD.UI.Events.License
{
    public class clsLocalDrivingLicenseApplicationEventArgs : EventArgs
    {
        public int LocalDrivingLicenseAppID { get; set; }

        public clsLocalDrivingLicenseApplicationEventArgs(int LocalDrivingLicenseAppID)
        {
            this.LocalDrivingLicenseAppID = LocalDrivingLicenseAppID;
        }
    }
}
