using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;

//Класс Student (студент) включает фамилию и номер курса.
//В основной программе сосздать массив из n студентов, сохранить в файл
//и восстановить из файла. Использовать сериализацию.
namespace CW1_mod4
{
    [Serializable]
    class Student
    {
        public string Surname { get; set; }
        public int Number { get; set; }

        public Student(string surname, int number)
        {
            Surname = surname;
            Number = number;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            Random rnd = new Random();
            string[] surArr = { "Asdf", "Sdfg", "Kjhgf", "LKJHGF", "Kkjhgfd" };
            int[] numArr = { 1, 2, 3, 4, 1 };
            List<Student> arr = new List<Student>(n);
            for (int i = 0; i < n; i++)
            {
                int j = rnd.Next(1, 4);
                arr.Add(new Student(surArr[j], numArr[j]));
            }
            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                // Сериализация.
                using (FileStream fs = new FileStream("data.dat", FileMode.OpenOrCreate))
                {
                    formatter.Serialize(fs, arr);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                // Десериализация.
                using (FileStream fs = new FileStream("data.dat", FileMode.OpenOrCreate))
                {
                    arr = (List<Student>)formatter.Deserialize(fs);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}