using System;
using System.IO;
using System.Linq;
namespace _8._3
{
    class Program
    {

        private static int[] Num(string text)
        {
            string[] arrstr = text.Split(";");
            int[] num = new int[arrstr.Length];
            int k = 0;
            for (int i = 0; i < arrstr.Length; i++)
            {
                int n;
                if (int.TryParse(arrstr[i], out n)) 
                {
                    num[k] = n;
                    k++; 
                }
            }
            Array.Resize(ref num, k);
            return num;
        }

        static void Main(string[] args)
        {
            File.WriteAllText("../../../ourtext2.txt", "23;ghgh; hgfh; hghh; ghh;76");
            string str = File.ReadAllText("../../../ourtext2.txt");
            int[] num = Num(str);
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($"{num[i]} ");
            }
            Console.WriteLine();
            Console.WriteLine(num.Average());
        }
    }
}