using System;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp1
{
    public class TestClass
    {
        static void Main()
        {
            Random rnd = new Random();

            Shape[] sh = new Shape[rnd.Next(3, 5)];
            for (int i = 0; i < sh.Length; i++)
            {
                if (i % 2 == 0)
                    sh[i] = new Circle(rnd.Next(3, 5));
                else
                    sh[i] = new Cylinder(rnd.Next(3, 5), rnd.Next(3, 5));

            }
            Array.Sort(sh);

            foreach (var i in sh)
            {
                Console.WriteLine(i.Area());
            }

            foreach (var i in sh)
            {
                if (i is Circle)
                {
                    Console.WriteLine($"Circle, S = {i.Area():f2}");
                }
                else
                {
                    Console.WriteLine($"Cylinder, S = {i.Area():f2}");
                }
            }





        }
        public class Shape : IComparable
        {
            public const double PI = Math.PI;
            protected double x, y;

            public Shape()
            {
            }

            public Shape(double x, double y)
            {
                this.x = x;
                this.y = y;
            }

            public virtual double Area()
            {
                return x * y;
            }

            public int CompareTo(object i)
            {
                if (i is Circle)
                    return 1;
                else
                    return -1;
            }
        }

        public class Circle : Shape
        {
            public Circle(double r) : base(r, 0)
            {
            }

            public override double Area()
            {
                return PI * x * x;
            }
        }

        class Sphere : Shape
        {
            public Sphere(double r) : base(r, 0)
            {
            }

            public override double Area()
            {
                return 4 * PI * x * x;
            }
        }

        class Cylinder : Shape
        {
            public Cylinder(double r, double h) : base(r, h)
            {
            }

            public override double Area()
            {
                return 2 * PI * x * x + 2 * PI * x * y;
            }
        }
    }






}
