using System;
// Треугольник паскаля
namespace CW_1._1
{
    class Program
    {
        public static void Tri(int n)
        {
            int[][] a = new int[n][];
            for (int i = 0; i < n; i++)
            {
                a[i] = new int[i + 2];
            }

            a[0][0] = 1;

            a[1][0] = a[1][1] = 1;

            for (int i = 2; i < n; ++i)

            {

                a[i][0] = 1;
                a[i][i] = 1;

                for (int j = 1; j < i; ++j)

                    a[i][j] = a[i - 1][j - 1] + a[i - 1][j];

            }

            for (int i = 0; i < n; i++)
            {
                int m = a[i].Length - 1;
                Array.Resize(ref a[i], m);
            }


            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    if (j == 0)
                    {
                        int m = 2 * (n - i);
                        for (int k = 0; k < m; k++)
                            Console.Write(" ");
                        Console.Write($"{a[i][j]}");
                    }
                    if (j != 0)
                    {
                        Console.Write(" ");
                        Console.Write("{0,4}", a[i][j]);
                    }

                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            while (true)
            {
                int n;
                int.TryParse(Console.ReadLine(), out n);
                Tri(n);
            }
        }
    }
}