using OOP;

internal class Program
{
    static void Main(string[] args)
    {
        Cat cat = new Cat ("Nika", 1, "Female","Black");
        Dog dog = new Dog ("Alpha", 2 , "Male", "Black");

        Console.WriteLine(cat.AnimalSound());
        Console.WriteLine(dog.AnimalSound());
    }
}


