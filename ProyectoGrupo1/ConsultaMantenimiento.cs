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
    public partial class ConsultaMantenimiento : Form
    {
        public ConsultaMantenimiento()
        {
            InitializeComponent();
            CargarOperarioCBX();
        }

        private void CargarOperarioCBX()
        {
            cbxOperario.DisplayMember = "NombreCompleto";
            cbxOperario.ValueMember = "Id";
            cbxOperario.DataSource = logOperario.Instancia.ListarOperario();
        }
        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            List<entMantenimiento> listaMantenimiento = logMantenimiento.Instancia.ListarMantenimiento().Where(x=>x.Operario.Id == Convert.ToInt32(cbxOperario.SelectedValue)).ToList();
            if (listaMantenimiento?.Count > 0)
            {
                var listaRequerimiento = listaMantenimiento.Select(x => new
                {
                    Id = x.Id,
                    Activo = x.Activo.Nombre,
                    FechaMantenimiento = x.FechaMantenimiento,
                    NombreOperario = x.Operario.Nombre,
                    Descripcion = x.Descripcion,
                    TipoMantenimiento = x.TipoMantenimiento.Nombre

                }).ToList();
                dgvOperario.DataSource = listaRequerimiento;
            }else
            {
                MessageBox.Show("El operario no tiene registros");
                dgvOperario.DataSource = new List<entMantenimiento>();
            }
        }

        private void ConsultaMantenimiento_Load(object sender, EventArgs e)
        {

        }
    }
}
