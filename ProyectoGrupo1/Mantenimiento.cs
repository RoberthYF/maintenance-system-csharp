using CapaEntidad;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoGrupo1
{
    public partial class Mantenimiento : Form
    {
        public Mantenimiento()
        {
            InitializeComponent();
            cbxTipoMantenimiento.Items.Clear();
            cbxTipoMantenimiento.DataSource = logTipoMantenimiento.Instancia.ListarTipoMantenimiento();
            cbxTipoMantenimiento.DisplayMember = "Nombre";
            cbxTipoMantenimiento.ValueMember = "Id";
            CargarOperarioCBX();
            ListarTipoActivo();
            CargarMantenimientosOperario();
            Limpiar();
            gbMantenimiento.Enabled = false;
        }

        private void Limpiar()
        {
            cbxTipoMantenimiento.SelectedIndex = -1;
            cbxTipoActivo.SelectedIndex = -1;
            cbxCodigo.SelectedIndex = -1;
            cbxOperario.SelectedIndex = -1;
            txtDescripcion.Clear();

        }
        private void CargarOperarioCBX()
        {
            cbxOperario.DisplayMember = "NombreCompleto";
            cbxOperario.ValueMember = "Id";
            cbxOperario.DataSource = logOperario.Instancia.ListarOperario();
        }
        private void ListarActivosPorTipo(int idTipoActivo)
        {
            var activos = logActivo.Instancia.ListarRegistroActivo();

            var activosFiltrados = activos.Where(a => a.TipoActivo.Id == idTipoActivo).ToList();

            if (idTipoActivo == 1) 
            {
                cbxCodigo.DataSource = activosFiltrados;
                cbxCodigo.DisplayMember = "Serie"; 
                cbxCodigo.ValueMember = "Id";
            }
            else if (idTipoActivo == 2) 
            {
                cbxCodigo.DataSource = activosFiltrados;
                cbxCodigo.DisplayMember = "Placa";
                cbxCodigo.ValueMember = "Id";
            }
        }
        private void btnAgregarMantenimiento_Click(object sender, EventArgs e)
        {
            try
            {
                entMantenimiento mantenimiento = new entMantenimiento();
                mantenimiento.TipoMantenimiento = new entTipoMantenimiento();
                mantenimiento.Activo = new entActivo();
                mantenimiento.Operario = new entOperario();

                // Validación de campos
                if (cbxTipoMantenimiento.SelectedValue == null ||
                    cbxCodigo.SelectedValue == null ||
                    cbxOperario.SelectedValue == null ||
                    string.IsNullOrWhiteSpace(txtDescripcion.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos antes de agregar el mantenimiento.");
                    return; // Salir del método si hay campos vacíos
                }

                mantenimiento.TipoMantenimiento.Id = (int)cbxTipoMantenimiento.SelectedValue;
                mantenimiento.Activo.Id = (int)cbxCodigo.SelectedValue;
                mantenimiento.Operario.Id = (int)cbxOperario.SelectedValue;
                mantenimiento.Descripcion = txtDescripcion.Text.Trim();

                string mensajeError = logMantenimiento.Instancia.ValidarRegistroMantenimiento(mantenimiento);
                if (string.IsNullOrEmpty(mensajeError))
                {
                    bool exitoso = logMantenimiento.Instancia.RegistrarMantenimiento(mantenimiento);
                    if (exitoso)
                    {
                        MessageBox.Show("El mantenimiento se registró con éxito");
                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un error al registrar el mantenimiento");
                    }
                }
                else
                {
                    MessageBox.Show(mensajeError);
                }

                CargarMantenimientosOperario();
                Limpiar();
                gbMantenimiento.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void CargarMantenimientosOperario()
        {
            try
            {
                if (cbxOperario.SelectedValue != null)
                {
                    List<entMantenimiento> listaMantenimiento = logMantenimiento.Instancia.ListarMantenimiento();

                    // Configurar el DataGridView
                    if (listaMantenimiento?.Count > 0)
                    {
                        var listaParaGrid = listaMantenimiento.Select(x => new
                        {
                            ID = x.Id,
                            Activo = x.Activo.Nombre,
                            Fecha = x.FechaMantenimiento,
                            Operario = x.Operario.NombreCompleto,
                            Descripcion = x.Descripcion,
                            TipoMantenimiento = x.TipoMantenimiento.Nombre,
                            Estado = x.Estado ? "Activo" : "Inactivo"
                        }).ToList();

                        dataGridViewMantenimientos.DataSource = listaParaGrid;
                    }
                    else
                    {
                        dataGridViewMantenimientos.DataSource = null;
                        MessageBox.Show("No se encontraron mantenimientos para el operario seleccionado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los mantenimientos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbxTipoMantenimiento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxTipoActivo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxTipoActivo.SelectedItem != null)
            {
                string tipoSeleccionado = cbxTipoActivo.Text;

                int idTipoActivo = 0;
                if (cbxTipoActivo.SelectedItem is entTipoActivo tipoActivo)
                {
                    idTipoActivo = tipoActivo.Id;
                }
                if (tipoSeleccionado == "Equipo")
                {
                    lblCodigo.Text = "Serie";
                }
                else if (tipoSeleccionado == "Unidad de Transporte")
                {
                    lblCodigo.Text = "Placa";
                }
                else
                {
                    lblCodigo.Text = "Codigo";
                }
                if (idTipoActivo > 0)
                {
                    ListarActivosPorTipo(idTipoActivo);
                }
            }
        }
        public void ListarTipoActivo()
        {
            cbxTipoActivo.DataSource = logTipoActivo.Instancia.ListarTipoActivo();
            cbxTipoActivo.DisplayMember = "Nombre";
            cbxTipoActivo.ValueMember = "Id";
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            gbMantenimiento.Enabled = true;
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
