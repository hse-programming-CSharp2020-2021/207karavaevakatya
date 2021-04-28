using System;
using System.Collections;

namespace CW4_mod4
{
    class Fibbonacci
    {
        public int Current { get; set; } = 1;
        public int Previous { get; set; } = 0;

        internal IEnumerable nextMemb(int n)
        {
            Current = 1;
            Previous = 0;
            for (int i = 0; i < n; i++)
            {
                int ans = Current;
                Current += Previous;
                Previous = ans;
                yield return Current;
            }

            yield break;
        }
    }

    class TriangleNums
    {

        internal IEnumerable nextMemb2(int n)
        {
            for (int i = 0; i < n; i++)
            {
                yield return (i * (i + 1)) * 0.5;
            }

            yield break;
        }

    }

    class Program
    {

        static void Main()
        {

            Fibbonacci fi = new Fibbonacci();
            TriangleNums tr = new TriangleNums();

            foreach (var numb in fi.nextMemb(7))

                Console.Write(numb + "  ");

            Console.WriteLine();



            foreach (var numb in tr.nextMemb2(7))

                Console.Write(numb + "  ");

            Console.WriteLine();
            int n = 7;
            IEnumerator fi2 = new Fibbonacci().nextMemb(n).GetEnumerator();
            IEnumerator tr2 = new TriangleNums().nextMemb2(n).GetEnumerator();
            for (int iterator = 0; iterator < n; iterator++)
            {
                fi2.MoveNext();
                tr2.MoveNext();
                Console.WriteLine((int)fi2.Current + (double)tr2.Current);

            }

        }

    }
}