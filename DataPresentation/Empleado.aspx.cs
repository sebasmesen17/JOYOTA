using DataLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DataPresentation
{
    public partial class Empleado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                FillDDLCargo(DDLCargo);
                FillDDLCargo(DDlEmpleadosPorDepartamento);
                lbDepartamento.Visible = false;
                DDLDepartamento.Visible = false;
                lbSucursal.Visible = false;
                DDLSucursal.Visible = false;
                bloqueaActualizar(false);
                btnEliminar.Enabled = false;
                FillDDLDepartamento();
                FillDDLSucursal();
                FillGVEmpleados();
            }
        }

        private void FillGVEmpleados()
        {
            GVEmpleados.DataSource = DLEmpleado.GetAll();
            GVEmpleados.DataBind();
        }

        private void FillDDLCargo(DropDownList d)
        {
            d.Items.Insert(0, "Seleccione un Cargo");
            d.Items.Insert(1, "Vendedor");
            d.Items.Insert(2, "Administrativo");



        }

        protected void tbregistrar_Click(object sender, EventArgs e)
        {
            if (DDLCargo.SelectedIndex != 0)
            {
                if (DDLCargo.SelectedIndex == 1)//si es vendedor
                {
                    if (verificarVededor())
                    {
                        insertEmp();
                        insertVendedor();
                        clear();
                    }
                }
                else
                {
                    if (verificarAdmin())
                    {
                        insertEmp();
                        insertAdmin();
                        clear();
                    }
                }
            }//fin de if
        }

        private void insertAdmin()
        {
            DataEntity.Administrativo e = new DataEntity.Administrativo()
            {

                IDAdministrativo = DLAdministrativo.GenID(),
                IDEmpleado = Int32.Parse(tbIDEmpleado.Text),
                IDDepartamento = int.Parse(DDLDepartamento.SelectedValue)

            };
            DLAdministrativo.Insert(e);
            FillGVEmpleados();
        }

        private void insertEmp()
        {
            DataEntity.Empleado e = new DataEntity.Empleado()
            {

                IDEmpleado = Int32.Parse(tbIDEmpleado.Text),
                nombre = tbNombre.Text,
                salario = int.Parse(tbSalario.Text),
                cargo = DDLCargo.SelectedValue,

            };
            DLEmpleado.Insert(e);
            FillGVEmpleados();
        }

        private void insertVendedor()
        {
            DataEntity.Ventas v = new DataEntity.Ventas()
            {
                IDVendedor = DLVendedor.GenID(),
                IDEmpleado = Int32.Parse(tbIDEmpleado.Text),
                IDSucursal = Int32.Parse(DDLSucursal.SelectedValue)
            };
            DLVendedor.Insert(v);
            FillGVEmpleados();
        }


        protected void DDLCargo_SelectedIndexChanged1(object sender, EventArgs e)
        {
            if (DDLCargo.SelectedIndex != 0 & DDLCargo.SelectedIndex != 1)
            {
                lbDepartamento.Visible = true;
                DDLDepartamento.Visible = true;
                FillDDLDepartamento();

            }
            else
            {
                lbDepartamento.Visible = false;
                DDLDepartamento.Visible = false;
                DDLDepartamento.SelectedIndex = 0;
            }
            if (DDLCargo.SelectedIndex != 0 & DDLCargo.SelectedIndex != 2)
            {
                lbSucursal.Visible = true;
                DDLSucursal.Visible = true;
                FillDDLSucursal();

            }
            else
            {
                lbSucursal.Visible = false;
                DDLSucursal.Visible = false;
                //DDLSucursal.SelectedIndex = 0;
            }

        }

        private void FillDDLSucursal()
        {
            DDLSucursal.DataSource = DLSucursal.GetAll();
            DDLSucursal.DataTextField = "NombreSucursal";
            DDLSucursal.DataValueField = "IDSucursal";

            DDLDepartamento.DataBind();
            DDLDepartamento.Items.Insert(0, "Seleccione Sucursal");
        }

        private void FillDDLDepartamento()
        {

            DDLDepartamento.DataSource = DLDepartamento.GetAll();
            DDLDepartamento.DataTextField = "nombreDepartamento";
            DDLDepartamento.DataValueField = "IDDepartamento";

            DDLDepartamento.DataBind();
            DDLDepartamento.Items.Insert(0, "Seleccione Departamento");

        }
        private void clear()
        {
            tbIDEmpleado.Text = " ";
            tbNombre.Text = " ";
            tbSalario.Text = " ";
            DDLCargo.SelectedIndex = 0;
            DDLDepartamento.SelectedIndex = 0;
        }
        private bool verificarVededor()
        {
            bool v = true;
            if (tbIDEmpleado.Text == "")
            {

                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Ingrese el ID Empleado')", true);
                v = false;
            }
            if (tbNombre.Text == "")
            {

                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('ingrese el nombre del empleado')", true);
                v = false;
            }
            if (tbSalario.Text == "")
            {

                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('ingrese el salario del empleado')", true);
                v = false;
            }
            if (DDLCargo.SelectedIndex == 0)
            {

                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Seleccione un Cargo')", true);
                v = false;
            }
            if (DDLSucursal.SelectedIndex == -1)//0
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Seleccione un Sucursal')", true);

                v = false;
            }

            return v;

        }
        private bool verificarAdmin()
        {
            bool v = true;
            if (tbIDEmpleado.Text == "")
            {

                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Ingrese el ID Empleado')", true);
                v = false;
            }
            if (tbNombre.Text == "")
            {

                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('ingrese el nombre del empleado')", true);
                v = false;
            }
            if (tbSalario.Text == "")
            {

                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('ingrese el salario del empleado')", true);
                v = false;
            }
            if (DDLCargo.SelectedIndex == 0)
            {

                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Seleccione un Cargo')", true);
                v = false;
            }
            if (DDLDepartamento.SelectedIndex == 0)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Seleccione un Departamento')", true);

                v = false;
            }
            return v;

        }
        private void BloqueoID(bool v, int cargo)
        {
            if (v)
            {

                tbIDEmpleado.Enabled = v;
                DDLCargo.SelectedIndex = cargo;
                DDLCargo.Enabled = v;

            }
            else
            {
                tbIDEmpleado.Enabled = v;
                DDLCargo.Enabled = v;
            }
        }
        private void bloqueaActualizar(bool t)
        {
            if (t)
            {
                btnActualizar.Enabled = t;
            }
            else
            {
                btnActualizar.Enabled = t;
            }
        }

        /////////////////Actualizar
        public void cargarEmp(int id)
        {
            tbregistrar.Enabled = false;
            DataEntity.Empleado e = DLEmpleado.GetID(id);
            tbIDEmpleado.Text = e.IDEmpleado.ToString();
            tbIDEmpleado.Enabled = false;
            tbSalario.Text = e.salario.ToString();
            tbNombre.Text = e.nombre;
            DDLCargo.SelectedValue = e.cargo;
            if (DDLCargo.SelectedIndex == 1)//vendedor
            {
                cargarVendedor(id);
                DDLCargo.Enabled = false;
            }
            else
            {
                cargarAdmin(id);
                DDLCargo.Enabled = false;
            }



        }
        public void cargarVendedor(int id)
        {
            DataEntity.Ventas v = DLVendedor.GetID(id);
            DDLSucursal.SelectedValue = v.IDSucursal.ToString();
            DDLSucursal.Enabled = false;

        }
        public void cargarAdmin(int id)
        {
            DataEntity.Administrativo a = DLAdministrativo.GetID(id);
            DDLDepartamento.SelectedValue = a.IDDepartamento.ToString();
            DDLDepartamento.Enabled = false;

        }
        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            tbregistrar.Enabled = true;
            bloqueaActualizar(false);
            tbIDEmpleado.Enabled = true;
            btnEliminar.Enabled = false;
            DDLCargo.Enabled = true;
            DDLDepartamento.Enabled = true;
            DDLSucursal.Enabled = true;
            if (DDLCargo.SelectedIndex != 0)
            {
                if (DDLCargo.SelectedIndex == 1)//si es vendedor
                {
                    if (verificarVededor())
                    {
                        UpdateEmp();

                        clear();
                    }
                }
                else
                {
                    if (verificarAdmin())
                    {
                        UpdateEmp();

                        clear();
                    }
                }


            }
        }



        private void UpdateEmp()
        {
            DataEntity.Empleado e = new DataEntity.Empleado()
            {

                IDEmpleado = Int32.Parse(tbIDEmpleado.Text),
                nombre = tbNombre.Text,
                salario = int.Parse(tbSalario.Text),
                cargo = DDLCargo.SelectedValue,

            };
            DLEmpleado.Update(e);
            FillGVEmpleados();
        }

        protected void GVEmpleados_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            bloqueaActualizar(true);
            btnEliminar.Enabled = true;
            int id = Int32.Parse(GVEmpleados.DataKeys[e.NewSelectedIndex].Value.ToString());
            cargarEmp(id);
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            tbregistrar.Enabled = true;
            bloqueaActualizar(false);
            tbIDEmpleado.Enabled = true;
            btnEliminar.Enabled = false;
            DDLCargo.Enabled = true;
            DDLDepartamento.Enabled = true;
            DDLSucursal.Enabled = true;
            if (DDLCargo.SelectedIndex != 0)
            {
                if (DDLCargo.SelectedIndex == 1)//si es vendedor
                {

                    DeleteVendedor();
                    DeleteEmp();

                    clear();

                }
                else
                {

                    DeleteEmp();
                    DeleteAdmin();
                    clear();

                }


            }
        }

        private void DeleteVendedor()
        {
            DLVendedor.Delete(DLVendedor.GetID(int.Parse(tbIDEmpleado.Text)));
            FillGVEmpleados();
        }

        private void DeleteAdmin()
        {
            DLAdministrativo.Delete(DLAdministrativo.GetID(int.Parse(tbIDEmpleado.Text)));
            FillGVEmpleados();
        }

        private void DeleteEmp()
        {
            DLEmpleado.Delete(DLEmpleado.GetID(int.Parse(tbIDEmpleado.Text)));
            FillGVEmpleados();
        }
    }
}