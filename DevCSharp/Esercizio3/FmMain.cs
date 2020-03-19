using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esercizio3
{
    // partial: è la carraterisca che consente a C# di defnire un'unica in più file diversi
    public partial class FmMain : Form
    {
        List<string> lines = new List<string>();
        List<Automobile> automobili = new List<Automobile>();
        public FmMain()
        {
            InitializeComponent();
        }

        private void BtnViaggio_Click(object sender, EventArgs e)
        {
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
            // faccio rifornimento a tutte le auto
            foreach (var auto in automobili)
            {
                auto.Rifornimento(10);
            }

            // inizia il viaggio... km per km...
            for (int km = 0; km < 300; km++)
            {
                lines.Add($"In viaggio... al km {km} :");
                foreach (var auto in automobili)
                {
                    lines.Add(auto.Viaggia(1));
                }
            }

            txtOutput.Lines = lines.ToArray();
        }
    }
}
