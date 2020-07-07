using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using DataEntity;

namespace DataLogic
{
    public class DLBodega
    {
        public static void Agregar(Bodega bodega)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
DataAccess.DABodega.Agregar(bodega);
                    scope.Complete();//commit

                }
            }
            catch
            {



            }
            
        }
    }
}
