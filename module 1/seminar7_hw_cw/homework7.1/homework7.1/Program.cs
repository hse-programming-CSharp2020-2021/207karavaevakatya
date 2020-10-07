using System;
using System.Globalization;
using System.Xml;
//Sem_03; задача 9
namespace Homework7._1
{
    class Program
    {
        // Заполняем массив случайными числами.
        public static int[] Organization(int n)
        {
            Random rnd = new Random();
            int[] a = new int[n];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rnd.Next(-10, 11);
            }
            return a;
        }
        // Выводим массив.
        public static void Output(int[] a)
        {
            foreach (int x in a)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();
        }
        // Сортируем массив и выводим его.
        public static void ArrayHill(int[] a)
        {
            int len = a.Length;
            int[] arr = new int[len];
            Array.Sort(a);
            for (int i = 0, m = len - 1, j = 0; i < len; i++)
            {
                if (i % 2 == 0)
                {
                    arr[j++] = a[i];
                }
                else
                {
                    arr[m--] = a[i];
                }
            }
            foreach (int x in arr)
            {
                Console.Write(x + " ");
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
                int[] a = Organization(n);
                Output(a);
                ArrayHill(a);
                Console.WriteLine();

            }
        }
    }
}
