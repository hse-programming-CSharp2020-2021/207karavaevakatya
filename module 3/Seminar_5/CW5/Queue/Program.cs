using System;

namespace Queue
{
    class Queue
    {
        private int[] arr;
        private int capacity;
        private int count;

        public Queue()
        {
            capacity = 1;
            arr = new int[1];
            count = 0;
        }

        public void Dequeue()
        {
            if (count == 0)
                return;
            for (int i = 0; i < count - 1; i++)
            {
                arr[i] = arr[i + 1];
            }
            count--;
            if (4 * count == capacity)
            {
                Array.Resize(ref arr, capacity / 2);
                capacity /= 2;
            }


        }

        public void Enqueue(int value)
        {
            if (count == capacity)
                Plus();
            arr[count++] = value;
        }

        public void Plus()
        {
            Array.Resize(ref arr, capacity * 2);
            capacity *= 2;
        }

        public int Peek()
        {
            if (count == 0)
                throw new ArgumentException("Stack is empty");
            return arr[0];
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Queue queue  = new Queue();
           queue.Enqueue(2);
           queue.Peek();
           
        }
    }
}