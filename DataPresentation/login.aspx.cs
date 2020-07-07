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
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["LoginCliente"] = "";
        }

        protected void btnRVerificar_Click(object sender, EventArgs e)
        {
            if (ComprobarCorreo(tbCorreo.Text, tbPassword.Text))
            {
                FormsAuthentication.RedirectFromLoginPage(
                Session["LoginCliente"].ToString(), true);
                Response.Redirect("catalogo.aspx");
                limpiar();

            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Contraseña o usuario Incorrecto')", true);
            }

        }

        private bool ComprobarCorreo(string correo, string password)
        {
            bool existe = false;

            String cedulaCliente = DLCorreoCliente.getCedula(correo);
            if (!cedulaCliente.Equals(""))
            {
                DataEntity.Cliente cliente = DLClientes.GetCliente(cedulaCliente);
                if (cliente.contrasenia.Equals(password))
                {

                    Session["LoginCliente"] = cliente.nombre;
                    Session["correo"] = DLClientes.GetCorreo(cliente.CedulaCliente);
                    existe = true;
                }
            }
            return existe;
        }

        public void limpiar()
        {
            tbPassword.Text = "";
            tbCorreo.Text = "";
        }

        protected void lbntEmpleadoLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("LoginEmp.aspx");
        }

        protected void lbntCrearUsuario_Click(object sender, EventArgs e)
        {
            Response.Redirect("Cliente.aspx");
        }
    }
}