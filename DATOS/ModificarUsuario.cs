using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entidades;
using Microsoft.Data.SqlClient;
using System.Data;
using SISTEMA;

namespace DATOS
{
    public class ModificarUsuario
    {
        private Conexion conexion = new Conexion();

        public void Modificar(Usuario usuario)
        {
            try
            {
                SqlCommand comando = new SqlCommand("sp_modificar_usuario", conexion.ObtenerConexion());
                comando.CommandType = CommandType.StoredProcedure;

                // Le manda al SP TODOS los campos del usuario, no solo los que cambia el formulario:
                // por eso en FrmModificarUsuario se reusan los valores que ya tenía (IdPersona, IntentosFallidos, etc.)
                // antes de llamar a este método — si no, se pisarían con valores vacíos.
                comando.Parameters.AddWithValue("@id_usuario", usuario.IdUsuario);
                comando.Parameters.AddWithValue("@user_name", usuario.UserName);
                comando.Parameters.AddWithValue("@password", usuario.password);
                comando.Parameters.AddWithValue("@activo", usuario.activo);
                comando.Parameters.AddWithValue("@intentos_fallidos", usuario.IntentosFallidos);
                comando.Parameters.AddWithValue("@hora_ultimo_intento", usuario.HoraUltimoIntento);
                comando.Parameters.AddWithValue("@id_persona", usuario.IdPersona);
                comando.Parameters.AddWithValue("@id_rol", usuario.IdRol);
                comando.Parameters.AddWithValue("@debe_cambiar_pass", usuario.DebeCambiarPass);
                comando.Parameters.AddWithValue("@dias_validez_pass", usuario.DiasValidezPass);

                conexion.AbrirConexion();
                comando.ExecuteNonQuery(); // UPDATE: no devuelve filas, solo ejecuta el cambio
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }
    }
}