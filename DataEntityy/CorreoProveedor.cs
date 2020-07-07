namespace DataEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CorreoProveedor")]
    public partial class CorreoProveedor
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(30)]
        public string CedulaJuridica { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(30)]
        public string email { get; set; }
    }
}
