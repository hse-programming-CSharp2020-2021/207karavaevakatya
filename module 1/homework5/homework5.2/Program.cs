using System;

namespace homework5._2
{
    class Program
    {
        static void Math(long[] m, int n)
        {
            m[0] = 1;
            for (int i = 1; i < n; i++)
            {
                m[i] = m[i-1] + 2;
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(m[i]);
            }

        }



        static void Main(string[] args)
        {
            int n;
            if (int.TryParse(Console.ReadLine(), out n) && n > 0)
            {
                long[] m = new long[n];
                Math(m, n);
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
