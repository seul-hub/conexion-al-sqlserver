using DATOS;
using entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGICA
{
    public class InsertarRespuestasSeguridadLogica
    {
        InsertarRespuestasSeguridad insertar = new InsertarRespuestasSeguridad();
        public void Insertar(RespuestasSeguridad respuestasSeguridad)
        {
            insertar.Insertar(respuestasSeguridad);
        }
    }
}
