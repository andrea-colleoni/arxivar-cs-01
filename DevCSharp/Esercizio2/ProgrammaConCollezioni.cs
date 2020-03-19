using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio2
{
    class ProgrammaConCollezioni
    {
        static void Main(string[] args)
        {
            var automobili = new List<Automobile>(); // il contenitore, non il contenuto

            // costruisco la prima automobile e la metto nella prima cella del contenitore
            // 1: costruttore vuoto e valorizzazione in loco dei campi
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
            var automobile = new Automobile();
            automobile.Marca = "Citroen";
            automobile.Modello = "C4";
            automobile.CapacitaSerbatoio = 60;
            automobile.Cilindrata = 1600;
            automobile.ConsumoKmLitro = 20;

            automobili.Add(automobile);

            // faccio rifornimento a tutte le auto
            foreach (var auto in automobili)
            {
                auto.Rifornimento(10);
            }

            // inizia il viaggio... km per km...
            for (int km = 0; km < 300; km++)
            {
                Console.WriteLine($"In viaggio... al km {km} :");
                foreach (var auto in automobili)
                {
                    auto.Viaggia(1);
                }
            }
        }
    }
}
