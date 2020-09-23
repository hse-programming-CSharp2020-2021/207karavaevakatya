using System;

namespace homework7_slides
{
    class Program
    {
        public static bool boo(double a, double b, double c)
        {
            double dis = b * b - 4 * a * c;
            if ((a == 0 && b == 0 && c != 0) || (a == 0 && b == 0 && c == 0))
            {
                return false;
            }
            return true;

        }
        static string sq(double a, double b, double c)
        {
            double x1, x2;
            double dis1 = b * b - 4 * a * c;
            string ans;
            if (boo(a, b, c) == true)
            {
                if ((dis1 > 0) && a != 0 && b != 0 && c != 0)
                {
                    x1 = (-b + Math.Sqrt(dis1)) / (2 * a);
                    x2 = (-b - Math.Sqrt(dis1)) / (2 * a);
                    ans = x1 + " " + x2;
                    return ans;
                }
                else if (dis1 == 0 && a != 0 && b != 0 && c != 0)
                {
                    x1 = -b / 2 * a;
                    ans = x1.ToString();
                    return ans;
                }
                else if ((a != 0 && b == 0 && c == 0) || (a == 0 && b != 0 && c == 0))
                {
                    x1 = 0;
                    ans = x1.ToString();
                    return ans;
                }
                else if (a != 0 && b != 0 && c == 0)
                {
                    x1 = 0;
                    x2 = -(b / a);
                    ans = x1 + " " + x2;
                    return ans;

                }
                else if (a != 0 && b == 0 && c != 0 && c < 0)
                {
                    c = -c;
                    x1 = Math.Sqrt(c / a);
                    x2 = -(Math.Sqrt(c / a));
                    ans = x1 + " " + x2;
                    return ans;

                }

            }
            return "нет корней";


        }

        static void Main(string[] args)
        {
            double a, b, c;
            if (double.TryParse(Console.ReadLine(), out a) && (double.TryParse(Console.ReadLine(), out b) && (double.TryParse(Console.ReadLine(), out c))))
            {
                if (boo(a, b, c) == true)
                {
                    Console.WriteLine(sq(a, b, c));
                }

                else
                {
                    Console.WriteLine("нет корней");
                }
            }
            else
            {
                Console.WriteLine("ошибка");
            }
        }
    }
}

