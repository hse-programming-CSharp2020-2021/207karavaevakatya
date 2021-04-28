using System;
using System.Collections;

namespace Number2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var rand = new RandomClass(n);
            foreach (var x in rand)
                Console.WriteLine(x);
        }
    }

    class RandomClass : IEnumerable
    {
        int n;

        public RandomClass(int n)
        {
            this.n = n;
        }

        public IEnumerator GetEnumerator()
        {
            return new RandomEnumer(n);
        }
    }

    class RandomEnumer : IEnumerator
    {
        int n;
        int currentPos;

        private static Random rnd = new Random();
        public RandomEnumer(int n)
        {
            this.n = n;
            currentPos = 0;
        }

        public object Current
        {
            get
            {
                return rnd.Next();
            }
        }

        public bool MoveNext()
        {
            if (currentPos >= n)
                return false;
            currentPos++;
            return true;
        }

        public void Reset()
        {
            currentPos = 0;
        }
    }
}