namespace _11_ConnessioneDb
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CorsoCS : DbContext
    {
        public CorsoCS()
            : base("name=CorsoCS")
        {
        }

        public virtual DbSet<Persone> Persone { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Persone>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<Persone>()
                .Property(e => e.Cognome)
                .IsUnicode(false);

            modelBuilder.Entity<Persone>()
                .Property(e => e.Email)
                .IsUnicode(false);
        }
    }
}
