namespace Properties
{
    public class Light
    {
        string color;
        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public float Intensity
        {
            get;
            private set;
        }

        int position;
        public int Position
        {
            set
            {
                if (value < 0) return;

                position = value;
                Console.WriteLine("The value of the light's position has changed");
            }
            get 
            {  
                return position; 
            }
        }
    }
}
