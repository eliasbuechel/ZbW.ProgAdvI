using System;
using System.Collections.Generic;

namespace Polymorphie {
    class Program {
        static void Main(string[] args) {
            // Test für new, abstract, virtual
            Flugzeug flg = new Flugzeug();
            flg.Starten();
            Hubschrauber hubi = new Hubschrauber();
            hubi.Starten();
            Zeppelin zpl = new Zeppelin();
            zpl.Starten();

            Luftfahrzeug lfz = new Flugzeug();
            Luftfahrzeug lfz2 = new Hubschrauber();
            Luftfahrzeug lfz3 = new Zeppelin();

            List<Luftfahrzeug> luftfahrzeuge = new List<Luftfahrzeug>();
            luftfahrzeuge.Add(lfz);
            luftfahrzeuge.Add(lfz2);
            luftfahrzeuge.Add(lfz3);

            foreach (Luftfahrzeug luftfahrzeug in luftfahrzeuge)
            {
                luftfahrzeug.Starten();
            }

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

    public abstract class Luftfahrzeug {
        public string Hersteller { get; set; }
        public int Baujahr { get; set; }
        public abstract void Starten();
    }
    public class Flugzeug : Luftfahrzeug
    {
        public double Spannweite { get; set; }
        public override void Starten()
        {
            Console.WriteLine("Das Flugzeug startet.");
        }
    }
    public class Hubschrauber : Luftfahrzeug
    {
        public double Rotor { get; set; }
        public override void Starten()
        {
            Console.WriteLine("Der Hubschrauber startet.");
        }
    }
    public class Zeppelin : Luftfahrzeug
    {
        public override void Starten()
        {
            Console.WriteLine("Der Zeppelin startet.");
        }
    }
}
