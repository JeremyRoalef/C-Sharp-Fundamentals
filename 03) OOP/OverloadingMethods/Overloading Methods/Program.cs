using Overloading_Methods;

public class Program
{
    static void Main(string[] args)
    {
        //Create the cups using a different overloaded constructor
        Cup cup1 = new Cup(10f);

        Console.WriteLine("----------------------------------");

        Cup cup2 = new Cup(7f, 3f);

        Console.WriteLine("----------------------------------");

        Cup cup3 = new Cup(9f, 4.5f, true);

        Console.WriteLine("----------------------------------");

        //Display the cups to the console
        Console.WriteLine(cup1.ToString());
        Console.WriteLine("----------------------------------");
        Console.WriteLine(cup2.ToString());
        Console.WriteLine("----------------------------------");
        Console.WriteLine(cup3.ToString());
    }
}