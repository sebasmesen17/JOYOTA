create database [JoyotaSA]
use [JoyotaSA]
Go
Create table FechasAlmacenamiento(IDBodega int, fechaingreso date, fechaSalida date, primary key(IDBodega)); --normalizada 
GO
Create table Almacenamiento (IDBodega int, IDVehiculo int, cantidad int, constraint pkAlmacenamiento primary key clustered (IDBodega,IDVehiculo) )--IDVehiculo)); --LISTO//PROBAR SI SE PUEDE CON VARIAS PK EN EL FK
GO
create table Vehiculo (IDVehiculo int, modelo varchar(30), marca varchar(30), año varchar(30), color varchar(30),
categoria varchar(30), codigoBarra int, precioCompra decimal, impuestoVenta int, impuestoValorAgregado int, excento varchar(30), 
peso int, estado varchar(30),NombreSucursal varchar (50),img image (50), primary key(IDVehiculo));--AÑADIR  ID SUCURSAL--LISTO
GO
Create table Proveedor(CedulaJuridica varchar(30), nombre varchar(30), direccion varchar(30), contacto varchar(30), primary key (CedulaJuridica));--LISTO
GO
Create table ReporteProveedor(CedulaJuridica varchar(30), IDVehiculo int, constraint pkReporteProveedor primary key clustered(CedulaJuridica, IDVehiculo));--LISTO
GO
create table Bodega(IDBodega int, modelo varchar(30), primary key (IDBodega));--LISTO
GO
Create table Cliente(CedulaCliente varchar(30), tipocedula varchar(30), nombre varchar(30), direccion varchar(30),contrasennia varchar(50),  primary key (CedulaCliente));
GO
create table SucursalCliente(CedulaCliente varchar(30), IDSucursal int, constraint pkSucursalCliente primary key clustered (CedulaCliente, IDSucursal));
GO
create table sucursal (IDSucursal int, NombreSucursal varchar(30), ubicacion varchar(30), IDBodega INT , constraint pkSucursal primary key clustered(IDSucursal))
;--LISTO//, IDBodega
GO
create table ContenidoDetalleFactura(IDVehiculo int, IDDetalleFactura int, constraint pkContenidoDetalleFactura primary key clustered(IDVehiculo));--LISTO
GO
create table DetalleFactura (IDDetalleFactura int, IDFactura int, subtotal decimal, cantidad int, costoUnitario decimal, constraint pkDetalleFactura primary key(IDDetalleFactura, IDFactura));--LISTO
GO
Create table Ventas(IDVendedor int, IDEmpleado int, IDSucursal int, constraint pkVentas primary key clustered (IDVendedor));--LISTO//IDEmpleado, IDSucursal
GO
Create table Empleado(IDEmpleado int, nombre varchar(30), salario decimal, cargo varchar(30), primary key (IDEmpleado));--LISTO
GO
create table Administrativo(IDAdministrativo int, IDEmpleado int, IDDepartamento int, constraint pkAdministrativo primary key clustered (IDAdministrativo, IDEmpleado, IDDepartamento));--LISTO
GO
create table Departamento (IDDepartamento int, nombreDepartamento varchar(30), primary key (IDDepartamento));--LISTO
GO
Create table FacturaVehiculo(IDFactura int, IDVehiculo int, constraint pkFacturaVehiculo primary key clustered (IDFactura, IDVehiculo));--LISTO
GO
create table Factura(IDFactura int, Fecha date, monto decimal,IDSucursal int NOT NULL, cantidad int, tipoPago Varchar(30), constraint PK_Factura primary key clustered (IDFactura));--LSTO
GO
create table FacturacionGenerada(CedulaCliente varchar(30), IDFactura int, constraint pkFacturacionGenerada primary key clustered (CedulaCliente, IDFactura));--LISTO
GO
create table ProveedoresPorSucursal(IDBodega int, CedulaJuridica varchar(30), telefono int, constraint pkProveedoresPorSucursal primary key(IDBodega,CedulaJuridica))--IGAL QUE ALMACENAMIENTO, CedulaJuridica));
GO
Create table TelefonoCliente(CedulaCliente varchar(30), telefono int, constraint pktelefonoCliente primary key clustered (CedulaCliente, telefono));--LISTO
GO
Create table CorreoCliente(CedulaCliente varchar(30), email varchar(30), constraint pkCorreoCliente primary key clustered(CedulaCliente, email));--LISTO
GO
create table TelefonoSucursal(IDSucursal int, telefono int, constraint pkTelefonoSucursal primary key clustered (IDSucursal, telefono));--FALTA EN LA IMG
GO
create table TelefonoProveedor(CedulaJuridica varchar(30), telefono int, constraint pkTelefonoProveedor primary key clustered (CedulaJuridica, telefono));--LISTO
GO

create table CorreoProveedor(CedulaJuridica varchar(30), email varchar(30), constraint pkCorreoProveedor primary key clustered(CedulaJuridica, email));--LISTO