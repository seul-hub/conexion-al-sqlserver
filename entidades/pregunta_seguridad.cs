using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidades
{
    public class pregunta_seguridad
    {
        public int IdPregunta {  get; set; }
        public string pregunta { get; set; }
        public pregunta_seguridad() { }
        public pregunta_seguridad(int IdPregunta, string pregunta) { 
            this.IdPregunta = IdPregunta;
            this.pregunta = pregunta;
        }
    }
}
