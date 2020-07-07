using DataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DAAdministrativo
    {
        public static int GenID()
        {
            ModelJoyotaSa db = new ModelJoyotaSa();
            List<Administrativo> v = null;
            try
            {
                v = db.Administrativo.OrderBy(c => c.IDAdministrativo).ToList();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return v.Count + 1;
        }

        public static Administrativo GetID(int id)
        {
            ModelJoyotaSa db = new ModelJoyotaSa();
            Administrativo v = null;
            try
            {
                v = db.Administrativo.First(c => c.IDEmpleado == id);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return v;
        }

        public static void Delete(Administrativo a)
        {
            using (ModelJoyotaSa db = new ModelJoyotaSa())
            {

                try
                {
                    Administrativo admin = new Administrativo();
                    admin = db.Administrativo.Where(c => c.IDEmpleado == a.IDEmpleado).FirstOrDefault();
                    db.Administrativo.Remove(admin);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }

            }
        }

        public static void Insert(Administrativo a)
        {

            using (ModelJoyotaSa db = new ModelJoyotaSa())
            {
                try
                {
                    db.Administrativo.Add(a);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }

            }
        }
    }
}

