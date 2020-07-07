using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataEntity;

namespace DataAccess
{
    public class DAVehiculo
    {
        public static void Agregar(Vehiculo vehiculo)
        {
            using (ModelJoyotaSa db = new ModelJoyotaSa())
            {
                try
                {
                    db.Vehiculo.Add(vehiculo);
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public static void Eliminar(int id)
        {
            using (ModelJoyotaSa db = new ModelJoyotaSa())
            {
                try
                {
                    Vehiculo vehiculo = db.Vehiculo.Where(a => a.IDVehiculo == id).FirstOrDefault();
                    if (vehiculo != null)//si existe...
                    {
                        db.Vehiculo.Remove(vehiculo);
                        db.SaveChanges();//guardar cambio
                    }
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
            }
        }

        public static Vehiculo GetVehiculo(int id)
        {
            ModelJoyotaSa db = new ModelJoyotaSa();
            Vehiculo veh = new Vehiculo();
            try
            {
                veh = db.Vehiculo.Where(c => c.IDVehiculo == id).FirstOrDefault();
                return veh; // afuera esta la condicion que si existe en correoCliente, entre aqui
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public static void actualizar(Vehiculo vehiculo)
        {
            using (ModelJoyotaSa db = new ModelJoyotaSa())
            {
                try
                {
                    Vehiculo vehiculoVerificar = db.Vehiculo.Where(a => a.IDVehiculo == vehiculo.IDVehiculo).FirstOrDefault();
                    if (vehiculoVerificar != null)
                    {
                        Vehiculo ve = db.Vehiculo.First(c => c.IDVehiculo == vehiculo.IDVehiculo);
                        ve.nombreSucursal = vehiculo.nombreSucursal;
                        ve.IDVehiculo = vehiculo.IDVehiculo;
                        ve.modelo = vehiculo.modelo;
                        ve.marca = vehiculo.marca;
                        ve.año = vehiculo.año;
                        ve.color = vehiculo.color;
                        ve.categoria = vehiculo.categoria;
                        ve.codigoBarra = vehiculo.codigoBarra;
                        ve.precioCompra = vehiculo.precioCompra;
                        ve.impuestoValorAgregado = vehiculo.impuestoValorAgregado;
                        ve.impuestoVenta = vehiculo.impuestoVenta;
                        ve.excento = vehiculo.excento;
                        ve.peso = vehiculo.peso;
                        ve.estado = vehiculo.estado;
                        ve.img = vehiculo.img;
                        db.SaveChanges();//guardar o actualizar lo de
                    }
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
            }
        }

        public static List<Vehiculo> GetVehiculos()
        {
            ModelJoyotaSa db = new ModelJoyotaSa();
            List<Vehiculo> vehiculos = new List<Vehiculo>();

            try
            {
                vehiculos = db.Vehiculo.OrderBy(c => c.modelo).ToList();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return vehiculos;
        }
    }
}
