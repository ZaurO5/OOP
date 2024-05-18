namespace Product
{
    public class Clothes : Product
    {
        public string Size { get; set; }
        public Clothes(string name, string color, decimal price, string size) : base(name, color, price)
        {
            this.Size = size;
        }

        public override string GetDetails()
        {
            return $"{Name} {Color} {Price} {Size}";
        }
    }
}
