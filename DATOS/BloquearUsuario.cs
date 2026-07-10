using Microsoft.Data.SqlClient;
using SISTEMA;
using System;
using System.Data;

namespace DATOS
{
    public class BloquearUsuario
    {
        private Conexion conexion = new Conexion();

        public void Bloquear(int idUsuario)
        {
            try
            {
                SqlCommand comando = new SqlCommand("sp_bloquear_usuario", conexion.ObtenerConexion());

                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@id_usuario", idUsuario);

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