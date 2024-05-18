namespace Vehicle
{
    public class Car : Vehicle
    {
        public int Passengers { get; set; }
        public Car(string name, string color, int year, int passengers) : base(name, color, year)
        {
            this.Passengers = passengers;
        }

        public override string GetDetails()
        {
            return $"{Name} {Color} {Year} {Passengers}";
        }
    }
}
