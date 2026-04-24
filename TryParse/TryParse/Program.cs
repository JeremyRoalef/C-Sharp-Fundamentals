//Gather the user input
Console.Write("Enter something: ");
string? userInput = Console.ReadLine();

//Try to parse user input to an integer
if (int.TryParse(userInput, out int _))
{
    Console.WriteLine("User input is an integer");
}
else
{
    Console.WriteLine("User input is not an integer");
}

//Try to parse user input to a float
if (float.TryParse(userInput, out float _))
{
    Console.WriteLine("User input is a float");
}
else
{
    Console.WriteLine("User input is not a float");
}

//Try to parse user input to a double
if (double.TryParse(userInput, out double _))
{
    Console.WriteLine("User input is a double");
}
else
{
    Console.WriteLine("User input is not a double");
}

//Try to parse user input to a decimal
if (decimal.TryParse(userInput, out decimal _))
{
    Console.WriteLine("User input is a decimal");
}
else
{
    Console.WriteLine("User input is not a decimal");
}

//Try to parse user input to a boolean
if (bool.TryParse(userInput, out bool userInputAsBool))
{
    Console.WriteLine($"User input is a boolean: {userInputAsBool}");
}
else
{
    Console.WriteLine("User input is not a boolean");
}