using System;

namespace HW5
{
    class Node
    {
        public Node(int data)
        {
            Data = data;
        }
        public int Data { get; set; }
        public Node Next { get; set; }
        public override string ToString()
        {
            return $"{Data}";
        }
    }

    class Stack
    {
        Node head;
        public int Count { get; set; }
        public bool IsEmpty
        {
            get { return Count == 0; }
        }
        public void Push(int item)
        {
            Node node = new Node(item);
            node.Next = head;
            head = node;
            Count++;
        }
        public int Pop()
        {
            //if (!IsEmpty)
            //{
            Node temp = head;
            head = head.Next;
            Count--;
            return temp.Data;
            //}
        }
        public int Peek()
        {
            //if (!IsEmpty)
            //{
            return head.Data;
            //}
        }
        public void Print()
        {
            Node current = head;
            while (current != null)
            {
                Console.Write(current + " ");
                current = current.Next;
            }
            Console.WriteLine();
        }
    }

    class Queue
    {
        Node tail, head;
        public int Count { get; set; }
        public bool isEmply
        {
            get
            {
                return Count == 0;
            }
        }

        public void Enqueue(int data)
        {
            Node node = new Node(data);
            Node tempNode = tail;
            tail = node;
            if (Count == 0)
                head = tail;
            else
                tempNode.Next = tail;
            Count++;
        }
        public int Dequeue()
        {
            //if (Count == 0)
            int output = head.Data;
            head = head.Next;
            Count--;
            return output;
        }
        public int First()
        {
            return head.Data;
        }
        public int Last()
        {
            return tail.Data;
        }
        public void Print()
        {
            Node current = head;
            while (current != null)
            {
                Console.Write(current + " ");
                current = current.Next;
            }
            Console.WriteLine();
        }
    }

    class MainClass
    {
        public static void Main()
        {
            Queue queue = new Queue();
            queue.Enqueue(10);
            queue.Enqueue(15);
            queue.Print();
            Console.WriteLine(queue.First());
            Console.WriteLine(queue.Last());
            queue.Enqueue(25);
            queue.Print();
            queue.Dequeue();
            queue.Dequeue();
            queue.Print();
            
        }
    }

    class LinkedList
    {
        public Node head;
        public Node tail;
        int count;

        public int Count
        {
            get
            {
                return count;
            }
        }

        public void Add(int data)
        {
            Node node = new Node(data);

            if (head == null)
                head = node;
            else
                tail.Next = node;
            tail = node;
            count++;
        }

        public void Print()
        {
            Node current = head;
            int i = 1;
            while (current != null)
            {
                Console.WriteLine($"{i} - {current}");
                i++;
                current = current.Next;
            }
        }

        public bool Remove(int data)
        {
            Node current = head;
            Node prev = null;

            while (current != null)
            {
                if (current.Data == data)
                {
                    // если узел в середине или в конце
                    if (prev != null)
                    {
                        prev.Next = current.Next;
                        if (current.Next == null)
                            tail = prev;
                    }
                    else // узел в начале
                    {
                        head = head.Next;
                    }
                    if (head == null)
                        tail = null;
                    count--;
                    return true;
                }
                prev = current;
                current = current.Next;
            }

            return false;
        }

        public void Clear() //чистит список
        {
            head = null;
            tail = null;
            count = 0;
        }

        public bool Contains(int data) // ищет есть ли указанный элемент
        {
            Node current = head;
            while (current != null)
            {
                if (current.Data == data)
                    return true;
                current = current.Next;
            }
            return false;
        }

        public void AppendFirst(int data) // добавляет элемент в начало списка
        {
            Node node = new Node(data);
            node.Next = head;
            head = node;
            if (count == 0)
                tail = head;
            count++;
        }

        public Node Max()
        {
            Node current = head;
            Node max = null;
            while (current != null)
            {
                if (max == null)
                    max = current;
                else if (max.Data < current.Data)
                    max = current;
                current = current.Next;
            }
            return max;
        }

        public Node Min()
        {
            Node current = head;
            Node min = null;
            while (current != null)
            {
                if (min == null)
                    min = current;
                else if (min.Data > current.Data)
                    min = current;
                current = current.Next;
            }
            return min;
        }

        public Node Middle()
        {
            // 1 2 3 4 5 6 7 -> 4
            // 1 2 3 4 5 6 -> 3
            Node current = head;
            for (int i = 0; i < count / 2; i++)
                current = current.Next;
            return current;
        }

        public void Reverse()
        {
            // 13 9 7 8 1
            // 1 8 7 9 13
            Node curr = head,
                 next = null,
                 prev = null,
                 temp;
            tail = head;
            while (curr != null)
            {
                next = curr.Next;
                curr.Next = prev;
                prev = curr;
                curr = next;
            }
            head = prev;
        }
    }

}