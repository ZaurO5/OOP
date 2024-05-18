namespace Product
{
    public class Product
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public decimal Price { get; set; }
        public Product(string name, string color, decimal price)
        {
            this.Name = name;
            this.Color = color;
            Price = price;
        }

        public virtual string GetDetails()
        {
            return $"{Name} {Color} {Price}";
        }
    }
}
