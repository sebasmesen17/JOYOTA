namespace DataEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Factura")]
    public partial class Factura
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDFactura { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "date")]
        public DateTime Fecha { get; set; }

        public decimal? monto { get; set; }

        public int? IDSucursal { get; set; }

        public int? cantidad { get; set; }

        [StringLength(30)]
        public string tipoPago { get; set; }
    }
}
