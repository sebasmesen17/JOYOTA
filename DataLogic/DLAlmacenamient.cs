using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using DataEntity;

namespace DataLogic
{
    public class DLAlmacenamient
    {
        public static void Agregar(Almacenamiento almacenamiento)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
DataAccess.DAAlmacenamiento.Agregar(almacenamiento);
                    scope.Complete();//commit

                }
            }
            catch
            {



            }
            
        }
    }
}
