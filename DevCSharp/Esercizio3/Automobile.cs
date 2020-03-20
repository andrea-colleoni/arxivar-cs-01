using Esercizio3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio3
{
    public class Automobile
    {
        public string Marca { get; set; }
        public string Modello { get; set; }
        public int Cilindrata { get; set; }
        public float CapacitaSerbatoio { get; set; }
        public float LivelloCarburante { get; set; }
        public float ConsumoKmLitro { get; set; }

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

        public string Rifornimento(float litri)
        {
            this.LivelloCarburante += litri; // LivelloCarburante = LivelloCarburante + litri;
            return $"nuovo livello carburante => {this.LivelloCarburante}";
        }

        public string Viaggia(int kilometri)
        {
            var consumo = kilometri / ConsumoKmLitro;
            if (consumo > LivelloCarburante)
            {
                return $"{Marca} {Modello} è ferma perché ha finito il carburante";
            }
            else
            {
                LivelloCarburante -= consumo; // LivelloCarburante = LivelloCarburante - litri;
                return $"{Marca} {Modello} ha percorso {kilometri} km";
            }
        }
    }
}
