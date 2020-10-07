using System;
using System.Linq;
// Sem_03; задача 16
namespace homework7._4
{
    class Program
    {
        public static int[] G(int n)
        {
            Random rnd = new Random();
            int[] a = new int[n];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rnd.Next(-10, 11);
            }
            foreach (int x in a)
            {
                Console.Write($"{x} ");
            }
            return a;
        }


        public static void Max_iMin_i(int[] a)
        {
            // Находим индекс минимального и максимального элемента.
            int mini = Array.FindIndex(a, w => w == a.Min());
            int maxi = Array.FindIndex(a, w => w == a.Max());
            Console.WriteLine();
            Console.WriteLine($"Минимальный индекс: {mini} ");
            Console.WriteLine($"Максимальный индекс: {maxi} ");
            Console.WriteLine($"Cумма индексов:{mini + maxi}");
        }

        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.WriteLine("введите n");
            } while (!int.TryParse(Console.ReadLine(), out n));
            int[] a = G(n);
            Max_iMin_i(a);
            //foreach (int x in a)
            //{
            //    Console.Write($"{x} ");
            //}
        }
    }
}
