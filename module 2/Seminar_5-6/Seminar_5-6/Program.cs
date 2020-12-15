using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace Number_8
{
    class Point
    {
        double x, y;
        public double X
        {
            get => x;
        }
        public double Y
        {
            get => y;
        }
        public Point() { }
        public Point(double xi, double yi)
        {
            x = xi;
            y = yi;
        }
        public override string ToString()
        {
            return $"x: {x:f2}, y: {y:f2}";
        }
    }
    class Triangle
    {
        Point a, b, c;
        public Triangle() { }

        public Triangle(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            a = new Point(x1, y1);
            b = new Point(x2, y2);
            c = new Point(x3, y3);
        }
        public Triangle(Point ai, Point bi, Point ci)
        {
            a = ai;
            b = bi;
            c = ci;
        }
        public Point[] GetPoints
        {
            get => new Point[] { a, b, c };
        }
        public double Perimeter
        {
            get =>
                Math.Sqrt((a.X - b.X) * (a.X - b.X) + (a.Y - b.Y) * (a.Y - b.Y)) +
                Math.Sqrt((a.X - c.X) * (a.X - c.X) + 
                Math.Sqrt((c.X - b.X) * (c.X - b.X) + (c.Y - b.Y) * (c.Y - b.Y)) + (a.Y - c.Y) * (a.Y - c.Y));
        }
        public double Area
        {
            get
            {
                double a1Sqrt;
                a1Sqrt = Math.Sqrt((a.X - b.X) * (a.X - b.X) + (a.Y - b.Y) * (a.Y - b.Y));
                double a2Sqrt = Math.Sqrt((a.X - c.X) * (a.X - c.X) + (a.Y - c.Y) * (a.Y - c.Y));
                double a3Sqrt = Math.Sqrt((c.X - b.X) * (c.X - b.X) + (c.Y - b.Y) * (c.Y - b.Y));
                double p = (a1Sqrt + a2Sqrt + a3Sqrt) / 2;
                return Math.Sqrt(p * (p - a1Sqrt) * (p - a2Sqrt) * (p - a3Sqrt));
            }
        }
        public override string ToString()
        {
            return $"Вершины:{Environment.NewLine}{a.ToString()}{Environment.NewLine}{b.ToString()}{Environment.NewLine}" +
                   $"{c.ToString()}{Environment.NewLine}S: {this.Area:f2}{Environment.NewLine}P: {this.Perimeter:f2}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int n = rnd.Next(5, 16);
            double[] el = new double[6];
            Triangle[] tr = new Triangle[n];
            Console.WriteLine($" Количество треугольников: {n}");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    el[j] = rnd.NextDouble() * (10 + 10) - 10;
                }

                tr[i] = new Triangle(el[0], el[1], el[2], el[3], el[4], el[5]);
                Console.WriteLine(tr[i]);
            }

            Array.Sort(tr,
                (x, y) =>
                {
                    if (x.Area < y.Area)
                        return 1;
                    else
                        return -1;
                });
            Console.WriteLine("*******************************");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(tr[i]);
            }

        }
    }
}