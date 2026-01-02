using System;

namespace DVLD.UI.Screens.Basic
{
    public partial class BaseForm <TEventArgs> : System.Windows.Forms.Form where TEventArgs : EventArgs
    {
        public event EventHandler<TEventArgs> OnDataChanged;

        protected void TriggerDataChanged(TEventArgs e)
        {
            OnDataChanged?.Invoke(this, e);
        }
    }
}
