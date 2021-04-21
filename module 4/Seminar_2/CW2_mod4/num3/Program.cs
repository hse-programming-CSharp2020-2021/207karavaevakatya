using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Xml.Serialization;

namespace num3
{
   
    [Serializable]
    [DataContract]
    public class ConsoleSimbolStruct
    {
        [DataMember]
        public int X { get; set; }
        [DataMember]
        public int Y { get; set; }
        [DataMember]
        public char Simb { get; set; }
        public ConsoleSimbolStruct(char simb, int x, int y)
        {
            X = x;
            Y = y;
            Simb = simb;
        }
        public ConsoleSimbolStruct()
        {

        }
        
    }
   
    [Serializable]
    [DataContract]
    public class ColoredConsoleSymbol : ConsoleSimbolStruct
    {
        [DataMember]
        public ConsoleColor color;

        public ColoredConsoleSymbol() 
        {
        }

        public ColoredConsoleSymbol(char simb, int x, int y, ConsoleColor color) : base(simb, x, y)
        {
            this.color = color;
        }
        public override string ToString()
        {
            return $"X = {X}, Y = {Y}, Simb = {Simb}, colour = {color} {Environment.NewLine}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            Random rnd = new Random();
            ConsoleSimbolStruct[] arr = new ConsoleSimbolStruct[n];
            ColoredConsoleSymbol[] colour = new ColoredConsoleSymbol[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = new ConsoleSimbolStruct((char)rnd.Next(67), rnd.Next(-10, 10), rnd.Next(-10, 10));
                colour[i] = new ColoredConsoleSymbol((char)rnd.Next(67), rnd.Next(-10, 10), rnd.Next(-10, 10), ConsoleColor.White);
            }

            Array.ForEach(colour, x => Console.Write(x));

            Console.WriteLine("********");
            string json = JsonSerializer.Serialize<ConsoleSimbolStruct[]>(colour);
            ColoredConsoleSymbol[] arrNew1 = JsonSerializer.Deserialize<ColoredConsoleSymbol[]>(json);
            Array.ForEach(arrNew1, x => Console.Write(x));


            Console.WriteLine("********");
            var serializer = new DataContractSerializer(typeof(ColoredConsoleSymbol[]));
            using (FileStream fs = new FileStream("Data.xml", FileMode.Create))
            {
                serializer.WriteObject(fs, colour);
            }
            ConsoleSimbolStruct[] arrNew;
            using (FileStream fs = new FileStream("Data.xml", FileMode.OpenOrCreate))
            {
                arrNew = (ColoredConsoleSymbol[])serializer.ReadObject(fs);
            }
            Array.ForEach(arrNew, x => Console.Write(x));


            Console.WriteLine("********");
            ColoredConsoleSymbol[] arrNew22;
            BinaryFormatter bf = new BinaryFormatter();
            using (FileStream fs = new FileStream("Data11.bin", FileMode.Create))
            {
                bf.Serialize(fs, colour);
            }
            using (FileStream fs1 = new FileStream("Data11.bin", FileMode.Open))
            {
                arrNew22 = (ColoredConsoleSymbol[])bf.Deserialize(fs1);
            }

            Console.WriteLine("********");
            ColoredConsoleSymbol[] arrNew4;
            XmlSerializer se = new XmlSerializer(typeof(ColoredConsoleSymbol[]));
            using (FileStream s = new FileStream("Data4.bin", FileMode.Create))
            {
                se.Serialize(s, colour);
            }
            using (FileStream s = new FileStream("Data4.bin", FileMode.Open))
            {
                arrNew4 = (ColoredConsoleSymbol[])se.Deserialize(s);
            }
            Array.ForEach(arrNew, x => Console.Write(x));
        }
    }
}
