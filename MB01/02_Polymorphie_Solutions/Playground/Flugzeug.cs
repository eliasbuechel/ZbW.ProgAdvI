using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    class Flugzeug : Luftfahrzeug
    {
        public double Spannweite {get; set;}

        public override void Starten()
        {
            Console.WriteLine("Das Flugzeug startet.");
        }
    }
}