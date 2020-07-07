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
    public class DLSucursal
    {
        public static void Agregar(sucursal sucursal)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DASucursal.Agregar(sucursal);
                    scope.Complete();//commit

                }
            }
            catch
            {



            }
            
        }

        public static List<sucursal> GetAll()
        {
            return DASucursal.GetAll();
        }
    }
}
