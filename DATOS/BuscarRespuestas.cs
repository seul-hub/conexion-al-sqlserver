using entidades;
using Microsoft.Data.SqlClient;
using SISTEMA;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DATOS
{
    public class BuscarRespuestas
    {
        private Conexion conexion = new Conexion();
        public bool Buscar(RespuestasSeguridad respuestasSeguridad)
        {
            bool valido = false;
            try
            {
                SqlCommand comando = new SqlCommand("sp_buscar_respuestas_pregunta", conexion.ObtenerConexion());
                comando.CommandType = CommandType.StoredProcedure;
             
                comando.Parameters.AddWithValue("@id_usuario",respuestasSeguridad.IdUsuario);
                comando.Parameters.AddWithValue("@id_pregunta",respuestasSeguridad.Idpregunta);
                comando.Parameters.AddWithValue("@respuestas",respuestasSeguridad.Respuestas);
                conexion.AbrirConexion();
                SqlDataReader reader = comando.ExecuteReader();
                
                if (reader.Read())
                {
                    valido = true;
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }
            return valido;
        }
    }
}
