namespace Shapes;
internal class Circle : Shape
{
    public Circle(int radius)
    {
        Radius = radius;
    }

    private int radius;
    public int Radius
    {
        get { return radius; }
        set
        {
            if (value > 0)
                radius = value;
            else
                throw new ArgumentOutOfRangeException(nameof(value), "Radius must be more than 0.");
        }
    }

    public override void FindArea()
    {
        Area = Math.Round(Math.PI * (Radius * Radius), 2);
        Console.WriteLine($"Circle: {Area}");
    }
}
