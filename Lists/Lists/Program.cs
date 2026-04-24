//Create the list of integers
List<int> myListOfInt = new List<int>();

//Add elements to the list
myListOfInt.Add(1);
myListOfInt.Add(9);
myListOfInt.Add(5);
myListOfInt.Add(7);
myListOfInt.Add(3);
myListOfInt.Add(21);

//Remove elements from the list
myListOfInt.Remove(21);

//Retrieve elements from the list
Console.WriteLine(myListOfInt[0]);
Console.WriteLine(myListOfInt.Find(x => x == 5));

Console.WriteLine("------------------------------------------");

//Important list functions
Console.WriteLine(myListOfInt.Count);
if (myListOfInt.Contains(4))
{
    Console.WriteLine("4 is in my list of ints");
}
else
{
    Console.WriteLine("4 is not in my list of ints");
}

myListOfInt.OrderByDescending(x => x);
myListOfInt.Sort();
myListOfInt.Reverse();

Console.WriteLine("------------------------------------------");

//Use a for loop to iterate through the list
for (int i = 0; i < myListOfInt.Count; i++)
{
    Console.WriteLine(myListOfInt[i].ToString() + " ");
}

Console.WriteLine("------------------------------------------");

//Use a foreach loop to iterate through the list
foreach (int number in myListOfInt)
{
    Console.WriteLine(number.ToString() + " ");
}

Console.WriteLine("------------------------------------------");

//Craeting a 2D list
List<List<float>> my2DList = new List<List<float>>();