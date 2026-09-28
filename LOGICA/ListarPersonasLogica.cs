using DATOS;
using entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGICA
{
    public class ListarPersonasLogica
    {
        private ListarPersonas listar = new ListarPersonas();

        public List<Persona> Listar()
        {
            return listar.Listar(); // acá "return" porque este método sí devuelve un resultado (la lista)
        }
    }
}