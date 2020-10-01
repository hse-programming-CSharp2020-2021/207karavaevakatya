using System;
using System.Net.Http.Headers;

namespace homework4._4
{
    class Program
    {
        public static void Method(ref int m, ref int n)
        {
            if (m < 64 && n < 64)
            {
                long final = 0;
                long fistnum = 1;

                final |= fistnum << n;
                if (n == m)
                    final <<= 1;
                else
                    final |= fistnum << m;

                Console.WriteLine(final);
            }
            else
            {
                Console.WriteLine("произошло переполнение");
            }
        }
        static void Main(string[] args)
        {
            int m;
            int n;
            Console.WriteLine("Введите степени двоек, для вычисления: 2^m + 2^n");
            if ((int.TryParse(Console.ReadLine(), out m)) && (int.TryParse(Console.ReadLine(), out n)))
                Method(ref m, ref n);
            else
                Console.WriteLine("error");
        }
    }
}
