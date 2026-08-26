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
    public partial class Frmprincipal : Form
    {
        public Frmprincipal()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListarUsuario frm = new FrmListarUsuario();
            frm.ShowDialog();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAgregarUsuario frm = new FrmAgregarUsuario();
            frm.ShowDialog();
        }

        private void bloquearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmbloquearUsuario frm = new FrmbloquearUsuario();
            frm.ShowDialog();
        }

        private void cambiarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCambiarContraseñaUsuario frm = new FrmCambiarContraseñaUsuario();
            frm.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Frmprincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
