using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Ereditarieta
{
    class Program
    {
        static void Main(string[] args)
        {
            var persona = new Persona();
            persona.Nome = "Mario";
            persona.Cognome = "Rossi";

            Console.WriteLine(persona.NomeCompleto());

            var studente = new Studente();
            studente.Nome = "Anna";
            studente.Cognome = "Verdi";
            studente.Matricola = "3456765";

            Console.WriteLine(studente.NomeCompleto());
            studente.Iscrizione("Dev C#");
        }
    }
}
