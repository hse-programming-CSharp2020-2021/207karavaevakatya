using System;
using System.Globalization;
using System.Threading;
using System.Xml;
// Sem_04; задача 5
namespace Homework7._8
{
    class Program
    {
        public static void Picture1(int n)
        {
            Random rnd = new Random();
            int[,] a1 = new int[n, n];
            for (int i = 0; i < a1.GetLength(0); i++)
            {
                for (int j = 0; j < a1.GetLength(1); j++)
                {
                    if (i > j && i < n - j - 1)
                    {
                        a1[i, j] = rnd.Next(0, 26);
                    }
                }
            }
            Output(a1);

        }
        public static void Picture2(int n)
        {
            Random rnd = new Random();
            int[,] a1 = new int[n, n];
            for (int i = 0; i < a1.GetLength(0); i++)
            {
                for (int j = 0; j < a1.GetLength(1); j++)
                {
                    if (i >= j && i >= n - j - 1)
                    {
                        a1[i, j] = rnd.Next(0, 26);
                    }
                }
            }
            Output(a1);

        }
        public static void Picture3(int n)
        {
            Random rnd = new Random();
            int[,] a1 = new int[n, n];
            for (int i = 0; i < a1.GetLength(0); i++)
            {
                for (int j = 0; j < a1.GetLength(1); j++)
                {
                    if (i < j && i < n - j - 1 || i > j && i > n - j - 1)
                    {
                        a1[i, j] = rnd.Next(1, 26);
                    }
                }
            }
            Output(a1);

        }

        public static void Picture4(int n)
        {
            Random rnd = new Random();
            int[,] a1 = new int[n, n];
            for (int i = 0; i < a1.GetLength(0); i++)
            {
                for (int j = 0; j < a1.GetLength(1); j++)
                {
                    if (i < j && i < n - j - 1 && (j < n / 2) || i > j && i > n - j - 1 && (j >= n / 2))
                    {
                        a1[i, j] = rnd.Next(1, 26);
                    }
                }
            }
            Output(a1);

        }


        // Выводим массив.
        public static void Output(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write("{0, 3}", a[i, j]);
                }
                Console.WriteLine();
            }
        }



        public static bool Read(out int n)
        {
            return int.TryParse(Console.ReadLine(), out n);
        }
        static void Main(string[] args)
        {
            while (true)
            {
                int n;
                do Console.WriteLine("Введите размер массива: ");
                while (!Read(out n));
                Picture1(n);
                Console.WriteLine();
                Console.WriteLine();
                Picture2(n);
                Console.WriteLine();
                Console.WriteLine();
                Picture3(n);
                Console.WriteLine();
                Console.WriteLine();
                Picture4(n);

            }
        }
    }
}
