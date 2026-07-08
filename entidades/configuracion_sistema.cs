using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATOS
{
    public class Configuracion_sistema
    {
        public int IdConfiguracion {  get; set; }
        public int Mincaracteres { get; set; }
        public int CantidadPreguntas { get; set; }
        public bool RequiereMayusculas {  get; set; }
        public bool RequiereNumeros { get; set; }
        public bool RequiereCaracteresEspeciales { get; set; }
        public bool Autenticacion { get; set; }
        public bool NoRepetirContraseña {  get; set; }
        public bool ValidarDatosPersonales { get; set; }

        public Configuracion_sistema()
        {
        }
        public Configuracion_sistema(int IdConfiguracion, int Mincaracteres, int CantidadPreguntas, bool RequiereMayusculas, bool RequiereNumeros, bool RequiereCaracteresEspeciales, bool Autenticacion, bool NoRepetirContraseña, bool ValidarDatosPersonales)
        {
            this.IdConfiguracion = IdConfiguracion;
            this.Mincaracteres = Mincaracteres;
            this.CantidadPreguntas = CantidadPreguntas;
            this.RequiereMayusculas = RequiereMayusculas;
            this.RequiereNumeros = RequiereNumeros;
            this.RequiereCaracteresEspeciales = RequiereCaracteresEspeciales;
            this.Autenticacion = Autenticacion;
            this.NoRepetirContraseña = NoRepetirContraseña;
            this.ValidarDatosPersonales = ValidarDatosPersonales;
        }

        
    }
}
