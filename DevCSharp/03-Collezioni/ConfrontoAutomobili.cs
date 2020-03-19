using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Collezioni
{
    class ConfrontoAutomobili : EqualityComparer<Automobile>
    // eredito le caratteristche di Equals e GetHashCode nella mia classe
    // ereditando, la mia classe diventa anch'essa un Camparer, ma è più specializzata
    // perché invece che fare generici confronti, confronta Automobili
    {
        public override bool Equals(Automobile x, Automobile y)
        {
            return x.Targa == y.Targa;
        }

        public override int GetHashCode(Automobile obj)
        {
            return obj.Targa.GetHashCode();
        }
    }
}
