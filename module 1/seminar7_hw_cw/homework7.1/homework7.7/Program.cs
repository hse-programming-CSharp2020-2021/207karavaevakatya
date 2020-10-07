using System;
// Sem_04; задача 4 
namespace homework7._7
{
    class Program
    {
        // Заполняем случайными числами матрицу.
        public static int[,] Method(int n, int min, int max)
        {
            Random rnd = new Random();
            int[,] a = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = rnd.Next(min, max + 1);
                }
            }
            return a;
        }
        // Выводим матрицу.
        public static void Output(int[,] a)
        {
            int n = a.GetLength(0); // Длина строки или столбца (равносильно).
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0, 3}", a[i, j]); // Выводим массив, причем на каждый его элемент отводим 3 знака.
                }
                Console.WriteLine();
            }
        }
        // Находим определитель.
        public static int Det(int[,] a)
        {
            int n = a.GetLength(0);
            if (n == 2)
            {
                return a[0, 0] * a[1, 1] - a[0, 1] * a[1, 0];
            }
            if (n == 3)
            {
                int det1 = 0;
                det1 = det1 + a[0, 0] * a[1, 1] * a[2, 2];
                det1 = det1 + a[0, 1] * a[1, 2] * a[2, 0];
                det1 = det1 + a[0, 2] * a[1, 0] * a[2, 1];
                det1 = det1 - a[0, 0] * a[1, 2] * a[2, 1];
                det1 = det1 - a[0, 1] * a[1, 0] * a[2, 2];
                det1 = det1 - a[0, 2] * a[1, 1] * a[2, 0];
                return det1;
            }
            return 0;
        }
        static void Main(string[] args)
        {
            while (true)
            {
                int n;
                int min;
                int max;
                do
                {
                    Console.WriteLine("введите размер матрицы (либо 2, либо 3): ");
                } while (!int.TryParse(Console.ReadLine(), out n) || !int.TryParse(Console.ReadLine(), out min) || !int.TryParse(Console.ReadLine(), out max) || (min >= max));
                int[,] a = Method(n, min, max); // Создаем массив.
                Output(a); // Выводим массив.
                Console.WriteLine();
                Console.WriteLine(Det(a)); // Выводим определитель.
            }
        }
    }
}
