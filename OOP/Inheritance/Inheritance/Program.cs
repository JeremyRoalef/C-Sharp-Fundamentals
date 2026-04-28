using Inheritance;

public class Program
{
    static void Main(string[] args)
    {
        //Enemy class cannot be instantiated because it is abstract

        //Enemy newEnemy = new Enemy(100);

        //Console.WriteLine($"Current enemy health: {newEnemy.Health}");
        //newEnemy.TakeDamage(125);
        //Console.WriteLine($"New enemy health: {newEnemy.Health}");

        //Console.WriteLine("---------------------------------------------");

        Slime newSlime = new Slime(50);

        Console.WriteLine($"Current enemy health: {newSlime.Health}");
        newSlime.TakeDamage(75);
        Console.WriteLine($"New enemy health: {newSlime.Health}");

        Console.WriteLine("---------------------------------------------");

        Knight newKnight = new Knight(250);

        Console.WriteLine($"Current enemy health: {newKnight.Health}");
        newKnight.TakeDamage(25);
        Console.WriteLine($"New enemy health: {newKnight.Health}");

        Console.WriteLine("---------------------------------------------");
        newSlime.Jump();
        Console.WriteLine("The knight has an armor rating of " + newKnight.armorRating);

        Console.WriteLine("---------------------------------------------");
        Console.WriteLine(newSlime.GetEnemyType());
        Console.WriteLine(newKnight.GetEnemyType());
    }
}