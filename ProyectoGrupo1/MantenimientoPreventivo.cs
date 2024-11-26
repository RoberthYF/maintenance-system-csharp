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
    public partial class MantenimientoPreventivo : Form
    {
        public MantenimientoPreventivo()
        {
            InitializeComponent();
        }
        private void LimpiarVariables()
        {
            cbxTipoActivo.SelectedIndex = -1;
            cbxCodigo.SelectedIndex = -1;
            cbxResponsables.SelectedIndex = -1;
            txtDescripcion.Clear();
            txtMantenimientoPreventivoID.Clear();
            chxEstado.Checked = false;

        }
        public void listarMantenimientoPreventivo()
        {
            dtgMantenimientoPreventivo.DataSource = logMantenimientoPreventivo.Instancia.listarMantenimientoPreventivo();
        }
        private void MantenimientoPreventivo_Load(object sender, EventArgs e)
        {
            listarMantenimientoPreventivo();
            gbMantenimientoPreventivo.Enabled = false;
            txtMantenimientoPreventivoID.Enabled = false;
        }

        private void btnAgregarMantenimiento_Click(object sender, EventArgs e)
        {
            try 
            
            {
                entMantenimientoPreventivo MantPre = new entMantenimientoPreventivo();
                MantPre.idEquipo = cbxCodigo.SelectedValue.ToString();
                MantPre.fechaMantenimientoPreventivo = dtpFecha.Value;
                MantPre.idOperario = cbxResponsables.SelectedValue.ToString();
                MantPre.operacionesMantenimientoPreventivo = txtDescripcion.Text.Trim();
                MantPre.estadoMantenimientoPre = chxEstado.Checked;
                logMantenimientoPreventivo.Instancia.RegistrarMantenimientoPreventivo(MantPre);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            gbMantenimientoPreventivo.Enabled = false;
            listarMantenimientoPreventivo();
        }
 
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarVariables();
            gbMantenimientoPreventivo.Enabled = true;
            btnAgregarMantenimiento.Enabled = true;
            btnNuevo.Visible = true;
        }

        private void gbMantenimientoPreventivo_Enter(object sender, EventArgs e)
        {

        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                entMantenimientoPreventivo MantPre = new entMantenimientoPreventivo();
                MantPre.MantenimientoPreventivo_id = Convert.ToInt32(txtMantenimientoPreventivoID.Text.Trim());
                chxEstado.Checked = false;
                MantPre.estadoMantenimientoPre = chxEstado.Checked;
                logMantenimientoPreventivo.Instancia.DeshabilitarMantenimientoPre(MantPre);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            gbMantenimientoPreventivo.Enabled = false;
            listarMantenimientoPreventivo();
        }

        private void txtMantenimientoPreventivoID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDeshabilitarMantenimiento_Click(object sender, EventArgs e)
        {

        }

        private void dtgMantenimientoPreventivo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow filaActual = dtgMantenimientoPreventivo.Rows[e.RowIndex];

                txtMantenimientoPreventivoID.Text = filaActual.Cells["MantenimientoPreventivo_id"].Value.ToString();
                cbxCodigo.SelectedValue = filaActual.Cells["idEquipo"].Value.ToString();
                cbxResponsables.SelectedValue = filaActual.Cells["idOperario"].Value.ToString();
                txtDescripcion.Text = filaActual.Cells["operacionesMantenimientoPreventivo"].Value.ToString();
                dtpFecha.Value = Convert.ToDateTime(filaActual.Cells["fechaMantenimientoPreventivo"].Value);
                chxEstado.Checked = Convert.ToBoolean(filaActual.Cells["estadoMantenimientoPre"].Value);
                gbMantenimientoPreventivo.Enabled = true;
            }
        }
    }
}
