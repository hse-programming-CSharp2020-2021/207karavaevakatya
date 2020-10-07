using System;
// Sem_04; задача 6
namespace homework7._9
{
    class Program
    {
        public static void M(int x, int y)
        {
            int det1 = 0;
            int det2 = 0;
            Random rnd = new Random();
            int[,] a = new int[x, y];
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    a[i, j] = rnd.Next(0, 21);
                }
            }
            det1 = det1 + a[0, 0] * a[1, 1] * a[2, 2];
            det1 = det1 + a[0, 1] * a[1, 2] * a[2, 0];
            det1 = det1 + a[0, 2] * a[1, 0] * a[2, 1];
            det1 = det1 - a[0, 0] * a[1, 2] * a[2, 1];
            det1 = det1 - a[0, 1] * a[1, 0] * a[2, 2];
            det1 = det1 - a[0, 2] * a[1, 1] * a[2, 0];

            det2 = det2 + a[0, 3] * a[1, 4] * a[2, 5];
            det2 = det2 + a[0, 4] * a[1, 5] * a[2, 3];
            det2 = det2 + a[0, 5] * a[1, 3] * a[2, 4];
            det2 = det2 - a[0, 3] * a[1, 5] * a[2, 4];
            det2 = det2 - a[0, 4] * a[1, 3] * a[2, 5];
            det2 = det2 - a[0, 5] * a[1, 4] * a[2, 3];

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write("{0,3}", a[i, j]);
                }
                Console.WriteLine();
            }
            int[] arr = new int[2];
            arr[0] = det1;
            arr[1] = det2;
            foreach (int number in arr)
            {
                Console.WriteLine(number + " ");
            }

        }



        static void Main(string[] args)
        {

            int x = 3;
            int y = 6;
            M(x, y);
            Console.WriteLine();

        }
    }
}
