using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Logging
{
    class Program
    {
        // Define a static logger variable so that it references the
        // Logger instance named "Program".
        //private static readonly ILog log = LogManager.GetLogger(typeof(Program));
        private static readonly ILog log = LogManager.GetLogger("Libreria.Logger01");

        static void Main(string[] args)
        {
            // log levels: DEBUG, INFO, WARN, ERROR, FATAL
            log.Debug("debug");
            log.Info("info avvio del programma");
            log.Warn("warn");
            log.Error("error");
            log.Fatal("fatal");

            var ac = new AltraClasse();
            ac.Metodo();

            Console.WriteLine("premere INVIO per continuare...");
            Console.ReadLine();
        }
    }
}
