using DATOS;
using entidades;

namespace LOGICA
{
    public class InsertarUsuariosLogica
    {
        private InsertarUsuario datos = new InsertarUsuario();

        public void Insertar(Usuario usuario)
        {
            datos.Insertar(usuario);
        }
    }
}           