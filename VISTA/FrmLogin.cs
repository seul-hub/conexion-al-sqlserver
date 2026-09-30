using LOGICA;
using entidades;
using System.Security.Cryptography;
using System.Text;
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

                string resultado = txtUsuario.Text + txtPassword.Text;
                string passwordHash = SeguridadSha256Logica.Sha256(resultado);
                Usuario usuario = login.IniciarSesion(
                    txtUsuario.Text,
                    passwordHash
                );
                //aqui debe estar el sha256(txtpassword)

                //contraseña hasheada
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