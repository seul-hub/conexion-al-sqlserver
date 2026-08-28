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
            // Vacío: evento generado automáticamente al hacer doble clic en el label desde el diseñador,
            // pero no tiene ninguna lógica adentro.
        }

        private void lblcontraseña_Click(object sender, EventArgs e)
        {
            // Igual que arriba, vacío.
        }

        private ErrorProvider errorProvider1 = new ErrorProvider();

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
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

                // Intenta autenticar con usuario/contraseña. Si son correctos, devuelve el objeto Usuario;
                // si no, devuelve null (por eso se chequea con "!= null" abajo).
                Usuario usuario = login.IniciarSesion(
                    txtUsuario.Text,
                    txtPassword.Text
                );

                if (usuario != null)
                {
                    MessageBox.Show("Bienvenido " + usuario.UserName);

                    Frmprincipal principal = new Frmprincipal();
                    principal.Show(); // abre la pantalla principal del sistema

                    this.Hide(); // oculta el login (no lo cierra del todo, queda en memoria)
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
            // Vacío: no hace falta cargar nada al abrir el login.
        }
    }
}