using System;
using System.Collections.Generic;
using System.Text;
using forNumber2;

namespace Figures
{
    public class Circle : Point
    {
        public double Rad { get; set; }

        public Circle(double x, double y, double rad)
        {
            X = x;
            Y = y;
            Rad = rad;
        }
        public override double Area
        {
            get
            {
                return Math.PI * Rad * Rad;
            }
        }

        public override double Perimeter
        {
            get
            {
                return 2 * Math.PI * Rad;
            }
        }

        public override string Display()
        {
            return $"Circle radius = {Rad:f3}, center: " + base.Display() + $", area = {Area:f3}";
        }
    }
}

