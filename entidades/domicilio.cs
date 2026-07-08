using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidades
{
    public class Domicilio
    {
        public int IdDomicilio { get; set; }
        public string Calle { get; set; }
        public int Altura { get; set; }
        public string? Piso { get; set; }
        public string? Departamento { get; set; }
        public int? IdLocalidad { get; set; }

        public Domicilio()
        {

        }
        public Domicilio(int IdDomicilio, string Calle, int Altura, string Piso, string Departamento, int IdLocalidad)
        {
            this.IdDomicilio = IdDomicilio;
            this.Calle = Calle;
            this.Altura = Altura;
            this.Piso = Piso;
            this.Departamento = Departamento;
            this.IdLocalidad= IdLocalidad;
        }
    }
}