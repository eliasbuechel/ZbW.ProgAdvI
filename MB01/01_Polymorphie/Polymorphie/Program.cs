using System;

namespace Polymorphie {
    class Program {
        static void Main(string[] args) {
            // Test für new, abstract, virtual
            Flugzeug flg = new Flugzeug();
            flg.Starten();
            Hubschrauber hubi = new Hubschrauber();
            hubi.Starten();



            // Test Polymorphie - Auswirkungen der drei Varianten
            //Luftfahrzeug[] arr = new Luftfahrzeug[4];
            //arr[0] = new Flugzeug();
            //arr[1] = new Hubschrauber();
            //arr[2] = new Hubschrauber();
            //arr[3] = new Flugzeug();
            //foreach (Luftfahrzeug temp in arr) {
            //    temp.Starten();
            //}

            //Console.ReadLine();
        }
    }

    public class Luftfahrzeug {
        public string Hersteller { get; set; }
        public int Baujahr { get; set; }

        public void Starten() {
            Console.WriteLine("Das Luftfahrzeug startet.");
        }
    }

    public class Flugzeug : Luftfahrzeug {
        public double Spannweite { get; set; }
    }

    public class Hubschrauber : Luftfahrzeug {
        public double Rotor { get; set; }
    }
}
