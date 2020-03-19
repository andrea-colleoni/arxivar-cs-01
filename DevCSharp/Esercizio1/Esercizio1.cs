using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio1
{
    class Esercizio1
    {
        static void Main(string[] args)
        {
            var risultato = Sottrazione(10, 6);
            Console.WriteLine("valore risutao " + risultato);
            Console.WriteLine(Sottrazione(6, 10));
        }

        static float Sottrazione(float a, float b)
        {
            if (a > b)
            {
                return (a - b);
            }
            else
            {
                return (b - a);
                Console.WriteLine("....");
            }
        }
    }
}
