using System;

namespace homework2._4
{
    class Program
    {
        public static void function(int x)
        {
            while (x != 0)
            {
                Console.Write(x%10);  //так как нам нужно перевернуть число,мы просто будем выводить его последнюю цыфру 
                x /= 10; //но при этом удаляя каждый раз уже выведенную
            }
        }
        static void Main(string[] args)
        {
            int x;
            while (true)
            {
                Console.WriteLine("введите число: ");

                if (int.TryParse(Console.ReadLine(), out x))
                {
                    function(x);
                    Console.WriteLine();
                }
                else
                {
                    return;
                }

            }
        }
    }
}