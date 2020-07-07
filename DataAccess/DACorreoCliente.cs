using DataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DACorreoCliente
    {
        public static string getCedula(string correo)
        {
            using (ModelJoyotaSa db = new ModelJoyotaSa())
            {
                try
                {
                    CorreoCliente cc = db.CorreoCliente.Where(c => c.email == correo).FirstOrDefault();
                    if (cc != null)
                    {
                        return cc.CedulaCliente;
                    }
                    else
                    {
                        return "";
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
    }
}
