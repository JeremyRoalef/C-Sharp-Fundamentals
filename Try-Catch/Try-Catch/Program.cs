try
{
    //Trying to parse this string will fail, causeing a System.FormatException error
    int.Parse("wergfeeqf");
    int.Parse("woeohgweg");
}
catch (FormatException e)
{
    Console.WriteLine(e.Message);
}
