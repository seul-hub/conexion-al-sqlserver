using Microsoft.Data.SqlClient;
using SISTEMA;
using System;
using System.Data;

namespace DATOS
{
    public class CambiarPassword
    {
        private Conexion conexion = new Conexion();//es el encargado de permitir la conexion a la BD de sqlserver.

        public void Cambiar(int idUsuario, string nuevaPassword)
        {
            try
            {
                SqlCommand comando = new SqlCommand("sp_cambiar_password", conexion.ObtenerConexion());

                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@id_usuario", idUsuario);
                comando.Parameters.AddWithValue("@new_password", nuevaPassword);
                //en este caso estoy mandando dos parametros, el id del usuario y la nueva contraseña que se va a establecer.
                conexion.AbrirConexion();

                comando.ExecuteNonQuery(); //se utiliza cuando no espéramos un resultado de la consulta, es decir, cuando no necesitamos obtener datos de la base de datos, sino que solo queremos ejecutar una acción, como insertar, actualizar o eliminar registros.
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
