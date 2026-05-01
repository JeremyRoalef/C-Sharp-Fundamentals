namespace Polymorphism
{
    public class Bird : Animal
    {
        public Bird(string name) : base(name)
        {
        }

        public void Fly()
        {
            Console.WriteLine("The bird flies");
        }
    }
}
