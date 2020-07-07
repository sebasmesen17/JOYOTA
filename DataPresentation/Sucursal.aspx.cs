using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DataPresentation
{
    public partial class Sucursal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DDLBodega.Items.Insert(0,"100");
                DDLBodega.Items.Insert(1, "200");
                DDLBodega.Items.Insert(2, "300");

                ddlidsucursal.Items.Insert(0, "1");
                ddlidsucursal.Items.Insert(1, "2");
                ddlidsucursal.Items.Insert(2, "3");
            }

        }


        protected void btninsertar_Click(object sender, EventArgs e)
        {
            if (tbnombre.Text != "" && tbubicacion.Text != "")
            {
                DataEntity.sucursal sucursal = new DataEntity.sucursal()
                {
                    IDSucursal = Convert.ToInt32(ddlidsucursal.SelectedValue),
                    NombreSucursal = tbnombre.Text,
                    ubicacion = tbubicacion.Text,
                    IDBodega = DDLBodega.SelectedValue.ToString(),
                };
                DataLogic.DLSucursal.Agregar(sucursal);
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Agregado correctamente')", true);
                limpiar();
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Faltan campos por llenar')", true);
            }
        }


        public void limpiar()
        {
     
            tbnombre.Text = "";
            tbubicacion.Text = "";

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void btnmod_Click(object sender, EventArgs e)
        {

        }
    }
}