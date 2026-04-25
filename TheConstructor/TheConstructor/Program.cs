using TheConstructor;

public class Program
{
    static void Main(string[] args)
    {
        //Create the animal pointer & object 
        Animal myAnimal = new Animal();

        //Display animal properties from the constructor
        Console.WriteLine($"Number of legs: {myAnimal.numOfLegs}\n" +
            $"Animal Name: {myAnimal.name}");
    }
}