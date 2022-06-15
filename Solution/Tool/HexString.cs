using System;

namespace Tool
{
    public class HexString
    {
        public static string ToHex(string text)
        {
            if (text == null)
            {
                return null;
            }
            string text2 = string.Empty;
            foreach (char value in text)
            {
                text2 += Convert.ToUInt16(value).ToString("X4");
            }
            return text2;
        }

        public static string FromHex(string hexText)
        {
            if (hexText == null)
            {
                return null;
            }
            string text = string.Empty;
            while (hexText.Length > 3)
            {
                text += Convert.ToChar(Convert.ToUInt32(hexText.Substring(0, 4), 16));
                hexText = hexText.Substring(4, hexText.Length - 4);
            }
            return text;
        }
    }
}

