using System;

namespace ConsoleApp3
{
    interface ISequence
    {
        double GetElement(int ind);
    }

    class ArithmeticPrograssion:ISequence
    {
        private double fistelement;
        private double d;
        public ArithmeticPrograssion( double fistelement, double d)
        {
            this.fistelement = fistelement;
            this.d = d;
        }
        public double GetElement(int ind)
        {
            return fistelement + d * (ind - 1);
        }
    }

    class GeometricPrograssion:ISequence
    {
        private double fistelement;
        private double q;
        public GeometricPrograssion(double fistelement, double q)
        {
            this.fistelement = fistelement;
            this.q = q;
        }
        public double GetElement(int ind)
        {
            return fistelement * Math.Pow(q, ind - 1);
        }
    }
    class Program
    {
        public static double Sum(ISequence progr, int n)
        {
            double s= 0;
            for (int i = 0; i<n; i++)
            {
                s += progr.GetElement(i+1);
            }
            return s;
        }
        static void Main(string[] args)
        {
            var sum = Sum(new ArithmeticPrograssion(1, 10), 5);
            Console.WriteLine(sum);
        }
    }
}