using DataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DAClientes
    {
        public static void Agregar(DataEntity.Cliente cliente)
        {
            using (ModelJoyotaSa db = new ModelJoyotaSa())
            {
                try
                {
                    db.Cliente.Add(cliente);
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public static void AgregarTelefono(TelefonoCliente telefono)
        {
            using (ModelJoyotaSa db = new ModelJoyotaSa())
            {
                try
                {
                    TelefonoCliente tel = db.TelefonoCliente.Where(t => t.telefono == telefono.telefono &&
                    t.CedulaCliente == telefono.CedulaCliente).FirstOrDefault();
                    if (tel == null)
                    {
                        db.TelefonoCliente.Add(telefono);
                        db.SaveChanges();
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public static List<Cliente> GetClientes()
        {
            ModelJoyotaSa db = new ModelJoyotaSa();
            List<Cliente> clientes = new List<Cliente>();
            try
            {
                clientes = db.Cliente.OrderBy(c => c.nombre).ToList();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return clientes;
        }

        public static List<TelefonoCliente> GetTelefonoCliente(string cedula)
        {
            ModelJoyotaSa db = new ModelJoyotaSa();
            List<TelefonoCliente> tc = new List<TelefonoCliente>();
            try
            {
                tc = db.TelefonoCliente.Where(c => c.CedulaCliente == cedula).ToList();
                return tc; // afuera esta la condicion que si existe en correoCliente, entre aqui
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public static bool Estado(int id)
        {
            using (ModelJoyotaSa db = new ModelJoyotaSa())
            {
                try
                {
                    Vehiculo vehiculo = db.Vehiculo.Where(c => c.IDVehiculo == id).FirstOrDefault();
                    if (vehiculo == null)
                    {
                        return false;
                    }

                }
                catch (Exception)
                {

                }
                return true;
            }
        }

        public static List<CorreoCliente> GetCorreoCliente(string cedula)
        {
            ModelJoyotaSa db = new ModelJoyotaSa();
            List<CorreoCliente> cc = new List<CorreoCliente>();
            try
            {
                cc = db.CorreoCliente.Where(c => c.CedulaCliente == cedula).ToList();
                return cc; // afuera esta la condicion que si existe en correoCliente, entre aqui
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public static string GetCorreo(string ced)
        {
            ModelJoyotaSa db = new ModelJoyotaSa();
            CorreoCliente cc = new CorreoCliente();
            try
            {
                cc = db.CorreoCliente.Where(c => c.CedulaCliente == ced).FirstOrDefault();
                return cc.email; // afuera esta la condicion que si existe en correoCliente, entre aqui
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public static void Eliminar(string ced)
        {
            using (ModelJoyotaSa db = new ModelJoyotaSa())
            {
                try
                {
                    Cliente cliente = db.Cliente.Where(c => c.CedulaCliente == ced).FirstOrDefault();
                    List<TelefonoCliente> telefonos = db.TelefonoCliente.Where(c => c.CedulaCliente == ced).ToList();
                    List<CorreoCliente> correos = db.CorreoCliente.Where(c => c.CedulaCliente == ced).ToList();
                    db.Cliente.Remove(cliente);
                    foreach (var i in correos)
                    {
                        db.CorreoCliente.Remove(i);
                    }
                    foreach (var i in telefonos)
                    {
                        db.TelefonoCliente.Remove(i);
                    }
                    db.SaveChanges();//guardar cambio
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
            }
        }

        public static void update(Cliente cliente)
        {
            using (ModelJoyotaSa db = new ModelJoyotaSa())
            {
                try
                {
                    Cliente verificarCliente = db.Cliente.Where(a => a.CedulaCliente == cliente.CedulaCliente).FirstOrDefault();
                    if (verificarCliente != null)
                    {
                        Cliente cli = db.Cliente.First(c => c.CedulaCliente == cliente.CedulaCliente);
                        cli.CedulaCliente = cliente.CedulaCliente;
                        cli.tipocedula = cliente.tipocedula;
                        cli.nombre = cliente.nombre;
                        cli.direccion = cliente.direccion;
                        db.SaveChanges();//guardar o actualizar lo de
                    }
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
            }
        }

        public static string GetTelefono(string ced)
        {
            ModelJoyotaSa db = new ModelJoyotaSa();
            TelefonoCliente tc = new TelefonoCliente();
            try
            {
                tc = db.TelefonoCliente.Where(c => c.CedulaCliente == ced).FirstOrDefault();
                return tc.telefono.ToString(); // afuera esta la condicion que si existe en correoCliente, entre aqui
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public static void AgregarCorreo(CorreoCliente correoCliente)
        {
            using (ModelJoyotaSa db = new ModelJoyotaSa())
            {
                try
                {
                    CorreoCliente correo = db.CorreoCliente.Where(c => c.email == correoCliente.email &&
                    c.CedulaCliente == correoCliente.CedulaCliente).FirstOrDefault();
                    if (correo == null)
                    {
                        db.CorreoCliente.Add(correoCliente);
                        db.SaveChanges();
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public static bool EstadoCedula(string cedula)
        {
            using (ModelJoyotaSa db = new ModelJoyotaSa())
            {
                try
                {
                    Cliente cliente = db.Cliente.Where(c => c.CedulaCliente == cedula).FirstOrDefault();
                    if (cliente == null)
                    {
                        return false;
                    }

                }
                catch (Exception)
                {

                }
                return true;
            }
        }

        public static Cliente GetCliente(string cedula)
        {
            ModelJoyotaSa db = new ModelJoyotaSa();
            Cliente cliente = new Cliente();
            try
            {
                cliente = db.Cliente.Where(c => c.CedulaCliente == cedula).FirstOrDefault();
                return cliente; // afuera esta la condicion que si existe en correoCliente, entre aqui
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
