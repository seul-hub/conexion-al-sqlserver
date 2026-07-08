using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidades
{
    public class Partido
    {
        public int IdPartido { get; set; }
        public string partido { get; set; }
        public int? IdProvincia { get; set; }

        public Partido() { }
        public Partido(int IdPartido, string partido, int? IdProvincia)
        {

            this.IdPartido = IdPartido;
            this.partido = partido;
            this.IdProvincia = IdProvincia;
        }
    }
}