using Microsoft.Data.SqlClient;//permite trabajar con SQL Server
using SISTEMA;//permite trabajar con la clase Conexion
using System;//permite trabajar con excepciones
using System.Data;//permite trabajar con DataTable y DataSet,tambien permite trabajar con cosas relacionadas a datos, como CommandType

namespace DATOS
{
    public class BloquearUsuario //Estás creando una clase llamada BloquearUsuario.La idea es que esta clase tenga la responsabilidad de bloquear un usuario.
    {
        private Conexion conexion = new Conexion();//es el encargado de permitir la conexion a la BD de sqlserver.

        public void Bloquear(int idUsuario)
        //public void Bloquear(int idUsuario) es un método público que recibe un parámetro idUsuario de tipo entero.
        //Este método se encarga de bloquear un usuario en la base de datos utilizando un procedimiento almacenado llamado sp_bloquear_usuario.
        {
            try//se utiliza un bloque try-catch-finally para manejar posibles excepciones que puedan ocurrir durante la ejecución del código.
            {
                SqlCommand comando = new SqlCommand("sp_bloquear_usuario", conexion.ObtenerConexion());
                //estamos creando un objeto sqlcommand llamado comando, que representa un comando SQL que se ejecutará en la base de datos.
                comando.CommandType = CommandType.StoredProcedure;
                //estamos indicando que el comando que vamos a ejecutar es un procedimiento almacenado.
                comando.Parameters.AddWithValue("@id_usuario", idUsuario);
                //manda un dato al procedimiento almacenado, en este caso el id del usuario que queremos bloquear.
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