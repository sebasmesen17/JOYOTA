using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DataPresentation
{
    public partial class Bodega : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
               
            }
        }

       
        protected void btnregistrar_Click(object sender, EventArgs e)
        {
            if (tbBodega.Text!="" && tbModelo.Text!="")
            {
                DataEntity.Bodega bodega = new DataEntity.Bodega()
                {
                    IDBodega = Convert.ToInt32(tbBodega.Text),
                    modelo = tbModelo.Text
                };
                DataLogic.DLBodega.Agregar(bodega);
            }
        }
    }
}