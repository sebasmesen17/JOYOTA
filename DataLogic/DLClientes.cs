using DataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace DataLogic
{
  public   class DLClientes
    {
        public static void AgregarCliente(Cliente cliente)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
            DataAccess.DAClientes.Agregar(cliente);

                    scope.Complete();//commit

                }
            }
            catch
            {



            }
        }

        public static bool Estado(string cedula)
        {
            return DataAccess.DAClientes.EstadoCedula(cedula);
        }

        public static void AgregarTelefono(TelefonoCliente telefono)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
            DataAccess.DAClientes.AgregarTelefono(telefono);

                    scope.Complete();//commit

                }
            }
            catch
            {



            }
        }

        public static List<Cliente> GetClientes()
        {
            return DataAccess.DAClientes.GetClientes();
        }

        public static void AgregarCorreo(CorreoCliente correoCliente)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
 DataAccess.DAClientes.AgregarCorreo(correoCliente);
                    scope.Complete();//commit

                }
            }
            catch
            {



            }
           
        }

        public static Cliente GetCliente(string cedula)
        {
            return DataAccess.DAClientes.GetCliente(cedula);
        }

        public static string GetCorreo(string ced)
        {
            return DataAccess.DAClientes.GetCorreo(ced);
        }

        public static string GetTelefono(string ced)
        {
            return DataAccess.DAClientes.GetTelefono(ced);
        }

        public static List<CorreoCliente> GetCorreoCliente(string cedula)
        {
            return DataAccess.DAClientes.GetCorreoCliente(cedula);
        }

        public static object GetTelefonoCliente(string cedula)
        {
            return DataAccess.DAClientes.GetTelefonoCliente(cedula);
        }

        public static void update(Cliente cliente)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
DataAccess.DAClientes.update(cliente);
                    scope.Complete();//commit

                }
            }
            catch
            {



            }
            
        }

        public static void Eliminar(string ced)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
DataAccess.DAClientes.Eliminar(ced);
                    scope.Complete();//commit

                }
            }
            catch
            {



            }
            
        }
    }
}
