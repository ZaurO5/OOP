namespace Product
{
    public class Electronic : Product
    {
        public string Material { get; set; }
        public Electronic(string name, string color, decimal price, string material) : base(name, color, price)
        {
            this.Material = material;
        }

        public override string GetDetails()
        {
            return $"{Name} {Color} {Price} {Material}";
        }
    }
}
