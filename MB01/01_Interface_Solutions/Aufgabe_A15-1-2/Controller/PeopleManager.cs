using System;
using Aufgabe_A15_1_2.Model;

namespace Aufgabe_A15_1_2.Controller
{
    class PeopleManager
    {
        private Person[] people;

        public PeopleManager()
        {
            people = new Person[7];
            FillDemoPeople();
        }

        private void FillDemoPeople()
        {
            people[0] = new Person("Anne", "Bolika", 42);
            people[1] = new Person("Max", "Muster", 33);
            people[2] = new Person("Peter", "Ammann", 23);
            people[3] = new Person("Petra", "Ammann", 18);
            people[4] = new Person("Anna", "Bolika", 42);
            people[5] = new Person("Clair", "Zelda", 27);
            people[6] = new Person("Peter", "Ammann", 18);
        }


        public override string ToString()
        {
            string temp = "";
            foreach (Person p in people)
            {
                temp += p.ToString() + "\r\n";
            }
            return temp;
        }

        public void SortNames()
        {
            Array.Sort(people, new PersonComparer());
        }
    }
}