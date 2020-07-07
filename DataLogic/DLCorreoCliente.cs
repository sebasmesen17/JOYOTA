using DataAccess;
using DataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLogic
{
    public class DLCorreoCliente
    {
        public static string getCedula(string correo)
        {
            return DACorreoCliente.getCedula(correo);
        }
    }
}
