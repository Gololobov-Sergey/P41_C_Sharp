using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P41_C_Sharp
{
    static class Extention
    {
        public static string Mult(this string str, int n)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < n; i++)
                sb.Append(str);
            return sb.ToString();
        }

        public static string PadCenter(this string str, int width)
        {
            if (str.Length >= width) return str;

            int left = (width - str.Length) / 2;
            StringBuilder sb = new StringBuilder();
            sb.Append(" ".Mult(left));
            sb.Append(str);
            sb.Append(" ".Mult(width - left - str.Length));
            return sb.ToString();
        }


        public static bool isEven(this int n)
        {
            return n % 2 == 0;
        }

    }
}
