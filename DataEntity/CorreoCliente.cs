namespace DataEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CorreoCliente")]
    public partial class CorreoCliente
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(30)]
        public string CedulaCliente { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(30)]
        public string email { get; set; }

        public virtual Cliente Cliente { get; set; }
    }
}
