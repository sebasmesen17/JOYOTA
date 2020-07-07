using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataEntity;

namespace DataAccess
{
    public class DASucursal
    {
        public static void Agregar(sucursal sucursal)
        {
            using (ModelJoyotaSa db = new ModelJoyotaSa())
            {
                try
                {
                    db.sucursal.Add(sucursal);
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public static List<sucursal> GetAll()
        {
            ModelJoyotaSa db = new ModelJoyotaSa();
            List<sucursal> s = null;
            try
            {
                s = db.sucursal.OrderBy(c => c.IDSucursal).ToList();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return s;
        }
    }
}
