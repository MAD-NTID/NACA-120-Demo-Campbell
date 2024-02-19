public class Triangle : IShape
{
    private double triangleBase, height;

    public Triangle(double _base, double _height)
    {
        triangleBase = _base;
        height = _height;
    }

    // public string Name => "Triangle";
    public string Name
    {
        get{return  "Triangle";}
    }

    public double Area()
    {
        return (1/2) * triangleBase * height;
    }

    public double Perimeter()
    {
        return 10.0;
    }
}