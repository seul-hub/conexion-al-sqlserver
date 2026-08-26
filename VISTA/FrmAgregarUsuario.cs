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
    public partial class FrmAgregarUsuario : Form
    {
        public FrmAgregarUsuario()
        {
            InitializeComponent();
        }

        private void FrmAgregarUsuario_Load(object sender, EventArgs e)
        {

        }
        private InsertarUsuariosLogica insertar = new InsertarUsuariosLogica();

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();

            usuario.UserName = txtUsuario.Text;
            usuario.password = txtPassword.Text;
            usuario.activo = chkActivo.Checked;

            // Completar vos:
            usuario.DebeCambiarPass = true;
            usuario.DiasValidezPass = 30;
            usuario.IntentosFallidos = 0;
            usuario.HoraUltimoIntento = DateTime.Now;
            usuario.IdPersona = Convert.ToInt32(cmbPersona.SelectedValue);
            usuario.IdRol = usuario.IdRol = Convert.ToInt32(cmbRol.SelectedValue);

            insertar.Insertar(usuario);

            MessageBox.Show("Usuario agregado correctamente");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
