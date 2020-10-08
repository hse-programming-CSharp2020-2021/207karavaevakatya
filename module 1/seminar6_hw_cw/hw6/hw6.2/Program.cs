using System;
using System.Threading;
// Задача 6.1.
namespace hw6._2
{
    class Program
    {
        public static void Method(int[] a)
        {
            for (int i = 0; i < a.Length - 1; i++)
            {
                if ((a[i] * a[i + 1]) % 3 == 0)
                {
                    a[i] = a[i] * a[i + 1];
                    for (int j = i + 1; j < a.Length - 1; j++)
                    {
                        a[j] = a[j + 1];
                    }
                    Array.Resize(ref a, a.Length - 1);
                }

            }
            Console.WriteLine();
            Console.WriteLine("New array: ");
            Array.ForEach(a, number => Console.Write($"{number} "));

        }


        static void Main(string[] args)
        {
            int x;
            do
            {
                Console.WriteLine("Введите число: ");
            } while (!int.TryParse(Console.ReadLine(), out x) || (x < 0));
            int[] a = new int[x];
            Random rnd = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rnd.Next(-10, 11);
            }
            Console.WriteLine("Old array: ");
            Array.ForEach(a, number => Console.Write($"{number} "));
            Method(a);

        }
    }
}
