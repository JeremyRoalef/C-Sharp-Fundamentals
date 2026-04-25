//If 4 > 3, then print "4 is greater than 3"
bool greaterThan = 4 > 3;
Console.WriteLine(greaterThan);
if (greaterThan)
{
    Console.WriteLine("4 is greater than 3");
}

//If 3 is equal to 4, then say "3 = 4". Otherwise, say "3 does not equal 4"
bool isEqual = 3 == 4;
if (!isEqual)
{
    Console.WriteLine("3 is not equal to 4");
}
else
{
    Console.WriteLine("3 is equal to 4");
}

//Use if-else if-else structure
bool isGreaterOrEqual = 4 >= 3;
bool isLessOrEqual = 4 <= 4;
if (isGreaterOrEqual)
{
    Console.WriteLine("4 is greater than or equal to 3");
}
else if (isLessOrEqual)
{
    Console.WriteLine("4 is less than or equal to 4");
}
else
{
    Console.WriteLine("4 is not greater than or equal to 3, " +
        "and it is not less than or equal to 4");
}

Console.WriteLine("-------------------------------------");

//Use if-else if-else structure
bool isGreaterOrEqual2 = true;
bool isLessOrEqual2 = true;
if (isGreaterOrEqual2 || isLessOrEqual2)
{
    Console.WriteLine("4 is greater than or equal to 3, " +
        "or 4 is less than or equal to 4");
}
else
{
    Console.WriteLine("4 is not greater than or equal to 3, " +
        "and it is not less than or equal to 4");
}

Console.WriteLine("-------------------------------------");

//Set my number using the ternary operator
int myNum = 0;
Console.WriteLine(myNum);

bool isSet = true;

//If isset, then set my number equal to 7. Otherwise, set it to 3
myNum = isSet ? 7 : 3;

Console.WriteLine(myNum);

Console.WriteLine("-------------------------------------");

//Use switch-case to run code
int num100 = 4123;
switch (num100)
{
    case 0:
        Console.WriteLine("Number is 0");
        break;
    case 1:
        Console.WriteLine("Number is 1");
        break;
    case 2:
        Console.WriteLine("Number is 2");
        break;
    default:
        Console.WriteLine("Number was not found in any case");
        break;
}

Console.WriteLine("-------------------------------------");

//Use if statements without the curly braces
if (false) Console.WriteLine("This is true");
Console.WriteLine("Hello");