using DataLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DataPresentation
{
    public partial class LoginEmp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnRVerificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ComprobarEmp(Convert.ToInt32(tbID.Text), tbNombre.Text))
                {
                    FormsAuthentication.RedirectFromLoginPage(tbNombre.Text, true);
                    limpiar();
                }
                else
                {
                    Response.Redirect("LoginEmp.aspx");
                }
            }
            catch
            {
                throw;
            }
        }

        private bool ComprobarEmp(int id, string nom)
        {
            bool existe = false;

            DataEntity.Empleado empleado = DLEmpleado.GetID(id);
            if (!empleado.nombre.Equals(""))
            {

                if (empleado.nombre.Equals(nom))
                {
                    existe = true;
                }
            }
            return existe;
        }

        public void limpiar()
        {
            tbID.Text = "";
            tbNombre.Text = "";
        }
    }
}