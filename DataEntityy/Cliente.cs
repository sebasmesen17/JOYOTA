namespace DataEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Cliente")]
    public partial class Cliente
    {
        [Key]
        [StringLength(30)]
        public string CedulaCliente { get; set; }

        [StringLength(30)]
        public string contrasenia { get; set; }

        [StringLength(30)]
        public string tipocedula { get; set; }

        [StringLength(30)]
        public string nombre { get; set; }

        [StringLength(30)]
        public string direccion { get; set; }
    }
}
