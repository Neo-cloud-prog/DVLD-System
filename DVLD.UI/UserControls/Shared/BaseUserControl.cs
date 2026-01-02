using System;
using System.Windows.Forms;

namespace DVLD.UI.UserControls.Shared
{
    public class BaseUserControl<TEventArgs> : UserControl where TEventArgs : EventArgs
    {
        public event EventHandler<TEventArgs> OnDataChanged;

        protected void TriggerDataChanged(TEventArgs e)
        {
            OnDataChanged?.Invoke(this, e);
        }
    }
}
