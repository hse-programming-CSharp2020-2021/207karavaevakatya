using System;

namespace homework5._4
{
    class Program
    {
        public static void Math(long[] m, int n)
        {
            m[0] = 1;
            m[1] = 1;
            for (int i = 2; i < n; i++)
            {
                m[i] = m[i - 1] + m[i - 2];
            }
        }


        static void Main(string[] args)
        {
            int n;
            if (int.TryParse(Console.ReadLine(), out n) && n > 0)
            {
                long[] m = new long[n];
                Math(m, n);
                for (int i = n - 1; i > -1; i--)
                {
                    Console.WriteLine(m[i]);
                }

            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
