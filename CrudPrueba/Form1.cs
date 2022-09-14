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
            Dgv.Columns[1].Visible = false;
        }

        private int? GetId()
        {
            try
            {
                return int.Parse(Dgv.Rows[Dgv.CurrentRow.Index].Cells[1].Value.ToString());
            }
            catch
            {
                return null;
            }
        }
        private void Borrar(int empresaId)
        {
            try
            {
                using (CrudEntities db = new CrudEntities())
                {
                    db.tabla.Remove(db.tabla.Single(x => x.EmpresaId == empresaId));
                    db.SaveChanges();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        private void BtnCrear1_Click(object sender, EventArgs e)
        {
            FormCompanyEditor formCompanyEditor = new FormCompanyEditor();
            formCompanyEditor.ShowDialog();

            Refrescar();
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
            
            int Seleccionados = Dgv.Rows.Cast<DataGridViewRow>()
                .Where(x => Convert.ToBoolean(x.Cells["Column1"].Value)).Count();
            int EmpresaId;
            DialogResult rpta = new DialogResult();
            if (Seleccionados == 0)
            {
                rpta = MessageBox.Show("Debe Seleccionar Almenos Una Empresa", "Seleccione Empresa", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else if (Seleccionados == 1)
            {
                rpta = MessageBox.Show("¿Desea Eliminar la Empresa Seleccionada?", "¡Eliminando Empresa!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (rpta == DialogResult.OK)
                {
                    foreach (DataGridViewRow row in Dgv.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells["Column1"].Value))
                        {
                            EmpresaId = Convert.ToInt32(row.Cells["EmpresaId"].Value);
                            Borrar(EmpresaId);
                        }
                    }
                }
            }
            else if (Seleccionados >= 2)
            {
                rpta = MessageBox.Show("¿Desea Eliminar " + Seleccionados + " Empresas Seleccionadas?", "¡Eliminando Empresa!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (rpta == DialogResult.OK)
                {
                    foreach (DataGridViewRow row in Dgv.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells["Column1"].Value))
                        {
                            EmpresaId = Convert.ToInt32(row.Cells["EmpresaId"].Value);
                            Borrar(EmpresaId);
                        }
                    }
                }
            }
            Refrescar();
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

        private void Dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
