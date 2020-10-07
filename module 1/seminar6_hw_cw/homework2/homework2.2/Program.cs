using System;

namespace homework2._2
{
    class Program
    {
        public static void math(int p)
        {
            int a1, a2, a3;
            int x, y, z;
            x = p / 100;   //находим первую цифру трехзначного числа
            y = (p / 10) % 10;  //вторую
            z = p % 10;  // и последнюю
            a1 = x < y ? (z < x ? z : x) : (y < z ? y : z);   // проверкой находим наибольшее число среди x,y,z 
            //(можно использовать if или сделать через switch)
            a3 = x > y ? (z > x ? z : x) : (y > z ? y : z);   //аналогично находим наименьшее
            a2 = x + y + z - a1 - a3;   // чтобы найти среднее число,складываем все числа и вычитаем сумму наибольшего с наименьшим
            Console.WriteLine(a3 * 100 + a2 * 10 + a1);   //конструируем числа так,чтобы они стояли в порядке убывания
        }


        static void Main(string[] args)
        {

            while (true)
            {
                int p;
                Console.Write("введите трехзначное число: ");

                    if (int.TryParse(Console.ReadLine(), out p))
                    {
                        math(p);
                    }
                    else
                    {
                        return;
                    }

            }       

        }
    }
}
