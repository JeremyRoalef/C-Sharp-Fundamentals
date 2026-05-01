namespace Structs
{
    public struct Vector3 : IEquatable<Vector3>
    {
        public float x, y, z;

        public static Vector3 Zero = new Vector3(0, 0, 0);
        public static Vector3 One = new Vector3(1, 1, 1);
        public static Vector3 Right = new Vector3(1, 0, 0);
        public static Vector3 Up = new Vector3(0, 1, 0);
        public static Vector3 Forward = new Vector3(0, 0, 1);

        public Vector3(float x, float y, float z)
        {
            this.x = x; 
            this.y = y; 
            this.z = z;
        }

        public bool Equals(Vector3 other)
        {
            return other.x == x && 
                other.y == y &&
                other.z == z;
        }

        public static Vector3 operator +(Vector3 a, Vector3 b)
        {
            return new Vector3(
                    a.x + b.x,
                    a.y + b.y,
                    a.z + b.z
                );
        }

        public static Vector3 operator -(Vector3 a, Vector3 b)
        {
            return new Vector3(
                    a.x - b.x,
                    a.y - b.y,
                    a.z - b.z
                );
        }

        public static Vector3 operator -(Vector3 a)
        {
            return new Vector3(
                -a.x,
                -a.y,
                -a.z
                );
        }

        public static Vector3 operator * (float constant, Vector3 vector)
        {
            return new Vector3(
                constant * vector.x,
                constant * vector.y,
                constant * vector.z
                );
        }

        public override string ToString()
        {
            // (x, y, z)
            return $"({x}, {y}, {z})";
        }

        public static float Distance(Vector3 a, Vector3 b)
        {
            Vector3 deltaVector = b - a;
            float magnitude = MathF.Sqrt(
                (deltaVector.x * deltaVector.x) +
                (deltaVector.y * deltaVector.y) +
                (deltaVector.z * deltaVector.z)
                );

            return magnitude;
        }
    }
}
