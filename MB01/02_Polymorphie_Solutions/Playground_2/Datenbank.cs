namespace Playground_2
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

        public string[] GibAlleCdAlsArray()
        {
            string[] data = new string[medienCounter];
            int dataCounter = 0;
            foreach (Medium m in medien)
            {
                if (m is CD)
                    data[dataCounter++] = m.Ausgeben();
            }
            return data;
        }

        public string[] GibAlleDvdAlsArray()
        {
            string[] data = new string[medienCounter];
            int dataCounter = 0;
            foreach (Medium m in medien)
            {
                if (m is DVD)
                    data[dataCounter++] = m.Ausgeben();
            }
            return data;
        }
    }
}