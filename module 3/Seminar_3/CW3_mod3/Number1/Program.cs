using System;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Channels;
// Номер 5
namespace CW3
{
    public delegate void Ev();

    public class Methods
    {
        public static event Ev lineEnd;
        public static void Print(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                    Console.Write($"{arr[i, j]}  ");
                lineEnd?.Invoke();
            }
        }

        public static void Fill(int[,] arr)
        {
            Random rnd = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                arr[i, j] = rnd.Next(100);
                lineEnd?.Invoke();
            }
        }
    }
    class Program
    {
        public static int Check()
        {
            int n;
            do
            {
                Console.WriteLine("Введите n");
            } while (!int.TryParse(Console.ReadLine(), out n));

            return n;
        }
        static void Main()
        {
            int n = Check();
            int[,] arr = new int[n, n];
            Methods.lineEnd += () => { Console.WriteLine(); };
            Methods.lineEnd += () => { Console.WriteLine("*******"); };
            Methods.Fill(arr);
            Methods.Print(arr);
        }
    }
}