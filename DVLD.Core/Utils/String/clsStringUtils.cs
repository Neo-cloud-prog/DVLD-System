namespace DVLD.Core.Utils.String
{
    public class clsStringUtils
    {
        public static string EncryptText(string Text, int Key = 2)
        {
            string EncryptedText = "";
            for (int i = 0; i < Text.Length; i++)
            {
                int ASCIINumber = Text[i] + Key;
                char Chr = (char)ASCIINumber;
                EncryptedText += Chr;
            }
            return EncryptedText;
        }

        public static string DecryptText(string Text, int Key = 2)
        {
            return EncryptText(Text, -Key);
        }

        public static string RemoveLastChar(string input)
        {
            return input.Length > 0 ? input.Remove(input.Length - 1) : input;
        }
    }
}
