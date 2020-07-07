using DataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DAVendedor
    {
        public static int GenID()
        {
            ModelJoyotaSa db = new ModelJoyotaSa();
            List<Ventas> v = null;
            try
            {
                v = db.Ventas.OrderBy(c => c.IDVendedor).ToList();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return v.Count + 1;
        }

        public static void Delete(Ventas ventas)
        {
            using (ModelJoyotaSa db = new ModelJoyotaSa())
            {

                try
                {
                    Ventas v = new Ventas();
                    v = db.Ventas.Where(c => c.IDEmpleado == ventas.IDEmpleado).FirstOrDefault();
                    db.Ventas.Remove(v);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }

            }
        }

        public static Ventas GetID(int id)
        {
            ModelJoyotaSa db = new ModelJoyotaSa();
            Ventas v = null;
            try
            {
                v = db.Ventas.First(c => c.IDEmpleado == id);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return v;
        }

        public static void Insert(Ventas v)
        {
            using (ModelJoyotaSa db = new ModelJoyotaSa())
            {
                try
                {
                    db.Ventas.Add(v);
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
