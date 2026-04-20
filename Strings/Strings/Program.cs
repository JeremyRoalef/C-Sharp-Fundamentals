//Print out "Hello World!"
string myFirstString = "Hello";
string mySecondString = "World!";
string myStringsCombined = myFirstString + " " + mySecondString;
Console.WriteLine(myStringsCombined);

//Combine a string with a number
string string1 = "Hello";
int int1 = 20497132;
string stringAndInt = string1 + int1;
Console.WriteLine(stringAndInt);

//Combine a string with two numbers
string string2 = "Hello";
int int2 = 20497132;
int int3 = 21094123;
string stringAndInt2 = string2 + int2.ToString() + int3.ToString();
Console.WriteLine(stringAndInt2);

//Use the $ and { } symbols two write out some strings
string combinedStrings = $"Hello World!\nMy first string is {string2}\n" +
    $"My first number is {int2}\n" +
    $"My second number is {int3}";
Console.WriteLine(combinedStrings);

//Cast data types to strings
int i = 4;
float iFloat = 2.5123f;
bool bool1 = true;

Console.WriteLine($"{i.ToString()} {iFloat.ToString() + bool1.ToString()}");

//Cast strings to data types
string numString = "5";
int stringToInt = int.Parse(numString);
Console.WriteLine(stringToInt.GetType());

string boolString = "wdgwewefwgfwe";
bool stringToBool;
bool.TryParse(boolString, out stringToBool);
Console.WriteLine(stringToBool.GetType());