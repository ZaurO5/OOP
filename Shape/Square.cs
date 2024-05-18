namespace Shapes;

internal class Square : Shape
{
    public Square(int side)
    {
        Side = side;
    }
    public int Side { get; set; }

    public override void FindArea()
    {
        Area = Side * Side;
        Console.WriteLine($"Square: {Area}");
    }
}
