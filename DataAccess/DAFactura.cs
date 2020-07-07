using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataEntity;

namespace DataAccess
{
    public class DAFactura
    {
        public static void agregarFac(Factura factura)
        {
            using (ModelJoyotaSa db = new ModelJoyotaSa())
            {
                try
                {
                    db.Factura.Add(factura);
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public static int idFac()
        {
            using (ModelJoyotaSa db = new ModelJoyotaSa())
            {
                try
                {
                    Factura fac = db.Factura.First();
                    if (fac == null)
                    {
                        return 1;
                    }
                    
                }
                catch (Exception)
                {

                }
                return db.Factura.Count() + 1;
            }
        }
    }
}
