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
            if (string.IsNullOrEmpty(usuario.UserName))
            {
                throw new Exception("El usuario es obligatorio.");
            }

            modificar.Modificar(usuario);
        }
    }
}