using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esercizio4
{
    public partial class FmMain : Form
    {
        delegate string Operazione(string op1, string op2);

        public FmMain()
        {
            InitializeComponent();
        }

        private float? Convalida(string testo)
        {
            try
            {
                return float.Parse(testo);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(
                    $"Errore di conversione di un numero\n{ex.Message}",
                    "Attenzione",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                   );
                return null;
            }
        }

        private void Pulisci()
        {
            txtOp1.Text = "";
            txtOp2.Text = "";
            // lblRisultato.Text = "";
        }

        private string Somma(string op1, string op2)
        {
            return ((Convalida(op1) ?? 0) + (Convalida(op2) ?? 0)).ToString();
        }

        private string Prodotto(string op1, string op2)
        {
            return ((Convalida(op1) ?? 0) * (Convalida(op2) ?? 0)).ToString();
        }

        private void EseguiOperazione(Operazione operazione, string op1, string op2, string testo)
        {
            lblRisultato.Text = operazione(op1, op2);
            AggiungiOperazione(testo);
            Pulisci();
        }

        private void BtnTutti_Click(object sender, EventArgs e)
        {
            

            // cast del sender a Button
            var operazione = ((Button)sender).Text;
            var op1 = txtOp1.Text;
            var op2 = txtOp2.Text;
            switch (operazione)
            {
                case "+":
                    EseguiOperazione(Somma, op1, op2, operazione);
                    break;
                case "*":
                    EseguiOperazione(Prodotto, op1, op2, operazione);
                    break;
                case "-":
                    EseguiOperazione((o1, o2) => {
                        return ((Convalida(op1) ?? 0) * (Convalida(op2) ?? 0)).ToString();
                    }, txtOp1.Text, txtOp2.Text, operazione);
                    break;
                case "/":
                    lblRisultato.Text = (
                        (Convalida(txtOp1.Text) ?? 0) / (Convalida(txtOp2.Text) ?? 0)
                        ).ToString();
                    break;
            }
            AggiungiOperazione(operazione);
            Pulisci();
        }

        private void AggiungiOperazione(string operazione)
        {
            lblUltimeOp.Text += $"\n{txtOp1.Text} {operazione} {txtOp2.Text} = {lblRisultato.Text}";
        }
    }
}
