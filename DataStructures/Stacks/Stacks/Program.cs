//Create the stack
Stack<int> stackOfInt = new Stack<int>();

//Add elements to the stack
stackOfInt.Push(1);
stackOfInt.Push(2);
stackOfInt.Push(4);
stackOfInt.Push(8);
stackOfInt.Push(16);

Console.WriteLine(stackOfInt.Pop());
Console.WriteLine(stackOfInt.Pop());
Console.WriteLine(stackOfInt.Pop());
Console.WriteLine(stackOfInt.Pop());
Console.WriteLine(stackOfInt.Pop());

Console.WriteLine("-------------------------------------------");

//If there are elements in the stack, peek at the top element
if( stackOfInt.Count > 0)
{
    Console.WriteLine(stackOfInt.Peek());
}
else
{
    Console.WriteLine("There are no elements in the stack");
}

Console.WriteLine("-------------------------------------------");

//Loop through the elements in a stack
stackOfInt.Push(1);
stackOfInt.Push(2);
stackOfInt.Push(4);
stackOfInt.Push(8);
stackOfInt.Push(16);

while ( stackOfInt.Count > 0)
{
    Console.WriteLine(stackOfInt.Pop().ToString());
}

Console.WriteLine("-------------------------------------------");

//Nested stacks
Stack<Stack<Stack<int>>> AAA = new Stack<Stack<Stack<int>>>();