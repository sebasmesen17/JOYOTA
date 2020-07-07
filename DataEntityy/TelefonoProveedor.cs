namespace DataEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TelefonoProveedor")]
    public partial class TelefonoProveedor
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(30)]
        public string CedulaJuridica { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int telefono { get; set; }
    }
}
