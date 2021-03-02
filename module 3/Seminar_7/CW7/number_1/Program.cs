using System;

namespace ConsoleApp23
{
    struct Coords
    {
        double x, y;

        public Coords(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return $"x = {x:f2}, y = {y:f2}";
        }
    }


    class Circle
    {

        double radius;
        Coords center;

        public Circle(double x, double y, double radius)
        {
            this.radius = radius;
            center = new Coords(x, y);
        }

        public double Length()
        {
            return 2 * Math.PI * radius;
        }

        public double Square()
        {
            return Math.PI * radius * radius;
        }

        public double Radius
        {
            get { return radius; }
            set
            {
                if (value < 0)
                    throw new ArgumentException();
                else
                    radius = value;
            }
        }

        public Coords Center
        {
            get { return center; }
            set { center = value; }
        }

        public override string ToString()
        {
            return $" center = {center}, Radius = {radius}," +
                   $" length = {Length()}, Square = {Square()}";
        }
    }




    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            try
            {
                for (int i = 0; i < 7; i++)
                {
                    Circle circle = new Circle(rand.NextDouble() * 10,
                        rand.NextDouble() * 10, rand.NextDouble() * 10);
                    Console.WriteLine(circle);
                }

            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}