using System;
using System.IO;

namespace _7654321
{
    class Program
    {
        public static int Gen()
        {
            Random rnd = new Random();
            return rnd.Next(10);
        }

        static void Main(string[] args)
        {
            string path = "1234";
            int n = 10;
            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Gen();
            }
            Array.ForEach(arr, x => Console.Write(x + " "));
            Console.WriteLine();
            using (StreamWriter st = new StreamWriter(path))
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    st.Write(arr[i] + " ");
                }
            }

            using (StreamReader streamReader = new StreamReader(path))
            {
                while (streamReader.Peek() > -1)
                {
                    Console.Write((char)streamReader.Read());
                }
            }

            string path1 = "12345.dat";
            using (BinaryWriter binaryW = new BinaryWriter(File.OpenWrite(path1)))
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    binaryW.Write(arr[i]);
                }
            }

            Console.WriteLine();
            using (BinaryReader binaryReader = new BinaryReader(File.Open(path1, FileMode.OpenOrCreate)))
            {
                while (binaryReader.PeekChar() > -1)
                {
                    Console.Write(binaryReader.ReadInt32() + " ");
                }

            }

            Console.WriteLine();
            string path3 = "1234456";
            using (FileStream fs = new FileStream(path3, FileMode.OpenOrCreate))
            {
                for (int i = 0; i < n; i++)
                {
                    byte[] byteArr1 = System.Text.Encoding.Default.GetBytes(arr[i].ToString() + " ");
                    fs.Write(byteArr1, 0, int.MaxValue);
                }
            }

            using (FileStream fs = new FileStream(path3, FileMode.OpenOrCreate))
            {
                byte[] byteArr2 = new byte[fs.Length];
                fs.Read(byteArr2,0,int.MaxValue);
                string str = System.Text.Encoding.Default.GetString(byteArr2);
                Console.WriteLine(str);
            }

        }
    }
}
