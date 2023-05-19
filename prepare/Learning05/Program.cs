using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> _list = new List<Shape>();
        
        Square square = new Square("blue", 5);
        Rectangle rectangle = new Rectangle("yellow", 8, 7);
        Circle circle = new Circle("green", 1);

        _list.Add(square);
        _list.Add(circle);
        _list.Add(rectangle);

        foreach (Shape shape in _list)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }

    }
}