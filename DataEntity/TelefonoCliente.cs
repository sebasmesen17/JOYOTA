namespace DataEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TelefonoCliente")]
    public partial class TelefonoCliente
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(30)]
        public string CedulaCliente { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int telefono { get; set; }

        public virtual Cliente Cliente { get; set; }
    }
}
