using System;
using System.ComponentModel;

namespace homework2._3
{
    class Program
    {
        public static void Ds(int a, int b, int c)
        {
            double D;
            D = b * b - 4 * a * c; // находим дискриминант
            if (D > 0) //если он >0, то выводим два корня
            {
                Console.WriteLine((-b + Math.Sqrt(D)) / 2 * a);
                Console.WriteLine((-b - Math.Sqrt(D)) / 2 * a);
            }
            else if (D == 0) // если равен 0, то выводим один корень
            {
                Console.WriteLine(-b / 2 * a);
            }
            else // комплексные числа не проходили....
            {
                Console.Write("действительных корней нет");
            }
        }

        static void Main(string[] args)
        {
            int a, b, c;
            while (true)
            {
                Console.WriteLine("");
                if (int.TryParse(Console.ReadLine(), out a) && int.TryParse(Console.ReadLine(), out b) && int.TryParse(Console.ReadLine(), out c))
                {
                    Ds(a, b, c);
                }
                else
                {
                    return;
                }
            }
        }
    }
}
