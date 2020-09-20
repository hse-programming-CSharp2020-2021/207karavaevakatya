using System;

namespace fourteen_4
{
    class Program
    {
        public static void method1(double x)
        {
            if (x <= 0.5)
            {
                Console.WriteLine(Math.Sin(Math.PI / 2));
            }
            else
            {
                Console.WriteLine(Math.Sin((Math.PI * (x - 1)) / 2));
            }
        }
        static void Main(string[] args)
        {
            double x;
            while (true)
            {
                if (double.TryParse(Console.ReadLine(), out x))
                {
                    method1(x); // вызов метода, который по значению x выбирает нужную формулу и выводит ответ
                }
                else
                {
                    Console.WriteLine("error");
                }

            }
        }
    }
}
