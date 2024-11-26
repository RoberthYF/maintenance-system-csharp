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
    public partial class MenuPROMAS : Form
    {
        public MenuPROMAS()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuLogistica logistica = new MenuLogistica();
            logistica.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenuOperario operario = new MenuOperario();
            operario.Show();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            MenuSupervisor supervisor = new MenuSupervisor();  
            supervisor.Show();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
