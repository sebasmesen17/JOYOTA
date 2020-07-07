using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DataPresentation
{
    public partial class Cliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FillDDL();
                FillClientes();
            }
        }

        private void FillClientes()
        {
            List<DataEntity.Cliente> Clientes = DataLogic.DLClientes.GetClientes();
            DDLClientes.DataSource = Clientes;
            DDLClientes.DataTextField = "nombre"; //antes del bind, para que no me muestre la ram el largo, igual que llama en el access
            DDLClientes.DataValueField = "CedulaCliente";
            DDLClientes.DataBind();
            DDLClientes.Items.Insert(0, "Seleccione un cliente");
        }

        public void FillDDL()
        {
            DDLTipoCedula.Items.Insert(0, "Nacional");
            DDLTipoCedula.Items.Insert(1, "Residente");
            DDLTipoCedula.Items.Insert(2, "Extranjero no residente");
        }

        public void fillGVCorreo(string cedula)
        {
            GVCorreo.DataSource = DataLogic.DLClientes.GetCorreoCliente(cedula);
            GVCorreo.DataBind();
        }

        public void fillGVTelefono(string cedula)
        {
            GVTelefono.DataSource = DataLogic.DLClientes.GetTelefonoCliente(cedula);
            GVTelefono.DataBind();
        }

        protected void btnregistrar_Click(object sender, EventArgs e)
        {
            if (tbCedula.Text != "")
            {
                if (DataLogic.DLClientes.Estado(tbCedula.Text) == true)
                {
                    DataEntity.Cliente clienteEncontrado = DataLogic.DLClientes.GetCliente(tbCedula.Text);
                    tbCedula.Enabled = false;
                    tbdireccion.Text = clienteEncontrado.direccion;
                    tbpassword.Enabled = false;
                    DDLTipoCedula.SelectedValue = clienteEncontrado.tipocedula;
                    tbNombreCompleto.Text = clienteEncontrado.nombre;
                    tbCorreo.Text = DataLogic.DLClientes.GetCorreo(tbCedula.Text);
                    tbTelefono.Text = DataLogic.DLClientes.GetTelefono(tbCedula.Text);
                    fillGVCorreo(tbCedula.Text);
                    fillGVTelefono(tbCedula.Text);
                }
                else
                {

                    if (tbNombreCompleto.Text != "" && tbdireccion.Text != "" && tbTelefono.Text != "" && tbCorreo.Text != "")
                    {
                        DataEntity.Cliente cliente = new DataEntity.Cliente()
                        {
                            CedulaCliente = tbCedula.Text,
                            tipocedula = DDLTipoCedula.SelectedValue,
                            nombre = tbNombreCompleto.Text,
                            direccion = tbdireccion.Text,
                            contrasenia = tbpassword.Text
                        };
                        bool estado = DataLogic.DLClientes.Estado(tbCedula.Text);
                        if (estado == false)
                        {
                            DataLogic.DLClientes.AgregarCliente(cliente);
                            DataEntity.TelefonoCliente telefono = new DataEntity.TelefonoCliente()
                            {
                                CedulaCliente = tbCedula.Text,
                                telefono = Convert.ToInt32(tbTelefono.Text)
                            };
                            DataLogic.DLClientes.AgregarTelefono(telefono);
                            tbTelefono.Text = "";
                            if (tbCorreo.Text != "")
                            {
                                DataEntity.CorreoCliente correoCliente = new DataEntity.CorreoCliente()
                                {
                                    CedulaCliente = tbCedula.Text,
                                    email = tbCorreo.Text
                                };
                                DataLogic.DLClientes.AgregarCorreo(correoCliente);
                                tbCorreo.Text = "";

                                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Agregado')", true);
                                limpiar();
                            }
                            else
                            {
                                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Inserte un correo')", true);
                            }
                        }
                    }
                    else
                    {
                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Campos requeridos no llenados')", true);
                    }
                }
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('No se encontró cédula')", true);
            }
        }

        private void limpiar()
        {
            Response.Redirect("/Cliente.aspx");
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            if (!tbCedula.Text.Equals(""))
            {
                if (DataLogic.DLClientes.Estado(tbCedula.Text))
                {
                    if (tbNombreCompleto.Text != "" && tbdireccion.Text != "" && tbTelefono.Text != "" && tbCorreo.Text != "")
                    {
                        DataEntity.Cliente cliente = new DataEntity.Cliente()
                        {
                            CedulaCliente = tbCedula.Text,
                            tipocedula = DDLTipoCedula.SelectedValue,
                            nombre = tbNombreCompleto.Text,
                            direccion = tbdireccion.Text
                        };
                        DataLogic.DLClientes.update(cliente);

                        DataEntity.CorreoCliente correo = new DataEntity.CorreoCliente()
                        {
                            CedulaCliente = tbCedula.Text,
                            email = tbCorreo.Text
                        };
                        DataLogic.DLClientes.AgregarCorreo(correo);

                        DataEntity.TelefonoCliente tel = new DataEntity.TelefonoCliente()
                        {
                            CedulaCliente = tbCedula.Text,
                            telefono = Convert.ToInt32(tbTelefono.Text)
                        };
                        DataLogic.DLClientes.AgregarTelefono(tel);

                        limpiar();
                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Cliente actualizado')", true);
                    }
                    else ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Algunos espacios están vacios')", true);
                }
                else
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('No existe esa cédula')", true);

            }
            else
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Digite la cédula para buscar')", true);
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!tbCedula.Text.Equals(""))
            {
                if (DataLogic.DLClientes.Estado(tbCedula.Text))
                {
                    DataLogic.DLClientes.Eliminar(tbCedula.Text);
                    limpiar();
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Cliente eliminado')", true);
                }
                else
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('No existe cedula')", true);

            }
            else
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Digite la cédula para buscar')", true);

        }

        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Cliente.aspx");
        }



        protected void DDLClientes_SelectedIndexChanged1(object sender, EventArgs e)
        {
            if (DDLClientes.SelectedIndex != 0)
            {
                DataEntity.Cliente clienteEncontrado = DataLogic.DLClientes.GetCliente(DDLClientes.SelectedValue.ToString());
                tbCedula.Enabled = false;
                tbCedula.Text = DDLClientes.SelectedValue.ToString();
                tbdireccion.Text = clienteEncontrado.direccion;
                tbpassword.Enabled = false;
                DDLTipoCedula.SelectedValue = clienteEncontrado.tipocedula;
                tbNombreCompleto.Text = clienteEncontrado.nombre;
                tbCorreo.Text = DataLogic.DLClientes.GetCorreo(DDLClientes.SelectedValue.ToString());
                tbTelefono.Text = DataLogic.DLClientes.GetTelefono(DDLClientes.SelectedValue.ToString());
                fillGVCorreo(DDLClientes.SelectedValue.ToString());
                fillGVTelefono(DDLClientes.SelectedValue.ToString());
            }
            else
                Response.Redirect("/Cliente.aspx");

        }

    }
}
