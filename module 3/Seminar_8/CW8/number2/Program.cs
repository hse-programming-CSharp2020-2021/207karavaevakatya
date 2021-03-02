using System;
using System.Collections.Generic;

namespace number2
{
    public class ElectronicQueue<T>
    {
        private Queue<T> eQueue = new Queue<T>();
        public void Add(T person) => eQueue.Enqueue(person);
        public void Output() {
            foreach (var x in eQueue)
            {
                Console.WriteLine(x.ToString());
            }
        }
        public T Delete() => eQueue.Dequeue();
    }

    public struct Person {
        public int Age { get;}
        public string Name { get; }
        public string Lastname { get;}
       
        public Person(string name, string lastname, int age) {
            Name = name; 
            Lastname = lastname;
            Age = age;
        }
        public override string ToString()
        {
            return $"Name: {Name} , Lastname :{Lastname}, Age: {Age}";
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            ElectronicQueue<Person> electronicQueue = new ElectronicQueue<Person>();
            electronicQueue.Add(new Person("Kghj", "Fhjhkj", 32));
            electronicQueue.Add(new Person("Jhgf", "Khg", 35));
            electronicQueue.Output();

        }
    }
}