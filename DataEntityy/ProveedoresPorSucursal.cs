namespace DataEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProveedoresPorSucursal")]
    public partial class ProveedoresPorSucursal
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDSucursal { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(30)]
        public string CedulaJuridica { get; set; }

        public int? telefono { get; set; }
    }
}
