using System;

// Sem_03; задача 13
namespace homework7._3
{
    class Program
    {
        public static void Method(int n, int k)
        {
            // Заполняем массив случайными числами.
            int[] a = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                a[i] = rnd.Next(-10, 11);
            }

            //foreach (int x in a)
            //{ Console.Write(x+ " "); }
            //Console.WriteLine();
            // Выводим индексы кратные k
            for (int i = 0; i < n; i += k)
            {
                Console.Write(a[i] + " ");
            }
        }
        static void Main(string[] args)
        {
            while (true)
            {
                int n, k;
                do
                {
                    Console.WriteLine("введите значения  n и k: ");
                } while (!int.TryParse(Console.ReadLine(), out n) || !int.TryParse(Console.ReadLine(), out k) || (k < 1) || (k > n) || (n <= 0));
                Console.WriteLine(n);
                Method(n, k);
                Console.WriteLine();
            }
        }
    }
}
