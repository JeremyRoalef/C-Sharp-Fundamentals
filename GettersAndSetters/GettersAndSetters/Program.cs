using GettersAndSetters;

public class Program
{
    static void Main(string[] args)
    {
        Mouse myMouse = new Mouse(10, 3, true, true);

        //Get the attributes from my mouse
        Console.WriteLine($"Number of mouse buttons: {myMouse.GetNumOfButtons()}");
        Console.WriteLine($"Number of DPI settings: {myMouse.GetnumOfDPISettings()}");
        Console.WriteLine($"Is the mouse wired? {myMouse.GetIsWired()}");
        Console.WriteLine($"Is the mouse ergonomic? {myMouse.GetIsErgonomic()}");

        Console.WriteLine("------------------------------------------------");

        //Set the attributes for my mouse
        myMouse.SetNumOfButtons(14);
        myMouse.SetNumOfDPISettings(0);
        myMouse.SetIsWired(false);
        myMouse.SetIsErgonomic(false);

        Console.WriteLine("------------------------------------------------");

        //Get the attributes from my mouse
        Console.WriteLine($"Number of mouse buttons: {myMouse.GetNumOfButtons()}");
        Console.WriteLine($"Number of DPI settings: {myMouse.GetnumOfDPISettings()}");
        Console.WriteLine($"Is the mouse wired? {myMouse.GetIsWired()}");
        Console.WriteLine($"Is the mouse ergonomic? {myMouse.GetIsErgonomic()}");
    }
}