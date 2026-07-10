using DATOS;
using entidades;

namespace LOGICA
{
    public class InsertarUsuarioLogica
    {
        private InsertarUsuario insertarUsuario = new InsertarUsuario();

        public void Insertar(Usuario usuario)
        {
            insertarUsuario.Insertar(usuario);
        }
    }
}
