namespace DataEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sucursal")]
    public partial class sucursal
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDSucursal { get; set; }

        [StringLength(30)]
        public string NombreSucursal { get; set; }

        [StringLength(30)]
        public string ubicacion { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(30)]
        public string IDBodega { get; set; }
    }
}
