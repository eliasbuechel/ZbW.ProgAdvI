using System;
using System.Windows.Forms;
using Aufgabe_A15_1_2.Controller;

namespace Aufgabe_A15_1_2
{
    public partial class Form1 : Form
    {
        private PeopleManager pm;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pm = new PeopleManager();
            ShowNames();
        }

        private void CmdSortNames_Click(object sender, EventArgs e)
        {
            pm.SortNames();
            ShowNames();
        }

        private void ShowNames()
        {
            TxtNames.Clear();
            TxtNames.Text = pm.ToString();
        }
    }
}
