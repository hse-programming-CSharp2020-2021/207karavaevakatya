using System;

namespace CW8
{
    interface IFigure {
        double Area { get; }
        string ToString();
    }
    public class Circle : IFigure {
        int r;
        public Circle(int r) => this.r = r;
        public double Area => Math.PI* Math.Pow(r, 2);
        public override string ToString() => $"side of the circle = {r}";
    } 

    public class Square : IFigure
    {
        int len;
        public Square(int len) => this.len = len;
        public double Area => Math.Pow(len, 2);
        public override string ToString() => $"side of the square = {len}";
    }
    

    class Program
    {
        public static void Print<T>(T[] arr, double count) where T : IFigure
        {
            foreach (var x in arr)
                if (x.Area > count)
                    Console.WriteLine(x);
        }

        static void Main(string[] args)
        {
            var rnd = new Random();
            int n = 5;
            Square[] squares = new Square[n];
            Circle[] circles = new Circle[n];
            Console.WriteLine("***********");
            for (int i = 0; i <n ; i++)  {
                squares[i] = new Square(rnd.Next(1,11));
                circles[i] = new Circle(rnd.Next(1,11));
                Console.WriteLine(squares[i]);
                Console.WriteLine(circles[i]);
            }

            Console.WriteLine("************");
            Print(squares, 5);
            Print(circles, 5);


        }
    }
}