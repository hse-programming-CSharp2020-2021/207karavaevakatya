using System;

namespace hw7
{
    class Program
    {
        public static void Method(int n)
        {
            int dir = 0;
            int k = 1;
            int m = 0;
            int[,] a = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {

                    
                    if (dir == 0 && j < n)
                    {
                        a[i, j] = k;
                        k++;
                    }
                    else
                    {
                        dir = 2;
                    }
                    if (dir == 2 && j == n-1)
                    {
                        a[i, j] = k;
                        k++;
                    }
                    else
                    {
                        dir = 3;
                    }
                    if (dir == 3 && j < n - 1)
                    {
                        a[i, j] = k;
                        k++;
                    }
                    else
                    {
                        dir = 4;
                    }  
                    if (dir ==4 && i==m)
                    {
                        a[i, j] = k;
                        k++;

                    }
                    else
                    {
                        m++;
                        dir = 1;
                        n--;
                    }
                    
                }
            }
            //Console.WriteLine(a.GetLength(1));



            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }

        }
        public static bool Read(out int n)
        {
            return int.TryParse(Console.ReadLine(), out n);
        }
        static void Main(string[] args)
        {
            while (true)
            {
                int n;
                do Console.WriteLine("Введите числа: ");
                while (!Read(out n));
                Method(n);

            }
        }
    }
}
