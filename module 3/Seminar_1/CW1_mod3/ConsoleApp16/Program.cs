using System;
using System.Text.RegularExpressions;

namespace ConsoleApp1333
{
    class Program
    {
        public delegate int Operations(ref int x, ref int y);
        public static int Multiple(ref int x1, ref int y1)
        {
            return x1 * y1;
        }

        public static int Sum(ref int a, ref int b)
        {
            a = a + b;
            Console.WriteLine("from Sum");
            return a + b;
        }

        public static int Min(ref int a, ref int b)
        {
            b = a - b;
            Console.WriteLine("From Min");
            return a - b;
        }

        public static int Invoke(Operations op, ref int a, ref int b)
        {
            return op.Invoke(ref a, ref b);
        }
        static void Main(string[] args)
        {
            int a = 5, b = 3;
            Operations op1 = Min;
            op1 += Min;
            Operations op = Min;
            op += Sum;
            op += Multiple;
            Console.WriteLine(Invoke(op, ref a, ref b));
            Console.WriteLine("**");
            op -= Sum;
            Console.WriteLine(Invoke(op, ref a, ref b));
            Console.WriteLine("**");
            Operations op2 = op1 + op;
            Console.WriteLine(Invoke(op2, ref a, ref b));
        }
    }
}