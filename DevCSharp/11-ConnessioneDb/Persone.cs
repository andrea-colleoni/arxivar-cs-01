namespace _11_ConnessioneDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vista")]
    public partial class Persone
    {
        public int Id { get; set; }

        [StringLength(30)]
        public string Nome { get; set; }

        [StringLength(30)]
        public string Cognome { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DataNascita { get; set; }

        [StringLength(50)]
        public string Email { get; set; }
    }
}
