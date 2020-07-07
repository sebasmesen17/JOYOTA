using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataEntity;

namespace DataLogic
{
    public class DLFactura
    {
        public static void agregarFac(Factura factura)
        {
            DataAccess.DAFactura.agregarFac(factura);
        }

        public static int idFac()
        {
            return DataAccess.DAFactura.idFac();
        }
    }
}
