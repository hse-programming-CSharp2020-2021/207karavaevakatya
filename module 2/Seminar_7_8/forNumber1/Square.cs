using System;
using System.Collections.Generic;
using System.Text;
using forNumber2;

namespace Figures
{
   
    public class Square:Point
    {

        double side;
        public double Side
        {
            get
            {
                return side;
            }
            set
            {
                side = value;
            }
        }
        public Square(double x, double y, double side)
        {
            X = x;
            Y = y;
            Side = side;
        }
        public override double Area
        {
            get
            {
                return Side * Side;
            }
        }

        public override double Perimeter
        {
            get
            {
                return 4 * Side;
            }
        }

        public override string Display()
        {
            return $"Square side length = {side:f3}, Center point: "
                   + base.Display() + $" Area = {Area:f3}";
        }
    }
}
