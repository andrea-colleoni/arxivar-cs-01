using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio2
{
    class Automobile
    {
        public string Marca;
        public string Modello;
        public int Cilindrata;
        public float CapacitaSerbatoio;
        public float LivelloCarburante;
        public float ConsumoKmLitro;

        public Automobile()
        {

        }

        // se è stato definito almeno un costruttore, posso utilizzare solo i costruttori definiti nella classe
        // (non posso più usare il costruttore vuoto, cioè quello senza argomenti, a meno di non specificarlo
        // esplicitamente
        public Automobile(string marca, string modello, int cilindrata, float capacitaSerbatoio, float consumoKmLitro)
        {
            // ?? : (COALESCE) server per dare un valore di default se un valore  risulta essere null
            Marca = marca ?? throw new ArgumentNullException(nameof(marca));
            Modello = modello ?? throw new ArgumentNullException(nameof(modello));
            Cilindrata = cilindrata;
            CapacitaSerbatoio = capacitaSerbatoio;
            ConsumoKmLitro = consumoKmLitro;
        }

        public void Rifornimento(float litri)
        {
            LivelloCarburante += litri; // LivelloCarburante = LivelloCarburante + litri;
        }

        public void Viaggia(int kilometri)
        {
            var consumo = kilometri / ConsumoKmLitro;
            if (consumo > LivelloCarburante)
            {
                Console.WriteLine($"{Marca} {Modello} è ferma perché ha finito il carburante");
            }
            else
            {
                LivelloCarburante -= consumo; // LivelloCarburante = LivelloCarburante - litri;
            }
        }
    }
}
