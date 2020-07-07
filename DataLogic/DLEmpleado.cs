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
    public class DLEmpleado
    {
        public static List<Empleado> GetAll()
        {
            return DAEmpleado.GetAll();
        }

        public static void Insert(Empleado v)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
DAEmpleado.Insert(v);
                    scope.Complete();//commit

                }
            }
            catch
            {



            }
            
        }

        public static Empleado GetID(int id)
        {
            return DAEmpleado.GetID(id);
        }

        public static void Update(Empleado e)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
DAEmpleado.Update(e);
                    scope.Complete();//commit

                }
            }
            catch
            {



            }
            
        }
        public static void Delete(Empleado e)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
DAEmpleado.Delete(e);
                    scope.Complete();//commit

                }
            }
            catch
            {



            }
            
        }
    }
}
