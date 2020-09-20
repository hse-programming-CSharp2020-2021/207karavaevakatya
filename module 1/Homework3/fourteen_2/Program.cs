using System;
using System.Runtime.CompilerServices;

namespace fourteen_2
{
    class Program
    {
        public static void night(int x, int y)
        {
            if ((x < y) && (x > 0))
                Console.WriteLine(x + Math.Sin(y));
            else if ((x > y) && (x < 0))
            {
                Console.WriteLine(y - Math.Cos(x));
            }
            else
            {
                Console.WriteLine(0.5*x*y);
            }
        }
        static void Main(string[] args)
        {
            int x, y;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(),out x)  && int.TryParse(Console.ReadLine(), out y))
                {
                    night(x, y); //вызываем метод, который определяет по значению x и y итоговую формулу и выводит ответ
                }
                else
                {
                    Console.WriteLine("error");
                }
                        
            }

        }
    }
}
