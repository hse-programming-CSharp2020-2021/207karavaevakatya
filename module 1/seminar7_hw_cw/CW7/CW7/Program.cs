using System;

namespace CW7
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
                    if (i > j)
                    {
                        arr[i, j] = -1;
                    }
                    else if (i == j)
                    {
                        arr[i, j] = 0;
                    }
                    else
                    {
                        arr[i, j] = 1;
                    }

                }
            }
                for (int  i = 0;  i < n;  i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write(" " + arr[i, j] + " ");
                    }
                  Console.WriteLine();
                }

            }
        }
    }

