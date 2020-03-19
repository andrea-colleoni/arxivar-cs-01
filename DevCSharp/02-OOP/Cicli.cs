using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Cicli
    {
        static void Main(string[] args)
        {
            string[] capoluoghiDiRegione;
            capoluoghiDiRegione = new string[6];

            capoluoghiDiRegione[0] = "Aosta";
            capoluoghiDiRegione[1] = "Torino";
            capoluoghiDiRegione[2] = "Genova";
            capoluoghiDiRegione[3] = "Milano";
            capoluoghiDiRegione[4] = "Venezia";
            capoluoghiDiRegione[5] = "Bologna";

            // i++ => i = i + 1 => incremento di 1 unità della variabile i
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(i);
                Console.WriteLine(capoluoghiDiRegione[i]);
            }
            Console.WriteLine("finito...");

            for (int i = 0; i < capoluoghiDiRegione.Length; i++)
            {
                Console.WriteLine(i);
                continue;
                // procede con la prossima iterazione del ciclo senza eseguire le istruzioni 
                // che vengono successivamente
                Console.WriteLine(capoluoghiDiRegione[i]);
            }

            foreach(var citta in capoluoghiDiRegione)
            {
                Console.WriteLine(citta);
                break; // esce dal code block corrente
            }

            int j = 0; // inizializzazione della variabile che governa il ciclo
            while(j < capoluoghiDiRegione.Length)
            {
                Console.WriteLine(capoluoghiDiRegione[i]);
                j++; // mi devo ricordare di modificare la variabile che governa il ciclo
            }
        }
    }
}
