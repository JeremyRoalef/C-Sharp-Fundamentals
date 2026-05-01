string myString = "Hello World!";

//Declare my first function
MyFirstFunction();
void MyFirstFunction()
{
    Console.WriteLine("This is my first function");
}

Console.WriteLine("-------------------------------------------");

//Create a function with parameters
void Add(float num1, float num2)
{
    Console.WriteLine(num1 + num2);
}

//Call the Add function with two float arguments
Add(1.5f, 2.5f);

Console.WriteLine("-------------------------------------------");

//Get the global variable "myString" inside the function
void DisplayString()
{
    Console.WriteLine(myString);
}
DisplayString();

Console.WriteLine("-------------------------------------------");

void DisplayLocalString()
{
    string myString = "Goodbye World!";
    Console.WriteLine(myString);
}
DisplayLocalString();

Console.WriteLine("-------------------------------------------");

//Value-Returning Functions
bool IsGreaterThan(int numberInQuestion, int numberToBeGreaterThan)
{
    bool isGreaterThan = numberInQuestion > numberToBeGreaterThan;
    return isGreaterThan;
}

if (IsGreaterThan(1, 5))
{
    Console.Write("1 is greater than 5");
}
else
{
    Console.WriteLine("1 is less than or equal to 5");
}

int Sum(int num1, int num2)
{
    return num1 + num2;
}

int sumOfNums = Sum(1, 5);
Console.WriteLine(sumOfNums.ToString());

Console.WriteLine("-------------------------------------------");

//Returning multiple values from functions
(int, bool) MyFunction()
{
    return (10, false);
}

(int myNum, bool myBool) = MyFunction();
Console.WriteLine(myNum.ToString());
Console.WriteLine(myBool.ToString());

Console.WriteLine("-------------------------------------------");

//Function to return early if necessary
void Foo(int i)
{
    if (i == 5) return;

    Console.WriteLine("foo");
}

Foo(5);