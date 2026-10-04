using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidades
{
    public class RespuestasSeguridad
    {
        public int IdRespuestas { get; set; }
        public int IdUsuario { get; set; }
        public int Idpregunta{ get; set; }
        public string Respuestas { get; set; }
        public RespuestasSeguridad() { }
        public RespuestasSeguridad(int IdRespuestas,int IdUsuario,int IdPregunta,string Respuestas) 
        {
            this.IdRespuestas = IdRespuestas;
            this.IdUsuario = IdUsuario;
            this.Idpregunta = IdPregunta;
            this.Respuestas = Respuestas;
        }
        
    }
}
