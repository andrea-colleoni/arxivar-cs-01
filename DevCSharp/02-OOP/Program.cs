using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static Cliente Destinatario;

        static void Main(string[] args)
        {
            // ora che ho la classe CLiente posso rappresentare variabili di "tipo" cliente
            Cliente cliente1;
            cliente1 = new Cliente(); // questo è un metodo costruttore
            // - ha lo stesso nome della classe
            // - si presenta come un metodo => ha le parentesi, quindi è un vero metodo
            // - il valore restituito da un costruttore è un valore del nuovo tipo definito dalla classe
            //   tale valore viene detto OGGETTO di tipo Cliente
            // Oggetto viene anche detto ISTANZA di una classe
            cliente1.RagioneSociale = "Rossi spa";
            cliente1.PartitaIVA = "45678909876";
            cliente1.Email = "isjhdjk@ijdhkj";

            cliente1.StampaRagSoc();

            var cliente2 = new Cliente();
            cliente2.RagioneSociale = "Verdi srl";

            cliente2.StampaRagSoc();
            Destinatario = new Cliente();
            Destinatario.RagioneSociale = "Bianchi snc";
            

        }
    }
}
