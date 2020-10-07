using System;
using System.Security.Cryptography.X509Certificates;

namespace CW6_1
{
    class Program
    {
        public static void Method(int n)
        {
            int ourn = n;
            int count = 0;
            //while (ourn != 0)
            //{
            //    count++;
            //    ourn /= 10;
            //}
            count = (int)(Math.Log10(n) + 1);
            Console.WriteLine(count);
            char[] arr = new char[count];
            for (int i = count - 1; n > 0; i--)
            {
                arr[i] = (char)(n % 10 + '0');
                n /= 10;
            }
            Array.ForEach(arr, x => Console.Write($"{x} "));
        }
        static void Main(string[] args)
        {
            int N;
            int.TryParse(Console.ReadLine(),out N);
            Method(N);
        }
    }
}