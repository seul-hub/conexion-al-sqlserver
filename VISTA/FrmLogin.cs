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
        private ErrorProvider errorProvider1 = new ErrorProvider();
        private void btnIngresar_Click(object sender, EventArgs e)
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