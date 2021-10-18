using Analyseaufgabe_A14_1_4.Model;
using System;

namespace Analyseaufgabe_A14_1_4.Model
{
    public class DVD : Medium
    {
        private string regisseur;

        public string Regisseur
        {
            get { return regisseur; }
            set
            {
                if (value != null && value.Length > 0)
                    regisseur = value;
                else
                    throw new ArgumentException("argument may not be null or empty!");
            }
        }


        public DVD(string titel, string regisseur, int spielzeit) : base (titel, spielzeit)
        {
            Regisseur = regisseur;
        }

        public override string Ausgeben()
        {
            const string delimiter = " | ";
            string data = GetType().Name + ": " + Titel + " (" + Spielzeit + " Min)" + delimiter;
            data += HabIch == true ? "*" + delimiter : "" + delimiter;
            data += "Kommentar: " + Kommentar + delimiter;
            data += "Regisseur: " + Regisseur + delimiter;
            return data;
        }
    }
}
