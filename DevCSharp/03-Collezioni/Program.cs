using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Collezioni
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = new string[10];
            // limiti dell'array:
            // - devo conoscerne la dimensione in fase di dichiarazione
            // - non posso, una volta dichiarato, modificarne la dimensione
            //      - non posso rimovere o aggiungere oggetti
            array[0] = "ciao";
            // posso collocare elementi nelle posizioni già disponibili nel contenitore
            var dimensioneArray = array.Length;
            array[1] = "buonasera";
            

            List<string> lista = new List<string>();
            // - usa "Generics" per definire qul è il tipo di elementi contenuti nella collezione
            lista.Add("ciao");
            // - posso aggiungere elementi (aumentare la dimensione del contenitore)
            var dimensioneLista = lista.Count;

            // foreach funziona su tutte le strutture che sono "iterabili"; sia array che le collezioni lo sono
            foreach (var s in array) Console.WriteLine(s);

            // come convenzione, anche se c'è solo un'istruzione è preferibile usare { ... }
            foreach (var s in lista)
            {
                Console.WriteLine(s);
            }
        }
    }
}
