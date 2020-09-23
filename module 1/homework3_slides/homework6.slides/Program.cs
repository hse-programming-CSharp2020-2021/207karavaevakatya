using System;
using System.Security.Cryptography.X509Certificates;

namespace homework7.slides
{
    class Program
    {
        static void Main(string[] args)
        {
           static void math1(double a, double b, double c)
            {
                double dis = b * b - 4 * a * c;
                Console.WriteLine((-b + Math.Sqrt(dis)) / (2 * a));
                Console.WriteLine((-b - Math.Sqrt(dis)) / (2 * a));
            }
            static void math2(double  a, double b, double c)
            {
                double dis = b * b - 4 * a * c;
                Console.WriteLine(-b/ (2 * a));
            }



            while (true)
            {
                double a, b, c, dis;
                int x;
                if (double.TryParse(Console.ReadLine(), out a) && double.TryParse(Console.ReadLine(), out b) && double.TryParse(Console.ReadLine(), out c))
                {
                    if ((a == 0 && b == 0 && c == 0) || (a==0 && b==0 && c !=0))
                        {
                        Console.WriteLine("False");
                        }
                       
                    else
                    { 

                    dis = b * b - 4 * a * c;
                    x = dis > 0 ? 2 : (dis == 0 ? 1 : 0);
                        switch (x)
                        {
                            case (2):
                                math1(a, b, c);
                                break;
                            case (1):
                                math2(a, b, c);
                                break;
                            case (0):
                                Console.WriteLine("False");
                                break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("False");
                }
            }
        }
    }
}
