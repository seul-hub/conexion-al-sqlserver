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
namespace VISTA
{
    public partial class FrmbloquearUsuario : Form
    {
        public FrmbloquearUsuario()
        {
            InitializeComponent();
        }

        private BloquearUsuario bloquearusuario = new BloquearUsuario(); // objeto de DATOS que ejecuta el SP de bloqueo

        private void btnBloquear_Click(object sender, EventArgs e)
        {
            // try/catch: si algo sale mal (conexión caída, SP inexistente, etc.),
            // el "catch" atrapa el error y muestra un mensaje en vez de romper la app.
            try
            {
                int idUsuarioSeleccionado = (int)cmbUsuario.SelectedValue; // ID del usuario elegido en el combo
                bloquearusuario.Bloquear(idUsuarioSeleccionado); // ejecuta el bloqueo en la base
                MessageBox.Show("Usuario bloqueado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al bloquear el usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmbloquearUsuario_Load(object sender, EventArgs e)
        {
            // Carga del combobox — mismo patrón ya explicado arriba (DataSource/DisplayMember/ValueMember).
            ListasUsuariosLogica usuarioLogica = new ListasUsuariosLogica();
            cmbUsuario.DataSource = usuarioLogica.Listar();
            cmbUsuario.DisplayMember = "UserName";
            cmbUsuario.ValueMember = "IdUsuario";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}


//Corrección de conceptos primero:

//BloquearUsuario no es una "entidad" — es una clase de la capa DATOS, como InsertarUsuario o ModificarUsuario. Las entidades son solo los "moldes de datos" (Usuario, Persona, Rol) — no tienen lógica ni conexión a la base.
//Lo de "hacer una conexión de la BD y C# con el comando conexión" en el botón — eso está mal pensado. Fijate que en ningún otro formulario tuyo (modificar, agregar) el botón de la VISTA toca SqlCommand ni Conexion directamente. Eso siempre vive adentro de la clase de DATOS. El botón solo arma el objeto y llama a la capa LOGICA, que a su vez llama a DATOS. Vos nunca ves un SqlCommand en un Form.cs.

//Cómo pensarlo, capa por capa (sin código todavía):

//DATOS → BloquearUsuario.cs: una clase nueva, con un método (por ejemplo Bloquear(int idUsuario)) que ejecuta el SP sp_bloquear_usuario pasándole el ID. Ahí sí va el SqlCommand, Conexion, etc. — como en ModificarUsuario.cs.
//LOGICA → BloquearUsuarioLogica.cs: una clase que llama al método de arriba. Puede tener alguna validación (por ejemplo, no dejar bloquear si no hay usuario seleccionado).
//VISTA → FrmBloquearUsuario.cs:
//En el Load: usás ListasUsuariosLogica(la que ya tenés) para traer la lista de usuarios y cargar el combobox — mismo patrón que hiciste con cmbRol y cmbPersona.
//En el botón "bloquear": tomás el SelectedValue del combobox (el ID del usuario elegido), y llamás a BloquearUsuarioLogica.Bloquear(idElegido), todo dentro de un try/catch con su MessageBox de éxito o error.