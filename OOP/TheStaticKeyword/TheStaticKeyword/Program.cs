using TheStaticKeyword;

public class Program
{
    static void Main(string[] args)
    {
        //Access a static attribute from the custom math class
        int unitNumber = CustomMath.unitNumber;
        Console.WriteLine(unitNumber);

        Console.WriteLine("----------------------------------------");

        //Access a static method from the custom math class
        float areaOfCircle = CustomMath.GetAreaOfCircle(unitNumber);
        Console.WriteLine($"The area of a circle with a radius of {unitNumber} is {areaOfCircle}");

        Console.WriteLine("----------------------------------------");

        //Save the game on the SaveManager Instance
        SaveManager.Instance.SaveGame();
    }
}