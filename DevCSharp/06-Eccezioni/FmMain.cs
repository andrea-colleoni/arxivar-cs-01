using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06_Eccezioni
{
    // partial: è la carraterisca che consente a C# di defnire un'unica in più file diversi
    public partial class FmMain : Form
    {
        List<string> lines = new List<string>();
        List<Automobile> automobili = new List<Automobile>();
        public FmMain()
        {
            InitializeComponent();
            automobileBindingSource.DataSource = automobili;
            /*
            automobili.Add(new Automobile()
            {
                CapacitaSerbatoio = 50,
                Cilindrata = 1500,
                ConsumoKmLitro = 18,
                Marca = "Fiat",
                Modello = "Multipla"
            });

            // 2: costruttore con argomenti
            // preferibile se c'è una complessa logia di costruzione dell'oggetto
            automobili.Add(new Automobile("Toyota", "Auris", 1800, 40, 22));

            // 3: costruttore vuoto e accesso ai campi
            automobili.Add(new Automobile()
            {
                Marca = "Citroen",
                Modello = "C4",
                CapacitaSerbatoio = 60,
                Cilindrata = 1600,
                ConsumoKmLitro = 20
            });
            */
        }

        private void BtnViaggio_Click(object sender, EventArgs e)
        {
            // faccio rifornimento a tutte le auto
            foreach (var auto in automobili)
            {
                auto.Rifornimento(10);
            }

            try
            {
                // inizia il viaggio... km per km...
                for (int km = 0; km < 300; km++)
                {
                    lines.Add($"In viaggio... al km {km} :");
                    foreach (var auto in automobili)
                    {
                        lines.Add(auto.Viaggia(1));
                    }
                }
            }
            catch (CarburanteFinitoException ex)
            {
                lines.Add(ex.Message);
            }
            catch  // catch all
            {
                MessageBox.Show("Si è verificato un errore sconosciuto");
            }
            txtOutput.Lines = lines.ToArray();
        }

        private void BtnAggiungi_Click(object sender, EventArgs e)
        {
            try
            {
                var capacita = float.Parse(txtCapacita.Text);
                var cilindrata = int.Parse(txtCilindrata.Text);
                var consumo = float.Parse(txtConsumo.Text);

                automobili.Add(new Automobile()
                {
                    CapacitaSerbatoio = capacita,
                    Cilindrata = cilindrata,
                    ConsumoKmLitro = consumo,
                    Marca = txtMarca.Text,
                    Modello = txtModello.Text
                });
                automobileBindingSource.ResetBindings(false);

                txtCapacita.Text = "";
                txtCilindrata.Text = "";
                txtConsumo.Text = "";
                txtMarca.Text = "";
                txtModello.Text = "";
                txtOutput.Text = "";
                txtMarca.Focus();
                /*
                int a = 0;
                int b = 10;
                int q = b / a;
                */
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Attenzione: alcune conversioni di numero non sono andate a buon fine.\n" +
                    ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show("Attenzione: hai diviso per zero!! Non si può!!.\n" +
                    ex.Message);
            }
            // dopo il try catch
        }
    }
}
