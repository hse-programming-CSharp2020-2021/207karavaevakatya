using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace fourteen_2
{
    class Program
    {
        public static void M1(double x, double y)
        {
            if ((Math.Pow(x, 2) + Math.Pow(y, 2)) <= 2 * 2) //проверяем, попадает ли точка в круг радиуса 2
            {

                if ((x < 0) && (y < 0)) // если она в 4 четверти, то точка вне сектора 
                {
                    Console.WriteLine("False");
                }
                else if ((y < Math.Sqrt(2)) && (x < Math.Sqrt(2))) // если точка в области от 0 до 45 градусов, то она вне сектора 
                {
                    Console.WriteLine("False");
                }
                else

                    Console.WriteLine("True"); // в любом другом случае, точка будет находиться в заданном секторе
            }
            else
                Console.WriteLine("False"); // если точка даже не попала во внутрь круга, то она точне не находится в секторе

        }

        static void Main(string[] args)
        {
            double x, y;
            if ((double.TryParse(Console.ReadLine(), out x) && (double.TryParse(Console.ReadLine(), out y))))
            {
                M1(x, y);
            }
            else
            {
                return;
            }

        }
    }
}