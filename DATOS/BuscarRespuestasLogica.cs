using entidades;
using Microsoft.Data.SqlClient;
using SISTEMA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DATOS
{
    public class BuscarRespuestasLogica
    {
        private Conexion conexion = new Conexion();
        public void Buscar(RespuestasSeguridad respuestasSeguridad)
        {
            try
            {
                SqlCommand comando = new SqlCommand("sp_buscar_respuestas_pregunta", conexion.ObtenerConexion());
            }
            catch(Exception ex)
            {

            }
            finally
            {

            }
            
        }
    }
}
