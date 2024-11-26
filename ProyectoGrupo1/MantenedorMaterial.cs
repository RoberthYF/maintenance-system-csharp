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
    public partial class MantenedorMaterial : Form
    {
        private int Id = 0;
        public MantenedorMaterial()
        {
            InitializeComponent();
            gbDatosMaterial.Enabled = false;
            listarMateriales();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarVariables();
            gbDatosMaterial.Enabled = true;
            btnAgregar.Visible = true;
            btnModificar.Visible = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            gbDatosMaterial.Enabled = true;
            btnModificar.Visible = true;
            btnAgregar.Visible = false;
        }

        private void LimpiarVariables()
        {
            Nombre.Text = "";
            Stock.Text = "";
            Medidas.Text = "";
            Marca.Text = "";
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                entMaterial ma = new entMaterial();
                ma.Id = Id;

                ma.Estado = false;
                logMaterial.Instancia.DeshabilitarMaterial(ma);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            gbDatosMaterial.Enabled = false;
            listarMateriales();
        }
        private void listarMateriales()
        {
           dgvMantenedorMaterial.DataSource = logMaterial.Instancia.ListarMaterial();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validación de campos
                if (string.IsNullOrWhiteSpace(Nombre.Text) ||
                    string.IsNullOrWhiteSpace(Stock.Text) ||
                    string.IsNullOrWhiteSpace(Medidas.Text) ||
                    string.IsNullOrWhiteSpace(Marca.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos antes de agregar el material.");
                    return; // Salir del método si hay campos vacíos
                }

                // Validación de Stock (asegurarse de que sea un número y mayor que 0)
                int stock;
                if (!int.TryParse(Stock.Text.Trim(), out stock) || stock <= 0)
                {
                    MessageBox.Show("El stock debe ser un número válido mayor que 0.");
                    return; // Salir del método si el stock no es válido o es 0 o negativo
                }

                entMaterial ma = new entMaterial
                {
                    Nombre = Nombre.Text.Trim(),
                    Stock = stock,
                    Medidas = Medidas.Text.Trim(),
                    Marca = Marca.Text.Trim()
                };

                logMaterial.Instancia.RegistrarMaterial(ma);

                MessageBox.Show("Material registrado exitosamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            LimpiarVariables();
            gbDatosMaterial.Enabled = false;
            listarMateriales();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Id == 0)
                {
                    MessageBox.Show("Por favor, seleccione un material para modificar.");
                    return;
                }

                // Validación de campos
                if (string.IsNullOrWhiteSpace(Nombre.Text) ||
                    string.IsNullOrWhiteSpace(Stock.Text) ||
                    string.IsNullOrWhiteSpace(Medidas.Text) ||
                    string.IsNullOrWhiteSpace(Marca.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos antes de modificar el material.");
                    return; // Salir del método si hay campos vacíos
                }

                // Validación de Stock (asegurarse de que sea un número)
                int stock;
                if (!int.TryParse(Stock.Text.Trim(), out stock))
                {
                    MessageBox.Show("El stock debe ser un número válido.");
                    return; // Salir del método si el stock no es válido
                }

                entMaterial ma = new entMaterial
                {
                    Id = Id,
                    Nombre = Nombre.Text.Trim(),
                    Stock = stock,
                    Medidas = Medidas.Text.Trim(),
                    Marca = Marca.Text.Trim(),
                    Estado = true
                };

                bool resultado = logMaterial.Instancia.EditarMaterial(ma);

                if (resultado)
                {
                    MessageBox.Show("Material modificado exitosamente.");
                    LimpiarVariables();
                    gbDatosMaterial.Enabled = false;
                    listarMateriales();
                }
                else
                {
                    MessageBox.Show("Error al modificar el material.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvMantenedorMaterial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgvMantenedorMaterial_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgvMantenedorMaterial.Rows[e.RowIndex];
                    Id = Convert.ToInt32(row.Cells["Id"].Value);
                    Nombre.Text = row.Cells["Nombre"].Value.ToString();
                    Stock.Text = row.Cells["Stock"].Value.ToString();
                    Medidas.Text = row.Cells["Medidas"].Value.ToString();
                    Marca.Text = row.Cells["Marca"].Value.ToString();

                    gbDatosMaterial.Enabled = false;
                    btnModificar.Visible = true;
                    btnAgregar.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al seleccionar el registro: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            gbDatosMaterial.Enabled = false;
            LimpiarVariables();
        }
    }

}

