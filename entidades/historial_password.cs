using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidades
{
    public class Historial_password
    {
        public int IdHistorial { get; set; }
        public string Password { get; set; }
        public DateTime Fecha { get; set; }
        public int? IdUsuario { get; set; }

        public Historial_password() { }

        public Historial_password(int IdHistorial, string Password, DateTime Fecha, int IdUsuario)
        {
            this.IdHistorial= IdHistorial;
            this.Password= Password;
            this.Fecha= Fecha;
            this.IdUsuario= IdUsuario;
        }
    }
}