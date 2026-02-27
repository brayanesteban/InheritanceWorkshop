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
            return $"{Name}\t" +
                $"\t=> Area.....:\t = {GetArea():F5}" +
                $"\t  Perimeter:\t {GetPerimeter():F5}";
        }
  
    }
}