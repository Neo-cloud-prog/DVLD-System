using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD.Core.Entities.User;
using DVLD.UI.Utils.IO;

namespace DVLD.UI.Helpers.Session
{
    internal static class clsUserSession
    {
        private static string _FilePath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Temp\Texts\LogedUser.txt"));

        public static void SetFilePath(string Path)
        {
            _FilePath = Path;
        }

        public static void Save(int UserId)
        {
            if (string.IsNullOrEmpty(_FilePath))
                throw new InvalidOperationException("File path not set call SetFilePath from UI layer.");

            clsFileUtils.WriteToFile(_FilePath, UserId.ToString());
        }

        public static void Delete()
        {
            if (string.IsNullOrEmpty(_FilePath))
                throw new InvalidOperationException("File path not set call SetFilePath from UI layer.");

            clsFileUtils.DeleteFile(_FilePath);
        }

        private static int _GetIdFromFile()
        {
            if (string.IsNullOrEmpty(_FilePath))
                throw new InvalidOperationException("File path not set call SetFilePath from UI layer.");

            string Line = clsFileUtils.ReadFromFile(_FilePath);
            if (int.TryParse(Line, out int UserId))
            {
                return UserId;
            }

            return -1;
        }

        public static clsUser Get()
        {
            return clsUser.Find(_GetIdFromFile());
        }
    }
}
