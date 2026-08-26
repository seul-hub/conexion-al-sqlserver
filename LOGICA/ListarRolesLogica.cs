using DATOS;
using entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGICA
{
    public class ListarRolesLogica
    {
        private ListarRoles listar = new ListarRoles();
        public List<Rol> Listar()
        {
            return listar.Listar();
        }
    }
}
