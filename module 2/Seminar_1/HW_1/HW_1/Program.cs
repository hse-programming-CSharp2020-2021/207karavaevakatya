using System;
using System.ComponentModel.DataAnnotations;
// Задание 2
namespace HW_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.WriteLine("Введите размер квадратной матрицы: ");
            } while (!int.TryParse(Console.ReadLine(), out n) || (n <= 0));
            int[,] arr = new int[n, n];
            int len = arr.GetLength(0);
            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < len; j++)
                {
                    int num = i + j + 1;
                    if (num > len)
                    {
                        num = num % n;
                    }
                    arr[i, j] = num;
                }
            }
            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < len; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
