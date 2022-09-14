using CrudPrueba.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudPrueba.Formularios
{
    public partial class FormCompanyEditor : Form
    {
        public int? EmpresaId;
        public string Titulo = "";
        public string Fecha_Creacion_Actualizacion = "";
        tabla table = null;
        public FormCompanyEditor(int? EmpresaId = null)
        {
            InitializeComponent();

            this.EmpresaId = EmpresaId;
            if (EmpresaId != null)
            {
                LabelFecha.Text = "Fecha De Actualizacion";
                TxtTitulo.Text = "Editando Empresa";
                Dtp_Fecha_Creacion.Visible = false;
                CargarDatos();
            }
            else
            {
                LabelFecha.Text = "Fecha De Creacion";
                TxtTitulo.Text = "Creando nueva Empresa";
                Dtp_Fecha_Actualizacion.Visible = false;
            }
        }
        private void CargarDatos()
        {
            using(CrudEntities db = new CrudEntities())
            {
                table = db.tabla.Find(EmpresaId);
                TxtNombre.Text = table.Nombre;
                TxtCodigo.Text = table.Codigo.ToString();
                TxtDireccion.Text = table.Direccion;
                TxtTelefono.Text = table.Telefono;
                TxtCiudad.Text = table.Ciudad;
                TxtPais.Text = table.Pais;
                TxtDepartamento.Text = table.Departamento;
                Dtp_Fecha_Actualizacion.Value = Dtp_Fecha_Actualizacion.Value;      
            }
        }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            string nombre = table.Nombre.ToString();
            if (EmpresaId == null)
            {
                DialogResult rpta = new DialogResult();
                rpta = MessageBox.Show("¿Desea Cerrar Creacion De Empresas?" , "¡Cerrando!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (rpta == DialogResult.OK)
                {
                    this.Close();
                }
            }
            else
            {
                DialogResult rpta = new DialogResult();
                rpta = MessageBox.Show("¿Desea Cerrar Edicion De La Empresa " +nombre + "?" , "¡Los Cambios No Se Guardaran!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (rpta == DialogResult.OK)
                {
                    this.Close();
                }
            }
            
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            using (CrudEntities db = new CrudEntities())
            {
                if(EmpresaId == null) 
                { 
                    tabla table = new tabla();
                    table.Fecha_Creacion = Dtp_Fecha_Creacion.Value;
                }
                table.Nombre = TxtNombre.Text;
                table.Codigo = Convert.ToInt32(TxtCodigo.Text);
                table.Direccion = TxtDireccion.Text;
                table.Telefono = TxtTelefono.Text;
                table.Ciudad = TxtCiudad.Text;
                table.Pais = TxtPais.Text;
                table.Departamento = TxtDepartamento.Text;
                table.Ultima_Modificacion = Dtp_Fecha_Actualizacion.Value;

                if (EmpresaId == null)
                {
                    db.tabla.Add(table);
                }
                else
                {
                    db.Entry(table).State = System.Data.Entity.EntityState.Modified;
                }
                db.SaveChanges();
                
                this.Close();
            }
        }
    }
}
