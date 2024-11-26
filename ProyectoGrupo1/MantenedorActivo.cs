using CapaEntidad;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoGrupo1
{
    public partial class MantenedorActivo : Form
    {
        private int activoIdSeleccionado = 0;

        public MantenedorActivo()
        {
            InitializeComponent();
            ListarRegistroActivo();
            gbMantenedorActivo.Enabled = false;
        }

        public void ListarRegistroActivo()
        {
            try
            {
                var datos = logActivo.Instancia.ListarRegistroActivo()
                    .Select(ac => new
                    {
                        Id = ac.Id,
                        TipoActivoId = ac.TipoActivo?.Id ?? 0,
                        Nombre = ac.Nombre ?? "",
                        Marca = ac.Marca ?? "",
                        Serie = ac.Serie ?? "",
                        Placa = ac.Placa ?? "",
                        Estado = ac.Estado
                    }).ToList();

                dgvMantenedorActivo.DataSource = null;
                dgvMantenedorActivo.DataSource = datos;

                // Configurar nombres de columnas si es necesario
                if (dgvMantenedorActivo.Columns["TipoActivoId"] != null)
                    dgvMantenedorActivo.Columns["TipoActivoId"].HeaderText = "Tipo Activo";

                dgvMantenedorActivo.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al listar los activos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MantenedorActivo_Load(object sender, EventArgs e)
        {
            this.dgvMantenedorActivo.CellClick += new DataGridViewCellEventHandler(this.dgvMantenedorActivo_CellClick);
            ListarRegistroActivo();
            ListarTipoActivo();
        }
        public void ListarTipoActivo()
        {
            cbxTipoActivo.DataSource = logTipoActivo.Instancia.ListarTipoActivo();
            cbxTipoActivo.DisplayMember = "Nombre";
            cbxTipoActivo.ValueMember = "Id";
        }
        

        private void cbxTipoActivo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipoSeleccionado = cbxTipoActivo.Text;

            if (tipoSeleccionado == "Equipo")
            {
                lblCodigo.Text = "Serie";
            }
            else if (tipoSeleccionado == "Unidad de Trasnporte")
            {
                lblCodigo.Text = "Placa";
            }
            else
            {
                lblCodigo.Text = "Codigo";

            }
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            gbMantenedorActivo.Enabled = true;
            btnAgregar.Visible = true;
            btnModificar.Visible = false;
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validación de campos
                if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                    string.IsNullOrWhiteSpace(txtMarca.Text) ||
                    string.IsNullOrWhiteSpace(txtCodigo.Text) ||
                    cbxTipoActivo.SelectedValue == null)
                {
                    MessageBox.Show("Por favor, complete todos los campos antes de agregar el activo.");
                    return; // Salir del método si hay campos vacíos
                }

                entActivo nuevoActivo = new entActivo
                {
                    TipoActivo = new entTipoActivo
                    {
                        Id = Convert.ToInt32(cbxTipoActivo.SelectedValue)
                    },
                    Nombre = txtNombre.Text,
                    Marca = txtMarca.Text,
                    Estado = true
                };

                if (lblCodigo.Text == "Serie")
                {
                    nuevoActivo.Serie = txtCodigo.Text;
                    nuevoActivo.Placa = null;
                }
                else if (lblCodigo.Text == "Placa")
                {
                    nuevoActivo.Placa = txtCodigo.Text;
                    nuevoActivo.Serie = null;
                }

                bool resultado = logActivo.Instancia.InsertarActivo(nuevoActivo);

                if (resultado)
                {
                    MessageBox.Show("Activo registrado exitosamente.");
                    ListarRegistroActivo();
                }
                else
                {
                    MessageBox.Show("Error al registrar el activo.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            LimpiarVariables();
        }
        private void LimpiarVariables()
        {
            txtNombre.Text = "";
            txtMarca.Text = "";
            txtCodigo.Text = "";
            cbxTipoActivo.SelectedIndex = 0;
            activoIdSeleccionado = 0;
            btnModificar.Enabled = false;
        }

        private void dgvMantenedorActivo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.RowIndex < dgvMantenedorActivo.Rows.Count)
                {
                    DataGridViewRow row = dgvMantenedorActivo.Rows[e.RowIndex];

                    // Verifica que los valores no sean nulos antes de usarlos
                    if (row.Cells["Id"].Value != null)
                    {
                        activoIdSeleccionado = Convert.ToInt32(row.Cells["Id"].Value);
                    }

                    if (row.Cells["TipoActivoId"].Value != null)
                    {
                        cbxTipoActivo.SelectedValue = Convert.ToInt32(row.Cells["TipoActivoId"].Value);
                    }

                    // Maneja los campos de texto con verificación de nulos
                    txtNombre.Text = row.Cells["Nombre"].Value?.ToString() ?? "";
                    txtMarca.Text = row.Cells["Marca"].Value?.ToString() ?? "";

                    // Maneja Serie y Placa
                    string serie = row.Cells["Serie"].Value?.ToString() ?? "";
                    string placa = row.Cells["Placa"].Value?.ToString() ?? "";

                    // Determina el tipo de código basado en el tipo de activo seleccionado
                    string tipoSeleccionado = cbxTipoActivo.Text;
                    if (tipoSeleccionado == "Equipo")
                    {
                        lblCodigo.Text = "Serie";
                        txtCodigo.Text = serie;
                    }
                    else if (tipoSeleccionado == "Unidad de Trasnporte")
                    {
                        lblCodigo.Text = "Placa";
                        txtCodigo.Text = placa;
                    }
                    else
                    {
                        lblCodigo.Text = "Codigo";
                        txtCodigo.Text = "";
                    }

                    // Para debugging, agrega esta línea
                    Console.WriteLine($"Fila seleccionada: ID={activoIdSeleccionado}, TipoActivo={cbxTipoActivo.SelectedValue}, Nombre={txtNombre.Text}");

                    btnModificar.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al seleccionar el registro: {ex.Message}\n\nDetalles: {ex.StackTrace}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (activoIdSeleccionado == 0)
                {
                    MessageBox.Show("Por favor, seleccione un activo para modificar.");
                    return;
                }

                // Validación de campos
                if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                    string.IsNullOrWhiteSpace(txtMarca.Text) ||
                    string.IsNullOrWhiteSpace(txtCodigo.Text) ||
                    cbxTipoActivo.SelectedValue == null)
                {
                    MessageBox.Show("Por favor, complete todos los campos antes de modificar el activo.");
                    return; // Salir del método si hay campos vacíos
                }

                entActivo activo = new entActivo
                {
                    Id = activoIdSeleccionado,
                    TipoActivo = new entTipoActivo
                    {
                        Id = Convert.ToInt32(cbxTipoActivo.SelectedValue)
                    },
                    Nombre = txtNombre.Text,
                    Marca = txtMarca.Text,
                    Estado = true
                };

                if (lblCodigo.Text == "Serie")
                {
                    activo.Serie = txtCodigo.Text;
                    activo.Placa = null;
                }
                else if (lblCodigo.Text == "Placa")
                {
                    activo.Placa = txtCodigo.Text;
                    activo.Serie = null;
                }

                bool resultado = logActivo.Instancia.ActualizarActivo(activo);

                if (resultado)
                {
                    MessageBox.Show("Activo modificado exitosamente.");
                    LimpiarVariables();
                    ListarRegistroActivo();
                }
                else
                {
                    MessageBox.Show("Error al modificar el activo.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            gbMantenedorActivo.Enabled = false;
            LimpiarVariables();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            gbMantenedorActivo.Enabled = true;
            btnModificar.Visible = true;
            btnAgregar.Visible = false;
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                entActivo ac = new entActivo();
                ac.Id =activoIdSeleccionado;

                ac.Estado = false;
                logActivo.Instancia.DeshabilitarActivo(ac);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            gbMantenedorActivo.Enabled = false;
            ListarRegistroActivo();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
