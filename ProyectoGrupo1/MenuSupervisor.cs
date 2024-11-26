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
    public partial class MenuSupervisor : Form
    {
        public MenuSupervisor()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MantenedorActivo mantenedorActivo = new MantenedorActivo();
            mantenedorActivo.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MantenedorOperario mant = new MantenedorOperario();
            mant.Show();
        }
    }
}
