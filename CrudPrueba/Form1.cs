using CrudPrueba.Entidades;
using CrudPrueba.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudPrueba
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        tabla table = null;
        public string Nombre = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Refrescar();
            OculatarColumnaId();
        }

        #region HELPER
        private void Refrescar()
        {
            using (CrudEntities db = new CrudEntities())
            {
                var list = from x in db.tabla
                           select x;
                Dgv.DataSource = list.ToList();
            }
        }
        

        private void OculatarColumnaId()
        {
            Dgv.Columns[0].Visible = false;
        }

        private int? GetId()
        {
            try
            {
                return int.Parse(Dgv.Rows[Dgv.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;
            }
        }
        #endregion
        private void BtnCrear1_Click(object sender, EventArgs e)
        {
            FormCompanyEditor formCompanyEditor = new FormCompanyEditor();
            formCompanyEditor.ShowDialog();

            Refrescar();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult rpta = new DialogResult();
            rpta = MessageBox.Show("¿Desea Salir De La Aplicacion?", "¡Cerrando Aplicacion!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (rpta == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        public List<tabla> Buscar(string nombre)
        {
            using (CrudEntities db = new CrudEntities())
            {
                return db.tabla.Where(x =>
                    x.Nombre.Contains(nombre)).ToList();
            }
        }
        private void TxtBuscador_TextChanged(object sender, EventArgs e)
        {
            if (TxtBuscador.Text != String.Empty)
            {
                var list = Buscar(TxtBuscador.Text);
                Dgv.DataSource = list;
            }
            else
            {
                Refrescar();
            }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnEliminar1_Click(object sender, EventArgs e)
        {
            int? EmpresaId = GetId();
            if (EmpresaId != null)
            {
                using (CrudEntities db = new CrudEntities())
                {
                    DialogResult rpta = new DialogResult();
                    rpta = MessageBox.Show("¿Desea Eliminar La Empresa?" , "¡Eliminando Empresa!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (rpta == DialogResult.OK)
                    {
                        tabla table = db.tabla.Find(EmpresaId);
                        db.tabla.Remove(table);

                        db.SaveChanges();
                    }
                    Refrescar();
                }
            }
            else
            {
                DialogResult rpta = new DialogResult();
                rpta = MessageBox.Show("Seleccione Alguna Empresa", "¡Seleccione Empresa!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (rpta == DialogResult.OK)
                {

                }
            }
        }

        private void BtnEditar1_Click(object sender, EventArgs e)
        {
            int? EmpresaId = GetId();
            if (EmpresaId != null)
            {
                FormCompanyEditor formCompanyEditor = new FormCompanyEditor(EmpresaId);
                formCompanyEditor.ShowDialog();
                Refrescar();
            }
            else
            {
                DialogResult rpta = new DialogResult();
                rpta = MessageBox.Show("Seleccione Alguna Empresa", "¡Seleccione Empresa!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (rpta == DialogResult.OK)
                {

                }
            }
        }

        private void Hora_Tick(object sender, EventArgs e)
        {
            LblHora.Text = DateTime.Now.ToString("hh:mm:ss");
        }
    }
}
