﻿using System;

namespace CW7._1
{
    class Program
    {

        static void Main(string[] args)
        {
            int n;
            int.TryParse(Console.ReadLine(), out n);
            int[,] arr = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i > n - j - 1)
                    {
                        arr[i, j] = 1;
                    }
                    else if (i == n - j -1)
                    {
                        arr[i, j] = 0;
                    }
                    else
                    {
                        arr[i, j] = -1;
                    }

                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0, 4}", arr[i, j]);
                }
                Console.WriteLine();
            }

        }
    }
}
