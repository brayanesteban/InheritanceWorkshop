using System;
using System.Collections.Generic;
using System.Text;

namespace Geometry
{
    public class Triangle : Rectangle
    {
        private double _c;
        private double _h;
        public Triangle(string name, double a, double b, double c, double h) : base(name, a, b)
        {
            H = h;
            C = c;
        }
        public double C {
            get => _c; 
            set => _c = ValidateC(value); 
        }
        public double H 
        { 
            get => _h; 
            set => _h = ValidateH(value); 
        }


        private double ValidateH(double h)
        {
            if (h <= 0)
            {
                throw new ArgumentException("Height must be greater than zero.");
            }
            return h;
        }

        private double ValidateC(double c)
        {
            if (c <= 0)
            {
                throw new ArgumentException("Side length must be greater than zero.");
            }
            return c;
        }

        public override double GetArea()=> (B * H) / 2;
        public override double GetPerimeter() => A + B + C;

    }
}
