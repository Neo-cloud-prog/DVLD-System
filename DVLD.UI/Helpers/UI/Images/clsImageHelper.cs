using System;
using DVLD.UI.Interfaces.UI.Images;

namespace DVLD.UI.Helpers.UI.Images
{
    public class clsImageHelper
    {
        private readonly IImageLoader _ImageLoader;

        public clsImageHelper(IImageLoader ImageLoader)
        {
            _ImageLoader = ImageLoader;
        }

        public bool TryLoadImage(string Path, object Gender)
        {   
           return _ImageLoader.LoadImage(Path, Gender);
        }
    }
}
