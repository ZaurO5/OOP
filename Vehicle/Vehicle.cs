namespace Vehicle
{
    public class Vehicle
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }
        public Vehicle(string name, string color,int year)
        {
            this.Name = name;
            this.Color = color;
            this.Year = year;
        }

        public virtual string GetDetails()
        {
            return $"{Name} {Color} {Year}";
        }
    }
}
