using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

namespace Number2
{
    class Plant
    {
        private double _growth;
        private double _photosensitivity;
        private double _frostresistance;
        public double Growth
        {
            get
            {
                return _growth;
            }
            set
            {
                if (_growth <= 100 && _growth >= 0)
                    _growth = value;
                else
                    throw new Exception();

            }

        }
        public double Photosensitivity
        {
            get
            {
                return _photosensitivity;
            }
            set
            {
                if (_photosensitivity <= 100 && _photosensitivity >= 0)
                    _photosensitivity = value;
                else
                    throw new Exception();

            }

        }
        public double Frostresistance
        {
            get
            {
                return _frostresistance;
            }
            set
            {
                if (_frostresistance <= 100 && _frostresistance >= 0)
                    _frostresistance = value;
                else
                    throw new Exception();

            }

        }
        public Plant(double g, double p, double f)
        {
            Growth = g;
            Photosensitivity = p;
            Frostresistance = f;
        }

        public override string ToString()
        {
            return $" Growth = {Growth:f3}, Photosensitivity = {Photosensitivity:f3}, Frostresistance = {Frostresistance:f3}";
        }
    }
    class Program
    {
        public static Plant ConvToNew(Plant x)
        {
            if ((int) x.Frostresistance % 2 == 0)
                return new Plant(x.Growth, x.Photosensitivity,(x.Frostresistance - (x.Frostresistance/ 3 )));
            else
                return new Plant(x.Growth, x.Photosensitivity, (x.Frostresistance - (x.Frostresistance / 2)));
        }
        static void Main(string[] args)
        {
            var rnd = new Random();
            int n;
            do
            {
                Console.WriteLine("Enter the number");
            } while (!int.TryParse(Console.ReadLine(), out n) );
            Plant[] pArr = new Plant[n];
            for (int i = 0; i < n; i++)
            {
                pArr[i] = new Plant((100 - 25)*rnd.NextDouble(), (100-0)* rnd.NextDouble(), (80 - 0)*rnd.NextDouble());
            }
            Array.ForEach(pArr,x => Console.Write(x.ToString() + $"{Environment.NewLine}"));
            Array.Sort(pArr, delegate(Plant x, Plant y)
            {
                if (x.Growth < y.Growth) return -1;
                else return 1;

            });
            Console.WriteLine("*******");
            Array.ForEach(pArr, x => Console.Write(x.ToString() + $"{Environment.NewLine}"));
            Array.Sort(pArr,
                (x, y) =>
                {
                    if (x.Frostresistance < y.Frostresistance) return -1;
                    else return 1;
                });
            Console.WriteLine("*******");
            Array.ForEach(pArr, x => Console.Write(x.ToString() + $"{Environment.NewLine}"));
            Array.Sort(pArr, delegate (Plant x, Plant y)
            {
                if ((int)x.Photosensitivity % 2 ==0) return -1;
                else return 1;

            });
            Console.WriteLine("*******");
            Array.ForEach(pArr, x => Console.Write(x.ToString() + $"{Environment.NewLine}"));

            pArr = Array.ConvertAll(pArr, new Converter<Plant, Plant>(ConvToNew));
            Console.WriteLine("*******");
            Array.ForEach(pArr, x => Console.Write(x.ToString() + $"{Environment.NewLine}"));

        }
    }
}
