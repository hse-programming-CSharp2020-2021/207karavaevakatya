using System;

namespace _1_thirteen
{
    class Program
    {
        public static int Met(out int nmax)
        {
            nmax = 0;
            int res = 0, n = 0, a1, a2, a3;
            while (res <= 999) // по условию число трехзначно
            {
                n += 1;
                res += n;// создаем сумму 1+2+3+4+...
                a1 = res % 10; //  первая цифра трехзначного числа
                a2 = (res / 10) % 10; // вторая
                a3 = (res / 100) % 10; // третия
                if (a1 == a2 && a2 == a3) // когда все числа суммы прогрессии будут между собой равны, мы зайдем в if
                {
                    nmax = n; // в nmax присвоим количество членов ряда 
                    return nmax;
                }
            }
            return 0;
        }
        static void Main(string[] args)
        {
            int s;
            int m;
            Met(out s); //вызываем метод
            m = (s * (s + 1) / 2);
            Console.WriteLine("Число:" + m + " " + "количество:" + s); //по формуле находим само число и выводим количество членов ряда

            Console.WriteLine($"1 + 2 + 3 + ... + {s - 2} + {s - 1} + {s}"); // выводим условное изображение соответствующей суммы

        }
    }
}
