using System.Collections;
using Aufgabe_A15_1_2.Model;


namespace Aufgabe_A15_1_2
{
    class PersonComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            // In einzelnen Schritten

            // Zuerst Argumente zurück in Person Objekte casten
            // Person one = (Person)x;
            // Person two = (Person)y;

            // Nachnamen der ersten Person beschaffen und in Grossbuchstaben umwandeln
            // string lastnameOne = one.Lastname.ToUpper();

            // Nachname der zweiten Person beschaffen und in Grossbuchstaben umwandeln
            // string lastnameTwo = two.Lastname.ToUpper();

            // Strings mittels der String-Klasse miteinander vergleichen lassen
            // Liefert grösser als 0, wenn lastnameOne grösser (lexikalische Prüfung)
            // Liefert 0, wenn beide identisch
            // Liefert kleiner als 0, wenn lastnameOne kleiner (lexikalische Prüfung)
            // int result = lastnameOne.CompareTo(lastnameTwo); 

            // Ergebnis zurückgeben an Aufrufstelle (also Sort)
            // return result

            // Alles in einer Zeile zusammengefasst 
            // Wenn die Nachnamen zweier Person identisch, dann vergleiche die Vornamen
            if (((Person)x).Lastname.ToUpper().CompareTo(((Person)y).Lastname.ToUpper()) == 0)
            {
                // Wenn die Vornamen zweier Person identisch, dann vergleiche die Nachnamen
                if (((Person)x).Firstname.ToUpper().CompareTo(((Person)y).Firstname.ToUpper()) == 0)
                {
                    if (((Person)x).Age > ((Person)y).Age)
                        return 1;
                    else if (((Person)x).Age < ((Person)y).Age)
                        return -1;
                    else
                        return 0;
                }
                else
                    return ((Person)x).Firstname.ToUpper().CompareTo(((Person)y).Firstname.ToUpper());
            }
            else
            {
                return ((Person)x).Lastname.ToUpper().CompareTo(((Person)y).Lastname.ToUpper());
            }
        }
    }
}