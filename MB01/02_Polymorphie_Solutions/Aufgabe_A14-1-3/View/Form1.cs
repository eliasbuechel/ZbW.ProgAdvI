using System;
using System.Windows.Forms;
using Analyseaufgabe_A14_1_4.Model;
using Analyseaufgabe_A14_1_4.Controller;

namespace Analyseaufgabe_A14_1_4
{
    public partial class Form1 : Form
    {
        private Datenbank Db { get; set; }

        public Form1(Datenbank db)
        {
            InitializeComponent();
            if (db == null)
                throw new ArgumentNullException("argument may not be null!");
            else
            {
                Db = db;
                SimuliereObjektErzeugung();
            }   
        }

       private void SimuliereObjektErzeugung()
        {
            Db.Erfasse(new CD("500 PS", "Bonez MC & RAF Camora", 12, 54));
            Db.Erfasse(new CD("Melodien", "Capital Bra", 19, 68));
            Db.Erfasse(new CD("Promises", "Calvin Harris, Sam Smith", 3, 12));

            Db.Erfasse(new DVD("Ready Player One", "Steven Spielberg", 182));
            Db.Erfasse(new DVD("A Beautiful Day", "John Francis Daley,", 102));
            Db.Erfasse(new DVD("Game Night", "Lynne Ramsay", 98));
        }

        private void CmdShowMedia_Click(object sender, EventArgs e)
        {
            TxtMediaList.Text = "";
            foreach (string cd in Db.GibAlleMedienAlsStringArray())
            {
                TxtMediaList.Text += cd + "\r\n";
            }
        }
    }
}
