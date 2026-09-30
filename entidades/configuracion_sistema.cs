using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidades // ojo: esto probablemente debería estar en el namespace "entidades", no en "DATOS" —
                // ver comentario más abajo
{
    // Entidad: representa las políticas de seguridad configurables del sistema (punto 5 del enunciado).
    // No tiene lógica ni conexión a la base, solo guarda los datos con sus "cajitas" (propiedades).
    public class Configuracion_sistema
    {
        public int IdConfiguracion { get; set; }
        public int Mincaracteres { get; set; }               // mínimo de caracteres exigido en la contraseña
        public int CantidadPreguntas { get; set; }            // cuántas preguntas de seguridad debe responder el usuario
        public bool RequiereMayusculas { get; set; }
        public bool RequiereNumeros { get; set; }
        public bool RequiereCaracteresEspeciales { get; set; }
        public bool Autenticacion { get; set; }                // ¿pide 2FA por correo?
        public bool NoRepetirContraseña { get; set; }          // ¿bloquea reusar contraseñas anteriores?
        public bool ValidarDatosPersonales { get; set; }        // ¿prohíbe que la contraseña contenga nombre/apellido/etc?

        public Configuracion_sistema() // constructor "vacío": crea el objeto sin cargarle datos todavía
        {
        }

        // constructor "completo": crea el objeto y le carga todos los valores de una sola vez
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
}}
