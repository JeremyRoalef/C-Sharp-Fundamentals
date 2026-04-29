using Polymorphism;

public class Program
{
    static void Main(string[] args)
    {
        //Create the animal reference
        Animal animal = new Bird("Chipper");

        //Display the current polymorphic reference of the animal
        Console.WriteLine($"My animal's name is {animal.ToString()}");

        //Cast the animal to a bird, then call bird-specific methods
        if (animal is Bird bird)
        {
            bird.Fly();
        }

        Console.WriteLine("-----------------------------------------------------");

        //Polymorph the animal to a dog
        animal = new Dog("Ruffles");

        //Display the current polymorphic reference of the animal
        Console.WriteLine($"My animal's name is {animal.ToString()}");
        
        //Cast the animal to a dog, then call the dog-specific methods
        if (animal is Dog dog)
        {
            dog.WagTail();
        }

        Console.WriteLine("-----------------------------------------------------");

        //Polymorph the animal to a cat
        animal = new Cat("Castor");

        //Display the current polymorphic reference of the animal
        Console.WriteLine($"My animal's name is {animal.ToString()}");

        //Cast the animal to a cat, then call the cat-specific methods
        if (animal is Cat cat)
        {
            cat.Pounce();
        }

        Console.WriteLine("-----------------------------------------------------");

        //Use a switch-case on the animal to call method-specific logic on the animal's subclasses.
        switch (animal)
        {
            case Bird bird1:
                bird1.Fly();
                break;
            case Dog dog1:
                dog1.WagTail();
                break;
            case Cat cat1:
                cat1.Pounce();
                break;
            default:
                animal.DoSomething();
                break;
        }
    }
}