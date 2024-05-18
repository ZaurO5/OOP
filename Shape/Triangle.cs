namespace Shapes;

internal class Triangle : Shape
{
    public Triangle(int side, int height)
    {
        Side = side;
        Height = height;
    }

    public int Side { get; set; }
    public int Height { get; set; }

    public override void FindArea()
    {
        Area = Side * Height * 0.5;
        Console.WriteLine($"Triangle: {Area}");
    }
}
