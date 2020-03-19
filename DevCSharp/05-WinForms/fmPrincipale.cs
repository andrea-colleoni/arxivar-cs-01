using _04_Ereditarieta;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_WinForms
{
    public partial class FmPrincipale : Form
    {
        List<string> linee = new List<string>();
        public FmPrincipale()
        {
            InitializeComponent();
        }

        private void BtnComando_Click(object sender, EventArgs e)
        {
            lblTitolo.Text = txtTesto.Text;

            var persona = new Persona();
            persona.Nome = "Mario";
            persona.Cognome = "Rossi";

            linee.Add(persona.NomeCompleto());

            var studente = new Studente();
            studente.Nome = "Anna";
            studente.Cognome = "Verdi";
            studente.Matricola = "3456765";

            linee.Add(studente.NomeCompleto());
            studente.Iscrizione("Dev C#");

            txtOutput.Lines = linee.ToArray();
        }

        private void FmPrincipale_Click(object sender, EventArgs e)
        {

        }
    }
}
