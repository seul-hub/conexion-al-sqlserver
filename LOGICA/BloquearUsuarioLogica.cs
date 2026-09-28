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
        private BloquearUsuario bloquear = new BloquearUsuario(); // objeto de DATOS

        public void Bloquear(int idUsuario)
        {
            bloquear.Bloquear(idUsuario); // reenvía el pedido a DATOS, sin agregar nada más
        }
    }
}