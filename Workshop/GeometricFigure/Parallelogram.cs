using System;
using System.Collections.Generic;
using System.Text;

namespace Geometry
{
    public class Parallelogram : Rectangle
    {
        private double _h;
        public Parallelogram(string name, double a, double b, double h) : base(name, a, b)
        {
            H = h;
        }

        public double H 
        { 
            get => _h; 
            set => _h = validateH(value); 
        }

        public override double GetArea() => B * H;

        public override double GetPerimeter() => 2 * (A + B);

        private double validateH(double h)
        {
            if (h <= 0)
            {
                throw new ArgumentException("Height must be greater than zero.");
            }
            return h;
        }
    }
}
