using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidades
{
    public class Rol
    {
        public int id_rol { get; set; }
        public string nombre_rol { get; set; }
        public Rol() { }
        public Rol(int id_rol, string nombre_rol)
        {
            this.id_rol = id_rol;
            this.nombre_rol = nombre_rol;
        }
    }
}
