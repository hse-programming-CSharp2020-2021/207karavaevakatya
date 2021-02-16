using System;
using System.Collections.Generic;
using System.Threading.Channels;

namespace CW5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.WriteLine("Введите число");
            } while (!int.TryParse(Console.ReadLine(), out n));

            LinkedList<int> list = new LinkedList<int>();
            while (n > 0)
            {
                list.AddLast(n % 10);
                n /= 10;
            }

            foreach (var x in list)
            {
                Console.Write(x + " ");
            }

            Console.WriteLine();
            int n1;
            do
            {
                Console.WriteLine("Введите число");
            } while (!int.TryParse(Console.ReadLine(), out n1));
            Stack<int> stack = new Stack<int>();
            int m = n1.ToString().Length;
            for (int i = 0; i < m; i++)
            {
                stack.Push(n1 % 10);
                n1 /= 10;
                Console.Write(stack.Peek() + " ");
            }
        }
    }
}