using System;
using System.IO;

namespace _8._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = 0;
          //  File.WriteAllText("input.txt", "30 100 300 5 -7 9");
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
            int[] a = new int[arr1.Length];
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] >= 0 && arr1[i] <= 10000)
                {
                    m++;
                }
            }
            int k = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] >= 0 && arr1[i] <= 10000)
                {
                    a[k] = (int)Math.Pow(2, (int)Math.Log2(arr1[i]));
                    k++;
                }
            }
            Array.Resize(ref a, m);
          //  Console.WriteLine();
          //  Console.WriteLine(m);
          //  Array.ForEach(a, x => Console.Write(x + " "));
            string str = "";
            for (int i = 0; i < a.Length; i++)
            {
                str += a[i].ToString() + " ";
            }
            File.WriteAllText("output.txt", str);
        }
    }
}
