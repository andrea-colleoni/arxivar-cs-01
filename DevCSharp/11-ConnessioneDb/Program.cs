using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_ConnessioneDb
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new CorsoCS();

            var persone = db.Persone.ToList();// .Where(p => p.Nome.StartsWith("A")).Take(100).ToList();
            persone.ForEach(p => Console.WriteLine($"Nome: {p.Nome}, cognome: {p.Cognome}"));
            /*
            db.Persone.Add(new Persone()
            {
                Nome = "Luisa",
                Cognome = "Neri",
                DataNascita = DateTime.Today,
                Email = "luisa@"
            });

            var luigi = db.Persone.Where(x => x.Nome == "Luigi").FirstOrDefault();
            if (luigi != null)
            {
                luigi.Email = "modificata***********@luigi";
            }

            var mario = db.Persone.Find(2);
            db.Persone.Remove(mario);

            db.SaveChanges();

            // db.Database. // sul Database posso usare direttamente ADO.NET
            */
            Console.WriteLine("finito.");

        }
    }
}
