using System;

using System.IO;
namespace cw8

{

    class Program

    {

        static string Bin(int x)

        {

            string s = "";

            while (x > 0)

            {

                s = (x % 2).ToString() + s;

                x /= 2;

            }

            return s;

        }

        static void Main(string[] args)

        {

            {

                int x;
                do

                {
                    Console.Write("Введите x: ");
                } while (!int.TryParse(Console.ReadLine(), out x));

                File.WriteAllText("../../../../IntNumber", Bin(x));

            }
        }

    }
}
