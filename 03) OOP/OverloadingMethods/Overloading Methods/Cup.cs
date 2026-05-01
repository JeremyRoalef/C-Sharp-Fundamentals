namespace Overloading_Methods
{
    public class Cup
    {
        float radius;
        float height;
        bool hasHandle;

        public Cup(float radius) : this(radius, 0)
        {
            //this.radius = radius;
            //this.height = 0;
            //hasHandle = false;

            Console.WriteLine("First constructor was called");
        }
        public Cup(float radius, float height) : this(radius, height, false)
        {
            //this.radius = radius;
            //this.height = height;
            //hasHandle = false;

            Console.WriteLine("Second constructor was called");
        }
        public Cup(float radius, float height, bool hasHandle)
        {
            this.radius = radius;
            this.height = height;
            this.hasHandle = hasHandle;

            Console.WriteLine("Third constructor was called");
        }

        public override string ToString()
        {
            string handleMessage = hasHandle ?
                "Cup has a handle" : "Cup has no handle";

            return $"Radius: {radius}\n" +
                $"Height: {height}\n" +
                $"{handleMessage}";
        }
    }
}
