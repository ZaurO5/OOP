namespace OOP
{
    internal class Cat : Animal
    { 
        public Cat(string name, int age, string breed, string color) : base(name, age, breed, color)
        {

        }

        public override string AnimalSound()
        {
            return "Myau";
        }
    }
}
