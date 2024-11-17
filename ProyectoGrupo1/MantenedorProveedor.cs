using CapaEntidad;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoGrupo1
{
    public partial class MantenedorProveedor : Form
    {
        public MantenedorProveedor()
        {
            InitializeComponent();
            listarProveedor();
            grupBoxDatos.Enabled = false;
            txtidProveedor.Enabled = false;

        }

        public void listarProveedor()
        {
            dataGridView3.DataSource = logProveedor.Instancia.ListarProveedor();
        }

        private void btn_registr_Click(object sender, EventArgs e)
        {
            LimpiarVariables();
            grupBoxDatos.Enabled = true;
            btnAgregar.Visible = true;
            btnModificar.Visible = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Agregamos insertar
            try
            {
                entProveedor p = new entProveedor();
                p.nombreProveedor = txtNombreProv.Text.Trim();
                p.RUC = txtRuc.Text.Trim();
                p.direccion = txtDireccion.Text.Trim();
                p.rubro = cmboxRubro.Text.Trim();
                p.idCiudad = int.Parse(cmboxCiudad.Text.Trim());
                p.estProveedor = cbkEstadoProveedor.Checked;
                logProveedor.Instancia.InsertarProveedor(p);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            grupBoxDatos.Enabled = false;
            listarProveedor();
        }
        private void btnRegistrarCambios_Click(object sender, EventArgs e)
        {
            grupBoxDatos.Enabled = true;
            btnModificar.Visible = true;
            btnAgregar.Visible = false;
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entProveedor p = new entProveedor();
                p.idProveedor = int.Parse(txtidProveedor.Text.Trim());
                p.nombreProveedor = txtNombreProv.Text.Trim();
                p.RUC = txtRuc.Text.Trim();
                p.direccion = txtDireccion.Text.Trim();
                p.rubro = cmboxRubro.Text.Trim();
                p.idCiudad = int.Parse(cmboxCiudad.Text.Trim());
                p.estProveedor = cbkEstadoProveedor.Checked;
                logProveedor.Instancia.EditarProveedor(p);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            grupBoxDatos.Enabled = false;
            listarProveedor();
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dataGridView3.Rows[e.RowIndex]; //
            txtidProveedor.Text = filaActual.Cells[0].Value.ToString();
            txtNombreProv.Text = filaActual.Cells[1].Value.ToString();
            txtRuc.Text = filaActual.Cells[2].Value.ToString();
            txtDireccion.Text = filaActual.Cells[3].Value.ToString();
            cmboxRubro.Text = filaActual.Cells[4].Value.ToString();
            cmboxCiudad.Text = filaActual.Cells[5].Value.ToString();
            cbkEstadoProveedor.Checked = Convert.ToBoolean(filaActual.Cells[6].Value);

        }

        public void LimpiarVariables()
        {
            txtidProveedor.Text = "";
            txtNombreProv.Text = "";
            txtRuc.Text = "";
            txtDireccion.Text = "";
            cmboxRubro.Text = "";
            cmboxCiudad.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            grupBoxDatos.Enabled = false;
        }

        private void btnInhabilitarProv_Click(object sender, EventArgs e)
        {
            try
            {
                entProveedor p = new entProveedor();
                p.idProveedor = int.Parse(txtidProveedor.Text.Trim());
                cbkEstadoProveedor.Checked = false;
                p.estProveedor = cbkEstadoProveedor.Checked;
                logProveedor.Instancia.DeshabilitarProveedor(p);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            grupBoxDatos.Enabled=false;
            listarProveedor();
        }
    }
}
