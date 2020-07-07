namespace DataEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FechasAlmacenamiento")]
    public partial class FechasAlmacenamiento
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDBodega { get; set; }

        [Column(TypeName = "date")]
        public DateTime? fechaingreso { get; set; }

        [Column(TypeName = "date")]
        public DateTime? fechaSalida { get; set; }
    }
}
