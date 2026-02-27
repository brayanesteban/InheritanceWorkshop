namespace Geometry
{
    public abstract class GeometricFigure
    {

        protected GeometricFigure(string name) 
        {
            Name = name;
        }
        public string Name { get; set; } = null!;

        public abstract double GetArea();
        public abstract double GetPerimeter();

        public override string ToString()
        {
            return $"{Name,-15}" +
                $"\t=> Area.....:\t = {GetArea(),-12:F5}" +
                $"\t  Perimeter:\t {GetPerimeter(),-12:F5}";
        }
  
    }
}