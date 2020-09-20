using System;

namespace homework2._7
{
    class Program
    {
        public static void math1(double real)
        {
            int integer = (int)real; // берем целую чать числа
            double fraction = real - integer; //находим дробную часть, вычитая из исходного числа его целую чать
            Console.WriteLine("integer = {0}; fraction= {1}", integer, fraction); // выводим на экран целую и дробную части 

        }

        public static void math2(double real)
        {
            Console.WriteLine("возведение в квадрат: " + Math.Pow(real, 2)); // возводим в квадрат
            Console.WriteLine("квадратный корень из числа: " + Math.Sqrt(real)); //извлекаем корень
        }

        static void Main(string[] args)
        {
            double real;
            Console.Write("введите число:");
            while (true)
            {
                if (double.TryParse(Console.ReadLine(), out real))
                {
                    math1(real); //  вызываем первую функцию
                    math2(real); //  вызываем вторую функцию
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
        }
    }
}
