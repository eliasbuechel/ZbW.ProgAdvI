using System;
using Analyseaufgabe_A14_1_4.Model;

namespace Analyseaufgabe_A14_1_4.Controller
{
    public class Datenbank
    {
        private Medium[] medien;
        private int medienCounter;

        public Datenbank()
        {
            medien = new Medium[100];
            medienCounter = 0;
        }

        public bool Erfasse(Medium medium)
        {
            if (medienCounter < medien.Length)
            {
                medien[medienCounter++] = medium;
            }
            return false;
        }

        public string[] GibAlleMedienAlsStringArray()
        {
            string[] data = new string[medienCounter];
            int dataCounter = 0;
            for(int c=0; c<medienCounter; c++)
            {
                data[dataCounter++] = medien[c].Ausgeben();
            }
            return data;
        }

        private void OptimiereArray(string[] data)
        {
            int counter = 0;
            foreach (string element in data)
            {
                if (element != null)
                    counter++;
            }

            Array.Resize(ref data, counter);
        }
    }
}