using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidades
{
    public class RespuestaslSeguridad
    {
        public int IdRespuestas { get; set; }
        public string Respuestas { get; set; }
        public int? IdUsuario { get; set; }
        public int? IdPregunta { get; set; }

        public RespuestaslSeguridad() { }
        public RespuestaslSeguridad(int idRespuestas, string respuestas, int idUsuario, int idPregunta  )
        {
            IdRespuestas = idRespuestas;
            Respuestas = respuestas;
            IdUsuario = idUsuario;
            IdPregunta = idPregunta;
        }
    }
}