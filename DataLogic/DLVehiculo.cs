using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using DataAccess;
using DataEntity;

namespace DataLogic
{
    public class DLVehiculo
    {
        public static void AgregarVehiculo(Vehiculo vehiculo)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {DAVehiculo.Agregar(vehiculo);
                   
                    scope.Complete();//commit

                }
            }
            catch
            {



            }
            
        }

        public static List<Vehiculo> GetVehiculos()
        {
            return DAVehiculo.GetVehiculos();
        }

        public static void Eliminar(string id)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAVehiculo.Eliminar(Convert.ToInt32(id));
                    scope.Complete();//commit

                }
            }
            catch
            {



            }
            
        }


        public static void actualizar(Vehiculo vehiculo)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {DAVehiculo.actualizar(vehiculo);
                    
                    scope.Complete();//commit

                }
            }
            catch
            {



            }
            
        }


        public static Vehiculo getVehiculo(string id)
        {
            return DAVehiculo.GetVehiculo(Convert.ToInt32(id));

        }

        public static bool estado(int id)
        {
            return DataAccess.DAClientes.Estado(id);
        }
    }
}
