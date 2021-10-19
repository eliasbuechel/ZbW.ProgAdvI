using System;
using Aufgabe_A15_1_3.Model;

namespace Aufgabe_A15_1_3.Controller
{
    public class PeopleManager
    {
        private Person[] people;
        private int counter;

        public PeopleManager()
        {
            people = new Person[100];
            counter = 0;
        }

        public bool Add(Person p)
        {
            if (counter < people.Length && p != null)
            {
                people[counter++] = p;
                SortData();
                return true;
            }
            return false;
        }

        public Person GetOldestPerson()
        {
            IPerson oldest = people[0];
            for (int c = 0; c < counter; c++)
            {
                IPerson p = people[c];
                if (p.GetAge() > oldest.GetAge())
                    oldest = p;
            }
            return (Person)oldest;
        }

        public string GetOldestPersonAsString()
        {

            return GetOldestPerson().ToString();
        }

        public string[] GetPeopleAsString()
        {
            SortData();
            string[] temp = new string[counter];
            for (int c = 0; c < counter; c++)
                temp[c] = people[c].ToString();
            return temp;
        }

        private void SortData()
        {
            Array.Sort(people, 0, counter);
        }
    }
}
