using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidades
{
   public class Usuario//Representa un usuario del sistema.
    {
        public int IdUsuario {  get; set; }//esto me permite identificar a cada usuario de manera única y poder obtener(get) inf y modificarla(set)
        public string UserName { get; set; }
        public string password {  get; set; }
        public bool activo { get; set; }
        public bool DebeCambiarPass { get; set; }
        public int DiasValidezPass { get; set; }
        public int IntentosFallidos { get; set; }
        public DateTime HoraUltimoIntento { get; set; }
        public int IdPersona { get; set; }
        public int IdRol { get; set; }
        public Usuario()//Esto es un constructor vacío.
        {

        }
        public Usuario(int idUsuario, string userName, string password, bool activo, bool debeCambiarPass, int diasValidezPass, int intentosFallidos, DateTime horaUltimoIntento, int idPersona, int idRol)
        //Este es un constructor que recibe parámetros para inicializar las propiedades de la clase Usuario.
        {
            IdUsuario = idUsuario;
            UserName = userName;
            this.password = password;
            this.activo = activo;
            DebeCambiarPass = debeCambiarPass;
            DiasValidezPass = diasValidezPass;
            IntentosFallidos = intentosFallidos;
            HoraUltimoIntento = horaUltimoIntento;
            IdPersona = idPersona;
            IdRol = idRol;
        }
       
    }
}
