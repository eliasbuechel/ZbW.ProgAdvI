using System.Runtime.CompilerServices;
using Utilitys;

namespace Main
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Test");
            TestPoint3D();
        }

        public static void TestPoint3D()
        {
            var p1 = new Vector(10, 20, 30);
            var p2 = new Vector() { X = 1, Y = 2, Z = 3};

            Console.WriteLine(p1.ToString());
            Console.WriteLine(p2.ToString());

            Vector sum = p1 + p2;
            Console.WriteLine(sum.ToString());
            Vector diff = p1 - p2;
            Console.WriteLine(diff.ToString());
            Vector product1 = 9 * p1;
            Console.WriteLine(product1.ToString());
            Vector product2 = p1 * p2;
            Console.WriteLine(product2.ToString());
            // int betrag = |p1|;
            if (p1 == p2)
                Console.WriteLine("p1 == p2");
            if (p1 != p2)
                Console.WriteLine("p1 != p2");
            if (p1 == p1)
                Console.WriteLine("p1 == p1");

            double d = (double)p1;
            Vector a = 4;
        }
    }

}

namespace Utilitys
{
    internal struct Vector
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public Vector(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        public static Vector operator +(Vector a, Vector b)
        {
            return new Vector(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
        }
        public static Vector operator -(Vector a, Vector b)
        {
            return new Vector(a.X - b.X, a.Y - b.Y, a.Z - b.Z);
        }
        public static Vector operator *(int factor, Vector v)
        {
            return new Vector(factor * v.X, factor * v.Y, factor * v.Z);
        }
        public static Vector operator *(Vector a, Vector b)
        {
            int x = a.Y * b.Z - a.Z * b.Y;
            int y = a.Z * b.X - a.X * b.Z;
            int z = a.X * b.Y - a.Y * b.X;

            return new Vector(x, y, z);
        }
        /*
        public static double operator || (Vector v)
        {
            return Math.Sqrt(
                Math.Pow(v.X, 2) +
                Math.Pow(v.Y, 2) +
                Math.Pow(v.Z, 2)
                );
        }
        */
        public static bool operator ==(Vector a, Vector b)
        {
            return a.Equals(b);
        }
        public static bool operator !=(Vector a, Vector b)
        {
            return !a.Equals(b);
        }
        public static explicit operator double(Vector v)
        {
            return Weight(v);
        }
        public static double Weight(Vector v)
        {
            return Math.Sqrt(
                Math.Pow(v.X, 2) +
                Math.Pow(v.Y, 2) +
                Math.Pow(v.Z, 2)
                );
        }

        public static implicit operator Vector(int number)
        {
            return new Vector(number, 0, 0);
        }

        public override string ToString()
        {
            return $"{X}, {Y}, {Z}";
        }

        public override bool Equals(object? obj)
        {
            return obj is Vector vector &&
                   X == vector.X &&
                   Y == vector.Y &&
                   Z == vector.Z;
        }
    }
        
}