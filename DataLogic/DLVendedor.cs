using DataAccess;
using DataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;


namespace DataLogic
{
    public class DLVendedor
    {
        public static int GenID()
        {
            return DAVendedor.GenID();
        }

        public static void Insert(Ventas v)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAVendedor.Insert(v);
                    scope.Complete();//commit

                }
            }
            catch
            {
               


            }
            
        }

        public static Ventas GetID(int id)
        {
           return  DAVendedor.GetID(id);
        }

        public static void Delete(Ventas ventas)
        {
            DAVendedor.Delete(ventas);
        }
    }
}
