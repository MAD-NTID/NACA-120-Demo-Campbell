public class Square : IShape
{
    private double length;

    public Square(double _length)
    {
        length = _length;
    }

    public string Name
    {
        get{ return "Square";}
    }

    public double Area()
    {
        return length * length;
    }

    public double Perimeter()
    {
       return 4 * length;
    }
}