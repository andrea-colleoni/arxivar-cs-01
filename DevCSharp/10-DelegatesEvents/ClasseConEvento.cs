using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DelegatesEvents
{
    class ClasseConEvento
    {
        public delegate void Delegato();
        public event Delegato Evento;

        public void Metodo()
        {
            Console.WriteLine("sono nel metodo della classe con evento");
            if (Evento != null)
            {
                Evento(); // chiamata al delegato
            }
            else
            {
                Console.WriteLine("nessun metodo delegato associato a questo evento");
            }
            Console.WriteLine("ho -lanciato- l'evento");
        }
    }
}
