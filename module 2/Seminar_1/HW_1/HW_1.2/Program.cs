using System;
// Задание 3.
namespace HW_1._2
{
    class RegularPolygon
    {
        uint sidesNumber;
        double radius;
        public double P
        {

            get
            {
                return 2 * sidesNumber * radius * Math.Tan(Math.PI / sidesNumber);
            }
        }
        public double S
        {

            get
            {
                return sidesNumber * radius * radius * Math.Tan(Math.PI / sidesNumber);
            }
        }
        public RegularPolygon(uint sidesNumber = 3, double radius = 5)
        {
            this.sidesNumber = sidesNumber;
            this.radius = radius;
        }
        public string PolygonData()
        {
            return $"radius = {radius:f2}, sidesNumber ={sidesNumber:f2}, S = {S:f2}, P ={P:f2} ";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            uint s;
            double r;
            RegularPolygon[] arr = new RegularPolygon[0];
            do
            {

                do
                {
                    Console.WriteLine("введите радиус: ");
                } while (!double.TryParse(Console.ReadLine(), out r) || (r < 0));
                do
                {
                    Console.WriteLine("введите количество сторон: ");
                } while (!uint.TryParse(Console.ReadLine(), out s) || (s == 1) || (s == 2));
                if (r > 0 && s > 0)
                {
                    Array.Resize(ref arr, arr.Length + 1);
                    arr[arr.Length - 1] = new RegularPolygon(s, r);
                    for (int i = 0; i < arr.Length; i++)
                    {
                        Console.WriteLine(arr[i].PolygonData());

                    }
                    Console.WriteLine("**************");
                }

            } while (s != 0 || r != 0);

            //uint num;
            //do
            //{
            //    Console.WriteLine("введите количество элементов в массиве: ");
            //} while (!uint.TryParse(Console.ReadLine(), out num) || (num < 2));
            //            double r;
            //            uint s;
            //            RegularPolygon[] n = new RegularPolygon[num];
            //            double max = 0;
            //            int maxi=0;
            //            double min = double.MaxValue;
            //            int mini=0;
            //            for (int i = 0; i < num; i++)
            //            {

            //                do
            //                {
            //                    Console.WriteLine("введите радиус: ");
            //                } while (!double.TryParse(Console.ReadLine(), out r) || r <= 0);
            //                do
            //                {
            //                    Console.WriteLine("введите количество сторон: ");
            //                } while (!uint.TryParse(Console.ReadLine(), out s) || s < 3);
            //                n[i] = new RegularPolygon(s, r);
            //                if (n[i].S > max)
            //                {
            //                    max = n[i].S;
            //                    maxi = i;
            //;
            //                }
            //                if (n[i].S < min)
            //                {
            //                    min = n[i].S;
            //                    mini = i;
            //                }

            //            }
            //            for (int i = 0; i < num; i++)
            //            {
            //                if (i == mini)
            //                {
            //                    Console.ForegroundColor = ConsoleColor.Green;
            //                    Console.WriteLine(n[i].PolygonData());
            //                    Console.ResetColor();
            //                }
            //                else if (i ==maxi)
            //                {
            //                    Console.ForegroundColor = ConsoleColor.Red;
            //                    Console.WriteLine(n[i].PolygonData());
            //                    Console.ResetColor();
            //                }
            //                else
            //                {
            //                    Console.WriteLine(n[i].PolygonData());
            //                }
            //            }





            //RegularPolygon n;
            //n = new RegularPolygon();
            //do
            //{
            //    Console.WriteLine();
            //    double r;
            //    uint s;
            //    do
            //    {
            //        Console.WriteLine("введите радиус: ");
            //    } while (!double.TryParse(Console.ReadLine(), out r) || r <= 0);
            //    do
            //    {
            //        Console.WriteLine("введите количество сторон: ");
            //    } while (!uint.TryParse(Console.ReadLine(), out s) || s < 3);
            //    n = new RegularPolygon(s, r);
            //    Console.WriteLine(n.PolygonData());
            //    Console.WriteLine("Ecли хотите продолжить нажмите любую клавишу, иначе Esc");
            //} while (Console.ReadKey().Key != ConsoleKey.Escape);

        }
    }
}
