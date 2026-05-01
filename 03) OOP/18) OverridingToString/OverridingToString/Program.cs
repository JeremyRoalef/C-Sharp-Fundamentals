using OverridingToString;

public class Program
{
    static void Main(string[] args)
    {
        Computer myComputer = new Computer("16:9", "QWERTY", "Lenovo");
        Console.WriteLine(myComputer.ToString());
    }
}