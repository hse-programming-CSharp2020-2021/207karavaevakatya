using System;
using System.Linq;
using System.Threading.Channels;

namespace Extra1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            var rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                arr[i] = rnd.Next(-20, 21);
            }
            Array.ForEach(arr, x => Console.Write(x + " "));
            int max = arr.Max();
            Console.WriteLine();
            arr = Array.ConvertAll(arr, x => x / max);
            Array.ForEach(arr, x => Console.Write(x + " "));


        }
    }
}
