using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidades
{
    public class Permisos
    {
        public int IdPermisos {  get; set; }
        public string Codigo {  get; set; }
        public string Descripcion { get; set; }

        public Permisos() { }

        public Permisos(int IdPermisos, string Codigo, string Descripcion) {
            this.IdPermisos = IdPermisos;
            this.Codigo = Codigo;
            this.Descripcion = Descripcion;
        }
    }
}
