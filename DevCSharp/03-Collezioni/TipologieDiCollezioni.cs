using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Collezioni
{
    class TipologieDiCollezioni
    {
        static void Main(string[] args)
        {
            var interi = new List<int>();
            interi.Add(10);
            interi.Add(20);
            interi.Add(30);
            // la caratteristica principale di List è che posso accedere per indice, come un array
            Console.WriteLine(interi[0]);
            // ne consegue che:
            // - add, aggiunge gli elementi "in sequanza ordinata" => come li ho messi, li ritrovo

            Dictionary<int, string> mesiDellAnno = new Dictionary<int, string>();
            mesiDellAnno.Add(1, "gennaio");
            mesiDellAnno.Add(2, "febbraio");
            mesiDellAnno.Add(3, "marzo");
            // in un dictionary posso decidere qual è il tipo e il valore dell'indice (key) di ogni elemnto
            // della collezione
            Console.WriteLine(mesiDellAnno[2]);

            Dictionary<string, string> traduttore = new Dictionary<string, string>();
            traduttore.Add("red", "rosso");
            traduttore.Add("cat", "gatto");
            traduttore.Add("table", "tavolo");
            Console.WriteLine(traduttore["red"]);
            // la comparazione è "red" == "red"

            foreach(var kv in traduttore) // iterazione sugli oggetti chiave/valore (KeyValuePair)
            {
                Console.WriteLine($"L'elemento con chiave {kv.Key} ha valore {kv.Value}");
            }
            foreach(var k in traduttore.Keys) // iterazione sulle chiavi
            {
                Console.WriteLine($"L'elemento con chiave {k} ha valore {traduttore[k]}");
            }
            foreach (var v in traduttore.Values) // iterazione sui valori
            {
                Console.WriteLine($"Nella collezione esiste un elemento con valore {v}");
            }
        }
    }
}
