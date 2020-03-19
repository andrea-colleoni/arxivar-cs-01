using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Cliente
    {
        // variabili di classe e non di metodo => campi (fields)
        public string RagioneSociale;
        public string PartitaIVA;
        public string Email;

        public void StampaRagSoc()
        {
            string variabileNelMetodo = "***";
            Console.WriteLine(RagioneSociale + variabileNelMetodo);
        }

    }
}
