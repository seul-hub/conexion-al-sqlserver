using entidades;
using Microsoft.Data.SqlClient;
using SISTEMA;
using System.Data;

namespace DATOS
{
    public class Login
    {
        private Conexion conexion = new Conexion();

        public Usuario IniciarSesion(string userName, string password)
        {
            Usuario usuario = null;

            try
            {
                SqlCommand comando = new SqlCommand("sp_login", conexion.ObtenerConexion());

                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@user_name", userName);
                comando.Parameters.AddWithValue("@password", password);

                conexion.AbrirConexion();

                SqlDataReader lector = comando.ExecuteReader();

                if (lector.Read())
                {
                    usuario = new Usuario();

                    usuario.IdUsuario = Convert.ToInt32(lector["id_usuario"]);
                    usuario.UserName = lector["user_name"].ToString();
                    usuario.password = lector["password"].ToString();
                    usuario.activo = Convert.ToBoolean(lector["activo"]);
                    usuario.DebeCambiarPass = Convert.ToBoolean(lector["debe_cambiar_pass"]);
                    usuario.DiasValidezPass = Convert.ToInt32(lector["dias_validez_pass"]);
                    usuario.IntentosFallidos = Convert.ToInt32(lector["intentos_fallidos"]);
                    usuario.HoraUltimoIntento = Convert.ToDateTime(lector["hora_ultimo_intento"]);
                    usuario.IdPersona = Convert.ToInt32(lector["id_persona"]);
                    usuario.IdRol = Convert.ToInt32(lector["id_rol"]);
                }

                lector.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }

            return usuario;
        }
    }
}