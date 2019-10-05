using System;

namespace LibreriaConversioni
{
    public class LibreriaConversioni
    {
        public static string ToBinary(int decimale)
        {
            string binarynumber = (Convert.ToString(decimale, 2));
            return binarynumber;
        }
        public static string ToHexadecimal(int decimale)
        {
            string hexadecimalnumber = (Convert.ToString(decimale, 16));
            return hexadecimalnumber;
        }
        public static string ToOctal(int decimale)
        {
            string octalnumber = (Convert.ToString(decimale, 8));
            return octalnumber;
        }
    }
}
