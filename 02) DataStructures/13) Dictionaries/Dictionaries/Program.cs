//Create a new dictionary

Dictionary<long, string> phoneBook = new Dictionary<long, string>()
{
    {0123456789, "Bob" },
    {9876543210, "Jeff" },
    {1112223456, "Billy" },
    {0000000000, "Joe" }
};

//phoneBook.Add(0123456789, "Bob");
//phoneBook[0123456789] = "Bob";

if (phoneBook.ContainsKey(098231212))
{
    Console.WriteLine(phoneBook[098231212]);
}
else
{
    Console.WriteLine("Phone number not found in phone book");
}

//Get the keys from the dictionary
Dictionary<long, string>.KeyCollection keyCollection = phoneBook.Keys;
long[] keyCollectionArray = keyCollection.ToArray();

//Display the keys
foreach (long key in keyCollectionArray)
{
    Console.Write(key + " || ");
}

Console.WriteLine();
Console.WriteLine("---------------------------------------");

//Get the values from the dictionary
Dictionary<long, string>.ValueCollection valueCollection = phoneBook.Values;
string[] valueCollectionArray = valueCollection.ToArray();
foreach (string value in valueCollectionArray)
{
    Console.Write(value + " || ");
}

Console.WriteLine();
Console.WriteLine("---------------------------------------");

//Use a foreach loop on the dictionary to grab keys and values
foreach (KeyValuePair<long, string> phoneKeyValue in phoneBook)
{
    Console.WriteLine($"{phoneKeyValue.Key} : {phoneKeyValue.Value}");
}

Console.WriteLine("---------------------------------------");

//Remove entries from the dictionary
if (phoneBook.Remove(0000000000))
{
    Console.WriteLine($"Phone number {0000000000} was removed");
}
else
{
    Console.WriteLine("Attemted to remove a phone number that didn't exist");
}

if (phoneBook.Remove(0000000000))
{
    Console.WriteLine($"Phone number {0000000000} was removed");
}
else
{
    Console.WriteLine("Attemted to remove a phone number that didn't exist");
}