using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Linq
{
    class Program
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Program));

        static void Main(string[] args)
        {
            var giorniDellaSettimana = new List<string>();
            giorniDellaSettimana.Add("lunedì");
            giorniDellaSettimana.Add("martedì");
            giorniDellaSettimana.Add("mercoledì");
            giorniDellaSettimana.Add("giovedì");
            giorniDellaSettimana.Add("venerdì");
            giorniDellaSettimana.Add("sabato");
            giorniDellaSettimana.Add("domenica");

            // linq aggiunge la possibilità di agire sulle collezioni con un paradigma funzionale
            /*
            var altraLista = new List<string>();
            foreach(var s in giorniDellaSettimana)
            {
                if (s.EndsWith("dì")) // il predicato in base a cui sceglo gli elementi della lista
                {
                    altraLista.Add(s);
                }
            }
            */
            // uso una lambda expression per definire una f() di trasformazione
            // la funzione viene utilizzata dall'extension method di linq per eseguire la funzione richiesta
            // in questo caso Where() => filtro
            var altraLista = giorniDellaSettimana.Where(s => s.EndsWith("dì"));
            log.Info($"elementi nella lista: {altraLista.Count()}");
            var esisteV = giorniDellaSettimana.Any(x => x.StartsWith("v"));
            log.Info($"esiste V? {esisteV}");
            // voglio alla fine una List<Appuntamento>
            var appuntamenti = giorniDellaSettimana
                .Where(s => s.EndsWith("dì") && s.StartsWith("l"))
                .Select(s => new Appuntamento()
                {
                    GiornoDellaSettimana = s,
                    Oggetto = "Appuntamento",
                    Categoria = "Importante",
                    OreDiLavoroGiornaliere = 8
                })
                .Where(a => a.Categoria == "Importante");

            var maxOre = appuntamenti.Max(a => a.OreDiLavoroGiornaliere);
            var mediaOre = appuntamenti.Average(a => a.OreDiLavoroGiornaliere);
            var sommaOre = appuntamenti.Sum(a => a.OreDiLavoroGiornaliere);

            // & , &&   (| , ||)
            // a & b & c & d => se a è false, il programma considera comunque b,c e d = false => false
            // a && b && c && d => se a è false b,c e d non vengono nemmeno letti => false

            var primoAppuntamento = appuntamenti
                .OrderBy(a => a.GiornoDellaSettimana)
                //.First(); // va in execption se la collezione è vuota (se non c'è un elemento da prendere)
                .FirstOrDefault(); // non va mai in eccezione; se la collezione è vuota restituisce null

            Console.ReadLine();
        }
    }
}
