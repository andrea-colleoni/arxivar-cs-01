using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DelegatesEvents
{
    class ProgrammaEventi
    {
        static void Main(string[] args)
        {
            ClasseConEvento ce = new ClasseConEvento();

            ce.Metodo();

            ClasseConEvento.Delegato f1 = () => Console.WriteLine("sono stato notificato dell'evento accaduto");
            ce.Evento += f1;

            ce.Evento += NomeCheVoglioIo;

            ClasseConEvento.Delegato f2 = () =>
            {
                Console.WriteLine("faccio qualcosa....");
            };
            // rimuovo i delgati precedentemente aggiunti
            ce.Evento -= f1;
            ce.Evento -= NomeCheVoglioIo;

            // aggiungo il mio nuovo delegato
            ce.Evento += f2;

            Console.WriteLine("prima di richiamare il metodo che lancia l'evento");

            ce.Metodo();

            Console.WriteLine("dopo aver richiamato il metodo che lancia l'evento");
        }

        private static void NomeCheVoglioIo()
        {
            Console.WriteLine("faccio qualcosa....");
        }
    }
}
