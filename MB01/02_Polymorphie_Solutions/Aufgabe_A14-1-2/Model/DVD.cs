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

        public string Ausgeben()
        {
            const string delimiter = " | ";
            string data = base.Ausgeben();
            
            data += "Regisseur: " + Regisseur + delimiter;
            return data;
        }
    }
}
