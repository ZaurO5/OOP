using Vehicle;

public static class Program
{
    public static void Main()
    {
        Car Porsche = new Car("Sedan", "Black", 2023, 4);
        Console.WriteLine(Porsche.GetDetails());
        Truck Mercedes = new Truck("Sedan", "White", 2020, 300);
        Console.WriteLine(Mercedes.GetDetails());
    }
}


