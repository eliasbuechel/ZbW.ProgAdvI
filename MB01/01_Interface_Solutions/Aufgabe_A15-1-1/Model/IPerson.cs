using System;

namespace Aufgabe_A15_1_3.Model
{
    interface IPerson
    {
        string Firstname { get; set; }
        string Lastname { get; set; }
        DateTime Birthday { get; set; }
        int GetAge();
    }
}
