namespace Polymorphism
{
    public class Cat : Animal
    {
        public Cat(string name) : base(name)
        {
        }

        public void Pounce()
        {
            Console.WriteLine("The cat pounces");
        }
    }
}
