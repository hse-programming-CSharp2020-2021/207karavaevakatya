using System;
// сжатый массив (неотрицательные)
namespace cw6_0
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { -1, 1, -2, 3, -4, 4, -5, 6 };
            int m = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] >= 0)
                {
                    a[m] = a[i];
                    m++;
                }
            }
            if (m > 0)
                Array.Resize(ref a, m);
            foreach (int x in a)
            {
                Console.WriteLine(x + " ");
            }


        }
    }
}
