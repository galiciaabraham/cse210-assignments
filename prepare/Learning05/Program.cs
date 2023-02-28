using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("red",4);
        Rectangle rectangle = new Rectangle("blue",2,5);
        Circle circle = new Circle("yellow",5);

        List<Shape> shapes = new List<Shape>{};
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach(Shape shaping in shapes)
        {
            Console.Write(shaping.GetColor());
            Console.WriteLine(shaping.GetArea());
        }
    }
}