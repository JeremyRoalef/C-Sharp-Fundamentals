//Create an array of integers
int[] myArrayOfIntegers = new int[5]
{
    1, 3, 5, 7, 9
};

//Retrieve the element at index 2
int element2 = myArrayOfIntegers[2];
Console.WriteLine(element2.ToString());

//Retrieve the element at index 0
int element0 = myArrayOfIntegers[0];
Console.WriteLine(element0.ToString());

Console.WriteLine("------------------------------------------");

//Check if 4 is inside my array of integers
if (myArrayOfIntegers.Contains(4))
{
    Console.WriteLine("4 is inside my array");
}
else
{
    Console.WriteLine("4 is not inside my array");
}

Console.WriteLine("------------------------------------------");

//Get the length of my integer array
Console.WriteLine(myArrayOfIntegers.Length);

Console.WriteLine("------------------------------------------");

//Important array functions
Console.WriteLine(myArrayOfIntegers.Max());
Console.WriteLine(myArrayOfIntegers.Min());
Console.WriteLine(myArrayOfIntegers.Average());

Console.WriteLine("------------------------------------------");

//Do a for loop on the array
for (int i = 0; i < myArrayOfIntegers.Length; i++)
{
    Console.WriteLine($"Element at index {i} = {myArrayOfIntegers[i]}");
}

Console.WriteLine("------------------------------------------");

//Do a foreach loop on the array
Console.WriteLine("Elements in the array:");
foreach (int number in myArrayOfIntegers)
{
    Console.Write(number.ToString() + ", ");
}
Console.WriteLine();

Console.WriteLine("------------------------------------------");

//Create a 2D array
float[][] my2DArray = new float[3][]
{
    new float[4]{1,2,3,4 },
    new float[4]{5,6,7,8 },
    new float[4]{9,10,11,12 }
};

//Row iteration
for (int i = 0; i < my2DArray.Length; i++)
{
    //Column iteration
    for (int j = 0;  j < my2DArray[i].Length; j++)
    {
        Console.Write(my2DArray[i][j] + " ");
    }
}

Console.WriteLine();
Console.WriteLine("------------------------------------------");

//Iterate through a row
int rowToIterate = 2;
for (int i = 0; i < my2DArray.Length; i++)
{
    //Skip any row that we don't want to iterate
    if (i != rowToIterate) continue;

    //Display the row
    for (int j = 0; j < my2DArray[i].Length; j++)
    {
        Console.Write(my2DArray[i][j] + " ");
    }
}

Console.WriteLine();
Console.WriteLine("------------------------------------------");

//Iterate through a column
int columnToIterate = 0;

//Row iteration
for (int i = 0; i < my2DArray.Length; i++)
{
    //Column iteration
    for (int j = 0; j < my2DArray[i].Length; j++)
    {
        if (j != columnToIterate) continue;

        Console.Write(my2DArray[i][j] + " ");
    }
}

Console.WriteLine();
Console.WriteLine("------------------------------------------");

//Grab the diagonal along the starting element in row 0
//Row iteration
for (int i = 0; i < my2DArray.Length; i++)
{
    //Column iteration
    for (int j = 0; j < my2DArray[i].Length; j++)
    {
        if (j != i) continue;
        Console.Write(my2DArray[i][j] + " ");
    }
}