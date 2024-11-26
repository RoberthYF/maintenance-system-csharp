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
    public partial class MenuOperario : Form
    {
        public MenuOperario()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RequerimientoMateriales reqmateriales = new RequerimientoMateriales();
            reqmateriales.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConsultaMantenimiento consulta = new ConsultaMantenimiento();
            consulta.Show();
        }
    }
}
