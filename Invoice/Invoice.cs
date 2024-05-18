public class Invoice(string account, string customer, string provider)
{
    public string Account { get; } = account;
    public string Customer { get; } = customer;
    public string Provider { get; } = provider;
    public string Article { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }

    public decimal CostCalculation(bool needEdv)
    {
        decimal sum = Price * Quantity;
        if (needEdv)
        {
            sum += sum * 0.18m;
        }
        return sum;
    }
}


