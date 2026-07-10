using Microsoft.Data.SqlClient;
using SISTEMA;
using System;
using System.Data;

namespace DATOS
{
    public class CambiarPassword
    {
        private Conexion conexion = new Conexion();

        public void Cambiar(int idUsuario, string nuevaPassword)
        {
            try
            {
                SqlCommand comando = new SqlCommand("sp_cambiar_password", conexion.ObtenerConexion());

                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@id_usuario", idUsuario);
                comando.Parameters.AddWithValue("@new_password", nuevaPassword);

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
