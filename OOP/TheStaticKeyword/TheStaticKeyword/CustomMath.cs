namespace TheStaticKeyword
{
    public static class CustomMath
    {
        public static int unitNumber;

        public static float GetAreaOfCircle(float radius)
        {
            return (float)Math.PI * radius * radius;
        }

        static CustomMath()
        {
            Console.WriteLine("Calling the static CustomMath constructor");
            unitNumber = 1;
        }
    }
}
