using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD.UI.Interfaces.UI.Images
{
    public interface IImageLoader
    {
        bool IsValidImagePath(string Path);
        bool LoadImage(string Path, object Gender);
    }
}
