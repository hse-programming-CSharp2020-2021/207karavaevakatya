using System;

namespace Number_2
{

    class Bread
    {
        public int Weight { get; set; } 
    }

    class Butter
    {
        public int Weight { get; set; } 
        public static Sandwich operator +(Bread bread, Butter butter)
        {
            Sandwich sandwich = new Sandwich() { Weight = bread.Weight + butter.Weight };
            return sandwich;
        }
    }

    class Sandwich
    {
        public int Weight { get; set; } 
    }
    class Program
    {
        static void Main(string[] args)
        {
            Bread bread = new Bread { Weight = 80 };
            Butter butter = new Butter { Weight = 20 };
            Sandwich sandwich = bread + butter;
            Console.WriteLine(sandwich.Weight);  
        }
    }
}