public class Program
{
    public static void Main()
    { 
        Invoice inv = new Invoice("678904", "Alex", "Foxtrot");
        inv.Article = "USB-hub";
        inv.Quantity = 6;
        inv.Price = 30;

        decimal totalCost = inv.CostCalculation(true);
        Console.WriteLine($"Mehsul: {inv.Article}, Sayi: {inv.Quantity}, Ümumi Deyer: {totalCost}");
    }
}