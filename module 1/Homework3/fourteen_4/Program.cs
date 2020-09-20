using System;
using System.Security.Cryptography;

namespace fourteen_4
{
    class Program
    {
        public static void res(int x, int y, int z)
        {
            int a1;
            a1 = x < y ? (z < x ? z : x) : (y < z ? y : z); // находим наименьший номер(номер этажа проверять не имеет смысла, т.к. по условию просят вывести мин номер)
            Console.WriteLine(a1);
        }



        static void Main(string[] args)
        {
            int x, y,z;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out x) && int.TryParse(Console.ReadLine(), out y) && int.TryParse(Console.ReadLine(), out z))
                {
                    x = x % 100; // берем две последние цифры числа, которые означают номер аудитории 
                    y = y % 100;// берем две последние цифры числа, которые означают номер аудитории 
                    z = z % 100;// берем две последние цифры числа, которые означают номер аудитории 
                    res(x, y, z);
                }
                else
                {
                    Console.WriteLine("error");
                }

            }
        }
    }
}
