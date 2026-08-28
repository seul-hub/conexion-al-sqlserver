using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DATOS;
using entidades;
using LOGICA;
using Microsoft.VisualBasic;

namespace VISTA
{
    public partial class FrmCambiarContraseñaUsuario : Form
    {
        // Objeto que Windows Forms usa para mostrar un ícono de error (❗)
        // al lado de un control cuando algo no es válido.
        private ErrorProvider errorProvider1 = new ErrorProvider();

        public FrmCambiarContraseñaUsuario()
        {
            InitializeComponent(); // arma todos los controles visuales del form (ver explicación completa que ya vimos)
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close(); // botón "cancelar": cierra el formulario sin hacer nada
        }

        private void FrmCambiarContraseñaUsuario_Load(object sender, EventArgs e)
        {
            // Trae la lista de usuarios (capa LOGICA) para llenar el combobox.
            ListasUsuariosLogica usuarioLogica = new ListasUsuariosLogica();
            cmbUsuario.DataSource = usuarioLogica.Listar(); // la lista completa de usuarios
            cmbUsuario.DisplayMember = "UserName";          // lo que se VE en el combobox
            cmbUsuario.ValueMember = "IdUsuario";            // lo que se GUARDA por dentro (el ID real)
        }

        private void btnCambiar_contraseña_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear(); // saca los íconos de error de una ejecución anterior, por si el usuario corrige y reintenta

            bool valido = true; // bandera: se pone en false si algún campo obligatorio falla

            // Valida que la nueva contraseña no esté vacía (ni solo espacios en blanco)
            if (string.IsNullOrWhiteSpace(txtContraseña_Nueva.Text))
            {
                errorProvider1.SetError(txtContraseña_Nueva, "Este campo es obligatorio.");
                valido = false;
            }

            // Misma validación para el campo de repetir contraseña
            if (string.IsNullOrWhiteSpace(txtRepetir_Contraseña.Text))
            {
                errorProvider1.SetError(txtRepetir_Contraseña, "Este campo es obligatorio.");
                valido = false;
            }

            // Si algún campo falló la validación de arriba, corta acá y no sigue.
            if (!valido) return;

            // Solo cambia la contraseña si ambos campos coinciden
            if (txtContraseña_Nueva.Text == txtRepetir_Contraseña.Text)
            {
                CambiarPassword cambiarPassword = new CambiarPassword(); // objeto de la capa DATOS

                // Llama al método que ejecuta el UPDATE en SQL Server.
                // (int) convierte el ID elegido en el combo (que llega como "object") a un número entero.
                cambiarPassword.Cambiar((int)cmbUsuario.SelectedValue, txtContraseña_Nueva.Text);

                MessageBox.Show("Contraseña cambiada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
