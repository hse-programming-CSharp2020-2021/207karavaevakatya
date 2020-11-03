using System;

namespace CW_2
{
    class LatinChar
    {
        char _char;
        public LatinChar(char let = 'a')
        {
            if (let >= 'A' && let <= 'Z' || let >= 'a' && let <= 'z')
                _char = let;
            else
                Console.WriteLine("error");
        }
        public char Char
        {
            get
            {
                return _char;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            LatinChar L = new LatinChar();
            char minChar, maxChar;
            do
            {
                Console.WriteLine("введите символы: ");
            } while (!char.TryParse(Console.ReadLine(), out minChar) || !char.TryParse(Console.ReadLine(), out maxChar));
            for (char i = minChar; i <= maxChar; i++)
            {
                L = new LatinChar(i);
                Console.WriteLine(L.Char);
            }
        }
    }
}