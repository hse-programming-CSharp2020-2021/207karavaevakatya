using System;
namespace homework4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            double s = 0.05;
            double x = 1;
            double y;
            if (int.TryParse(Console.ReadLine(), out a) && int.TryParse(Console.ReadLine(), out b) && int.TryParse(Console.ReadLine(), out c))
            {
                while (x <= 2)
                {
                    if (x < 1.2)
                    {
                        y = a * Math.Pow(x,2) + b * x + c;
                    }
                    if (x == 1.2)
                    {
                        y = a / x + Math.Sqrt(Math.Pow(x, 2) + 1);
                    }
                    else
                    {
                        y = (a + b * x) / Math.Sqrt(Math.Pow(x, 2) + 1);
                    }
                    x += s;
                    Console.WriteLine("x = " + x + "y = " + y);
                }
            }
            else
                Console.WriteLine("error");
        }
    }
}