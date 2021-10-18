using System;

namespace Playground
{
    public abstract class Luftfahrzeug
    {
        public string Hersteller { get; set; }
        public int Baujahr { get; set; }

        public virtual void Starten()
        {
            Console.WriteLine("Das Luftfahrzeug startet.");
        }

        
    }
}