namespace DataEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Vehiculo")]
    public partial class Vehiculo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Vehiculo()
        {
            Almacenamiento = new HashSet<Almacenamiento>();
            ContenidoDetalleFactura = new HashSet<ContenidoDetalleFactura>();
            FacturaVehiculo = new HashSet<FacturaVehiculo>();
            Proveedor = new HashSet<Proveedor>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDVehiculo { get; set; }

        [StringLength(30)]
        public string modelo { get; set; }

        [StringLength(30)]
        public string marca { get; set; }

        [StringLength(30)]
        public string año { get; set; }

        [StringLength(30)]
        public string color { get; set; }

        [StringLength(30)]
        public string categoria { get; set; }

        public int? codigoBarra { get; set; }

        public decimal? precioCompra { get; set; }

        public int? impuestoVenta { get; set; }

        public int? impuestoValorAgregado { get; set; }

        [StringLength(30)]
        public string excento { get; set; }

        public int? peso { get; set; }

        [StringLength(30)]
        public string estado { get; set; }

        [StringLength(50)]
        public string img { get; set; }

        [StringLength(30)]
        public string nombreSucursal { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Almacenamiento> Almacenamiento { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContenidoDetalleFactura> ContenidoDetalleFactura { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FacturaVehiculo> FacturaVehiculo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Proveedor> Proveedor { get; set; }
    }
}
