using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidades
{
    public class recuperacion_password
    {
        public int IdRecuperacion {  get; set; }
        public DateTime FechaRecuperacion { get; set; }
        public string Codigo { get; set; }
        public Boolean Usado { get; set; }
        public int? IdUsuario { get; set; }
        public recuperacion_password() { }
        public recuperacion_password(int idRecuperacion, DateTime FechaRecuperacion, string Codigo, bool Usado, int? IdUsuario)
        {
            this.IdRecuperacion = idRecuperacion;
            this.FechaRecuperacion = FechaRecuperacion;
            this.Codigo = Codigo;
            this.Usado = Usado;
            this.IdUsuario = IdUsuario;
            
        }
    }
}
