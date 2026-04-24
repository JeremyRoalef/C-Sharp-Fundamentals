int myNum = 10;

//The while loop
while (myNum >= 0)
{
    Console.WriteLine(myNum.ToString());

    //int myNewNum = myNum - 1;
    //myNum = myNewNum;

    //myNum = myNum - 1;

    //myNum--; //post-fix operator
    --myNum; //pre-fix operator
}

Console.WriteLine("-----------------------------------");

//The while loop
int i = 1;
do
{
    Console.WriteLine("Hello World!");
    i++;
} while (i < 0);

Console.WriteLine("-----------------------------------");

//The for loop
for (int j = 0; j <= 10; j++)
{
    Console.WriteLine(j.ToString());
}

Console.WriteLine("-----------------------------------");

//postfix operation
int k = 0;
Console.WriteLine(k++);
Console.WriteLine(k);

Console.WriteLine("-----------------------------------");

//Prefix operation
int l = 0;
Console.WriteLine(++l);
Console.WriteLine(l);

Console.WriteLine("-----------------------------------");

//Foreach loop
List<int> myListOfInt = new List<int>()
{
    1,2,3,4
};

foreach (int number in myListOfInt)
{
    Console.WriteLine(number.ToString());
}

Console.WriteLine("-----------------------------------");

//Continue & Break
int minNum = 0;
while (minNum < 10)
{
    //Continue to next iteration if number is equal to 3 or 7
    if (minNum == 3 || minNum == 7)
    {
        minNum++;
        continue;
    }

    //Break out of the loop if the number is equal to 8
    if (minNum == 8)
    {
        break;
    }

    Console.WriteLine(minNum.ToString());
    minNum++;
}