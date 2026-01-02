using System;
using System.Windows.Forms;
using DVLD.UI.Events.Person;
using DVLD.UI.Screens.Basic;

namespace DVLD.UI.Screens.Person
{
    public partial class frmPersonDetails : BaseForm<clsPersonEventArgs>
    {
        private int _PersonID = -1;

        public frmPersonDetails(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;
        }

        private void frmPersonDetails_Load(object sender, EventArgs e)
        {
            PersonDetailsControl.LoadPersonByID(_PersonID);
        }

        private void PersonDetailsControl_ParsonChanged(object sender, EventArgs e)
        {
            TriggerDataChanged(new clsPersonEventArgs(_PersonID));
        }
    }
}
