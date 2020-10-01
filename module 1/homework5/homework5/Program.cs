using System;
using System.Collections.Concurrent;

namespace homework5
{
    class Program
    {
        public static void gen(long[] m, int len)
        {
            for (int i = 0; i < len; i++)
            {
                m[i] = (long)Math.Pow(2, i);
            }
            for (int i = 0; i < len; i++)
            {
                Console.Write(m[i] + " ");
            }

        }
        static void Main(string[] args)
        {

            int len;
            do
                Console.WriteLine("Введите длину: ");
            while (!int.TryParse(Console.ReadLine(), out len) | len < 1);
            long[] m = new long[len];
            gen(m, len);
        }
    }
}
