using System;

namespace DVLD.UI.Events.License
{
    public class clsLicenseEventArgs : EventArgs
    {
        public int LicenseID { get; set; }

        public clsLicenseEventArgs(int LicenseID)
        {
            this.LicenseID = LicenseID;
        }
    }
}
