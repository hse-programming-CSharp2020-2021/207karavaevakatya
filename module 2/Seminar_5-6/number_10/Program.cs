using System;

namespace number_10
{
    class Circle
    {
        public double _x, _y;
        public double _r;
        public Circle()
        {
            _x = new Random().NextDouble() * (15-1) + 1;
            _y = new Random().NextDouble() * (15 - 1) + 1;
            _r = new Random().NextDouble() * (15 - 1) + 1;
        }
        public override string ToString()
        {
            return $"Центр в точке: {_x:f2},{_y:f2}; радиус = {_r:f2}";
        }
        public bool Сheck(Circle a)
        {
            if (a._r + _r <= Math.Sqrt(Math.Pow(a._x - this._x,2) + Math.Pow(a._y - this._y,2)))
                return true;
            else
            {
                return false;
            }
               
        }
       
    }
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int n;
                do
                {
                    Console.WriteLine("Введите n: ");
                } while (!int.TryParse(Console.ReadLine(), out n) || n < 0);

                Circle circle = new Circle();
                Console.WriteLine($"Отдельная окружность:{Environment.NewLine}" + circle);
                Circle[] arr = new Circle[n];
                for (int i = 0; i < n; i++)
                {
                    arr[i] = new Circle();
                    Console.WriteLine(arr[i]);
                }

                Console.WriteLine();
                Console.WriteLine("Пересекаются:");
                for (int i = 0; i < n; i++)
                {
                    if (arr[i].Сheck(circle))
                    {
                        Console.WriteLine(arr[i]);
                    }
                }
            }
        }
    }
}
