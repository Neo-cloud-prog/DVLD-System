using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD.UI.Utils.IO
{
    public class clsFileUtils
    {
        public static void WriteToFile(string FilePath, string Content)
        {
            string directory = Path.GetDirectoryName(FilePath);
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            File.WriteAllText(FilePath, Content);
        }

        public static string ReadFromFile(string FilePath)
        {
            return File.Exists(FilePath) ? File.ReadAllText(FilePath) : null;
        }

        public static void DeleteFile(string FilePath)
        {
            if (File.Exists(FilePath))
            {
                try
                {
                    GC.Collect();
                    GC.WaitForPendingFinalizers();

                    File.Delete(FilePath);
                }
                catch (IOException ex)
                {
                    // do somthing...
                }
            }
        }

        public static void CopyFile(string SourcePath, string DestinationPath)
        {
            if (File.Exists(SourcePath))
            {
                File.Copy(SourcePath, DestinationPath);
            }
        }

        public static bool FileExists(string FilePath)
        {
            return File.Exists(FilePath);
        }
    }
}
