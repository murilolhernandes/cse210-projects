using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Shapes Project.");
        List<Shape> shapes = new List<Shape>();

        Square square1 = new Square("yellow", 5);
        shapes.Add(square1);
        // Console.WriteLine(square1.GetColor());
        // Console.WriteLine(square1.GetArea());

        Rectangle rectangle1 = new Rectangle("blue", 10, 8);
        shapes.Add(rectangle1);
        // Console.WriteLine(rectangle1.GetColor());
        // Console.WriteLine(rectangle1.GetArea());

        Circle circle1 = new Circle("red", 4);
        // Console.WriteLine(circle1.GetColor());
        // Console.WriteLine(circle1.GetArea());
        shapes.Add(circle1);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"The {shape.GetColor()} shape has an area of {shape.GetArea()}.");
        }
    }
}