namespace Polymorphism
{
    public class Dog : Animal
    {
        public Dog(string name) : base(name)
        {
        }

        public void WagTail()
        {
            Console.WriteLine("The dog wags its tail");
        }
    }
}
