using System;
using System.Text.RegularExpressions;

namespace DVLD.UI.Utils.Validation
{
    public class clsValidateUtils
    {
        public static bool IsNumericType(Type type) =>
            type == typeof(int) || type == typeof(long) ||
            type == typeof(short) || type == typeof(byte) ||
            type == typeof(double) || type == typeof(decimal) ||
            type == typeof(float);

        public static bool IsValideEmail(string Email)
        {
            if (string.IsNullOrWhiteSpace(Email))
                return false;

            string Pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(Email, Pattern);
        }

        public static bool IsValidPassword(string Password)
        {
            return Password.Length >= 8 && Regex.IsMatch(Password, "[a-z]") && Regex.IsMatch(Password, "[A-Z]") && Regex.IsMatch(Password, "\\d") && Regex.IsMatch(Password, "[^a-zA-Z\\d]");
        }
    }
}
