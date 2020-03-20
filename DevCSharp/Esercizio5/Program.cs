using Esercizio3;
using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Esercizio5
{
    class Program
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Program));

        static void Main(string[] args)
        {
            List<int> consumi = new List<int>() { 20, 18, 19, 22, 17};
            log.Info("creazione automobili");
            var automobili = consumi.Select(c => new Automobile()
            {
                Marca = "Test",
                Modello = "Modello",
                CapacitaSerbatoio = 20,
                Cilindrata = 1800,
                ConsumoKmLitro = c
            }).ToList();
            // devo fare ToList() per "scaricare" l'IEnumerable restituito da Select in una List modificabile
            log.Info($"creazione automobili => sono state create {automobili.Count()} automobili");
            var rnd = new Random();
            automobili.ForEach(auto =>
            {
                log.Info(auto.Rifornimento(rnd.Next(15, 30)));
                log.Info($"livello auto {auto.Marca} => {auto.LivelloCarburante}");
            });
            log.Info($"carburante inziale => {automobili.Sum(a => a.LivelloCarburante)}");

            for (int km = 1; km <= 100; km += 10)
            {
                automobili.ForEach(auto =>
                {
                    log.Info(auto.Viaggia(10));
                    Thread.Sleep(100);
                });
            }
            var residuo = automobili.Sum(a => a.LivelloCarburante);
            log.Info($"carburante residuo => {residuo}");
        }
    }
}
