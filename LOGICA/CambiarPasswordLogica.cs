using DATOS;
using entidades;
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
            ListasUsuariosLogica usuarioLogica = new ListasUsuariosLogica();
            Usuario usuario=usuarioLogica.ObtenerPorId(idUsuario); 
            string hashpassword= SeguridadSha256Logica.Sha256(usuario.UserName + password);
            cambiar.Cambiar(idUsuario, hashpassword); // mismo patrón: solo reenvía
        }
    }
}