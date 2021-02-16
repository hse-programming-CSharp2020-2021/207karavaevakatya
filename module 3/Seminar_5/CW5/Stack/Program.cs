using System;

namespace Stack
{
    class Stack
    {
        private int[] arr;
        private int capacity;
        private int count;

        public Stack()
        {
            capacity = 1;
            arr = new int[1];
            count = 0;
        }

        public void Push(int value)
        {
            if (count == capacity)
                Plus();
            arr[count++] = value;
        }

        void Plus()
        {
            Array.Resize(ref arr, capacity*2);
            capacity *= 2;
        }



        public void Pop()
        {

            if (count != 0)
                count--;
            if (count * 4 == capacity)
            {

                Array.Resize(ref arr, capacity / 2);
                capacity /= 2;
            }


        }

        public bool isEmpty()
        {
            
            return count==0;
        }

        public int Top()
        {
            if (count == 0)
                throw new ArgumentException("Stack is empty");
            return arr[count - 1];
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Stack stack = new Stack();
                stack.Push(1);
                stack.Pop();
                stack.Top();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
               
            }
           

        }
    }
}