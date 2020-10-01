using System;
using System.IO;

namespace homework5._3
{
    class Program
    {
        static void Math(int n, int a, int b)
        {
            long[] m = new long[n];
            for (int i = 0; i < n; i++)
            {
                m[i] = a + i * b;
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(m[i]);
            }
        }



        static void Main(string[] args)
        {
            int n;
            int a;
            int b;
            if (int.TryParse(Console.ReadLine(), out n) && int.TryParse(Console.ReadLine(), out a)
                && int.TryParse(Console.ReadLine(), out b) && n > 1)
            {
                Math(n, a, b);
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
