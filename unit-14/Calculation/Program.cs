//Square square = new Square(7);// approach 1

IShape square = new Square(7);
IShape triangle = new Triangle(100,20);

PrintShapeInformation(square);
PrintShapeInformation(triangle);

// Console.WriteLine(square.Name);
// Console.WriteLine(square.Area());
// Console.WriteLine(square.Perimeter());

// Console.WriteLine();
// Console.WriteLine(triangle.Name);
// Console.WriteLine(triangle.Area());
// Console.WriteLine(triangle.Perimeter());

void PrintShapeInformation(IShape shape)
{
    Console.WriteLine();
    Console.WriteLine(shape.Name);
    Console.WriteLine(shape.Area());
    Console.WriteLine(shape.Perimeter());
}
