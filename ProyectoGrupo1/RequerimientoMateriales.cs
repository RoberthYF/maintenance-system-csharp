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
    public partial class RequerimientoMateriales : Form
    {
        public RequerimientoMateriales()
        {
            InitializeComponent();
            gbDatos.Enabled = false;
            CargarOperarioCBX();
            CargarMaterial();
            ListarRequerimientoMateriales();
            LimpiarVariables();
        }
        public void LimpiarVariables()
        { 
            cbxOperario.SelectedIndex = -1 ;  
            cbxMaterial.SelectedIndex = 0;
            txtCantidad.Value = 0;

        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            gbDatos.Enabled = true;
            btnDeshabilitar.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            gbDatos.Enabled =false;
            LimpiarVariables();
        }
        public void ListarRequerimientoMateriales()
        {
            List<entRequerimientoMateriales> listaRequerimientoMateriales = logRequerimientoMateriales.Instancia.ListarRequerimientoMateriales();
            var listaRequerimiento = listaRequerimientoMateriales.Select(x => new
            {
                Id = x.Id,
                FechaRequerimiento = x.FechaRequerimiento,
                NombreOperario = x.Operario.Nombre,
                NombreMaterial = x.Material.Nombre,
                Cantidad = x.Cantidad,
                FechaIngreso = x.FechaIngreso,
                Estado = x.IdEstado == 1 ? "Pendiente" : x.IdEstado == 2 ? "Aceptado" : "Rechazado"

            }).ToList();
            dgvPedidoMateriales.DataSource = listaRequerimiento;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validación de campos
                if (cbxOperario.SelectedValue == null ||
                    cbxMaterial.SelectedValue == null ||
                    string.IsNullOrWhiteSpace(txtCantidad.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos antes de registrar el requerimiento.");
                    return; // Salir del método si hay campos vacíos
                }

                // Validación de cantidad
                int cantidad;
                if (!int.TryParse(txtCantidad.Text, out cantidad) || cantidad <= 0)
                {
                    MessageBox.Show("La cantidad debe ser un número mayor que 0.");
                    return; // Salir del método si la cantidad no es válida
                }

                entRequerimientoMateriales rm = new entRequerimientoMateriales
                {
                    Operario = new entOperario
                    {
                        Id = Convert.ToInt32(cbxOperario.SelectedValue)
                    },
                    Material = new entMaterial
                    {
                        Id = Convert.ToInt32(cbxMaterial.SelectedValue)
                    },
                    Cantidad = cantidad
                };

                logRequerimientoMateriales.Instancia.InsertarRequerimientoMateriales(rm);

                MessageBox.Show("Requerimiento registrado exitosamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            LimpiarVariables();
            gbDatos.Enabled = false;
            ListarRequerimientoMateriales();
        }

        private void RequerimientoMateriales_Load(object sender, EventArgs e)
        {

        }

        private void CargarOperarioCBX()
        {
            cbxOperario.DisplayMember = "NombreCompleto";
            cbxOperario.ValueMember = "Id";
            cbxOperario.DataSource = logOperario.Instancia.ListarOperario();
        }

        private void CargarMaterial()
        {
            cbxMaterial.Items.Clear();
            cbxMaterial.DisplayMember = "Nombre";
            cbxMaterial.ValueMember = "Id";
            cbxMaterial.DataSource = logMaterial.Instancia.ListarMaterial();

        }

        private void cbxMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            entMaterial material = logMaterial.Instancia.ListarMaterial().FirstOrDefault(X => X.Id == Convert.ToInt32(cbxMaterial.SelectedValue.ToString()));
            lblMarca.Text = material.Marca;
            lblMedida.Text = material.Medidas;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
