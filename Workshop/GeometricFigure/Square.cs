using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace Geometry
{
    public class Square : GeometricFigure
    {
        private double _a;
        public Square(string name, double a ) : base(name)
        {
            A = a;
        }

        public double A 
        { 
            get => _a; 
            set => _a = ValidateA(value); 
        }

        private double ValidateA(double a)
        {
            if (a <= 0)
            {
                throw new ArgumentException("Side length must be greater than zero.");
            }
            return a;
        }

        public override double GetArea() => A * A;

        public override double GetPerimeter() => 4 * A;
    }
}
