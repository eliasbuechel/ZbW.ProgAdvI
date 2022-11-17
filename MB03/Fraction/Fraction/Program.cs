using System.Data.Common;
using System.Security.Cryptography.X509Certificates;

namespace Fraction
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Test");
            var a = new Fraction(5, 4);
            var b = new Fraction(1, 2);

            var sum = a + b;
            Console.WriteLine(a.ToString());
            Console.WriteLine(b.ToString());
            Console.WriteLine(sum.ToString());

            Fraction f = 4;
            Console.WriteLine(f);
            int i = (int)sum;
            Console.WriteLine(i);

            Fraction frag = -sum;
            Console.WriteLine(frag);

            if (a != b)
                Console.WriteLine("Fraction a is not equal to b");

            var p1 = new Person() { Name = "Thomas", Age = 45 };
            var p2 = new Person() { Name = "Thomas", Age = 45 };

            if (p1 != p2)
                Console.WriteLine("Object a is not equal to b");

        }
    }

    internal class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is Person person &&
                   Name == person.Name &&
                   Age == person.Age;
        }
        public static bool operator ==(Person p1, Person p2)
        {
            return p1.Equals(p2);
        }
        public static bool operator !=(Person p1, Person p2)
        {
            return !(p1 == p2);
        }
    }

    internal struct Fraction
    {
        private int m_numerator;
        private int m_denominator;

        public Fraction(int numerator, int denominator)
        {
            m_numerator = numerator;
            m_denominator = denominator;
        }

        public override string ToString()
        {
            return $"{m_numerator}/{m_denominator}";
        }

        public static Fraction operator +(Fraction a, Fraction b)
        {
            return new Fraction(a.m_numerator * b.m_denominator + b.m_numerator * a.m_denominator, a.m_denominator * b.m_denominator);
        }
        public static implicit operator Fraction(int x)
        {
            return new Fraction(x, 1);
        }

        public static implicit operator Fraction(short x)
        {
            return new Fraction(x, 1);
        }
        public static explicit operator int(Fraction f)
        {
            return f.m_numerator / f.m_denominator;
        }

        public static Fraction operator -(Fraction f)
        {
            return new Fraction(-f.m_numerator, f.m_denominator);
        }
        public static bool operator ==(Fraction a, Fraction b)
        {
            return (double)a.m_numerator / a.m_denominator == (double)b.m_numerator / b.m_denominator;
        }
        public static bool operator !=(Fraction a, Fraction b)
        {
            return !(a == b);
        }
    }
}