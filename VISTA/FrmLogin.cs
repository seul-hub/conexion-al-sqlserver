using LOGICA;
using entidades;
namespace VISTA
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblcontraseña_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginLogica login = new LoginLogica();
            Usuario usuario = login.IniciarSesion(txtUsuario.Text, txtPassword.Text);
            if (usuario != null)
            {
                MessageBox.Show("Bienvenido " + usuario.UserName);
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }
    }
}