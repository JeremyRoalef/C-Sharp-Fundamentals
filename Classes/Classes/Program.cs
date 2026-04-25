using Classes;

public class Program
{
    //This will always run when the application runs
    static void Main(string[] args)
    {
        House myHouse = new House();
        myHouse.length = 10;
        myHouse.width = 5;
        myHouse.numOfRooms = 6;

        Console.WriteLine($"Length: {myHouse.length}\n" +
            $"Width: {myHouse.width}\n" +
            $"Number of Rooms: {myHouse.numOfRooms}");

        Console.WriteLine("---------------------------------------");

        House myFirstHouse = myHouse;

        myHouse = new House();

        Console.WriteLine($"Length: {myHouse.length}\n" +
            $"Width: {myHouse.width}\n" +
            $"Number of Rooms: {myHouse.numOfRooms}");

        Console.WriteLine("---------------------------------------");

        Console.WriteLine($"Length: {myFirstHouse.length}\n" +
            $"Width: {myFirstHouse.width}\n" +
            $"Number of Rooms: {myFirstHouse.numOfRooms}");

        myHouse = null;

        Console.WriteLine("---------------------------------------");

        Console.WriteLine(myFirstHouse.GetArea());
    }
}