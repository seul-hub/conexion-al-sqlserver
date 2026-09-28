using entidades;
using Microsoft.Data.SqlClient;
using SISTEMA;
using System.Data;

namespace DATOS
{
    public class ListarRoles
    {
        private Conexion conexion = new Conexion();

        public List<Rol> Listar()
        {
            List<Rol> lista = new List<Rol>();

            try
            {
                SqlCommand comando = new SqlCommand("sp_listar_roles", conexion.ObtenerConexion());
                comando.CommandType = CommandType.StoredProcedure;
                conexion.AbrirConexion();
                SqlDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Rol rol = new Rol();
                    rol.id_rol = Convert.ToInt32(lector["id_rol"]);
                    rol.nombre_rol = lector["nombre_rol"].ToString();
                    lista.Add(rol);
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

            return lista;
        }
    }
}