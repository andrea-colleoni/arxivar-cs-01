using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Logging
{
    class AltraClasse
    {
        private static readonly ILog log = LogManager.GetLogger("Logger02");
        public void Metodo()
        {
            log.Debug("debug");
            log.Info("info avvio del programma");
            log.Warn("warn");
            log.Error("error");
            log.Fatal("fatal");
        }
    }
}
