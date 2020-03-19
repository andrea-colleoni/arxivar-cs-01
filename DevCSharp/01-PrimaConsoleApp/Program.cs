using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// questo è un commento
// - c# è case sensistive!! 
//      - aiuta il fatto di conoscere e seguire le coding conventions
//      - usiamo il code assistant (IntelliSense)
// - ha una sintassi c-like
//      - ogni istruzione termina con;
//      - le porzioni di codice (code blocks) sono racchiuse tra {} (shift + alt gr + [])
// - è strongly typed
// - ogni code block costituisce uno specifico contesto di validità per variabili (scope)

// operatori:
// matematici: +, -, * /, %
// logici: & && (AND), | || (OR), ! (NOT)
// di confronto: ==, !=, <, >, <=, >=
// di assegnazione: =
// navigazione proprietà: .

namespace PrimaConsoleApp
{
    // una classe è una porzione di programma che rappresenta informazioni specifiche e contienet 
    // porzioni di codice richiamabile dal altri punti del programma => metodi
    class Program
    {
        static void Main(string[] args) // un code bock che ha un nome (Main()) => metodo
        {
            Console.WriteLine("Hello world!");
            string str1 = "Ciao";
            // str: è l'identificatore (un identificatore è il nome che noi diamo a un elemento del programma)
            // string: è il tipo di variabile
            // =: è l'operatore di assegnazione
            // "Ciao": è un valore (literal) che verrà memorizzato nella variabile
            string str2;
            str2 = "Buongiorno";
            // parola chiave var
            var str3 = "Buonasera";
            // se utilizzo var, il tipo della variabile viene inferito (dedotto dal compilatore) 
            // dalla operazione di assegnazione
            // le stringhe in c# sono delimitate dal carattere "
            int int1 = 10;

            // tipi di variabili:
            // value types => variabili il cui valore è direttamente associato alla variabile
            // reference types => puntatori ad aree di memoria in cui sono conservati i valori

            // value types: bool, decimal, int, long, float, double, ....
            // reference types: tutti gli altri.... (string, ....)
            Metodo("ciao");

            // chiamo il metodo Somma con 5, 8
            var ris = Somma(5, 8);
            Console.WriteLine(ris);

            // var int2 = ...;
            Metodo(str1);

            // esempio chimata metodo con arg value
            int x = 30;
            MetodoConArgValue(x);
            Console.WriteLine("Ora x vale " + x);

            string s = "ciao";
            MetodoConArgRef(ref s);
            Console.WriteLine("Ora vale " + s);

            // costrutto if
            // if ( condizione (bool) )
            //{
            //   istruzioni che vengono eseguite se la condizione è true
            //}
            //else 
            //{
            //  istruzioni che vengono eseguite se la condizione è false
            //}
            int y = 40;
            if (x > 40)
            {
                y = 50;
                Console.WriteLine("x è meggiore di 40");
            }
            else
            {
                Console.WriteLine(y);
                Console.WriteLine("non lo è!");
            }
        }

        static void MetodoConArgValue(int x)
        {
            Console.WriteLine("Hai passato " + x);
            x = x + 10;
        }
        // uso ref per condividere l'indirizzo di memoria di s
        static void MetodoConArgRef(ref string s)
        {
            Console.WriteLine("Hai passato " + s);
            s = s + "***";
        }

        // definizione di un metodo
        // void indica che il metodo non restituisce alcun valore al chiamante
        static void Metodo(string argomento)
        {
            Console.WriteLine("Hai scritto: " + argomento); 
        }

        // il metodo accetta due argomenti di tipo int
        // e restituisce al chiamante un valore di tipo in (usando l'istruzione return)
        static int Somma(int a, int b)
        {
            // eseguo la somma di a e b
            int risultato = a + b; // effettuo l'operazione
            Console.WriteLine(risultato);
            return risultato; // il momento in cui il metodo restituisce un risultato al chiamante)
        }


    }
}
