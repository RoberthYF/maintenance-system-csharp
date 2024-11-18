using CapaEntidad;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoGrupo1
{
    public partial class MantenedorUnidadTransporte : Form
    {
        public MantenedorUnidadTransporte()
        {
            InitializeComponent();
            listarUT();
            gbDatosUndTransporte.Enabled = false;
            txtidUT.Enabled = false;

        }

        public void listarUT()
        {
            dgvMantenedorUndTransp.DataSource = logUnidadTransporte.Instancia.ListarUT();
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarVariables();
            gbDatosUndTransporte.Enabled = true;
            btnAgregar.Visible = true;
            btnModificar.Visible = false;
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                entUnidadTransporte ut1 = new entUnidadTransporte();
                ut1.nombreUnidTransporte = txtNombreUT.Text.Trim();
                ut1.placaUnidTransporte = txtPlacaUT.Text.Trim();
                ut1.idUnidadTransporte = ut1.nombreUnidTransporte + ut1.placaUnidTransporte;
                ut1.marca = txtMarcaUT.Text.Trim();
                ut1.estUT = cbkEstadoUT.Checked;
                logUnidadTransporte.Instancia.InsertarUT(ut1);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            gbDatosUndTransporte.Enabled = false;
            listarUT();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            gbDatosUndTransporte.Enabled = true;
            btnModificar.Visible = true;
            btnAgregar.Visible = false;
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entUnidadTransporte ut1 = new entUnidadTransporte();
                ut1.idUnidadTransporte = txtidUT.Text.Trim();
                ut1.nombreUnidTransporte = txtNombreUT.Text.Trim();
                ut1.placaUnidTransporte = txtPlacaUT.Text.Trim();
                ut1.marca = txtMarcaUT.Text.Trim();
                ut1.estUT = cbkEstadoUT.Checked;
                logUnidadTransporte.Instancia.EditarUT(ut1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            gbDatosUndTransporte.Enabled = false;
            listarUT();
        }
        private void LimpiarVariables()
        {
            txtidUT.Text = "";
            txtNombreUT.Text = "";
            txtPlacaUT.Text = "";
            txtMarcaUT.Text = "";

        }
        private void dgvMantenedorUndTransp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvMantenedorUndTransp.Rows[e.RowIndex]; //
            txtidUT.Text = filaActual.Cells[0].Value.ToString();
            txtNombreUT.Text = filaActual.Cells[1].Value.ToString();
            txtPlacaUT.Text = filaActual.Cells[2].Value.ToString();
            txtMarcaUT.Text = filaActual.Cells[3].Value.ToString();
            cbkEstadoUT.Checked = Convert.ToBoolean(filaActual.Cells[4].Value);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            gbDatosUndTransporte.Enabled = false;
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                entUnidadTransporte ut1 = new entUnidadTransporte();
                ut1.idUnidadTransporte = txtidUT.Text.Trim();
                cbkEstadoUT.Checked = false;
                ut1.estUT = cbkEstadoUT.Checked;
                logUnidadTransporte.Instancia.DeshabilitarUT(ut1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            gbDatosUndTransporte.Enabled = false;
            listarUT();
        }
    }
}
