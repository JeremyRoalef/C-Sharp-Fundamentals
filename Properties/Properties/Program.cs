using Properties;

public class Program
{
    static void Main(string[] args)
    {
        Light myLight = new Light();

        //Set the light's color, then display it
        myLight.Color = "Red";
        Console.WriteLine($"Light color: {myLight.Color}");

        //Get the intensity of the light
        Console.WriteLine($"Light intensity: {myLight.Intensity}");

        //Set the position of the light
        myLight.Position = -10;
    }
}