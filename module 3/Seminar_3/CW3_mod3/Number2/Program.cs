using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Xml;

namespace Number2
{

    delegate void SquareSizeChanged(double num);

    class Square
    {
        private double _xLeft;
        private double _yLeft;
        private double _xRight;
        private double _yRight;
        public event SquareSizeChanged OnSizeChanged;
        public Square(double xl, double yl, double xr, double yr)
        {
            XLeft = xl;
            XRight = xr;
            YLeft = yl;
            XRight = xr;
        }

        public double XLeft
        {
            get
            {
                return _xLeft;
            }
            set
            {
                _xLeft = value;
                OnSizeChanged?.Invoke(_xLeft);
            }
        }
        public double YLeft
        {
            get
            {
                return _yLeft;
            }
            set
            {
                _yLeft = value;
                OnSizeChanged?.Invoke(_yLeft);
            }
        }
        public double XRight
        {
            get
            {
                return _xRight;
            }
            set
            {
                _xRight = value;
                OnSizeChanged?.Invoke(_xRight);
            }
        }
        public double YRight
        {
            get
            {
                return _yRight;
            }
            set
            {
                _yRight = value;
                OnSizeChanged?.Invoke(_yRight);
            }
        }
    }
    class Program
    {
        public static void SquareConsoleInfo(double A)
        {
            Console.WriteLine($"{A:f2}");
        }

        public static double Check()
        {
            double x;
            do
            {
                Console.WriteLine("Введите");
            } while (!double.TryParse(Console.ReadLine(), out x));

            return x;
        }
        static void Main()
        {

            double xl = Check();
            double yl = Check();
            double xr = Check();
            double yr = Check();
            Square s = new Square(xl, yl, xr, yr);
            s.OnSizeChanged += SquareConsoleInfo;
            double n = Check();
            for (int i = 0; i < n; i++)
            {
                double xrr = Check();
                double yrr = Check();
                s.XRight = xrr;
                s.YRight = yrr;

            }

        }


    }
}
