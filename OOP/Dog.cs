
namespace OOP
{
    internal class Dog : Animal
    {
        public Dog(string name, int age, string breed, string color) : base(name, age, breed, color)
        {
            
        }

        public override string AnimalSound()
        {
            return "Woof";
        }
    }
}
