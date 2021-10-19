namespace Aufgabe_A15_1_2.Model
{
    class Person
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }

        public Person(string f, string l, int a)
        {
            Firstname = f;
            Lastname = l;
            Age = a;
        }

        public override string ToString()
        {
            return Firstname + " " + Lastname + ", Age: " + Age;
        }
    }
}
