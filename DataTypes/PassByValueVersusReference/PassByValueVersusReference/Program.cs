using PassByValueVersusReference;

public class Program
{
    static void Main(string[] args)
    {
        //Create a new integer and pass its value to a method
        int i = 10;
        DisplayNumber(i);

        //Show the current value of the variable
        Console.WriteLine("My variable value is currently " + i);

        Console.WriteLine("---------------------------------------------------------");

        //Create a new integer and pass the reference of that variable to the method
        int j = 17;
        UpdateVariable(ref j);

        //Show the current value of the variable. Notice that, unlike the example above,
        //the value of j changed because of the method
        Console.WriteLine("My variable value is currently " + j);

        Console.WriteLine("---------------------------------------------------------");

        //Craete a new message pointer and a new message object
        Message myMessageObj = new Message();
        myMessageObj.MyMessage = "Hello World!";

        //Pass the message object's value to the method
        UpdateMyMessage(myMessageObj);
        
        //Show the current value of the object's MyMessage string property. Notice that the property's value changed
        //This is because the method's message parameter copies our message's pointer to the object in memory
        //The object in memory is not the value of our message variable. The value is its pointer
        Console.WriteLine("My message value is currently " + myMessageObj.MyMessage);

        Console.WriteLine("---------------------------------------------------------");

        //Craete a new message objects
        Message myMessageObj2 = new Message();
        myMessageObj2.MyMessage = "C# is a fun language!";

        //Pass the reference of the new message object to the method
        UpdateMyMessageObjReference(ref myMessageObj2);

        //Show the current value of the object's MyMessage string property. Just like before, the message value changed
        //However, our object is now pointing to a new object in memory, not the original object with the message:
        //"C# is a fun language!". This is because we changed our message pointer to a new object.
        //The previous object in memory with the original message can no longer be accessed
        Console.WriteLine("My message value is currently " + myMessageObj2.MyMessage);
    }

    static void DisplayNumber(int myNum)
    {
        Console.WriteLine("The current value of the parameter is " + myNum);

        myNum = 7;

        Console.WriteLine("The new value of the parameter is " + myNum);
    }

    static void UpdateVariable(ref int myNum)
    {
        Console.WriteLine("The current value of the parameter is " + myNum);

        myNum = 7;

        Console.WriteLine("The new value of the parameter is " + myNum);
    }

    static void UpdateMyMessage(Message message)
    {
        Console.WriteLine("The current message is " + message.MyMessage);

        message.MyMessage = "Goodbye World!";

        Console.WriteLine("The new message is " + message.MyMessage);
    }

    static void UpdateMyMessageObjReference(ref Message message)
    {
        Console.WriteLine("The current message is " + message.MyMessage);

        message = new Message();
        message.MyMessage = "C# is a weird language";

        Console.WriteLine("The new message is " + message.MyMessage);
    }
}