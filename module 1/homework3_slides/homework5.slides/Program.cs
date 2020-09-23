using System;

namespace homework6_slides
{
    class Program
    {

        static double Total(double k, double r, uint n)
        {
            double newr, sum;
            newr = Math.Pow((1 + r / 100), n);
            sum = k * newr;
            return sum;
        }
        static void Main(string[] args) 
        {
            while (true)
            {
                double k, r;
                uint n;
                if (double.TryParse(Console.ReadLine(), out k) && double.TryParse(Console.ReadLine(), out r) && uint.TryParse(Console.ReadLine(), out n))
                {
                    Console.WriteLine(Total(k, r, n));
                }
                else
                {
                    Console.WriteLine("error");
                }

            }
        }
    }
}
