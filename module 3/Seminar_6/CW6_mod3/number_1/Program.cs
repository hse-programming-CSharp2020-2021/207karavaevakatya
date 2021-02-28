using System;

namespace ConsoleApp1
{
    abstract class Figure
    { 
        public int a =5;
       public abstract void Print();
    }

    interface IS
    {
        public int Square(int a);

    }

    interface IP
    {
        public int Perimeter(int a);
    }

    class Square : Figure, IP
    {
        public override void Print()
        {
            Console.WriteLine("Square p = " + Perimeter(a));
        }

        public int Perimeter(int a)
        {
            return a * a;
        }
    }

    class Triangle: Figure,IP
    {
        public override void Print()
        {
            Console.WriteLine("Triangle P = " + Perimeter(a));
        }

        public int Perimeter(int a)
        {
            return (int)(a * a * Math.Sqrt(3) / 4);
        }
    }

    class Cube: Figure,IS
    {
        public override void Print()
        {
            Console.WriteLine("Cube S = " + Square(a));
        }

        public int Square(int n)
        {
            return 6 * n* n;
        }

       
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Figure[] arr = new Figure[10];
            for (int i = 0; i < 10; i++)
            {
                if (rnd.Next(0, 3) == 0)
                {
                    arr[i] = new Triangle();
                }
                else if (rnd.Next(0, 3) == 1)
                {
                    arr[i] = new Square();
                }
                else
                {
                    arr[i] = new Cube();
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i].Print();
            }
        }
    }
}