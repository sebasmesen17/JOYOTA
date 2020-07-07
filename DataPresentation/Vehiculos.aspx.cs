using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DataPresentation
{
    public partial class Vehiculos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                FillDLLs();
        }

        private void FillDLLs()
        {

            DDLmarca.Items.Insert(0, "TOYOTA");


            DDLmodelo.Items.Insert(0, "Aygo");
            DDLmodelo.Items.Insert(1, "Cruiser");
            DDLmodelo.Items.Insert(2, "Corolla");
            DDLmodelo.Items.Insert(3, "Fortuner");
            DDLmodelo.Items.Insert(4, "Hilux");
            DDLmodelo.Items.Insert(5, "Land Cruiser");
            DDLmodelo.Items.Insert(6, "Tundra");
            DDLmodelo.Items.Insert(7, "Tacoma");

            int var = 2000;
            for (int i = 0; i < 21; i++)
            {

                DDLAño.Items.Insert(i, var.ToString());
                var++;
            }

            DDLColor.Items.Insert(0, "Rojo");
            DDLColor.Items.Insert(1, "Verde");
            DDLColor.Items.Insert(2, "Amarillo");
            DDLColor.Items.Insert(3, "Azul");
            DDLColor.Items.Insert(4, "Naranja");
            DDLColor.Items.Insert(5, "Marino");
            DDLColor.Items.Insert(6, "Celeste");
            DDLColor.Items.Insert(7, "Negro");
            DDLColor.Items.Insert(8, "Blanco");
            DDLColor.Items.Insert(9, "Morado");

            DDLCategoria.Items.Insert(0, "Deportivo");
            DDLCategoria.Items.Insert(1, "4x4");
            DDLCategoria.Items.Insert(2, "Electrico");
            DDLCategoria.Items.Insert(3, "Suv");

            DDLImpuestoVenta.Items.Insert(0, "13");
            DDLImpuestoVenta.Items.Insert(1, "4");

            DDLEstado.Items.Insert(0, "Nuevo");
            DDLEstado.Items.Insert(0, "Usado");

            DDLExcento.Items.Insert(0, "No excento");
            DDLExcento.Items.Insert(0, "Excento");

            DDLSucursal.Items.Insert(0, "La Uruca");
            DDLSucursal.Items.Insert(1, "Heredia");
            DDLSucursal.Items.Insert(2, "Guanacaste");
        }

        public void InsertarVehiculo()
        {
            if(!String.IsNullOrEmpty(tbIDvehiculo.Text))
            {
                if (DataLogic.DLVehiculo.estado(Convert.ToInt32(tbIDvehiculo.Text)) == false)
                {
                    /*int length = fileuploadImage.PostedFile.ContentLength;
                byte[] imageByte = new byte[length];
                HttpPostedFile image = fileuploadImage.PostedFile;
                image.InputStream.Read(imageByte, 0, length);*/
                    if (tbCodigoBarra.Text != "" && tbIDvehiculo.Text != "" && tbImpValorAgregado.Text != ""
                        && tbpeso.Text != "" && tbpreciocompra.Text != "" && fileimage.FileName != "")
                    {
                        string ruta = "";
                        DataEntity.Vehiculo vehiculo = new DataEntity.Vehiculo()
                        {

                            nombreSucursal = DDLSucursal.SelectedValue.ToString(),
                            IDVehiculo = Convert.ToInt32(tbIDvehiculo.Text),
                            modelo = DDLmodelo.SelectedValue.ToString(),
                            marca = DDLmarca.SelectedValue.ToString(),
                            año = DDLAño.SelectedValue.ToString(),
                            color = DDLColor.SelectedValue.ToString(),
                            categoria = DDLCategoria.SelectedValue.ToString(),
                            codigoBarra = Convert.ToInt32(tbCodigoBarra.Text),
                            precioCompra = Convert.ToDecimal(tbpreciocompra.Text),
                            impuestoValorAgregado = Convert.ToInt32(tbImpValorAgregado.Text),
                            impuestoVenta = Convert.ToInt32(DDLImpuestoVenta.Text),
                            excento = DDLExcento.SelectedValue.ToString(),
                            peso = Convert.ToInt32(tbpeso.Text),
                            estado = DDLEstado.SelectedValue.ToString(),
                            img = ruta = "imag/carros/" + fileimage.FileName
                        };
                        DataLogic.DLVehiculo.AgregarVehiculo(vehiculo);
                        limpiar();
                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Agregado correctamente')", true);

                    }
                    else
                    {
                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Faltan campos por llenar')", true);

                    }
                }
                else
                {
                    DataEntity.Vehiculo veh = DataLogic.DLVehiculo.getVehiculo(tbIDvehiculo.Text);
                    DDLSucursal.SelectedValue = veh.IDVehiculo.ToString();
                    tbIDvehiculo.Text = veh.IDVehiculo.ToString();
                    DDLmodelo.SelectedValue = veh.modelo;
                    DDLmarca.SelectedValue = veh.marca;
                    DDLAño.SelectedValue = veh.año;
                    DDLColor.SelectedValue = veh.color;
                    DDLCategoria.SelectedValue = veh.categoria;
                    tbCodigoBarra.Text = veh.codigoBarra.ToString();
                    tbpreciocompra.Text = veh.precioCompra.ToString();
                    tbImpValorAgregado.Text = veh.impuestoValorAgregado.ToString();
                    DDLImpuestoVenta.Text = veh.impuestoVenta.ToString();
                    DDLExcento.SelectedValue = veh.excento;
                    tbpeso.Text = veh.peso.ToString();
                    DDLEstado.SelectedValue = veh.estado;
                }
            }
            else
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('ingrese un ID')", true);

        }

        private void limpiar()
        {
            Response.Redirect("/Vehiculos.aspx");
        }

        protected void tbinsertarvehiculo_Click(object sender, EventArgs e)
        {
            InsertarVehiculo();
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbIDvehiculo.Text))
            {
                DataLogic.DLVehiculo.Eliminar(tbIDvehiculo.Text);
                limpiar();
            }
            else
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Ingrese el id')", true);
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbIDvehiculo.Text))
            {
                    if (tbCodigoBarra.Text != "" && tbIDvehiculo.Text != "" && tbImpValorAgregado.Text != "" && tbpeso.Text != "" && tbpreciocompra.Text != "")
                    {
                        string ruta = "";
                        DataEntity.Vehiculo vehiculo = new DataEntity.Vehiculo();
                        vehiculo.nombreSucursal = DDLSucursal.SelectedValue.ToString();
                        vehiculo.IDVehiculo = Convert.ToInt32(tbIDvehiculo.Text);
                        vehiculo.modelo = DDLmodelo.SelectedValue.ToString();
                        vehiculo.marca = DDLmarca.SelectedValue.ToString();
                        vehiculo.año = DDLAño.SelectedValue.ToString();
                        vehiculo.color = DDLColor.SelectedValue.ToString();
                        vehiculo.categoria = DDLCategoria.SelectedValue.ToString();
                        vehiculo.codigoBarra = Convert.ToInt32(tbCodigoBarra.Text);
                        vehiculo.precioCompra = Convert.ToDecimal(tbpreciocompra.Text);
                        vehiculo.impuestoValorAgregado = Convert.ToInt32(tbImpValorAgregado.Text);
                        vehiculo.impuestoVenta = Convert.ToInt32(DDLImpuestoVenta.Text);
                        vehiculo.excento = DDLExcento.SelectedValue.ToString();
                        vehiculo.peso = Convert.ToInt32(tbpeso.Text);
                        vehiculo.estado = DDLEstado.SelectedValue.ToString();
                        vehiculo.img = ruta = "imag/carros/" + fileimage.FileName;

                        DataLogic.DLVehiculo.actualizar(vehiculo);
                        limpiar();
                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Vehiculo actualizado')", true);
                    }
                        else
                            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Algunos espacios están vacios...')", true);

                    
                    
                }
            else
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Digite el ID')", true);
        }
    }
}