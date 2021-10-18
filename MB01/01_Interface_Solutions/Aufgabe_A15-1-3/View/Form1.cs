using System;
using System.Windows.Forms;
using Aufgabe_A15_1_3.Controller;
using Aufgabe_A15_1_3.Model;

namespace Aufgabe_A15_1_3
{
    public partial class Form1 : Form
    {
        private PeopleManager pm;
        public Form1(PeopleManager pm)
        {
            this.pm = pm;
            InitializeComponent();
        }

        private void CmdCreate_Click(object sender, EventArgs e)
        {
            string firstname = TxtFirstname.Text;
            string lastname = TxtLastName.Text;
            DateTime birthday = DtpBirthday.Value;
            pm.Add(new Person(firstname, lastname, birthday));

            UpdateListBox();
            ClearInputFields();
        }

        private void UpdateListBox()
        {
            TxtList.Text = "";
            foreach (string s in pm.GetPeopleAsString())
            {
                TxtList.Text += s + "\r\n";
            }
        }

        private void ClearInputFields()
        {
            TxtFirstname.Text = "";
            TxtLastName.Text = "";
            DtpBirthday.ResetText();
        }

        private void CmdOldestPerson_Click(object sender, EventArgs e)
        {
            LblOldestPerson.Text = pm.GetOldestPerson().ToString(); 
        }
    }
}
