//Create the queue
Queue<int> frontier = new Queue<int>();

//Enqueue elements to the queue
frontier.Enqueue(1);
frontier.Enqueue(2);
frontier.Enqueue(4);
frontier.Enqueue(8);
frontier.Enqueue(16);

//Peek at the next element in the queue

if (frontier.Count > 0)
{
    Console.WriteLine(frontier.Peek());
}

Console.WriteLine("----------------------------------------");

//Dequeue elements from the queue
Console.WriteLine(frontier.Dequeue());
Console.WriteLine(frontier.Dequeue());
Console.WriteLine(frontier.Dequeue());
Console.WriteLine(frontier.Dequeue());
Console.WriteLine(frontier.Dequeue());

Console.WriteLine("----------------------------------------");

//Loop through and dequeue element from the queue
frontier.Enqueue(1);
frontier.Enqueue(2);
frontier.Enqueue(4);
frontier.Enqueue(8);
frontier.Enqueue(16);

while (frontier.Count > 0)
{
    Console.WriteLine(frontier.Dequeue());
}