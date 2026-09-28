using entidades;
using Microsoft.Data.SqlClient;
using SISTEMA;
using System.Data;

namespace DATOS
{
    public class Login
    {
        // Objeto que sabe cómo abrir/cerrar la conexión a SQL Server (se reutiliza en TODA la capa DATOS).
        private Conexion conexion = new Conexion();

        public Usuario IniciarSesion(string userName, string password)
        {
            Usuario usuario = null; // arranca en null: "todavía no encontré a nadie"

            try
            {
                // SqlCommand: representa la orden que se va a ejecutar contra la base
                // (en este caso, un procedimiento almacenado llamado sp_login).
                SqlCommand comando = new SqlCommand("sp_login", conexion.ObtenerConexion());

                comando.CommandType = CommandType.StoredProcedure; // le avisa a SQL que "sp_login" es un SP, no una consulta directa

                // AddWithValue: le "engancha" un valor de C# al parámetro correspondiente del SP (@user_name, @password).
                comando.Parameters.AddWithValue("@user_name", userName);
                comando.Parameters.AddWithValue("@password", password);

                conexion.AbrirConexion(); // abre la conexión física a la base

                // ExecuteReader: ejecuta el comando y devuelve un "lector" para recorrer los resultados fila por fila.
                SqlDataReader lector = comando.ExecuteReader();

                // Read() avanza una fila y devuelve true si hay datos, false si no encontró nada
                // (es decir: si el usuario/contraseña no coinciden con ningún registro).
                if (lector.Read())
                {
                    usuario = new Usuario();

                    // Convert.ToInt32 / ToString() / ToBoolean / ToDateTime: pasan el dato crudo de SQL
                    // (que llega como "object") al tipo de C# correspondiente.
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

                lector.Close(); // libera el lector, ya se terminó de usar
            }
            catch (Exception ex)
            {
                // Si algo falla (conexión caída, SP inexistente, etc.), relanza el error
                // para que la capa de arriba (LOGICA/VISTA) lo pueda mostrar al usuario.
                throw new Exception(ex.Message);
            }
            finally
            {
                // finally se ejecuta SIEMPRE, haya error o no: garantiza que la conexión
                // se cierre pase lo que pase (evita dejar conexiones "colgadas" abiertas).
                conexion.CerrarConexion();
            }

            // Si el login fue correcto, devuelve el Usuario con sus datos.
            // Si no, devuelve null (así lo detecta el FrmLogin con el "if (usuario != null)").
            return usuario;
        }
    }
}