using entidades;
using LOGICA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VISTA
{
    public partial class FrmModificarUsuario : Form
    {
        // Variables de clase: se declaran una vez y quedan disponibles en TODOS los métodos del form,
        // no solo en el que las creó (a diferencia de una variable normal dentro de un método).
        private int idUsuarioSeleccionado; // guarda qué usuario se está editando
        private Usuario usuarioActual;     // guarda los datos completos que ya tenía ese usuario en la base

        public FrmModificarUsuario(int idUsuario)
        {
            InitializeComponent();
            idUsuarioSeleccionado = idUsuario; // guarda el ID recibido por parámetro (viene de FrmListarUsuario)
        }

        private ErrorProvider errorProvider1 = new ErrorProvider();

        private void FrmModificarUsuario_Load(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool valido = true;

            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                errorProvider1.SetError(txtUsuario, "Este campo es obligatorio.");
                valido = false;
            }

            if (string.IsNullOrWhiteSpace(txtContraseña.Text))
            {
                errorProvider1.SetError(txtContraseña, "Este campo es obligatorio.");
                valido = false;
            }

            // Nota: esta validación acá arriba en realidad no tiene mucho efecto,
            // porque al ABRIR el form los textbox todavía están vacíos (recién se van a llenar más abajo).
            if (!valido) return;

            // Carga del combobox de roles
            ListarRolesLogica rolLogica = new ListarRolesLogica();
            cmbRol.DataSource = rolLogica.Listar();
            cmbRol.DisplayMember = "nombre_rol";
            cmbRol.ValueMember = "id_rol";

            // Trae TODOS los datos actuales del usuario que se va a modificar (por su ID),
            // para no perder los campos que este form no edita (persona, intentos fallidos, etc.)
            ListasUsuariosLogica usuarioLogica = new ListasUsuariosLogica();
            usuarioActual = usuarioLogica.ObtenerPorId(idUsuarioSeleccionado);

            // Precarga los controles en pantalla con los datos que ya tenía el usuario
            txtUsuario.Text = usuarioActual.UserName;
            txtContraseña.Text = usuarioActual.password;
            cmbRol.SelectedValue = usuarioActual.IdRol;
            checkBox1.Checked = usuarioActual.activo;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario usuario = new Usuario();
                usuario.IdUsuario = idUsuarioSeleccionado;
                usuario.UserName = txtUsuario.Text;
                usuario.password = txtContraseña.Text;
                usuario.IdRol = Convert.ToInt32(cmbRol.SelectedValue);
                usuario.activo = checkBox1.Checked;

                // Campos que este form NO edita: se reusan los valores que ya tenía el usuario,
                // para no pisarlos con datos vacíos/por defecto.
                usuario.IdPersona = usuarioActual.IdPersona;
                usuario.IntentosFallidos = usuarioActual.IntentosFallidos;
                usuario.HoraUltimoIntento = usuarioActual.HoraUltimoIntento;
                usuario.DebeCambiarPass = usuarioActual.DebeCambiarPass;
                usuario.DiasValidezPass = usuarioActual.DiasValidezPass;

                ModificarUsuarioLogica logica = new ModificarUsuarioLogica();
                logica.ModificarUsuario(usuario); // ejecuta el UPDATE en la base

                MessageBox.Show("Usuario modificado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbRol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
