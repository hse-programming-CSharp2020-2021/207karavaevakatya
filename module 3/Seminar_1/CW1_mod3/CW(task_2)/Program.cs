using System;

namespace CW2
{
    class Program
    {
        public delegate int[]  D1(int num);

        public delegate void D2(int[] num);

        public static int[] Method1(int num)
        {
            int[] arr = new int[(int)Math.Log10(num) + 1];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = num % 10;
                num /= 10;
            }
            Array.Reverse(arr);
            return arr;

        }
        public static void Method2(int[] num)
        {
            Array.ForEach(num, x => Console.Write(x + " "));

        }


        static void Main(string[] args)
        {
            int a = 12345;
            int[] arr = {10, 11, 12, 13, 14, 15, 16, 17, 18, 19};
            D1 dd = Method1;
            D2 dd2 = Method2;
            Console.WriteLine(dd?.Invoke(a));
            dd2.Invoke(arr);
            Console.WriteLine(dd.Target);
            Console.WriteLine(dd.Method);
            Console.WriteLine(dd2.Target);
            Console.WriteLine(dd2.Method);
          
            

        }
    }
}
