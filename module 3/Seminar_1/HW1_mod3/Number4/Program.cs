using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Channels;

namespace Number4
{
    // Делегат-тип.
    delegate void Steps();

    class Program
    {
        public static int ValidateInteger(string message)
        {
            int num;
            Console.WriteLine(message);
            while (!int.TryParse(Console.ReadLine(), out num) || (num <= 0) || (num > 10))
            {
                Console.WriteLine("Try again!");
                Console.WriteLine(message);
            }

            return num;
        }

        public static int Check_to_continue()
        {
            int n;
            do
            {
                Console.WriteLine("If you want to continue enter 1, otherwise enter 0");
            } while (!int.TryParse(Console.ReadLine(), out n) || (n < 0) || (n > 1));

            return n;
        }




        static void Main(string[] args)
        {
            int flag = 1;
            while (flag == 1)
            {
                int max_X = ValidateInteger("Enter the maximum number of columns (from 1 to 10)");
                int max_Y = ValidateInteger("Enter the maximum number of lines (from 1 to 10)");
                Console.Clear();
                Robot robot = new Robot(max_X, max_Y);
                Console.Write("Now enter the commands (on the line without spaces):" +
                              " R(Right), L(Left), F(Forward), B(Backward): ");
                string commands = Console.ReadLine();
                Steps Chain = delegate () { };
                for (int i = 0; i < commands.Length; i++)
                {
                Again:
                    if (commands[i] == 'R')
                    {
                        Chain += robot.Right;
                    }
                    else if (commands[i] == 'L')
                    {
                        Chain += robot.Left;
                    }
                    else if (commands[i] == 'F')
                    {
                        Chain += robot.Forward;
                    }
                    else if (commands[i] == 'B')
                    {
                        Chain += robot.Backward;
                    }
                    else
                    {
                        Console.WriteLine("You entered the commands incorrectly, try again!");
                        Console.Write(" P.S: R(Right), L(Left), F(Forward), B(Backward): ");
                        commands = Console.ReadLine();
                        goto Again;
                    }
                }

                Console.Clear();
                Chain += robot.Print;
                try
                {
                    Chain?.Invoke();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    flag = Check_to_continue();
                    Console.Clear();
                }
            }
        }
    }
}

class Robot
{
    // Положение робота на плоскости. 
    int x, y;
    private int max_X, max_Y;
    HashSet<(int, int)> xy = new HashSet<(int, int)>();
    public Robot(int maxX, int maxY)
    {
        max_X = maxX;
        max_Y = maxY;
    }
    // Направо.
    public void Right()
    {
        xy.Add((x, y));
        x++;
        if (x > max_X)
            throw new ArgumentException();
    }
    // Налево.
    public void Left()
    {
        xy.Add((x, y));
        x--;
        if (x < max_X)
            throw new ArgumentException();
    }
    // Вперед.
    public void Forward()
    {
        xy.Add((x, y));
        y++;
        if (y > max_Y)
            throw new ArgumentException();
    }
    // Назад.
    public void Backward()
    {
        xy.Add((x, y));
        y--;
        if (x < max_Y)
            throw new ArgumentException();
    }

    public string Position()
    {  // Сообщить координаты.
        return String.Format("The Robot position: x={0}, y={1}", x, y);
    }

    public void Print()
    {
        for (int i = 0; i < max_Y; i++)
        {
            for (int j = 0; j < max_X; j++)
            {

                if (xy.Contains((j, i)))
                {

                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("+");
                    Console.ResetColor();

                }
                else if ((i == y) && (j == x))
                {

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write('*');
                    Console.ResetColor();
                }
                else
                {
                    Console.Write(" ");
                }
            }

            Console.WriteLine();
        }
    }
}


