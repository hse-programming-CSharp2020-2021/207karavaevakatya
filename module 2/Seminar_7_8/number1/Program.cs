using System;
using ClassLibrary1;
namespace number_1
{

    class Program
    {
        static void Main()
        {
            A[] arr = new A[10];
            Random ran = new Random();
            for (int k = 0; k < arr.Length; k++)
                if (ran.Next(0, 3) % 2 == 0) arr[k] = new A(k);
                else arr[k] = new B(k);
            Console.WriteLine("Объекты класса A: ");
            foreach (A d in arr) d.GetA();
            Console.WriteLine("Объекты класса B: ");
            foreach (A d in arr)
                if (d is B) d.GetA();
            //// Самостоятельно для класса А!
            Console.WriteLine();
        }


    }
}
