using System;
// Task3
namespace HW_Seminar1
{
    class Program
    {
        class TemperatureConverterImp
        {
            public double From_C_to_F(double num) => ((9 / 5) * (num - 32));

            public double From_F_to_C(double num) => (5 / 9) * (num + 32);
        }

        static class StaticTempConverters
        {
            public static double From_C_to_K(double num) => num + 273.15;

            public static double From_K_to_C(double num) => num - 273.15;

            public static double From_C_to_R(double num) => 9.0 / 5 * (num + 273.15);

            public static double From_R_to_C(double num) => 5.0 / 9 * (num - 491.67);

            public static double From_C_to_Rm(double num) => num * 4 / 5;

            public static double From_Rm_to_C(double num) => num * 5 / 4;
        }

        delegate double ConvertTemperature(double num);
        static void Main(string[] args)
        {
            double temp = 36.6;
            TemperatureConverterImp obj = new TemperatureConverterImp();
            ConvertTemperature ct1 = new ConvertTemperature(obj.From_C_to_F);
            ConvertTemperature ct2 = new ConvertTemperature(obj.From_F_to_C);
            Console.WriteLine($"{(ct1?.Invoke(temp)):f3} F");
            Console.WriteLine($"{(ct2?.Invoke(temp)):f3} F");
            Console.WriteLine("*****");

            ConvertTemperature[] delArr =
            { StaticTempConverters.From_C_to_K ,
                StaticTempConverters.From_C_to_R ,
                StaticTempConverters.From_C_to_Rm
            };
            
            string[] sc = { "K", "R", "Rm" };
            do Console.Write("Enter the temperature in Celsius: ");
            while (!double.TryParse(Console.ReadLine(), out temp));

            for (int i = 0; i < delArr.Length; i++)
            {
                Console.WriteLine($"{temp:f3} C ~ {(delArr[i]?.Invoke(temp)):f3} {sc[i]}");
            }

        }
    }
}
