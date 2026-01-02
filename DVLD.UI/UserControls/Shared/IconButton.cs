using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DVLD.UI.UserControls.Shared
{
    [DefaultEvent("Click")]
    public partial class IconButton : UserControl
    {
        private Image _Icon;
        private string _Value;
        private Color _BakColor;
        private Color _TextColor;
        private Size _IconSize;
        public new event EventHandler Click;


        [Browsable(true)]
        [Category("Custom")]
        [Description("Sets the icon image of the button.")]
        [DefaultValue(null)]
        public Image Icon
        {
            get { return _Icon; }
            set
            {
                this._Icon = value == null ? new Bitmap(this._Icon, _IconSize) : new Bitmap(value, _IconSize);
                this.IconBtn.Image = this._Icon;
            }
        }

        [Browsable(true)]
        [Category("Custom")]
        [Description("Sets the icon size.")]
        [DefaultValue(null)]
        public Size IconSize
        {
            get { return _IconSize; }
            set
            {
                _IconSize = value;
                this.IconBtn.Image = new Bitmap(this.IconBtn.Image, _IconSize);
            }
        }

        [Browsable(true)]
        [Category("Custom")]
        [Description("Sets the text of the button.")]
        [DefaultValue(null)]
        public string Value
        {
            get { return _Value; }
            set
            {
                _Value = value;
                this.IconBtn.Text = _Value;
                this.IconBtn.ImageAlign = _Value == "" ? ContentAlignment.MiddleCenter : ContentAlignment.MiddleLeft;
            }
        }

        [Browsable(true)]
        [Category("Custom")]
        [Description("Sets the bakColor of the button.")]
        [DefaultValue(null)]
        public Color BakColor
        {
            get { return _BakColor; }
            set
            {
                _BakColor = value;
                this.IconBtn.BackColor = _BakColor;
            }
        }

        [Browsable(true)]
        [Category("Custom")]
        [Description("Sets the bakColor of the button.")]
        [DefaultValue(null)]
        public Color TextColor
        {
            get { return _TextColor; }
            set
            {
                _TextColor = value;
                this.IconBtn.ForeColor = _TextColor;
            }
        }

        public IconButton()
        {
            InitializeComponent();
            _Value = this.IconBtn.Text;
            _BakColor = this.IconBtn.BackColor;
            _TextColor = this.IconBtn.ForeColor;
            _IconSize = new Size(24, 24);
            this.IconBtn.Click += (s, e) => OnClick(e);
        }

        protected override void OnClick(EventArgs e)
        {
            Click?.Invoke(this, e);
        }
    }
}
