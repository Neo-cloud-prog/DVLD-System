using System;

namespace DVLD.UI.Events.Person
{
    public class clsPersonEventArgs : EventArgs
    {
        public int PersonID { get; set; }

        public clsPersonEventArgs(int PersonID)
        {
            this.PersonID = PersonID;
        }
    }
}
