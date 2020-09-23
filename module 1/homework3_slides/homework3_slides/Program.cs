using System;

namespace homework3_slides 
{
    class Program
    {
        public static void math(int A)
        {
            //программа вычисляет площать под графиком x^2
            // Суть в том, что мы находим площадь прямоугольника, ограниченного отрезком от 0 до A
            // Затем мы площадь прямоугольника умножаем на коэффициент пифагора либо (1/3), либо (2/3), но так как
            //мы ищем площадь под параболой, то должны умножить на 1/3 
            Console.WriteLine((A * Math.Pow(A, 2))/3);
        }

        static void Main(string[] args)
        {
            int A;
            int.TryParse(Console.ReadLine(), out A);
            math(A);
            Console.WriteLine(A);
        }
    }
}
