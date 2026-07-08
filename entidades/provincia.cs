using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidades
{
   public class Provincia
    {
     public int IdProvincia {  get; set; }
        public string provincia {  get; set; }

        public Provincia() { }
        public Provincia(int IdProvincia, string provincia)
        {
            this.IdProvincia = IdProvincia;
            this.provincia = provincia;
            
        }

    }
}
