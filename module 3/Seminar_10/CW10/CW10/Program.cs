using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Channels;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            int n;
            do
            {
                Console.WriteLine("Введите число");
            } while (!int.TryParse(Console.ReadLine(), out n) || n < 1 || n > 100);

            using (BinaryReader binaryReader = new BinaryReader(File.Open("../../../../123.dat", FileMode.OpenOrCreate)))
            {
                while (binaryReader.PeekChar() > -1)
                {
                    list.Add(binaryReader.ReadInt32());
                }
                Array.ForEach(list.ToArray(), x => Console.Write(x + " "));
                int ind = 0;
                for (int i = 0; i < list.Count; i++)
                {
                    if (Math.Abs(list[i] - n) < Math.Abs(list[ind] - n))
                    {
                        ind = i;
                    }
                }

                list[ind] = n;
            }

            using (BinaryWriter br = new BinaryWriter(File.Open("../../../../123.dat", FileMode.OpenOrCreate)))
            {
                for (int i = 0; i < list.Count; i++)
                {
                    br.Write(list[i]);
                }
            }

            Console.WriteLine("########");
            using (BinaryReader binaryReader =
                new BinaryReader(File.Open("../../../../123.dat", FileMode.OpenOrCreate)))
            {
                while (binaryReader.PeekChar() > -1)
                {
                    Console.Write(binaryReader.ReadInt32() + " ");
                }
            }
        }
    }
}