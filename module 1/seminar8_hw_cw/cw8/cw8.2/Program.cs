using System;
using System.IO; namespace Project2
{
    class Program
    {
        static int Dec(string s)
        {
            int x = 0;

            for (int i = 0; i < s.Length; ++i)

                x = x * 2 + s[i] - '0';

            return x;

        }
        static void Main(string[] args)

        {

            string s = File.ReadAllText("../../../../IntNumber");

            Console.WriteLine(Dec(s));

        }

    }

}

