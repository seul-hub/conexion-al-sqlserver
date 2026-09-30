using DATOS;
using entidades;
using System.Collections.Generic;

namespace LOGICA
{
    public class ListasUsuariosLogica
    {
        private ListarUsuario listar = new ListarUsuario();

        // Dos métodos, porque DATOS.ListarUsuario también tiene dos: uno para la lista completa,
        // otro para traer un usuario puntual por ID.
        public List<UsuarioListado> Listar()
        {
            return listar.Listar();
        }

        public Usuario ObtenerPorId(int idUsuario)
        {
            return listar.ObtenerPorId(idUsuario);
        }
    }
}