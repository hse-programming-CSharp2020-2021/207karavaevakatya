using System;
using System.IO;

namespace CW9
{
    class Program
    {
        static void Main(string[] args)
        {
            using (FileStream file1 = new FileStream(@"text.txt", FileMode.OpenOrCreate)) {
                int num;
                while ((num = file1.ReadByte()) != -1) 
                {
                    if (char.IsDigit((char)num))
                        Console.Write((char)num + " ");
                }   
            }    
        }
    }
}
