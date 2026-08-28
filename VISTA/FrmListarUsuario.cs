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

        // Nota: este evento se dispara al hacer clic en una celda de la grilla —
        // recargar toda la grilla acá es medio raro (se ejecuta en cada clic dentro
        // de la tabla, no solo cuando el usuario realmente quiere "actualizar").
        private void dguUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CargarGrilla();
        }

        // Método reutilizable: trae la lista de usuarios y la muestra en el DataGridView.
        // Se llama desde varios lugares (Load, botón actualizar, después de modificar) para no repetir código.
        private void CargarGrilla()
        {
            ListasUsuariosLogica logica = new ListasUsuariosLogica();
            List<UsuarioListado> lista = logica.Listar();
            dguUsuarios.DataSource = lista;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarGrilla(); // simplemente vuelve a traer los datos, por si algo cambió
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            // Si no hay ninguna fila seleccionada, avisa y corta (no tiene sentido seguir).
            if (dguUsuarios.CurrentRow == null)
            {
                MessageBox.Show("Seleccioná un usuario primero.");
                return;
            }

            // Toma el objeto completo de la fila que el usuario seleccionó en la grilla.
            UsuarioListado usuarioSeleccionado = (UsuarioListado)dguUsuarios.CurrentRow.DataBoundItem;
            int idUsuario = usuarioSeleccionado.IdUsuario;

            // Abre el form de modificar, pasándole el ID del usuario elegido.
            FrmModificarUsuario frm = new FrmModificarUsuario(idUsuario);
            frm.ShowDialog(); // ShowDialog espera a que el usuario cierre esa ventana antes de seguir acá

            CargarGrilla(); // refresca la grilla al volver, por si se modificó algo
        }

        private void FrmListarUsuario_Load(object sender, EventArgs e)
        {
            // Vacío: hoy la grilla se llena solo cuando se hace clic (Load no llama a CargarGrilla).
        }
    }
}
