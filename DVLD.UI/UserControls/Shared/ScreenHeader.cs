using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DVLD.UI.UserControls.Shared
{
    public partial class ScreenHeader : UserControl
    {
        private string _Title;
        private Image _ScreenImage;

        private enum enScreenType { Default, WithNoImage };

        public ScreenHeader()
        {
            InitializeComponent();
        }

        [Browsable(true)]
        [Category("Custom")]
        [Description("Sets the title of screen")]
        [DefaultValue(null)]
        public string Title
        {
            get { return _Title; }
            set
            {
                _Title = value;
                this.lbTitle.Text = _Title;
            }
        }

        [Browsable(true)]
        [Category("Custom")]
        [Description("Sets the image of screen")]
        [DefaultValue(null)]
        public Image ScreenImage
        {
            get { return _ScreenImage; }
            set
            {
                _ScreenImage = value;
                this.pbScreen.Image = _ScreenImage;
            }
        }

        private void _SetParentFormBorderStyle(Control Parent)
        {
            if(Parent is Form)
            {
                Form ParentForm = Parent as Form;
                ParentForm.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            }
        }

        private void _FitToParent(Control Parent)
        {
            this.Width = Parent.Width;
            this.Dock = DockStyle.Top;
            CenterControlContainer.Width = Parent.Width;
            CenterControlContainer.Dock = DockStyle.Fill;
            CenterControlContainer.Controls.Add(pbScreen);
            CenterControlContainer.Controls.Add(lbTitle);
        }

        private void _CustomizeHeaderByScreenType(enScreenType ScreenType = enScreenType.Default, string Title = "", Image ScreenImage = null)
        {
            switch (ScreenType)
            {
                case enScreenType.WithNoImage:
                    this.pbScreen.Image = null;
                    this.pbScreen.Visible = false;
                    lbTitle.Location = pbScreen.Location;
                    CenterControlContainer.Controls.Remove(pbScreen);
                    this.lbTitle.Text = Title;
                    break;
                default:
                    this.pbScreen.Image = ScreenImage;
                    this.lbTitle.Text = Title;
                    break;
            }
        }

        private void ScreenHeader_Load(object sender, EventArgs e)
        {
            switch (this.Parent.Name)
            {
                case "frmManagePeople":
                    _CustomizeHeaderByScreenType(enScreenType.Default, "Manage People", Properties.Resources.People);
                    break;
                case "frmManageUsers":
                    _CustomizeHeaderByScreenType(enScreenType.Default, "Manage Users", Properties.Resources.Users);
                    break;
                case "frmManageDrivers":
                    _CustomizeHeaderByScreenType(enScreenType.Default, "Manage Drivers", Properties.Resources.driver);
                    break;
                case "frmManageApplicationTypes":
                    _CustomizeHeaderByScreenType(enScreenType.Default, "Manage Application Types", Properties.Resources.applicationTypes);
                    break;
                case "frmLocalDrivingLicenseApplocations":
                    _CustomizeHeaderByScreenType(enScreenType.Default, "Local Driving License Applocations", Properties.Resources.mangeApplications);
                    break;
                case "frmManageTestTypes":
                    _CustomizeHeaderByScreenType(enScreenType.Default, "Manage Test Types", Properties.Resources.test);
                    break;
                case "frmLocalDrivingLicenseInfo":
                    _CustomizeHeaderByScreenType(enScreenType.Default, "Driver License Info", Properties.Resources.driverLicense);
                    break;
                case "frmInternationalDrivingLicenseInfo":
                    _CustomizeHeaderByScreenType(enScreenType.Default, "Driver International License info", Properties.Resources.internationalLicense);
                    break;
                case "frmManageDetainedLicenses":
                    _CustomizeHeaderByScreenType(enScreenType.Default, "Manage Detained Licenses", Properties.Resources.detain);
                    break;
                case "frmInternationalDrivingLicenseApplicaitons":
                    _CustomizeHeaderByScreenType(enScreenType.Default, "International Driving License Applicaitons", Properties.Resources.mangeApplications);
                    break;
                case "frmDetainLicense":
                    _CustomizeHeaderByScreenType(enScreenType.WithNoImage, "Detain License");
                    break;
                case "frmReleaseDetainedLicense":
                    _CustomizeHeaderByScreenType(enScreenType.WithNoImage, "Release Detained License");
                    break;
                case "frmLocalDrivingLicense":
                    _CustomizeHeaderByScreenType(enScreenType.WithNoImage, "New Local Driving License Application");
                    break;
                case "frmUpdateApplicationType":
                    _CustomizeHeaderByScreenType(enScreenType.WithNoImage, "Update Application Type");
                    break;
                case "frmUpdateTestType":
                    _CustomizeHeaderByScreenType(enScreenType.WithNoImage, "Update Test Type");
                    break;
                case "frmReplacementForLostLicense":
                    _CustomizeHeaderByScreenType(enScreenType.WithNoImage, "Replacement For Los tLicense");
                    break;
                case "frmInternationalLicenseApplication":
                    _CustomizeHeaderByScreenType(enScreenType.WithNoImage, "International License Application");
                    break;
                case "frmRenewLicenseApplication":
                    _CustomizeHeaderByScreenType(enScreenType.WithNoImage, "Renew License Application");
                    break;
            }
            _SetParentFormBorderStyle(this.Parent);
            _FitToParent(this.Parent);
        }
    }
}
