using DATOS;
using entidades;

namespace LOGICA
{
    public class LoginLogica
    {
        private Login loginDatos = new Login();

        public Usuario IniciarSesion(string userName, string password)
        {
            return loginDatos.IniciarSesion(userName, password);
        }
    }
}