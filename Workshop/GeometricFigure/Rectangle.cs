using System;
using System.Collections.Generic;
using System.Text;

namespace Geometry
{

    public class Rectangle : Square
    {
        private double _b;
        public Rectangle(string name, double a, double b) : base(name, a)
        {
            B = b;
        }

        public double B 
        { 
            get => _b; 
            set => _b = validateB(value); 
        }

        public override double GetArea() => A * B;

        public override double GetPerimeter() => 2 *(A + B);


        private double validateB(double b)
        {
            if (b <= 0)
            {
                throw new ArgumentException("Side length must be greater than zero.");
            }
            return b;
        }
    }
}
