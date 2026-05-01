using Structs;

public class Program
{
    static void Main(string[] args)
    {
        //Create a new Vector3
        Vector3 myFirstVector = new Vector3(10, 10, 10);
        Console.WriteLine("My vector value is: " + myFirstVector.ToString());

        myFirstVector = UpdateMyVector(myFirstVector);
        Console.WriteLine("My vector value is: " + myFirstVector.ToString());

        Console.WriteLine("------------------------------------------------------------------");
        Vector3 vectorToCompare = new Vector3(10, 10, 10);
        Console.WriteLine("My vector value is: " + vectorToCompare.ToString());

        Console.WriteLine("------------------------------------------------------------------");
        if (vectorToCompare.Equals(myFirstVector))
        {
            Console.WriteLine("My new vector equals the original");
        }
        else
        {
            Console.WriteLine("My new vector is not equal to the original");
        }

        Console.WriteLine("------------------------------------------------------------------");
        Vector3 a = new Vector3(12, 15, 7);
        Vector3 b = new Vector3(11.5f, 17, 4);

        Console.WriteLine($"Vector a + Vector b = {a + b}");
        Console.WriteLine($"Vector a - Vector b = {a - b}");
        Console.WriteLine($"Vector b - Vector a = {b - a}");

        Console.WriteLine("------------------------------------------------------------------");
        Vector3 a2 = new Vector3(12, 3, 4);
        Vector3 b2 = new Vector3(6, 1, 2);

        Console.WriteLine($"The distance between a2 and b2 is {Vector3.Distance(a2, b2)}");

        Console.WriteLine("------------------------------------------------------------------");
        Console.WriteLine($"The zero vector is {Vector3.Zero}");
        Console.WriteLine($"The one vector is {Vector3.One}");
        Console.WriteLine($"The right vector is {Vector3.Right}");
        Console.WriteLine($"The up vector is {Vector3.Up}");
        Console.WriteLine($"The forward vector is {Vector3.Forward}");

        Console.WriteLine($"The left vector is {-Vector3.Right}");
        Console.WriteLine($"The down vector is {-Vector3.Up}");
        Console.WriteLine($"The back vector is {-Vector3.Forward}");
    }

    public static Vector3 UpdateMyVector(Vector3 myVector)
    {
        return new Vector3(12, myVector.y, myVector.z);
    }
}