using System;

namespace homework4
{
    class Program
    {
        public static void math1()
        {
            for (int a = 1; a <= 20; a++)
            {
                for (int b = a + 1; b < 21; b++)
                {
                    for (int c = b + 1; c < 21; c++)
                    {
                        if (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2))
                        {
                            Console.WriteLine(a + "^2 + " + b + "^2 = " + c + "^2");
                        }
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            math1();
        }
    }
}
