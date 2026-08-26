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
    public partial class FrmListarUsuario : Form
    {
        public FrmListarUsuario()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dguUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CargarGrilla();
        }
        private void CargarGrilla()
        {
            ListasUsuariosLogica logica = new ListasUsuariosLogica();
            List<UsuarioListado> lista = logica.Listar();
            dguUsuarios.DataSource = lista;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dguUsuarios.CurrentRow == null)
            {
                MessageBox.Show("Seleccioná un usuario primero.");
                return;
            }

            UsuarioListado usuarioSeleccionado = (UsuarioListado)dguUsuarios.CurrentRow.DataBoundItem;
            int idUsuario = usuarioSeleccionado.IdUsuario;

            FrmModificarUsuario frm = new FrmModificarUsuario(idUsuario);
            frm.ShowDialog();

            CargarGrilla();
        }

        private void FrmListarUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
