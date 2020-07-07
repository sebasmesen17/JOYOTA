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
    public class DLAdministrativo
    {
        public static int GenID()
        {
            return DAAdministrativo.GenID();
        }

        public static void Insert(Administrativo e)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAAdministrativo.Insert(e);
                    scope.Complete();//commit

                }
            }
            catch
            {



            }
            
        }

        public static Administrativo GetID(int id)
        {
            return DAAdministrativo.GetID(id);
        }
        public static void Delete(Administrativo a)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
DAAdministrativo.Delete(a);
                    scope.Complete();//commit

                }
            }
            catch
            {



            }
            
        }
    }
}
