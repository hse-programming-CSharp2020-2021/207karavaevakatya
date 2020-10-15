using System;
using System.IO;

namespace _8._4
{
    class Program
    {
        static void Main(string[] args)
        {
           // File.WriteAllText("input.txt", "2 3 5 12 -23 34 -5346 0 543 -45 -9");
            string s = File.ReadAllText("input.txt");
            string[] arr = s.Split(" ");
            Array.ForEach(arr, x => Console.Write(x + " "));
            int[] arr1 = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr1[i] = Convert.ToInt32(arr[i]);
            }
            Console.WriteLine();
            Array.ForEach(arr1, x => Console.Write(x + " "));
            int sch = 0;
            bool[] boarr = new bool[arr1.Length];
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] >= -10 && arr1[i] <= 10)
                {
                    if (arr1[i] <= 10 && arr1[i]>= 0)
                    {
                        boarr[sch] = true;
                    }
                    else
                    {
                        boarr[sch] = false;
                    }
                    sch++;
                }
            }
            Array.Resize(ref boarr, sch);
            Console.WriteLine();
            Array.ForEach(boarr, x => Console.Write(x + " "));
            string str = "";
            for (int i = 0; i < boarr.Length; i++)
            {
                str += boarr[i].ToString() + " ";
            }
            File.WriteAllText("output.txt", str);
        }
    }
}
