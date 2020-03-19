// using indica quali namespace utilizzo da questa classe, oltre al namespace in cui questa
// classe stessa si trova
// NB: i riferimenti tra "namespace" diversi non sono direttamente collegati ai riferimenti che si possono
// realizzare tra "progetti" diversi (Assembly diversi)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// using Esercizio2; // non posso riferimi al nome di un progetto perché un progetto NON È un namespace!!


namespace _03_Collezioni
{
    class ComparazioneDiOggetti
    {
        static void Main(string[] args)
        {
            var garage = new HashSet<Automobile>(new ConfrontoAutomobili());
            garage.Add(new Automobile()
            {
                Targa = "AB123CD",
                Marca = "Aaa",
                Modello = "Bbb"
            });

            garage.Add(new Automobile()
            {
                Targa = "EF123GH",
                Marca = "Aaa",
                Modello = "Bbb"
            });

            garage.Add(new Automobile()
            {
                Targa = "AB123CD",
                Marca = "Aaa",
                Modello = "Bbb"
            });

            var autoEsiste = garage.Contains(new Automobile()
            {
                Targa = "AB123CD",
                Marca = "Zzzz"
                // la marca è irrilevante perché io ho deciso che due auto sono uguali se è uguale la targa
            });
            Console.WriteLine($"L'automobile {(autoEsiste ? "esiste" : "non esiste")}");
            // operatore ternario => (condizione ? "se vero" : "se falso")
        }
    }
}
