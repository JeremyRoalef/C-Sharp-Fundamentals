namespace Classes
{
    public class House
    {
        //Create some attributes
        public float length;
        public float width;
        public int numOfRooms;

        private string houseAddress;

        public float GetArea()
        {
            return length * width;
        }

        private float GetPerimeter()
        {
            return (2 * width) + (2 * length);
        }
    }
}
