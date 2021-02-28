using System;

namespace ConsoleApp2
{
    interface ICalculation
    {
        double Perform(double value);
    }

    class Add:ICalculation
    {
        private double k;
        public Add(double k)
        {
            this.k = k;
        }
        public double Perform(double value)
        {
            return value + k;
        }
    }
    class Multiply:ICalculation
    {
        private double k;
        public Multiply(double k)
        {
            this.k = k;
        }
        public double Perform(double value)
        {
            return value*k;
        }
    }
    
    class Program
    {
        static void Calculate(double a, double b, double c)
        {
            Add add = new Add(a);
            Multiply multiply = new Multiply(a);
            double ans = add.Perform( multiply.Perform(b));
            Console.WriteLine(ans);
        }
        static void Main(string[] args)
        {
            Calculate(1,2,3);
        }
    }
}