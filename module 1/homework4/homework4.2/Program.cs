using System;
using System.Dynamic;
using System.Threading;

namespace homework4._2
{
    class Program
    {
        public static void method()
        {
            int input;
            int sum_negat_numb = 0;
            int count = 0;
            while (sum_negat_numb >= -1000)
            {

                if (int.TryParse(Console.ReadLine(), out input))
                {
                    if (input < 0)
                    {
                        sum_negat_numb += input;
                        count++;

                    }
                }
                else
                {
                    break;
                }


            }
            double final = (double)sum_negat_numb / count;
            Console.WriteLine(final);
        }
        static void Main(string[] args)
        {
            method();
        }
    }
}

