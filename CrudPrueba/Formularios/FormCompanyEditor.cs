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
                BtnCancelar1.Visible = false;
                CargarDatos();
            }
            else
            {
                LabelFecha.Text = "Fecha De Creacion";
                TxtTitulo.Text = "Creando nueva Empresa";
                BtnCancelar2.Visible = false;
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




        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnGuardar1_Click(object sender, EventArgs e)
        {
            using (CrudEntities db = new CrudEntities())
            {
                //validaciones
                if(string.IsNullOrEmpty(TxtNombre.Text))
                {
                    MessageBox.Show("Debe Ingresar Un Nombre,", "warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (string.IsNullOrEmpty(TxtCodigo.Text))
                {
                    MessageBox.Show("Debe Ingresar Un Codigo", "warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (string.IsNullOrEmpty(TxtDireccion.Text))
                {
                    MessageBox.Show("Debe Ingresar Una Direccion", "warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (string.IsNullOrEmpty(TxtTelefono.Text))
                {
                    MessageBox.Show("Debe Ingresar Un Telefono", "warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (string.IsNullOrEmpty(TxtCiudad.Text))
                {
                    MessageBox.Show("Debe Ingresar Una Ciudad", "warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (string.IsNullOrEmpty(TxtPais.Text))
                {
                    MessageBox.Show("Debe Ingresar Un Pais", "warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (string.IsNullOrEmpty(TxtDepartamento.Text))
                {
                    MessageBox.Show("Debe Ingresar Un Departamento", "warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                //guardado y edicion
                if (EmpresaId == null)
                {
                    table = new tabla();

                }
                table.Nombre = TxtNombre.Text;
                table.Codigo = Convert.ToInt32(TxtCodigo.Text);
                table.Direccion = TxtDireccion.Text;
                table.Telefono = TxtTelefono.Text;
                table.Ciudad = TxtCiudad.Text;
                table.Pais = TxtPais.Text;
                table.Departamento = TxtDepartamento.Text;

                if (EmpresaId == null)
                {
                    table.Fecha_Creacion = Dtp_Fecha_Creacion.Value;
                    db.tabla.Add(table);
                }
                else
                {
                    table.Ultima_Modificacion = Dtp_Fecha_Actualizacion.Value;
                    db.Entry(table).State = System.Data.Entity.EntityState.Modified;
                }
                db.SaveChanges();

                
                
                this.Close();
            }
        }

        private void TxtDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnCancelar1_Click(object sender, EventArgs e)
        {
            DialogResult rpta = new DialogResult();
            rpta = MessageBox.Show("¿Desea Cerrar Creacion De Empresas?", "¡Cerrando!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (rpta == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void BtnCancelar2_Click(object sender, EventArgs e)
        {
            string nombre = table.Nombre.ToString();
            DialogResult rpta = new DialogResult();
            rpta = MessageBox.Show("¿Desea Cerrar Edicion De La Empresa " + nombre + "?", "¡Los Cambios No Se Guardaran!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (rpta == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void FormCompanyEditor_Load(object sender, EventArgs e)
        {

        }

        private void Hora_Tick(object sender, EventArgs e)
        {
            LblHora.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void TxtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar >=32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Puedes Escribir Numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Puedes Escribir Numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
