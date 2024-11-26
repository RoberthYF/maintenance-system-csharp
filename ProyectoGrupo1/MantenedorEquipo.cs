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
    public partial class MantenedorEquipo : Form
    {
        public MantenedorEquipo()
        {
            InitializeComponent();
            listarEQ();
            gbDatosEquipo.Enabled = false;
            txtidEQ.Enabled = false;
        }
        public void listarEQ()
        {
            dgvMantenedorEquipo.DataSource = logEquipo.Instancia.ListarEQ();
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarVariables();
            gbDatosEquipo.Enabled = true;
            btnAgregar.Visible = true;
            btnModificar.Visible = false;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                entEquipo eq1 = new entEquipo();
                eq1.nombreEquipo = txtNombreEQ.Text.Trim();
                eq1.serieEquipo = txtserieEQ.Text.Trim();
                eq1.idEquipo = eq1.nombreEquipo + eq1.serieEquipo;
                eq1.marca = txtserieEQ.Text.Trim();
                eq1.estEQ = cbkEstadoEQ.Checked;
                logEquipo.Instancia.InsertarEQ(eq1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            gbDatosEquipo.Enabled = false;
            listarEQ();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            gbDatosEquipo.Enabled = true;
            btnModificar.Visible = true;
            btnAgregar.Visible = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entEquipo eq1 = new entEquipo();
                eq1.idEquipo = txtidEQ.Text.Trim();
                eq1.nombreEquipo = txtNombreEQ.Text.Trim();
                eq1.serieEquipo = txtserieEQ.Text.Trim();
                eq1.marca = txtMarcaEQ.Text.Trim();
                eq1.estEQ = cbkEstadoEQ.Checked;
                logEquipo.Instancia.EditarEQ(eq1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            gbDatosEquipo.Enabled = false;
            listarEQ();
        }
        private void LimpiarVariables()
        {
            txtidEQ.Text = "";
            txtNombreEQ.Text = "";
            txtserieEQ.Text = "";
            txtMarcaEQ.Text = "";

        }
        private void dgvMantenedorEquipo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvMantenedorEquipo.Rows[e.RowIndex]; //
            txtidEQ.Text = filaActual.Cells[0].Value.ToString();
            txtNombreEQ.Text = filaActual.Cells[1].Value.ToString();
            txtserieEQ.Text = filaActual.Cells[2].Value.ToString();
            txtMarcaEQ.Text = filaActual.Cells[3].Value.ToString();
            cbkEstadoEQ.Checked = Convert.ToBoolean(filaActual.Cells[4].Value);
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            gbDatosEquipo.Enabled = false;

        }
        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                entEquipo eq1 = new entEquipo();
                eq1.idEquipo = txtidEQ.Text.Trim();
                cbkEstadoEQ.Checked = false;
                eq1.estEQ = cbkEstadoEQ.Checked;
                logEquipo.Instancia.DeshabilitarEQ(eq1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            gbDatosEquipo.Enabled = false;
            listarEQ();
        }

        
    }
}
