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
    public class DLDepartamento
    {
        public static List<Departamento> GetAll()
        {
            return DADepartamento.GetAll();
        }
        public static int GenID()
        {
            return DADepartamento.GenID();
        }

        public static void Insert(Departamento v)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
DADepartamento.Insert(v);
                    scope.Complete();//commit

                }
            }
            catch
            {



            }
            
        }

        public static Departamento GetID(int id)
        {
            return DADepartamento.GetID(id);
        }

        public static void Delete(Departamento v)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
DADepartamento.Delete(v);
                    scope.Complete();//commit

                }
            }
            catch
            {



            }
            
        }

        public static void Update(Departamento a)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
DADepartamento.Update(a);
                    scope.Complete();//commit

                }
            }
            catch
            {



            }
            
        }
    }
}
