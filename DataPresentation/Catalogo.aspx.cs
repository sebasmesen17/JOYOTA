using DataEntity;
using DataLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DataPresentation
{
    public partial class Catalogo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FillDataList();
                try
                {
                    if (Session["fac"].ToString() == "realizada")
                    {
                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Factura fue generada exitosamente')", true);
                        Session["fac"] = "";
                    }
                }
                catch { }
            }
        }

        private void FillDataList()
        {
            List<Vehiculo> vehiculos = DLVehiculo.GetVehiculos();
            dlVehiculos.DataSource = vehiculos;
            dlVehiculos.DataBind();
        }

        protected void dlVehiculos_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if (e.CommandName.Equals("Compra"))
            {
                int posicion = Convert.ToInt32(e.CommandArgument);
                DataListItem columna = dlVehiculos.Items[posicion];

                Label id = (Label)columna.FindControl("l1");

                Session["CarroElegido"] = id.Text;
                try
                {
                    if (Session["LoginCliente"].ToString() != "")
                    {
                        irFactura();
                    }
                    else
                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Primero iniciar sesión')", true);
                }
                catch
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Primero iniciar sesión')", true);
                }
            }
        }

        private void irFactura()
        {

            Response.Redirect("/Facturacion.aspx");
        }
    }
}