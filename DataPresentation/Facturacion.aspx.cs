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
    public partial class Facturacion : System.Web.UI.Page
    {
        Vehiculo vehiculo;
        Factura factura = new Factura();
        double total = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            vehiculo = DLVehiculo.getVehiculo(Session["CarroElegido"].ToString());
            fillDDLPago();
            fillFactura();
        }

        private void fillDDLPago()
        {
            DDLTipoPago.Items.Insert(0, "Efectivo");
            DDLTipoPago.Items.Insert(1, "Cheque");
        }

        private void fillFactura()
        {
            lbMarca.Text = vehiculo.marca;
            lbModelo.Text = vehiculo.modelo;
            lbAño.Text = vehiculo.año;
            lbCate.Text = vehiculo.categoria;
            lbEstado.Text = vehiculo.estado;

            tbFecha.Text = DateTime.Now.ToString();
            lbCliente.Text = Session["LoginCliente"].ToString();
            lbiva.Text = vehiculo.impuestoValorAgregado.ToString();
            lbIvi.Text = vehiculo.impuestoVenta.ToString();
            lbPrecio.Text = vehiculo.precioCompra.ToString();
            total = Convert.ToDouble(vehiculo.precioCompra) + Convert.ToDouble(vehiculo.precioCompra) * (Convert.ToDouble(vehiculo.impuestoValorAgregado) * 0.01) +
                Convert.ToDouble(vehiculo.precioCompra) * (Convert.ToDouble(vehiculo.impuestoVenta) * 0.01);
            lbTotal.Text = total.ToString();
        }

        protected void btnComprar_Click(object sender, EventArgs e)
        {
            
                email em = new email();

                factura.Fecha = Convert.ToDateTime(tbFecha.Text);
                factura.monto = Convert.ToDecimal(total);
                factura.IDSucursal = Convert.ToInt32(lbIDSucursal.Text);
                factura.cantidad = Convert.ToInt32(lbCantidad.Text);
                factura.tipoPago = DDLTipoPago.SelectedValue.ToString();

           
                factura.IDFactura = DataLogic.DLFactura.idFac();
                DataLogic.DLFactura.agregarFac(factura);
            

                em.Send(factura,tbFecha.Text, lbCliente.Text, vehiculo, Session["correo"].ToString());


            Session["fac"] = "realizada"; 
            Response.Redirect("Catalogo.aspx");
        }

        
    }
}