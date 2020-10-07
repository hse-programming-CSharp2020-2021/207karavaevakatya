
using System;
using System.Data;

namespace homework2._5
{
    class Program
    {
        public static void tr(double a, double b, double c)
        {
            double stmax;
            double sum23;
            stmax = Math.Max(a, Math.Max(b, c)); //находим наибольшую сторону
            sum23 = (a + b + c) - stmax; // находим сумму двух других сторон
            string str = (stmax < sum23) ? "неравенство треугольника выполнено,такой треугольник существует" : "неравенство треугольника не выполнено, такого треугольника нет";
            // если большая сторона меньше суммы двух других, то такой треугольник существует
            Console.WriteLine(str);
        }
        static void Main(string[] args)
        {
            while (true)
            {
                double a, b, c;
                if (double.TryParse(Console.ReadLine(), out a) && double.TryParse(Console.ReadLine(), out b) && double.TryParse(Console.ReadLine(), out c))
                {
                    tr(a, b, c);
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
        }
    }
}