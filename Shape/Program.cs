class Program
{
    static void Main()
    {
        Shapes.Circle circle = new Shapes.Circle(5);
        Shapes.Square square = new Shapes.Square(7);
        Shapes.Triangle triangle = new Shapes.Triangle(5, 6);

        circle.FindArea();
        square.FindArea();
        triangle.FindArea();
    }
}
