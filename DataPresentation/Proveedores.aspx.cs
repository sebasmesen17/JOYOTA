using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DataPresentation
{
    public partial class Proveedores : System.Web.UI.Page
    {


protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FillGVPro();

            }
        }

        private void FillGVPro()
        {
            
            GVProveedor.DataBind();
        }

        protected void tbregistrar_Click(object sender, EventArgs e)
        {
            if (tbCedulaJuridica.Text != "" && tbContacto.Text != "" && tbdireccion.Text != "" && tbNombre.Text != "" && tbregistrar.Text != "" )
            {

            
            DataEntity.Proveedor proveedor = new DataEntity.Proveedor()
            {
                CedulaJuridica = tbCedulaJuridica.Text,
                nombre = tbNombre.Text,
                direccion = tbdireccion.Text,
                contacto = tbContacto.Text,



            };
            DataLogic.DLProveedor.Agregar(proveedor);
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Agregado correctamente')", true);
                FillGVPro();
            Clear();
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Faltan campos por agregar')", true);
            }

        }

        private void Clear()
        {
            tbCedulaJuridica.Text = " ";
            tbNombre.Text = " ";
            tbdireccion.Text = " ";
            tbContacto.Text = " ";
        }

       
    }
}