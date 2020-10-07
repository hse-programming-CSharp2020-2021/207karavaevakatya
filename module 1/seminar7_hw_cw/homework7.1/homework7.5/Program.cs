using System;
using System.Security.Cryptography.X509Certificates;
// Sem_03; задача 20
namespace homework7._5
{
    class Program
    {
        public static void ArrayItemDouble(ref int[] a, int x)
        {
            int len = a.Length;
            // Находим длину нужного нам нового массива, с учетом того, что мы продублируем числа равные x .
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == x)
                { len++; }
            }
            // Console.WriteLine("new len " + len);
            int[] newa = new int[len];
            int k = 0;
            // Заполняем навый массив так, чтобы элементы равные x были продублированы.
            for (int i = 0; i < a.Length; i++)
            {
                newa[k] = a[i];
                k++;
                if (a[i] == x)
                {
                    newa[k] = a[i];
                    k++;
                }
            }
            a = newa;
        }


        public static void Output(int[] a)
        {
            foreach (int x in a)
            {
                Console.Write($"{x} ");
            }
        }

        // Заполняем массив случайными числами.
        public static int[] Organization(int n)
        {
            Random rnd = new Random();
            int[] a = new int[n];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rnd.Next(10, 101);
            }
            return a;
        }
        public static bool Read(out int n)
        {
            return int.TryParse(Console.ReadLine(), out n);
        }
        static void Main(string[] args)
        {
            while (true)
            {
                int n;
                int y;
                do Console.WriteLine("Введите размер массива и y: ");
                while (!Read(out n) || !Read(out y) || (n <= 0));
                int[] a = Organization(n);
                Console.WriteLine("our array: ");
                Output(a);
                Console.WriteLine();
                ArrayItemDouble(ref a, y);
                Console.WriteLine("new array: ");
                Output(a);

            }
        }
    }
}
