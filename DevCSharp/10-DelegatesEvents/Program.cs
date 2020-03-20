using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DelegatesEvents
{
    class Program
    {
        public delegate void Delegato();
        public static void Metodo1()
        {
            Console.WriteLine("metodo 1");
        }

        public void Metodo2()
        {
            Console.WriteLine("metodo 2");
        }

        public void Metodo3(string s)
        {
            Console.WriteLine("metodo 3");
        }

        public static void EsegueDelegati(Delegato delegato)
        {
            Console.WriteLine("eseguo il delegato");
            delegato();
        }

        // obiettivo: riuscire a passare ad un metodo, un altro metodo come argomento
        static void Main(string[] args)
        {
            Delegato delegato = null;

            delegato += new Delegato(Program.Metodo1);

            Program prog = new Program();
            delegato += new Delegato(prog.Metodo2);
            // delegato += new Delegato(prog.Metodo3);

            delegato(); // mettere () => significa chiamare il metodo delegato

            EsegueDelegati(delegato);

            EsegueDelegati(new Delegato(Metodo1));

            EsegueDelegati(() => Metodo1());

            EsegueDelegati(() => {
                Console.WriteLine("non sono in un metodo");
                Console.WriteLine("io sono solo il corpo di un metodo senza nome");
            });

            Console.WriteLine("finito...");


        }
    }
}
