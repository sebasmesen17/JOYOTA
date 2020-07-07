namespace DataEntity
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModelJoyotaSa : DbContext
    {
        public ModelJoyotaSa()
            : base("name=ModelJoyotaSa")
        {
        }

        public virtual DbSet<Administrativo> Administrativo { get; set; }
        public virtual DbSet<Almacenamiento> Almacenamiento { get; set; }
        public virtual DbSet<Bodega> Bodega { get; set; }
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<ContenidoDetalleFactura> ContenidoDetalleFactura { get; set; }
        public virtual DbSet<CorreoCliente> CorreoCliente { get; set; }
        public virtual DbSet<CorreoProveedor> CorreoProveedor { get; set; }
        public virtual DbSet<Departamento> Departamento { get; set; }
        public virtual DbSet<DetalleFactura> DetalleFactura { get; set; }
        public virtual DbSet<Empleado> Empleado { get; set; }
        public virtual DbSet<Factura> Factura { get; set; }
        public virtual DbSet<FacturacionGenerada> FacturacionGenerada { get; set; }
        public virtual DbSet<FacturaVehiculo> FacturaVehiculo { get; set; }
        public virtual DbSet<FechasAlmacenamiento> FechasAlmacenamiento { get; set; }
        public virtual DbSet<Proveedor> Proveedor { get; set; }
        public virtual DbSet<ProveedoresPorSucursal> ProveedoresPorSucursal { get; set; }
        public virtual DbSet<ReporteProveedor> ReporteProveedor { get; set; }
        public virtual DbSet<sucursal> sucursal { get; set; }
        public virtual DbSet<SucursalCliente> SucursalCliente { get; set; }
        public virtual DbSet<TelefonoCliente> TelefonoCliente { get; set; }
        public virtual DbSet<TelefonoProveedor> TelefonoProveedor { get; set; }
        public virtual DbSet<TelefonoSucursal> TelefonoSucursal { get; set; }
        public virtual DbSet<Vehiculo> Vehiculo { get; set; }
        public virtual DbSet<Ventas> Ventas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bodega>()
                .Property(e => e.modelo)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.CedulaCliente)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.contrasenia)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.tipocedula)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.direccion)
                .IsUnicode(false);

            modelBuilder.Entity<CorreoCliente>()
                .Property(e => e.CedulaCliente)
                .IsUnicode(false);

            modelBuilder.Entity<CorreoCliente>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<CorreoProveedor>()
                .Property(e => e.CedulaJuridica)
                .IsUnicode(false);

            modelBuilder.Entity<CorreoProveedor>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<Departamento>()
                .Property(e => e.nombreDepartamento)
                .IsUnicode(false);

            modelBuilder.Entity<DetalleFactura>()
                .Property(e => e.subtotal)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DetalleFactura>()
                .Property(e => e.costoUnitario)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Empleado>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Empleado>()
                .Property(e => e.salario)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Empleado>()
                .Property(e => e.cargo)
                .IsUnicode(false);

            modelBuilder.Entity<Factura>()
                .Property(e => e.monto)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Factura>()
                .Property(e => e.tipoPago)
                .IsUnicode(false);

            modelBuilder.Entity<FacturacionGenerada>()
                .Property(e => e.CedulaCliente)
                .IsUnicode(false);

            modelBuilder.Entity<Proveedor>()
                .Property(e => e.CedulaJuridica)
                .IsUnicode(false);

            modelBuilder.Entity<Proveedor>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Proveedor>()
                .Property(e => e.direccion)
                .IsUnicode(false);

            modelBuilder.Entity<Proveedor>()
                .Property(e => e.contacto)
                .IsUnicode(false);

            modelBuilder.Entity<ProveedoresPorSucursal>()
                .Property(e => e.CedulaJuridica)
                .IsUnicode(false);

            modelBuilder.Entity<ReporteProveedor>()
                .Property(e => e.CedulaJuridica)
                .IsUnicode(false);

            modelBuilder.Entity<sucursal>()
                .Property(e => e.NombreSucursal)
                .IsUnicode(false);

            modelBuilder.Entity<sucursal>()
                .Property(e => e.ubicacion)
                .IsUnicode(false);

            modelBuilder.Entity<sucursal>()
                .Property(e => e.IDBodega)
                .IsUnicode(false);

            modelBuilder.Entity<SucursalCliente>()
                .Property(e => e.CedulaCliente)
                .IsUnicode(false);

            modelBuilder.Entity<TelefonoCliente>()
                .Property(e => e.CedulaCliente)
                .IsUnicode(false);

            modelBuilder.Entity<TelefonoProveedor>()
                .Property(e => e.CedulaJuridica)
                .IsUnicode(false);

            modelBuilder.Entity<Vehiculo>()
                .Property(e => e.modelo)
                .IsUnicode(false);

            modelBuilder.Entity<Vehiculo>()
                .Property(e => e.marca)
                .IsUnicode(false);

            modelBuilder.Entity<Vehiculo>()
                .Property(e => e.año)
                .IsUnicode(false);

            modelBuilder.Entity<Vehiculo>()
                .Property(e => e.color)
                .IsUnicode(false);

            modelBuilder.Entity<Vehiculo>()
                .Property(e => e.categoria)
                .IsUnicode(false);

            modelBuilder.Entity<Vehiculo>()
                .Property(e => e.precioCompra)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Vehiculo>()
                .Property(e => e.excento)
                .IsUnicode(false);

            modelBuilder.Entity<Vehiculo>()
                .Property(e => e.estado)
                .IsUnicode(false);

            modelBuilder.Entity<Vehiculo>()
                .Property(e => e.img)
                .IsUnicode(false);

            modelBuilder.Entity<Vehiculo>()
                .Property(e => e.nombreSucursal)
                .IsUnicode(false);
        }
    }
}
