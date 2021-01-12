using System;

namespace CW1
{
    class Program
    {
        public delegate int Cast(double num);
        static void Main(string[] args)
        {
            double a = 3.6;
            Cast AnyDelegate1 = delegate (double x) {
                if ((int)x % 2 == 0) { return (int)x; }
                else { return (int)(x + 1); }
            };
            Cast AnyDelegate2 = delegate (double x) {
                return (int)Math.Log10(x) + 1;
            };
            Console.WriteLine(AnyDelegate1?.Invoke(a));
            Console.WriteLine(AnyDelegate2?.Invoke(a));
            Console.WriteLine("******");
            Cast AnyDelegate11 = x =>
            {
                if ((int)x % 2 == 0) { return (int)x; }
                else { return (int)(x + 1); }
            };
            Cast AnyDelegate22 = x => (int)Math.Log10(x) + 1;

            Cast cast12 = AnyDelegate11 + AnyDelegate22;
            Console.WriteLine(cast12?.Invoke(a));
            Console.WriteLine("***");
            Console.WriteLine("Target" + cast12.Target);
            Console.WriteLine("***");
            Console.WriteLine("Method" + cast12.Method);
        }
    }
}
