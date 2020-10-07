using System;

namespace CW7._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = 0;
            int z = 0;
            int[] a = { 1, -7, 2, 5,-4};
            int len = a.Length;
            int[] b = new int[len];
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] >= 0)
                {
                    a[m] = a[i];
                    m++;
                }
                else if (a[i] < 0)
                {
                    b[z] = a[i];
                    z++;
                }
            }
            Array.Resize(ref b, z);

            //foreach (int x in a)
            //{
            //    Console.Write(x + " ");
            //}
            //foreach (int x in b)
            //{
            //    Console.WriteLine(x + " ");
            //}
            for (int j = m; j < len; j++)
            {  
                a[j] = b[len - j -1];
            }

            foreach (int x in a)
            {
                Console.Write(x + " ");
            }


        }
    }
}
