using System;
using System.ComponentModel;
using System.Windows.Forms;
using DVLD.UI.Utils.Presentation;

namespace DVLD.UI.UserControls.Shared
{
    public partial class CenterControlContainer : UserControl
    {
        private clsPresentationUtils.enDirection _Direction = clsPresentationUtils.enDirection.X;

        public CenterControlContainer()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ContainerControl, true);
        }

        [Browsable(true)]
        [Category("Custom")]
        [Description("Sets the direction.")]
        [DefaultValue(clsPresentationUtils.enDirection.X)]
        public clsPresentationUtils.enDirection Direction
        {
            get { return _Direction; }
            set
            {
                _Direction = value;
                CenterControls(); 
            }
        }

        public void CenterControls()
        {
            if (this.Controls.Count == 0)
                return;

            for (int i = 0; i < this.Controls.Count; i++)
            {
                Control ControlToCenter = this.Controls[i];
                clsPresentationUtils.CenterControl(this, ref ControlToCenter, _Direction);

                if (ControlToCenter.Left < 0) ControlToCenter.Left = 0;
                if (ControlToCenter.Top < 0) ControlToCenter.Top = 0;

                if (ControlToCenter.Right > this.Width)
                    ControlToCenter.Left = this.Width - ControlToCenter.Width;

                if (ControlToCenter.Bottom > this.Height)
                    ControlToCenter.Top = this.Height - ControlToCenter.Height;
            }
        }

        protected override void OnControlAdded(ControlEventArgs e)
        {
            base.OnControlAdded(e);
            OnChildControlAdded(e.Control);
        }

        private void OnChildControlAdded(Control child)
        {
            CenterControls();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            CenterControls();
        }

        protected override void OnLayout(LayoutEventArgs e)
        {
            base.OnLayout(e);
            CenterControls();
        }

        protected override void OnParentChanged(EventArgs e)
        {
            base.OnParentChanged(e);
            CenterControls();
        }

        protected override void OnLocationChanged(EventArgs e)
        {
            base.OnLocationChanged(e);
            if (this.DesignMode)
                CenterControls();
        }
    }
}