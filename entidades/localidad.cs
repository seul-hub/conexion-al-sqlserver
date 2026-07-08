using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidades
{
    public class Localidad
    {
        public int IdLocalidad { get; set; }
        public string localidad {  get; set; }
        public string CodigoPostal { get; set; }
        public int? IdPartido { get; set; }

        public Localidad() { }

        public Localidad(int IdLocalidad, string localidad,string CodigoPostal, int IdPartido) {
            this.IdLocalidad = IdLocalidad;
            this.localidad = localidad;
            this.CodigoPostal = CodigoPostal;
            this.IdPartido = IdPartido;
           
        }
    }
}
