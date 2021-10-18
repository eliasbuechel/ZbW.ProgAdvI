using System;

namespace Aufgabe_A15_1_3.Model
{
    public class Person : IPerson, IComparable
    {

        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime Birthday { get; set; }

        public Person(string firstname, string lastname, DateTime birthday)
        {
            Firstname = firstname;
            Lastname = lastname;
            Birthday = birthday;
        }

        public int GetAge()
        {
            return DateTime.Now.Subtract(Birthday).Days / 365;
        }

        public override string ToString()
        {
            return Firstname + ", " + Lastname + ", " + Birthday.ToShortDateString();
        }

        public int CompareTo(object obj)
        {
            if(Lastname.CompareTo(((Person)obj).Lastname)==0)
            {
                if (Firstname.CompareTo(((Person)obj).Firstname) == 0)
                {
                    return Birthday.CompareTo(((Person)obj).Birthday);
                }
                else
                    return Firstname.CompareTo(((Person)obj).Firstname);
            }
            else
                return Lastname.CompareTo(((Person)obj).Lastname);
        }
    }
}