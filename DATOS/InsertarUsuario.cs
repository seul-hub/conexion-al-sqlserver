using entidades;
using Microsoft.Data.SqlClient;
using SISTEMA;
using System;
using System.Data;

namespace DATOS
{
    public class InsertarUsuario
    {
        private Conexion conexion = new Conexion();//es el encargado de permitir la conexion a la BD de sqlserver.

        public void Insertar(Usuario usuario)
        {
            try
            {
                SqlCommand comando = new SqlCommand("sp_insert_usuario", conexion.ObtenerConexion());

                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@user_name", usuario.UserName);
                comando.Parameters.AddWithValue("@password", usuario.password);
                comando.Parameters.AddWithValue("@activo", usuario.activo);
                comando.Parameters.AddWithValue("@debe_cambiar_pass", usuario.DebeCambiarPass);
                comando.Parameters.AddWithValue("@dias_validez_pass", usuario.DiasValidezPass);
                comando.Parameters.AddWithValue("@intentos_fallidos", usuario.IntentosFallidos);
                comando.Parameters.AddWithValue("@hora_ultimo_intento", usuario.HoraUltimoIntento);
                comando.Parameters.AddWithValue("@id_persona", usuario.IdPersona);
                comando.Parameters.AddWithValue("@id_rol", usuario.IdRol);

                conexion.AbrirConexion();

                comando.ExecuteNonQuery();
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