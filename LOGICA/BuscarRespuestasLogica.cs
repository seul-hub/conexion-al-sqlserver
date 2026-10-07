using DATOS;
using entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGICA
{
    public class BuscarRespuestasLogica
    {
        BuscarRespuestas buscar = new BuscarRespuestas();
        public bool Buscar(RespuestasSeguridad respuestasSeguridad)
        {
            return buscar.Buscar(respuestasSeguridad);
        }
    }
}
