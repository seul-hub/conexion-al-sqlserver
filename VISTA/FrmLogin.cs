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

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                LoginLogica login = new LoginLogica();

                Usuario usuario = login.IniciarSesion(
                    txtUsuario.Text,
                    txtPassword.Text
                );

                if (usuario != null)
                {
                    MessageBox.Show("Bienvenido " + usuario.UserName);

                    Frmprincipal principal = new Frmprincipal();
                    principal.Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}