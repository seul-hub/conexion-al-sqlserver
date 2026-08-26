using DATOS;
using entidades;
using System.Collections.Generic;

namespace LOGICA
{
    public class ListasUsuariosLogica
    {
        private ListarUsuario listar = new ListarUsuario();

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