namespace DataEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Empleado")]
    public partial class Empleado
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDEmpleado { get; set; }

        [StringLength(30)]
        public string nombre { get; set; }

        public decimal? salario { get; set; }

        [StringLength(30)]
        public string cargo { get; set; }
    }
}
