using DataLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataEntity;

namespace DataPresentation
{
    public partial class Departamento : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FillGVDepartamentos();
                tbIDDepartamento.Text = DLDepartamento.GenID().ToString();
                tbIDDepartamento.Enabled = false;
                btnEliminar.Enabled = false;
                btnActualizar.Enabled = false;
            }
        }

        private void FillGVDepartamentos()
        {
            GVDepartamentos.DataSource = DLDepartamento.GetAll();
            GVDepartamentos.DataBind();
            //GVDepartamentos.Columns[1].Visible=false;
        }

        protected void btnregistrar_Click(object sender, EventArgs e)
        {
            if (tbNombreDep.Text != "")
            {
                insertDep();
            }
            clear();
            FillGVDepartamentos();

        }

        private void insertDep()
        {
            DataEntity.Departamento a = new DataEntity.Departamento()
            {
                IDDepartamento = DLDepartamento.GenID(),
                nombreDepartamento = tbNombreDep.Text

            };

            DLDepartamento.Insert(a);
            tbIDDepartamento.Text = DLDepartamento.GenID().ToString();
            tbIDDepartamento.Enabled = false;
            btnregistrar.Enabled = true;
            btnLimpiar.Enabled = true;
            btnEliminar.Enabled = false;
            btnActualizar.Enabled = false;
        }

        private void clear()
        {
            tbNombreDep.Text = "";
            // tbIDDepartamento;
        }


        protected void GVDepartamentos_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            if (GVDepartamentos.SelectedIndex != 0)
            {
                cargardep(Int32.Parse(GVDepartamentos.DataKeys[e.NewSelectedIndex].Value.ToString()));


            }

        }

        private void cargardep(int v)
        {
            DataEntity.Departamento d = DLDepartamento.GetID(v);
            tbIDDepartamento.Enabled = true;
            tbIDDepartamento.Text = d.IDDepartamento.ToString();
            tbNombreDep.Text = d.nombreDepartamento;
            tbIDDepartamento.Enabled = false;
            btnregistrar.Enabled = false;
            btnLimpiar.Enabled = false;
            btnEliminar.Enabled = true;
            btnActualizar.Enabled = true;
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            if (tbNombreDep.Text != "")
            {
                DataEntity.Departamento a = new DataEntity.Departamento()
                {
                    IDDepartamento = Convert.ToInt32(tbIDDepartamento.Text),
                    nombreDepartamento = tbNombreDep.Text

                };

                DLDepartamento.Update(a);
                tbIDDepartamento.Text = DLDepartamento.GenID().ToString();
                tbIDDepartamento.Enabled = false;
                btnregistrar.Enabled = true;
                btnLimpiar.Enabled = true;
                btnEliminar.Enabled = false;
                btnActualizar.Enabled = false;
                FillGVDepartamentos();
                clear();
            }
        }
        private void delete()
        {
            if (tbNombreDep.Text != "")
            {
                DataEntity.Departamento a = new DataEntity.Departamento()
                {
                    IDDepartamento = Convert.ToInt32(tbIDDepartamento.Text),
                    nombreDepartamento = tbNombreDep.Text

                };

                DLDepartamento.Delete(a);
                tbIDDepartamento.Text = DLDepartamento.GenID().ToString();
                tbIDDepartamento.Enabled = false;
                btnregistrar.Enabled = true;
                btnLimpiar.Enabled = true;
                btnEliminar.Enabled = false;
                btnActualizar.Enabled = false;
                FillGVDepartamentos();
                clear();
            }

        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            delete();
        }

        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}