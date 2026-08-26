using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidades
{
    public class RolPermiso
    {
        public int IdRol {  get; set; }
        public int IdPermiso { get; set; }
        //No tiene mucha información porque sirve para representar la relación entre roles y permisos.
    }
}
