using System;
// Задача 4.
namespace hw6
{
    class Program
    {

        public static void Output(int[] mas)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write($"[{i}] = {mas[i]}  ");
                // Выводим по 5 элементов в строке.
                if (i % 4 == 0 && (i != 0))
                    Console.WriteLine("\n");
            }
        }


        static void Main(string[] args)
        {
            int a;
            do
            {
                Console.WriteLine("Введите число: ");
            } while (!int.TryParse(Console.ReadLine(), out a) || (a < 0));
            int[] mas = new int[1];
            mas[0] = a;
            int i = 0;     
            while (mas[i] != 1)
            {

                if (mas.Length == i + 1)
                {
                    int[] newmas = new int[mas.Length * 2];
                    Array.Copy(mas, newmas, mas.Length);
                    mas = newmas;
                }
                mas[i + 1] = mas[i] % 2 == 0 ? mas[i] / 2 : 3 * mas[i] + 1;
                i++;
            }


            if (mas.Length > (i + 1))
            {
                Array.Resize(ref mas, i);
            }
            Array.ForEach(mas, x => Console.Write($"{x} "));
            Console.WriteLine();

            Output(mas);

        }
    }
}
