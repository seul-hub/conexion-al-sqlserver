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
    public class ListarPreguntaSeguridad
    {
        private Conexion conexion = new Conexion();
        public List<PreguntaSeguridad> Listar()
        {
            List<PreguntaSeguridad> lista = new List<PreguntaSeguridad>();
            try
            {
                SqlCommand comando = new SqlCommand("sp_listar_pregunta_seguridad", conexion.ObtenerConexion());
                comando.CommandType = CommandType.StoredProcedure;
                conexion.AbrirConexion();
                SqlDataReader lector = comando.ExecuteReader();
                while(lector.Read())
                {
                    PreguntaSeguridad preguntaSeguridad = new PreguntaSeguridad();
                    preguntaSeguridad.IdPregunta = Convert.ToInt32(lector["id_pregunta"]);
                    preguntaSeguridad.Pregunta =lector["pregunta"].ToString();

                    lista.Add(preguntaSeguridad);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }

            return lista;
        }
    }
}
