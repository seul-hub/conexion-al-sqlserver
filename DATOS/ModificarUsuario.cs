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
        private Conexion conexion = new Conexion();//es el encargado de permitir la conexion a la BD de sqlserver.
        public void Modificar(Usuario usuario)
        {
            try
            {
                SqlCommand comando = new SqlCommand("sp_modificar_usuario", conexion.ObtenerConexion());
                comando.CommandType = CommandType.StoredProcedure;

               

                comando.Parameters.AddWithValue("@id_usuario", usuario.IdUsuario);//lo que significa:"Al parámetro @nombre_del_parametro mandale este valor."
                comando.Parameters.AddWithValue("@user_name", usuario.UserName);
                comando.Parameters.AddWithValue("@password", usuario.password);
                comando.Parameters.AddWithValue("@activo", usuario.activo);
                comando.Parameters.AddWithValue("@intentos_fallidos", usuario.IntentosFallidos);
                comando.Parameters.AddWithValue("@hora_ultimo_intento", usuario.HoraUltimoIntento);
                comando.Parameters.AddWithValue("@id_persona", usuario.IdPersona);
                comando.Parameters.AddWithValue("@id_rol", usuario.IdRol);
                comando.Parameters.AddWithValue("@debe_cambiar_pass", usuario.DebeCambiarPass);
                comando.Parameters.AddWithValue("@dias_validez_pass", usuario.DiasValidezPass);
                //todo lo que hace esto es pasarle los datos del objeto usuario al procedimiento almacenado de SQL Server.
                conexion.AbrirConexion();
                comando.ExecuteNonQuery();

            } catch (Exception ex) {
                throw new Exception(ex.Message);

            }
            finally
            {
                conexion.CerrarConexion();
            }
           
        }
    }
}
