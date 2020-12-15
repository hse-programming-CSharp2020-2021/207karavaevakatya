using Figures;
using forNumber2;
using System;

namespace number2
{
    class Program
    {
        static void Main(string[] args)
        {

            Point p = new Point();
            p.Display();
            Console.WriteLine("p.Area (Point) = " + p.Area);
            p = new Circle(1, 2, 6);
            p.Display();
            Console.WriteLine("p.Area (Circle)= " + p.Area);
            p = new Square(3, 5, 8);
            p.Display();
            Console.WriteLine("p.Area (Square) = " + p.Area);

            Point[] arrPoint = FigArray();

            foreach (Point x in arrPoint)
            {
                Console.WriteLine(x.Display());
            }
            int cCount = 0, sCount = 0;
            foreach (Point x in arrPoint)
            {
                if (x is Circle)
                {
                    cCount++;
                }
                else
                {
                    sCount++;
                }
            }
            Console.WriteLine($" Количество окружностей: {cCount}");
            foreach (Point x in arrPoint)
            {
                if (x is Circle)
                {
                    Console.WriteLine(x.Display());
                }
            }
            Console.WriteLine($"Количество квадратов: {sCount} ");
            Array.Sort(arrPoint,
                (x, y) =>
                {
                    if (x.Area > y.Area)
                    {
                        return 1;
                    }
                    else
                    {
                        return -1;
                    }
                });
        }
        static Point[] FigArray()
        {
            var rnd = new Random();
            Point[] arr = new Point[rnd.Next(0, 11)];
            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 == 0)
                {
                    arr[i] = new Circle(rnd.NextDouble() * (100 - 10) + 10, rnd.NextDouble() * 90 + 10, rnd.NextDouble() * 90 + 10);
                }
                else
                {
                    arr[i] = new Square(rnd.NextDouble() * (100 - 10) + 10, rnd.NextDouble() * 90 + 10, rnd.NextDouble() * 90 + 10);

                }
            }
            return arr;

        }
    }
}
