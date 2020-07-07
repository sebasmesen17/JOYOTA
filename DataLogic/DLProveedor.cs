using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using DataEntity;

namespace DataLogic
{
    public class DLProveedor
    {
        public static void Agregar(Proveedor proveedor)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
DataAccess.DAProveedores.Agregar(proveedor);
                    scope.Complete();//commit

                }
            }
            catch
            {



            }
            
        }
    }
}
