using DATOS;
using entidades;
using System;

namespace LOGICA
{
    public class ModificarUsuarioLogica
    {
        private ModificarUsuario modificar = new ModificarUsuario();

        public void ModificarUsuario(Usuario usuario)
        {
            // A diferencia de las otras clases de LOGICA, acá SÍ hay una validación antes de reenviar
            // el pedido a DATOS: si el nombre de usuario viene vacío, corta con una excepción
            // en vez de intentar guardar un usuario sin nombre.
            if (string.IsNullOrEmpty(usuario.UserName))
            {
                throw new Exception("El usuario es obligatorio.");
            }

            modificar.Modificar(usuario);
        }
    }
}