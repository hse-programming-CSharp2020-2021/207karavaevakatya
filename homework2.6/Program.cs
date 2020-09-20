using System;
using System.Globalization;
using System.Threading;

namespace homework2._6
{
    class Program
    {
        public static void Sum(double finances, int percent)
        {
            double count = 0;
            count = (finances * percent)/100;  // считаем ту долю денег,которая выделена на игры
            Console.WriteLine(count.ToString("c3", CultureInfo.GetCultureInfo("en-US"))); //выводим эту сумму в валюте
        }
        static void Main(string[] args)
        {
            double finances;
            int percent;
            while (true)
            {
                if (double.TryParse(Console.ReadLine(), out finances) && int.TryParse(Console.ReadLine(), out percent))
                {
                    Sum(finances, percent);
                }
                else
                {
                    return;
                }
            }
        }
    }
}