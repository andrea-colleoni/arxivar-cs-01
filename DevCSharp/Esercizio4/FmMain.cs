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

        private void BtnTutti_Click(object sender, EventArgs e)
        {
            // cast del sender a Button
            var operazione = ((Button)sender).Text;
            switch (operazione)
            {
                case "+":
                    lblRisultato.Text = (
                        (Convalida(txtOp1.Text) ?? 0) + (Convalida(txtOp2.Text) ?? 0)
                        ).ToString();
                    break;
                case "-":
                    lblRisultato.Text = (
                        (Convalida(txtOp1.Text) ?? 0) - (Convalida(txtOp2.Text) ?? 0)
                        ).ToString();
                    break;
                case "*":
                    lblRisultato.Text = (
                        (Convalida(txtOp1.Text) ?? 0) * (Convalida(txtOp2.Text) ?? 0)
                        ).ToString();
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
