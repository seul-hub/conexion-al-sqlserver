using DATOS;
using entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGICA
{
   public class ListasUsuariosLogica
    {
        private ListarUsuario listar = new ListarUsuario();

        public List<Usuario> Listar()
        {
            return listar.Listar();
        }
    }
}
