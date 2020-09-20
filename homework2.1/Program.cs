using System;

namespace homework2._1
{
    class Program
    {
        public static int Fun(int x)
        {
            int sum;
            sum = ((((12 * x) + 9) * x - 3) * x + 2) * x - 4; // в методе считаем значение функции
            return sum;
        }
        static void Main(string[] args)
        { 
            Console.WriteLine("Для выхода нажмите символ");
            while (true)
            {

                Console.WriteLine("введите x: ");
                int x;
                if (int.TryParse(Console.ReadLine(), out x))
                {
                    Console.WriteLine(Fun(x));
                }
                else
                {
                    return;
                }
            }
        }
    }
}
