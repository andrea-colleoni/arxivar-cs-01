using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Ereditarieta
{
    class Persona
    {
        public string Nome;
        public string Cognome;
        public string Email;

        // virtual: indica che di questo metodo è possibile fare l'override in una sottoclasse
        public virtual string NomeCompleto()
        {
            return $"{Nome} {Cognome}";
        }


    }
}
