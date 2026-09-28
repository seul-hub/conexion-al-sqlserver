using DATOS;
using entidades;

namespace LOGICA
{
    public class LoginLogica
    {
        private Login datos = new Login();

        public Usuario IniciarSesion(string userName, string password)
        {
            return datos.IniciarSesion(userName, password); // devuelve el Usuario si el login fue correcto, o null si no
        }
    }
}