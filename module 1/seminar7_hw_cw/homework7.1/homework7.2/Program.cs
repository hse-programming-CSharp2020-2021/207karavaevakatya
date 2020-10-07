using System;
using System.Runtime.Serialization.Formatters;
using System.Xml;

// Sem_03; задача 11
namespace homework7._2
{
    class Program
    {
        public static void Output(int n)
        {
            int[] s = new int[n];
            s[0] = 0;
            s[1] = 1;
            for (int i = 2; i < s.Length; i++)
            {
                s[i] = s[i] = 34 * s[i - 1] - s[i - 2] + 2;
            }
            foreach (int x in s)
            {
                Console.Write($"{x} ");
            }
        }


        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.WriteLine("введите n");
            } while (!int.TryParse(Console.ReadLine(), out n));
            Output(n);
        }
    }
}
