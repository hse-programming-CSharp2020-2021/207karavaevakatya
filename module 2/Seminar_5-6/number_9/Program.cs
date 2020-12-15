using System;

namespace number_9
{
    class LinearEquation
    {
        private int _a;
        private int _b;
        private int _c;

        public LinearEquation(int _a, int _b, int _c)
        {
            this._a = _a;
            this._b = _b;
            this._c = _c;
        }

        public double Solve()
        {
            if (_a == 0)
            {
                throw new ArgumentException("Корней нет");

            }
            return (_c - _b) / _a;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int n;
            do
            {
                Console.WriteLine("Введите число n");
            } while (!int.TryParse(Console.ReadLine(), out n) || n <= 0);

            LinearEquation[] ln = new LinearEquation[n];
            for (int i = 0; i < n; i++)
            { 
                ln[i] = new LinearEquation(rnd.Next(0,1), rnd.Next(-10, 11), rnd.Next(-10, 11));
            }

            for (int i = 0; i < n; i++)
            {
                try
                {
                    Console.WriteLine(ln[i].Solve());
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }

        }
    }
}