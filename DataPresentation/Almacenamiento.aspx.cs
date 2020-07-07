using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DataPresentation
{
    public partial class Almacenamiento : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void FillDDL()
        {

        }

        protected void btnregistrar_Click(object sender, EventArgs e)
        {
            DataEntity.Almacenamiento almacenamiento = new DataEntity.Almacenamiento()
            {
                cantidad=Convert.ToInt32(tbCantidad.Text),
                IDBodega=Convert.ToInt32(DDlbodega.SelectedValue),
                IDVehiculo= Convert.ToInt32(DDLvehiculo.SelectedValue)
            };

            DataLogic.DLAlmacenamient.Agregar(almacenamiento);
        }

        protected void boton_Click(object sender, EventArgs e)
        {
            DataEntity.Almacenamiento almacenamiento = new DataEntity.Almacenamiento()
            {
                cantidad = Convert.ToInt32(tbCantidad.Text),
                IDBodega = Convert.ToInt32(DDlbodega.SelectedValue),
                IDVehiculo = Convert.ToInt32(DDLvehiculo.SelectedValue)
            };

            DataLogic.DLAlmacenamient.Agregar(almacenamiento);
        }
    }
}