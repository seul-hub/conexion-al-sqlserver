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
    public partial class FrmPrincipal2 : Form
    {
        public FrmPrincipal2()
        {
            InitializeComponent();
        }

      
        private void button1_Click(object sender, EventArgs e)
        {
            FrmAgregarUsuario frmAgregarUsuario = new FrmAgregarUsuario();
            frmAgregarUsuario.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmbloquearUsuario frmbloquearUsuario = new FrmbloquearUsuario();
            frmbloquearUsuario.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmCambiarContraseñaUsuario frmCambiarContraseñaUsuario = new FrmCambiarContraseñaUsuario();
            frmCambiarContraseñaUsuario.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmListarUsuario frmListarUsuario = new FrmListarUsuario();
            frmListarUsuario.ShowDialog();
        }
    }
}
