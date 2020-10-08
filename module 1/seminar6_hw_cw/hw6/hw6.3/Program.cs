using System;

namespace hw6._3
{
    class Program
    {
        public static void Compress(int[] a)
        {
            int m = 0;
            int count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = a[m++];
                count++;
            }
            Console.WriteLine();
            Console.WriteLine("количество cжатий: " + count);
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
                a[i] = rnd.Next(1, 11);
            }
            Console.WriteLine("Array: ");
            Array.ForEach(a, number => Console.Write($"{number} "));
            Compress(a);
            
        }
    }
}
