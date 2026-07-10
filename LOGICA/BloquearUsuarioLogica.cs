using DATOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGICA
{
  public class BloquearUsuarioLogica
    {
        private BloquearUsuario bloquear = new BloquearUsuario();

        public void Bloquear(int idUsuario)
        {
            bloquear.Bloquear(idUsuario);
        }
    }
}
