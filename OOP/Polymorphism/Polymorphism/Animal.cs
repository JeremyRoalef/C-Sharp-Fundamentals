namespace Polymorphism
{
    public class Animal
    {
        public string Name { get; protected set; }

        public Animal(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }

        public void DoSomething()
        {
            Console.WriteLine("The animal does something");
        }
    }
}
