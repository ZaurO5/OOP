using Product;
public static class Program
{
    public static void Main()
    {
        Electronic electronic = new Electronic("Iphone", "White", 550, "Carbon");
        Clothes clothes = new Clothes("T-shirt", "Black", 200, "L");

        Console.WriteLine(electronic.GetDetails());
        Console.WriteLine(clothes.GetDetails());
        Order order = new Order();
        order.AddProduct(electronic);
        order.AddProduct(clothes);
        order.GetProductDetails();
        order.GetTotalAmount();
        Console.WriteLine(order.GetTotalAmount());
    }
}

