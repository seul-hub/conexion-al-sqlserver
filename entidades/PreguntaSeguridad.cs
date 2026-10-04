using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidades
{
    public class PreguntaSeguridad
    {
        public int IdPregunta { get; set; }
        public string Pregunta { get; set; }
       

        public PreguntaSeguridad(){ }
        public PreguntaSeguridad(int IdPregunta,string pregunta)   
        {
            this.IdPregunta = IdPregunta;
            this.Pregunta = pregunta;
          
        }
        
    }
}
