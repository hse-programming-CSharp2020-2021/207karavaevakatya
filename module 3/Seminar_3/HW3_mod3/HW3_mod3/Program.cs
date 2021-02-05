using System;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Channels;

namespace Number1
{
    public delegate void Ev();
    public delegate void EventNew(int[,] arr);

    public class Methods
    {
        public static event Ev lineEnd;
        public static event EventNew newItemFilled;
        public static void ArrayPrint(int[,] arr)
        {
            for (int i = 0; i <= arr.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= arr.GetUpperBound(1); j++)
                    Console.Write(arr[i, j] + " ");
                lineEnd();
            }
        }

        public static void ArrayFill(int[,] arr)
        {
            Random rnd = new Random();
            for (int i = 0; i <= arr.GetUpperBound(0); i++)
                for (int j = 0; j <= arr.GetUpperBound(1); j++)
                {
                    arr[i, j] = rnd.Next(100);
                    newItemFilled(arr);
                }
        }
    }
    class Program
    {
        static void Main()
        {
            int[,] arr = new int[15, 15];


            Methods.newItemFilled += (int[,] arr) =>
            {
                int sum = 0;
                for (int i = 0; i <= arr.GetUpperBound(0); i++)
                {
                    for (int j = 0; j <= arr.GetUpperBound(1); j++)
                    {
                        sum += arr[i, j];
                    }
                }

                Console.WriteLine($"Sum {sum}");
            };

            int n = 1;
            Methods.newItemFilled += (int[,] arr) =>
            {
                ++n;
                int count = 0;
                for (int i = 0; i <= arr.GetUpperBound(0); i++)
                {
                    for (int j = 0; j <= arr.GetUpperBound(1); j++)
                    {
                        count += arr[i, j];
                    }
                }
                Console.WriteLine($"Av {1.0 * count / n}");
            };

            Methods.newItemFilled += (int[,] arr) =>
            {
                int max = Int32.MinValue;
                for (int i = 0; i <= arr.GetUpperBound(0); i++)
                {
                    for (int j = 0; j <= arr.GetUpperBound(1); j++)
                    {
                        if (arr[i, j] >= max)
                        {
                            max = arr[i, j];
                        }
                    }
                }

                Console.WriteLine("Max " + max);
            };
            Methods.ArrayFill(arr);
            Methods.lineEnd += () => { Console.WriteLine(); };
            Methods.ArrayPrint(arr);
        }
    }
}
