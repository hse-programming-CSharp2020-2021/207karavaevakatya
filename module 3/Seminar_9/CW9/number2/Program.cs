using System;
using System.Collections.Generic;
using System.IO;

namespace number2
{
    class ColorPoint
    {
        public static string[] colors =
        {
            "Red", "Green",
            "DarkRed", "Magenta", "DarkSeaGreen", "Lime", "Purple",
            "DarkGreen", "DarkOrange", "Black", "BlueViolet", "Crimson",
            "Gray", "Brown", "CadetBlue"
        };

        public double x, y;
        public string color;

        public override string ToString()
        {
            string format = "{0:F3}    {1:F3}    {2}";
            return string.Format(format, x, y, color);
        }
    }

    class Test
    {
        static Random gen = new Random();

        public static void Main()
        {
            string path = @"..\..\..\..\MyTest.txt";
            int N; // Количество создаваемых объектов (число строк в файле)
            do
            {
                Console.WriteLine("Введите число: ");
            } while (!int.TryParse(Console.ReadLine(), out N) || N < 0);

            List<ColorPoint> list = new List<ColorPoint>();
            ColorPoint one;
            for (int i = 0; i < N; i++)
            {
                one = new ColorPoint();
                one.x = gen.NextDouble();
                one.y = gen.NextDouble();
                int j = gen.Next(0, ColorPoint.colors.Length);
                one.color = ColorPoint.colors[j];
                list.Add(one);
            }

            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate)))
            {
                foreach (var x in list)
                {
                    writer.Write(x.color);
                    writer.Write(x.x);
                    writer.Write(x.y);
                }
            }

            using (BinaryReader binaryReader = new BinaryReader(File.Open(path, FileMode.Open)))
            {
                while (binaryReader.PeekChar() != 0)
                {
                    Console.WriteLine(binaryReader.ReadString());
                }
            }
        }
    }
}
            
 