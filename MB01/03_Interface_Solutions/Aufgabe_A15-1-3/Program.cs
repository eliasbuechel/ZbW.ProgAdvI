using System;
using System.Windows.Forms;
using Aufgabe_A15_1_3.Controller;

namespace Aufgabe_A15_1_3
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            PeopleManager pm = new PeopleManager();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(pm));
        }
    }
}
