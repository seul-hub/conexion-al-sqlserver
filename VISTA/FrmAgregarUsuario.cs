using DATOS;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace VISTA
{
    public partial class FrmAgregarUsuario : Form
    {
        public FrmAgregarUsuario()
        {
            InitializeComponent();
        }

        private void FrmAgregarUsuario_Load(object sender, EventArgs e)
        {
            ListarRolesLogica rolLogica = new ListarRolesLogica();
            cmbRol.DataSource = rolLogica.Listar();
            cmbRol.DisplayMember = "nombre_rol";
            cmbRol.ValueMember = "id_rol";

            ListarPersonasLogica personaLogica = new ListarPersonasLogica();
            cmbPersona.DataSource = personaLogica.Listar();
            cmbPersona.DisplayMember = "nombre";
            cmbPersona.ValueMember = "idpersona";
        }
        private InsertarUsuariosLogica insertar = new InsertarUsuariosLogica();
        private ErrorProvider errorProvider1 = new ErrorProvider();
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear(); // limpia errores previos

            bool valido = true;

            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                errorProvider1.SetError(txtUsuario, "Este campo es obligatorio.");
                valido = false;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                errorProvider1.SetError(txtPassword, "Este campo es obligatorio.");
                valido = false;
            }

            if (!valido) return;
            try
            {
                Usuario usuario = new Usuario();

                usuario.UserName = txtUsuario.Text;
                usuario.password = txtPassword.Text;
                usuario.activo = chkActivo.Checked; 
                usuario.DebeCambiarPass = true;
                usuario.DiasValidezPass = 30;
                usuario.IntentosFallidos = 0;
                usuario.HoraUltimoIntento = DateTime.Now;
                usuario.IdPersona = Convert.ToInt32(cmbPersona.SelectedValue);
                usuario.IdRol = Convert.ToInt32(cmbRol.SelectedValue);

                insertar.Insertar(usuario);

                MessageBox.Show("Usuario agregado correctamente");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
