using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using DVLD.UI.Interfaces.UI.Images;

namespace DVLD.UI.Helpers.UI.Picturebox
{
    public class clsPictureBoxImageLoader : IImageLoader
    {
        private readonly PictureBox _PictureBox;

        public clsPictureBoxImageLoader(PictureBox PictureBox)
        {
            _PictureBox = PictureBox;
        }

        public static Image SetPictureBoxImageAccordingGender(object Gender)
        {
            if (Gender is byte)
            {
                return ((byte)Gender == 0) ? Properties.Resources.unknown : Properties.Resources.unknownWoman;
            } 
            else if (Gender is bool)
            {
                return (!(bool)Gender) ? Properties.Resources.unknown : Properties.Resources.unknownWoman;
            }
            else
            {
                return Gender.ToString().ToLower() == "male" ? Properties.Resources.unknown : Properties.Resources.unknownWoman;
            }
        }

        public bool IsValidImagePath(string Path)
        {
            if (string.IsNullOrWhiteSpace(Path) || !File.Exists(Path))
                return false;

            try
            {
                using (var img = Image.FromFile(Path)) { }
                return true;
            }
            catch
            {
                return false;
            }
        }


        public bool LoadImage(string Path, object Gender)
        {
            _PictureBox.Image?.Dispose();
            try
            {
                _PictureBox.Image = Image.FromFile(Path);
                return true;
            }
            catch
            {
                _PictureBox.Image = SetPictureBoxImageAccordingGender(Gender);
                return false;
            }
        }
    }
}
