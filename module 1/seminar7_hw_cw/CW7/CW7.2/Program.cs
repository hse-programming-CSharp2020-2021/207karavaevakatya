using System;

namespace CW7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int.TryParse(Console.ReadLine(), out n);
            int[][] a = new int[n][];
            for (int i = 0; i < n; i++)
            {
                    a[i] = new int[i];
            }
             
        }
    }
}
