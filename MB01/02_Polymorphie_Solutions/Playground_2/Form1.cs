using System;
using System.Windows.Forms;

namespace Playground_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdStart_Click(object sender, EventArgs e)
        {
            DVD d1 = new DVD("Film 1", "Regisseur 1", 120);

            Medium m1 = d1; 

            LblOutput.Text = m1.Ausgeben();
            
        }
    }
}
