using DATOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGICA
{
    public class CambiarPasswordLogica
    {
        private CambiarPassword cambiar = new CambiarPassword();

        public void Cambiar(int idUsuario, string password)
        {
            cambiar.Cambiar(idUsuario, password); // mismo patrón: solo reenvía
        }
    }
}