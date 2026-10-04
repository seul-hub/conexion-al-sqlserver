using entidades;
using Microsoft.Data.SqlClient;
using SISTEMA;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATOS
{
   public class InsertarRespuestasSeguridad
    {
        private Conexion conexion = new Conexion();

        public void Insertar (RespuestasSeguridad respuestasSeguridad)
        {
            try
            {
                SqlCommand comando = new SqlCommand("sp_alta_respuestas_seguridad", conexion.ObtenerConexion());
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@id_usuario", respuestasSeguridad.IdUsuario);
                comando.Parameters.AddWithValue("@id_pregunta", respuestasSeguridad.Idpregunta);
                comando.Parameters.AddWithValue("@respuestas", respuestasSeguridad.Respuestas);
                
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
