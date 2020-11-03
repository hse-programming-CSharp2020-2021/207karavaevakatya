using System;
// Задание 2.
namespace HW_2._1
{
    class Point
    {

        public double X { get; set; }
        public double Y { get; set; }
        public double p
        {
            get
            {
                return Math.Sqrt(Y * Y + X * X);
            }
        }
        public double q
        {
            get
            {
                if (X > 0 && Y >= 0)
                {
                    return Math.Atan(Y / X);
                }
                if (X > 0 && Y < 0)
                {
                    return Math.Atan(Y / X) + 2 * Math.PI;
                }
                if (X < 0)
                {
                    return Math.Atan(Y / X) + Math.PI;
                }
                if (X == 0 && Y > 0)
                {
                    return Math.PI / 2;
                }
                if (X == 0 && Y < 0)
                {
                    return 3 * Math.PI / 2;
                }
                else
                {
                    return 0;
                }

            }
        }
        public Point() : this(0, 0) { }
        public Point(double X, double Y)
        {
            this.X = X;
            this.Y = Y;
        }

        public override string ToString()
        {
            return $"X = {X}, Y = {Y}";
        }


    }




    class Program
    {
        static void Main(string[] args)
        {
            double x1;
            double y1;
            Point point1 = new Point(2.5, 3.8);
            Point point2 = new Point(3.5, 2.7);
            do
            {
                Console.WriteLine("Введите числа: ");
                double.TryParse(Console.ReadLine(), out x1);
                double.TryParse(Console.ReadLine(), out y1);

                Point point3 = new Point(x1, y1);
                if (point1.p < point2.p)
                {
                    if (point1.p < point3.p)
                    {
                        Console.WriteLine(point1.ToString());
                        if (point2.p > point3.p)
                        {
                            Console.WriteLine(point3);
                            Console.WriteLine(point2);
                        }
                        else
                        {
                            Console.WriteLine(point2);
                            Console.WriteLine(point1);
                        }
                    }
                    else
                    {
                        Console.WriteLine(point3);
                        Console.WriteLine(point1);
                        Console.WriteLine(point2);
                    }

                }
                else
                {
                    if (point1.p > point3.p)
                    {
                        if (point2.p > point3.p)
                        {
                            Console.WriteLine(point3);
                            Console.WriteLine(point2);
                            Console.WriteLine(point1);
                        }
                        else
                        {
                            Console.WriteLine(point2);
                            Console.WriteLine(point3);
                            Console.WriteLine(point1);
                        }
                    }
                    else
                    {
                        Console.WriteLine(point2);
                        Console.WriteLine(point1);
                        Console.WriteLine(point3);
                    }
                }
            } while (x1 != 0 || y1 != 0);
        }
    }
}
