using System;
using System.Text.RegularExpressions;

namespace Number1
{
    delegate string ConvertRule(string str);

    class Converter
    {
        public static string Convert(string str, ConvertRule cr)
        {
            return cr(str);
        }
    }
    class Program
    {
        private int[] dig = new[] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
        public static string RemoveDigits(string str)
        {
            string s = Regex.Replace(str, "[0-9]", "", RegexOptions.IgnoreCase);
            return s;

        }

        public static string RemoveSpaces(string str)
        {
            return str.Replace(" ", "");
        }
        static void Main(string[] args)
        {
            string[] arr = new[] {"asd345 354", "234sdfgf45retr", "243df", "34 dr"};
            ConvertRule cr1 = RemoveSpaces;
            ConvertRule cr2 = RemoveDigits;
            ConvertRule cr12 = cr1 + cr2;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(Converter.Convert(arr[i], cr1));
            }

            Console.WriteLine("***");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(Converter.Convert(arr[i], cr2));

            }
            Console.WriteLine("***");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(Converter.Convert(arr[i], cr1));

            }


        }
    }
}