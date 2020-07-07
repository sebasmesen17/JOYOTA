using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataEntity;

namespace DataAccess
{
    public class DAProveedores
    {
        public static void Agregar(Proveedor proveedor)
        {
            using (ModelJoyotaSa db = new ModelJoyotaSa())
            {
                try
                {
                    db.Proveedor.Add(proveedor);
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
    }
}
