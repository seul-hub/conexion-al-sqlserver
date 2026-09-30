using DATOS;
using entidades;
using System.Security.Cryptography;
using System.Runtime.Intrinsics.Arm;

namespace LOGICA
{
    public class InsertarUsuariosLogica
    {
        private InsertarUsuario datos = new InsertarUsuario();

        public void Insertar(Usuario usuario)
        {
        
            string resultado = usuario.UserName + usuario.password;
            usuario.password = SeguridadSha256Logica.Sha256(resultado);
            datos.Insertar(usuario); // mismo patrón
        }
    }
}
