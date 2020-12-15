using System;

namespace number_11
{
    class GeometricProgression
    {
        double _start { get;}
        double _increment { get; }

        public GeometricProgression()
        {
            _increment = 1;
            _start = 0;
        }
        public GeometricProgression(double start, double increment)
        {
            _start = start;
            _increment = increment;
        }
        public double this[int ind]
        {
            get => _start * Math.Pow(_increment, ind - 1);
        }
        public double GetSum(int n)
        {
            double count = 0;
            for (int i = 1; i <= n; i++)
            {
                count += this[i];
            }
            return count;
        }
        public override string ToString()
        {
            return $"b.0 = {_start:f3} ; q = {_increment:f3}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
           
                var rnd = new Random();
                int n = rnd.Next(5, 16);
                GeometricProgression geometric = 
                    new GeometricProgression(rnd.NextDouble() * (10 - 0), rnd.NextDouble() * (15 - 5) + 5);
                Console.WriteLine("Последовательность: ");
                Console.WriteLine(geometric);
                Console.WriteLine("\n");
                int delta = rnd.Next(3, 16);
                GeometricProgression[] arr = new GeometricProgression[n];
                Console.WriteLine($"Эти последовательности с элемент d{delta} больше главной: ");
                for (int i = 0; i < n; i++)
                {
                    double _start = rnd.NextDouble() * 10;
                    double _increment = rnd.NextDouble() * (15 - 5) + 5;
                    arr[i] = new GeometricProgression(_start, _increment);
                    if ((arr[i])[delta] > geometric[delta])
                    {
                        Console.WriteLine(arr[i]);
                    }
                }

                Console.WriteLine("**************");
                Console.WriteLine("Array: ");
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine(arr[i]);

                    Console.WriteLine($"Сумма c 1 по {delta}: {arr[i].GetSum(delta):f3}");
                }
        }
    }
}
