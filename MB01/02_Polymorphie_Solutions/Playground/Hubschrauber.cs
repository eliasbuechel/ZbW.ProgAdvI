using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    class Hubschrauber : Luftfahrzeug
    {
        public double Rotor { get; set; }

        public override void Starten()
        {
            Console.WriteLine("Der Hubschrauber startet.");
        }

        public void Hallo()
        {
            Console.WriteLine("Hallo");
        }
    }
}