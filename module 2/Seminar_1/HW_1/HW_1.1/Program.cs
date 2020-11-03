using System;
// Задание 7 (по шаблону)
namespace HW_1._1
{
    class Program
    {
        static string[] Filials = { "Западный", "Центральный", "Восточный" };
        static string[] Kvartal = { "I", "II", "III", "IV" };
        static int[,] auto = {
            { 20, 24, 25 },
            { 21, 20, 18 },
            { 23, 27, 26 },
            { 22, 19, 20 }
        };

        static void Main(string[] args)
        {
            string s, input;
            Console.WriteLine(PrintSrc()); // Печать исходных данных.
            do
            {
                Console.Write(Print()); // Вывод текстового меню.
                // Обработка выбранного меню и вывод результата.
                s = PrintResults(input = Console.ReadLine());
                Console.WriteLine(s);
            } while (input != "0"); // Выход из меню по "0".
            Console.ReadLine();
        }
        public static string PrintResults(string mode)
        {
            string st = "";
            int Nstroki; // номер строки
            int Nstolbca; // номер столбца
            int SumFilial; // продано филиалом
            int NFiliala_MaxAutoYear; // номер лучшего филиала
            int MaxAutoFilialZaGod;
            int SumKvartal;
            int NKvartal_MaxAuto;
            int MaxAutoKvartal;
            // переключатель
            switch (mode)
            {
                case "0": st += "Спасибо за работу!\r\n"; break;
                case "1":
                    st += "Ответ 1. Общее количество автомобилей = " +
                    GrandTotal() + "\r\n"; break;
                case "2":
                    GetMax4Kvartal(out Nstroki, out Nstolbca);
                    st += "Ответ 2. Максимальное количество автомобилей = " +
                    auto[Nstroki, Nstolbca] + ", Квартал = " + Kvartal[Nstroki] + ", Филиал = " + Filials[Nstolbca] + "\r\n";
                    break;
                case "3":
                    maxAutoFilialZaGod(out NFiliala_MaxAutoYear, out MaxAutoFilialZaGod);
                    st += "Ответ 3. Название филиала, который продал максимальное количество автомобилей по результатам года = " +
                    Filials[NFiliala_MaxAutoYear] +
                    ", проданное количество автомобилей = " + MaxAutoFilialZaGod
                    + "\r\n"; break;
                case "4":
                    maxAutoKvartal(out NKvartal_MaxAuto, out MaxAutoKvartal);
                    st += "Ответ 4. Наиболее успешный квартал = " +
                    Kvartal[NKvartal_MaxAuto] + ", проданное количество автомобилей = " +
                    MaxAutoKvartal + "\r\n"; break;
                default:
                    st += "Неизвестный режим. Введите число [0..4]\r\n"; break;
            }
            return st;
        }
        private static string PrintSrc()
        {
            string st = "Исходные данные: \r\n\\\t";
            foreach (var item in Filials)
            {
                st += item + "\t";
            }
            st += "\r\n";
            for (int i = 0; i < auto.GetLength(0); i++)
            {
                st += Kvartal[i] + "\t";
                for (int j = 0; j < auto.GetLength(1); j++)
                {
                    st += auto[i, j] + "\t\t";
                }
                st += "\r\n";
            }
            return st;
        }
        private static string Print()
        {
            return "Выберите., что вы желаете сделать:\n" +
                "1. Вычислить общее количество автомобилей;\n" +
                "2. Вывести максимальное количество автомобилей, проданных филиалом\n" +
                "за квартал (название филиала и номер квартала);\n" +
                "3. Найти название филиала, который продал максимальное количество\n" +
                "автомобилей по результатам года(и число проданных);\n" +
                "4. Найти наиболее успешный квартал(номер квартала и число\n" +
                "проданных);\n" +
                "0. Завершить работу.\n" +
                "Ваш выбор: ";
        }
        private static int GrandTotal()
        {
            int s = 0;
            for (int i = 0; i < auto.GetLength(0); i++)
            {
                for (int j = 0; j < auto.GetLength(1); j++)
                {
                    s += auto[i, j];
                }
            }
            return s;
        }
        private static void GetMax4Kvartal(out int Nstroki, out int NStolbca)
        {
            Nstroki = 0;
            NStolbca = 0;
            for (int i = 0; i < auto.GetLength(0); i++)
            {
                for (int j = 0; j < auto.GetLength(1); j++)
                {
                    if (auto[Nstroki, NStolbca] < auto[i, j])
                    {
                        Nstroki = i;
                        NStolbca = j;
                    }
                }
            }
        }
        private static void maxAutoFilialZaGod(out int Nfiliala_MaxAutoYear, out int MaxAutoFIlialZaGod)
        {
            Nfiliala_MaxAutoYear = 0;
            MaxAutoFIlialZaGod = 0;
            for (int i = 0; i < auto.GetLength(1); i++)
            {
                int SumMax = 0;
                for (int j = 0; j < auto.GetLength(0); j++)
                {
                    SumMax += auto[j, i];
                }
                if (SumMax > MaxAutoFIlialZaGod)
                {
                    MaxAutoFIlialZaGod = SumMax;
                    Nfiliala_MaxAutoYear = i;
                }
            }
        }
        private static void maxAutoKvartal(out int NKvartal_MaxAuto, out int MaxAutoKvartal)
        {
            NKvartal_MaxAuto = 0;
            MaxAutoKvartal = 0;
            for (int i = 0; i < auto.GetLength(0); i++)
            {
                int MaxSum = 0;
                for (int j = 0; j < auto.GetLength(1); j++)
                {
                    MaxSum += auto[i, j];
                }
                if (MaxSum > MaxAutoKvartal)
                {
                    MaxAutoKvartal = MaxSum;
                    NKvartal_MaxAuto = i;
                }
            }
        }
    }
    }
