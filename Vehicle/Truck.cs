namespace Vehicle
{
    public class Truck : Vehicle
    {
        public int Load { get; set; }
        public Truck(string name, string color, int year, int load) : base(name, color, year)
        {
            this.Load = load;
        }

        public override string GetDetails()
        {
            return $"{Name} {Color} {Year} {Load}";
        }
    }
}
