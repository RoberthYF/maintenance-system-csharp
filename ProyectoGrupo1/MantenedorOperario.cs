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
    public partial class MantenedorOperario : Form
    {
        public MantenedorOperario()
        {
            InitializeComponent();
            ListarOperario();
            gbDatosOperario.Enabled = false;
            Id.Enabled = false;
        }
        public void ListarOperario()
        {
            dgvMantenedorOperario.DataSource = logOperario.Instancia.ListarOperario();
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarVariables();
            gbDatosOperario.Enabled = true;
            btnAgregar.Visible = true;
            btnModificar.Visible = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                // Trim para eliminar espacios en blanco
                string nombre = Nombre.Text.Trim();
                string apellido = Apellido.Text.Trim();
                string dni = Dni.Text.Trim();
                string genero = Genero.Text.Trim();
                string edadText = Edad.Text.Trim();

                // Validación de campos
                if (string.IsNullOrWhiteSpace(nombre) ||
                    string.IsNullOrWhiteSpace(apellido) ||
                    string.IsNullOrWhiteSpace(dni) ||
                    string.IsNullOrWhiteSpace(edadText) ||
                    string.IsNullOrWhiteSpace(genero))
                {
                    MessageBox.Show("Por favor, complete todos los campos antes de agregar el operario.");
                    return; // Salir del método si hay campos vacíos
                }

                // Validación de Nombre (solo caracteres y espacios)
                if (!nombre.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
                {
                    MessageBox.Show("El nombre solo debe contener caracteres alfabéticos y espacios.");
                    return; // Salir del método si el nombre contiene números o caracteres no válidos
                }

                // Validación de Apellido (solo caracteres y espacios)
                if (!apellido.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
                {
                    MessageBox.Show("El apellido solo debe contener caracteres alfabéticos y espacios.");
                    return; // Salir del método si el apellido contiene números o caracteres no válidos
                }

                // Validación de DNI (debe tener exactamente 8 caracteres)
                if (dni.Length != 8)
                {
                    MessageBox.Show("El DNI debe tener exactamente 8 caracteres.");
                    return; // Salir del método si el DNI no tiene 8 caracteres
                }

                // Validación de Edad (asegurarse de que sea un número)
                int edad;
                if (!int.TryParse(edadText, out edad))
                {
                    MessageBox.Show("La edad debe ser un número válido.");
                    return; // Salir del método si la edad no es válida
                }

                // Validación de Género (solo H o M)
                if (genero != "H" && genero != "M")
                {
                    MessageBox.Show("El género debe ser 'H' (Hombre) o 'M' (Mujer).");
                    return; // Salir del método si el género no es válido
                }

                entOperario op1 = new entOperario
                {
                    Nombre = nombre,
                    Apellido = apellido,
                    Dni = dni,
                    Edad = edad,
                    Genero = genero,
                    Estado = true
                };

                logOperario.Instancia.InsertarOperario(op1);

                MessageBox.Show("Operario agregado exitosamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            LimpiarVariables();
            gbDatosOperario.Enabled = false;
            ListarOperario();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            gbDatosOperario.Enabled = true;
            btnModificar.Visible = true;
            btnAgregar.Visible = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validación de campos
                if (string.IsNullOrWhiteSpace(Id.Text) ||
                    string.IsNullOrWhiteSpace(Nombre.Text) ||
                    string.IsNullOrWhiteSpace(Apellido.Text) ||
                    string.IsNullOrWhiteSpace(Dni.Text) ||
                    string.IsNullOrWhiteSpace(Edad.Text) ||
                    string.IsNullOrWhiteSpace(Genero.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos antes de modificar el operario.");
                    return; // Salir del método si hay campos vacíos
                }

                // Validación de Id (asegurarse de que sea un número)
                int id;
                if (!int.TryParse(Id.Text.Trim(), out id))
                {
                    MessageBox.Show("El ID debe ser un número válido.");
                    return; // Salir del método si el ID no es válido
                }

                // Validación de Nombre (solo caracteres y espacios)
                string nombre = Nombre.Text.Trim();
                if (!nombre.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
                {
                    MessageBox.Show("El nombre solo debe contener caracteres alfabéticos y espacios.");
                    return; // Salir del método si el nombre contiene números o caracteres no válidos
                }

                // Validación de Apellido (solo caracteres y espacios)
                string apellido = Apellido.Text.Trim();
                if (!apellido.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
                {
                    MessageBox.Show("El apellido solo debe contener caracteres alfabéticos y espacios.");
                    return; // Salir del método si el apellido contiene números o caracteres no válidos
                }

                // Validación de DNI (debe tener exactamente 8 caracteres y ser solo números)
                string dni = Dni.Text.Trim();
                if (dni.Length != 8 || !dni.All(char.IsDigit))
                {
                    MessageBox.Show("El DNI debe tener exactamente 8 números.");
                    return; // Salir del método si el DNI no tiene 8 caracteres numéricos
                }

                // Validación de Edad (asegurarse de que sea un número)
                int edad;
                if (!int.TryParse(Edad.Text.Trim(), out edad))
                {
                    MessageBox.Show("La edad debe ser un número válido.");
                    return; // Salir del método si la edad no es válida
                }

                // Validación de Género (solo H o M)
                string genero = Genero.Text.Trim();
                if (genero != "H" && genero != "M")
                {
                    MessageBox.Show("El género debe ser 'H' (Hombre) o 'M' (Mujer).");
                    return; // Salir del método si el género no es válido
                }

                entOperario op1 = new entOperario
                {
                    Id = id,
                    Nombre = nombre,
                    Apellido = apellido,
                    Dni = dni,
                    Edad = edad,
                    Genero = genero,
                    Estado = true
                };

                logOperario.Instancia.EditarOperario(op1);

                MessageBox.Show("Operario modificado exitosamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            LimpiarVariables();
            gbDatosOperario.Enabled = false;
            ListarOperario();
        }
        private void LimpiarVariables()
        {
            Id.Text = "";
            Nombre.Text = "";
            Apellido.Text = "";
            Dni.Text = "";
            Edad.Text = "";
            Genero.Text = "";
        }
        private void dgvMantenedorOperario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow filaActual = dgvMantenedorOperario.Rows[e.RowIndex]; //
                Id.Text = filaActual.Cells[0].Value.ToString();
                Nombre.Text = filaActual.Cells[1].Value.ToString();
                Apellido.Text = filaActual.Cells[2].Value.ToString();
                Dni.Text = filaActual.Cells[4].Value.ToString();
                Edad.Text = filaActual.Cells[5].Value.ToString();
                Genero.Text = filaActual.Cells[6].Value.ToString();
                // Manejo seguro de Estado
                bool estadoBool;
                if (filaActual.Cells[7].Value != null)
                {
                    
                    if (bool.TryParse(filaActual.Cells[7].Value.ToString(), out estadoBool))
                    {
                        estadoBool = true;
                    }
                    else
                    {
                        string estadoValor = filaActual.Cells[7].Value.ToString().ToLower();
                        estadoBool = (estadoValor == "true" || estadoValor == "1" || estadoValor == "activo");
                    }
                }
                else
                {
                    estadoBool = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar la fila: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            gbDatosOperario.Enabled = false;
            LimpiarVariables();

        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                entOperario op1 = new entOperario();
                op1.Id = Convert.ToInt32(Id.Text);
                
                op1.Estado = false;
                logOperario.Instancia.DeshabilitarOperario(op1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            gbDatosOperario.Enabled = false;
            ListarOperario();
        }

        private void gbDatosOperario_Enter(object sender, EventArgs e)
        {

        }

        private void MantenedorOperario_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
