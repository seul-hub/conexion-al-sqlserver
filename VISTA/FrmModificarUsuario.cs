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
        private int idUsuarioSeleccionado;
        private Usuario usuarioActual;

        public FrmModificarUsuario(int idUsuario)
        {
            InitializeComponent();
            idUsuarioSeleccionado = idUsuario;
        }

        private void FrmModificarUsuario_Load(object sender, EventArgs e)
        {
            ListarRolesLogica rolLogica = new ListarRolesLogica();
            cmbRol.DataSource = rolLogica.Listar();
            cmbRol.DisplayMember = "nombre_rol";
            cmbRol.ValueMember = "id_rol";

            ListasUsuariosLogica usuarioLogica = new ListasUsuariosLogica();
            usuarioActual = usuarioLogica.ObtenerPorId(idUsuarioSeleccionado);

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

                usuario.IdPersona = usuarioActual.IdPersona;
                usuario.IntentosFallidos = usuarioActual.IntentosFallidos;
                usuario.HoraUltimoIntento = usuarioActual.HoraUltimoIntento;
                usuario.DebeCambiarPass = usuarioActual.DebeCambiarPass;
                usuario.DiasValidezPass = usuarioActual.DiasValidezPass;


                ModificarUsuarioLogica logica = new ModificarUsuarioLogica();
                logica.ModificarUsuario(usuario);

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
