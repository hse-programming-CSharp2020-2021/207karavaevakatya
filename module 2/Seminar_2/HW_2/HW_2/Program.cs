using System;
// Задание 1.
namespace HW_2
{
    class Birthday
    {
        int m;
        int y;
        int d;
        string name;
        public Birthday()
        {
            d = 1;
            m = 1;
            y = 1970;
        }
        public int Count()
        {
            int today = DateTime.Now.DayOfYear;
            int ourday = Date.DayOfYear;
            int answer = (ourday > today) ? ourday - today : 365 - (today - ourday);
            return answer;
        }
        public Birthday(string name, int y, int m, int d)
        {
            this.name = name;
            this.y = y;
            this.m = m;
            this.d = d;
        }
        public DateTime Date
        {
            get
            {
                DateTime date = new DateTime(y, m, d);
                return date;

            }
        }
        public override string ToString()
        {
            return $" name: {name} , day: {d}, month :{m}, year:{y}";
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Birthday birth = new Birthday();
            Console.WriteLine(birth.Count());
           // Birthday d = new Birthday("Kate", 2002, 7, 20);
           // Console.WriteLine(d);
           // Console.WriteLine(d.Count());

        }
    }
}
