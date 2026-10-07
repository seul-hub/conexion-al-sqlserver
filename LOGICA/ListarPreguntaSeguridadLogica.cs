using DATOS;
using entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGICA
{
    public class ListarPreguntaSeguridadLogica
    {
        ListarPreguntaSeguridad listar = new ListarPreguntaSeguridad();
        public List<PreguntaSeguridad> Listar()
        {
            return listar.Listar();
        }
    }
}
