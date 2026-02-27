using Geometry;

var circle = new Circle(nameof(Circle), 5);
//var square = new Square(nameof(Square), 10);
//var rhombus = new Rhombus(nameof(Rhombus), 5, 7, 10);
//var kite = new Kite(nameof(Kite), 7, 6, 5, 8);
//var rectangle = new Rectangle(nameof(Rectangle), 4.568, 67.790);
//var parallelogram = new Parallelogram(nameof(Parallelogram), 5, 10, 7);
//var triangle = new Triangle(nameof(Triangle), 5, 7, 10);
//var trapeze = new Trapeze(nameof(Trapeze), 5, 7, 10);

var figures = new List<GeometricFigure> { circle,};
foreach (var figure in figures)
{
    Console.WriteLine(figure);
}