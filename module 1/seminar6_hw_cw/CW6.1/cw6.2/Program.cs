using System;
// сжатый массив (нечетные)
namespace Task5
{
    class Program
    {
        public static int[] Method(int n)
        {
            Random rng = new Random();
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = rng.Next(-30, 30);
            }
            Console.WriteLine("Текущий массив: ");
            Array.ForEach(a, x => Console.Write($"{x} "));
            int m = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 != 0)
                {
                    a[m] = a[i];
                    m++;
                }
            }
            Array.Resize(ref a, m);
            return a;

        }
        static void Main(string[] args)
        {
            int n;
            int.TryParse(Console.ReadLine(), out n);
            int[] final = Method(n);
            Console.WriteLine("Сжатый массив: ");
            Array.ForEach(final, x => Console.Write($"{x} "));
        }
    }
}
