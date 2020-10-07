using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;
// Sem_04; задача 1 (картинка 3)
namespace homework7._6
{
    class Program
    {
        public static int[,] Method(int n)
        {
            int[,] a = new int[n, n];
            int i = 0; // Переменная отвечающая за строки.
            int j = 0; // Переменная отвечающая за столбцы.
            int number = 1; // Стартовое значение чисел в матрице.
            int len = a.GetLength(0); // Длина массива а.
            while (len > 0)
            {
                for (int count = 0; count < (len - 1); count++)
                {
                    a[i, j] = number; // Заполняем фиксированную строку.
                    number++; // Увеличиваем число.
                    j++; // В строке каждый раз переходим к новому столбцу. (Создаем движение вправо)
                }
                for (int count = 0; count < (len - 1); count++)
                {
                    a[i, j] = number; // Заполняем фиксированный столбец.
                    number++; // Увеличиваем число.
                    i++; // В столбце каждый раз переходим к новой строке. (Создаем движение вниз)
                }
                for (int count = 0; count < (len - 1); count++)
                {
                    a[i, j] = number; // Заполняем фиксированную строку.
                    number++; // Увеличиваем число.
                    j--; // В строке каждый раз переходим к новому столбцу. (Создаем движение влево)
                }
                for (int count = 0; count < (len - 1); count++)
                {
                    a[i, j] = number;
                    number++; // Увеличиваем число.
                    i--; // // В столбце каждый раз переходим к новой строке. (Создаем движение вверх)
                }
                i++; // увеличиваем i на 1, чтобы вернуться к строке, где мы остановились.
                j++; // Переходим к новому столбцу.
                len = len - 2; // Длина каждый цикл уменьшается на 2, поэтому вычитаем 2.
            }
            if (len == 0) // Если введеный размер матрицы был нечетным, то в конце мы должны отдельно заполнить элемент.
            {
                a[i, j] = number;
            }
            return a;

        }
        public static void Output(int[,] a)
        {
            int n = a.GetLength(0); // Длина строки или столбца (равносильно).
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0, 5}", a[i, j]); // Выводим массив, причем на каждый его элемент отводим 3 знака.
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            while (true)
            {
                int n;
                do
                {
                    Console.WriteLine("введите размер матрицы: ");
                } while (!int.TryParse(Console.ReadLine(), out n));
                int[,] a = Method(n); // Создаем массив.
                Output(a); // Выводим массив.
                Console.WriteLine();
            }
        }
    }
}
