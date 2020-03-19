using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Ereditarieta
{
    // studente è sottoclasse di persona
    // persona è superclasse per studente
    // in C# una classe può usare l'ereditarietà solo verso UNA classe, non di più
    // => una sottoclasse ha UNA SOLA super classe (non ereditarietà multipla!!)
    // => una superclasse può avere più sottoclassi (che sono tutte le classi che ereditano dalla stessa superclasse)
    class Studente : Persona
    {
        // aggiungo un campo
        public string Matricola;

        // aggiungo un metodo
        public void Iscrizione(string corso)
        {
            Console.WriteLine($"Lo studente {NomeCompleto()} è iscritto al corso {corso}");
        }

        // override: è la ridefinizione di un super metodo
        // modifico il comportamento di un super metodo
        public override string NomeCompleto()
        {
            return $"{Matricola} - " + base.NomeCompleto();
        }
    }
}
