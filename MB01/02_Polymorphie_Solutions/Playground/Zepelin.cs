using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    class Zepelin : Luftfahrzeug
    {
        public double Gasvolumen { get; set; }

        public override void Starten()
        {
            Console.WriteLine("Der Zepelin startet.");
        }
    }
}