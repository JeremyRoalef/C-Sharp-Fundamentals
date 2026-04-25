namespace TheConstructor
{
    public class Animal
    {
        public int numOfLegs;
        public string name;

        //Constructor syntax
        public Animal()
        {
            //Initialize the object's attributes
            this.numOfLegs = 10;
            this.name = "Unknown";

            //Initialize the object's behavior
            DisplayMessage();
        }

        void DisplayMessage()
        {
            Console.WriteLine("Animal has been created!");
        }
    }
}
