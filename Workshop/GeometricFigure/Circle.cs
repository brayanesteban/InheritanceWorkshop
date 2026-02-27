using System;
using System.Collections.Generic;
using System.Text;

namespace Geometry
{
    public class Circle : GeometricFigure
    {
        private double _r;
        public Circle(string name, double r) : base(name)
        {
            R = r;
        }

        public double R 
        { 
            get => _r; 
            set => _r = ValidateR(value); 
        }

        public override double GetArea() => Math.PI * R * R;


        public override double GetPerimeter() => 2 * Math.PI * R;

        private double ValidateR(double r)
        {
            if (r <= 0)
            {
                throw new ArgumentException("Radius must be greater than zero.");
            }
            return r;
        }
    }
}
